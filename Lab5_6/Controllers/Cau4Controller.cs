using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cau4Controller : ControllerBase
    {
        [HttpGet("CalculateTriangleArea")]
        public IActionResult CalculateTriangleArea(double a, double b, double c)
        {
            //check độ dài cạnh
            if (a <= 0 || b <= 0 || c <= 0)
                return BadRequest("All sides must be positive numbers.");
            if (!(a < b + c && a > Math.Abs(b - c)))
            {
                return BadRequest("There edges are not the length of triangle!!!!");
            }
            //nửa chu vi
            double s = (a + b + c) / 2;
            //area
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return Ok(area);
        }
    }
}
