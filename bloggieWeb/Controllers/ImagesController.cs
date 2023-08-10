using bloggieWeb.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using System.Net;

namespace bloggieWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {

        private readonly IImageRepository imageRepository;
        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        [HttpPost]
        public async Task<IActionResult> UploadAsync(IFormFile file)
        {
            //Call repos
            var imageURL = await imageRepository.UploadAsync(file);

            if (imageURL == null)
            {
                return Problem("Sometihng went wrong!", null, (int)HttpStatusCode.InternalServerError);
            }

            return new JsonResult(new { link = imageURL });
        }
    }
}
