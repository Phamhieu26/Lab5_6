using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cau3Controller : ControllerBase
    {
        [HttpGet("CheckPrimeNumbers")]
        public IActionResult CheckPrimeNumbers([FromQuery] long[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return BadRequest("Please provide an array of integers.");
            //trả kq về mảng true false
            var result = new bool[numbers.Length];
            //duyệt mảng
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = IsPrime(numbers[i]);
            }

            return Ok(result);
        }
        //hàm check ngto chia từ 2 đến căn bậc 2 của số
        private bool IsPrime(long number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
