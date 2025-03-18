using EntityFrameWork.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EntityFrameWork.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDBContext appDBContext;

        public CurrencyController(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }


        //GetALL Data
        [HttpGet("")]
        public async Task<IActionResult> GetAllCurrencies()
        {
            var result = await this.appDBContext.Currency.ToListAsync();
            return Ok(result);
        }


        //Get Data Use ID
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCurrencyByIdAsync([FromRoute] int id)
        {
            var result = await this.appDBContext.Currency.FindAsync(id);
            return Ok(result);
        }

        //Get Data Use Name
        [HttpGet("{Name}")]
        public async Task<IActionResult> GetCurrencyByNameAsync([FromRoute] string Name)
        {
            var result = await this.appDBContext.Currency
                 .Where(Data => Data.CurTitle == Name).FirstOrDefaultAsync();
            //.ToListAsync();
            return Ok(result);
        }


        //Get ALL Data Using Multiple Parameter
        [HttpGet("by-name/{Name}")]
        public async Task<IActionResult> GetCurrencyByNameAsync([FromRoute] string Name, [FromQuery] string? CurDescription)
        {
            var result = await this.appDBContext.Currency
                .Where(Data => Data.CurTitle == Name && (string.IsNullOrEmpty(CurDescription) || Data.CurDescription == CurDescription))
                .ToListAsync();

            return Ok(result);
        }


    }
}
