using Microsoft.AspNetCore.Identity;
using MyMoviesMVC.Common.Exceptions;
using MyMoviesMVC.Common.Helpers.Converters;
using MyMoviesMVC.Interfaces;
using MyMoviesMVC.Models;
using MyMoviesMVC.ModelsDTO.MovieComment;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyMoviesMVC.Services
{
    public class MovieCommentService : IMovieCommentService
    {
        private readonly IMovieCommentRepository _movieCommmentRepository;
        private readonly UserManager<User> _userManager;

        public MovieCommentService(IMovieCommentRepository movieCommentRepository, UserManager<User> userManager)
        {
            _movieCommmentRepository = movieCommentRepository;
            _userManager = userManager;
        }

        public async Task AddComment(AddMovieCommentDTO addMovieCommentDTO,ClaimsPrincipal sessionUser)
        {
            var targetUser = await GetUserByClaimCheckNullAsync(sessionUser);

            _movieCommmentRepository.Add(DTOToModel.AddMovieCommentDTOToModel(addMovieCommentDTO,targetUser.Id));
            await _movieCommmentRepository.SaveEntitiesAsync();
        }

        public async Task<List<ApprovalOverviewDTO>> MovieCommentsApproval()
        {
            var commentsForApproval = await _movieCommmentRepository.GetAllWhereUserIncludedAsync(x => x.IsVerified == false);

            return commentsForApproval.Select(x => ModelToDTO.MovieCommentToApprovalDTO(x)).ToList();
        }

        public async Task ApproveComment(int commentId)
        {
            var targetComment = await GetMovieByIdIsVerifiedAsync(commentId);

            targetComment.IsVerified = true;

            _movieCommmentRepository.Update(targetComment);
            await _movieCommmentRepository.SaveEntitiesAsync();
        }

        public async Task DisapproveComment(int commentId)
        {
            var targetComment = await GetMovieByIdIsVerifiedAsync(commentId);

            _movieCommmentRepository.Remove(targetComment);
            await _movieCommmentRepository.SaveEntitiesAsync();
        }

        public async Task RemoveComment(int commentId)
        {
            var targetComment = await _movieCommmentRepository.GetFirstWhereAsync(x => x.Id == commentId);

            if(targetComment == null)
            {
                throw new FlowException();
            }

            _movieCommmentRepository.Remove(targetComment);
            await _movieCommmentRepository.SaveEntitiesAsync();
        }

        private async Task<User> GetUserByClaimCheckNullAsync(ClaimsPrincipal sessionUser)
        {
            var targetUser = await _userManager.GetUserAsync(sessionUser);

            if (targetUser == null)
            {
                throw new FlowException("Account user not found!");
            }

            return targetUser;
        }

        private async Task<MovieComment> GetMovieByIdIsVerifiedAsync(int commentId)
        {
            var targetComment = await _movieCommmentRepository.GetFirstWhereAsync(x => x.Id == commentId && x.IsVerified == false);

            if (targetComment == null)
            {
                throw new FlowException("Comment not found!");
            }

            return targetComment;
        }
    }
}
