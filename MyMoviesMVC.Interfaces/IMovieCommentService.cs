using MyMoviesMVC.ModelsDTO.MovieComment;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyMoviesMVC.Interfaces
{
    public interface IMovieCommentService
    {
        Task AddComment(AddMovieCommentDTO addMovieCommentDTO, ClaimsPrincipal sessionUser);

        Task<List<ApprovalOverviewDTO>> MovieCommentsApproval();

        Task ApproveComment(int commentId);

        Task DisapproveComment(int commentId);

        Task RemoveComment(int commentId);
    }
}
