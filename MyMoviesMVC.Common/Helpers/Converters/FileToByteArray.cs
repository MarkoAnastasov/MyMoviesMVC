using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace MyMoviesMVC.Common.Helpers.Converters
{
    public static class FileToByteArray
    {
        public static async Task<byte[]> ImageToByteArray(IFormFile image)
        {
            using (var memoryStream = new MemoryStream())
            {
                await image.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
