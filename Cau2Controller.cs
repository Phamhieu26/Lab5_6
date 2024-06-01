using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cau2Controller : ControllerBase
    {
        [HttpGet("SolveQuadraticEquation")]
        public IActionResult SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                // Phương trình không phải là phương trình bậc 2
                return BadRequest("Hệ số a phải khác 0 để làm phương trình bậc 2.");
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                // Phương trình không có nghiệm thực
                return NotFound("Phương trình không có nghiệm thực.");
            }
            else if (delta == 0)
            {
                // Phương trình có nghiệm kép
                double x = -b / (2 * a);
                return Ok($"Nghiệm kép: x = {x}");
            }
            else
            {
                // Phương trình có 2 nghiệm phân biệt
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return Ok($"Nghiệm 1: x1 = {x1}, Nghiệm 2: x2 = {x2}");
            }
        }
    }
}
