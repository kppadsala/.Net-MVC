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


        //Get Records Based On Ids [1,2,3]
        [HttpGet("AllIds")]
        public async Task<IActionResult> GetCurrencyByIds()
        {
            var ids =new List<int> { 1,2,3,4};
            var result = await this.appDBContext.Currency
                .Where(data => ids.Contains(data.ID))
                .ToListAsync();
            return Ok(result);
        }

        //Get Ids By User
        [HttpPost("AllIdsPost")]
        public async Task<IActionResult> GetCurrencyByIds([FromBody] List<int> ids)
        {
            //var ids =new List<int> { 1,2,3,4};
            var result = await this.appDBContext.Currency
                .Where(data => ids.Contains(data.ID))
                .ToListAsync();
            return Ok(result);
        }


        //Get Specific Column  But Give All Column
        [HttpPost("AllIdsLinq")]
        public async Task<IActionResult> GetCurrencyByLINQIds([FromBody] List<int> ids)
        {
            var result = await this.appDBContext.Currency
                .Where(data => ids.Contains(data.ID))
                .Select(data => new Currency()
                {
                    ID = data.ID,
                    CurTitle = data.CurTitle,
                }
                )
               
                .ToListAsync();
            return Ok(result);
        }


        //Get Specific Column  PreDefine

        [HttpPost("AllIdsLinqSelect")]
        public async Task<IActionResult> GetCurrencyByLINQColumn()
        {
            var result = await (from Currency in this.appDBContext.Currency
                                select new
                                {
                                    ID = Currency.ID,
                                    Title = Currency.CurTitle
                                }).ToListAsync(); 

            return Ok(result);
        }

    }
}
