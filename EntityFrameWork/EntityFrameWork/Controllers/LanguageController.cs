using EntityFrameWork.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork.Controllers
{
    [Route("api/language")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDBContext appDBContext;

        public LanguageController(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        [HttpGet("")]

        //WithOut USe Async
        //public IActionResult GetAllLanguages() {

        //    var result = this.appDBContext.Language.ToList();
        //    return Ok(result);
        //}


        //Use Async
        public async Task< IActionResult> GetAllLanguages()
        {

            var result =await this.appDBContext.Language.ToListAsync();
            return Ok(result);
        }
    }
}
