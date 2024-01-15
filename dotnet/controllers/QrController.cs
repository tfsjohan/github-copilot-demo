// Make a MVC API Controller with the name QrController and an action called QrCode that takes a string parameter called data
// The action should return a FileContentResult with the content type image/png

using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    public class QrController : Controller
    {
        public async Task<ActionResult> GenerateQrImage(string data, int size = 400)
        {
            if (size is < 1 or > 500)
            {
                size = 500;
            }

            var url =
                $"https://chart.googleapis.com/chart?cht=qr&chs={size}x{size}&chl=https://cloud-qr.se{data}&chld=L|0";

            var request = new HttpClient();
            var response = await request.GetStreamAsync(url);

            return new FileStreamResult(response, "image/png");
        }
    }
}