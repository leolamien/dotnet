using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_Minimal_AP.NewFolder
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        [HttpGet("{price}/{pays}")]
        public double CalculPrice( int price, String pays)
        {
            if(pays == "BE")
            {
                return price * 1.21;
            }
            else if (pays == "FR")
            {
                return price * 1.20;
            }
            return 0;
        }

    }
}
