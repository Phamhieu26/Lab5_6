using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cau1Controller : ControllerBase
    {
        [HttpGet("CalculateCompoundInterest")]
        public IActionResult CalculateCompoundInterest(int months, long moneyFirst, double rateMonths)
        {
            //check số âm
            if (months <= 0 || moneyFirst <= 0 || rateMonths <= 0)
                return BadRequest("Invalid input. Please provide positive values.");
            //gốc * (1+rate/100)^thang - gốc
            double laiKep = moneyFirst * Math.Pow(1 + rateMonths / 100, months) - moneyFirst;

            return Ok(laiKep);
        }
    }
}
