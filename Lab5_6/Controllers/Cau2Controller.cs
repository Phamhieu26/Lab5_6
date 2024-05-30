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
            //tìm delta
            double discriminant = b * b - 4 * a * c;
            //check vô nghiệm
            if (discriminant < 0)
                return BadRequest("No real roots.");
            //căn bậc 2 delta
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            //tìm nghiệm
            double x1 = (-b + sqrtDiscriminant) / (2 * a);
            double x2 = (-b - sqrtDiscriminant) / (2 * a);

            return Ok(new { x1, x2 });
        }
    }
}
