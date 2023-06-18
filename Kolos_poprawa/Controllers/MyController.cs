using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using static Kolos_poprawa.Services.Service;
using Kolos_poprawa.Models.DTO;


namespace Kolos_poprawa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly IMyService _service;

        public MyController(IMyService service)
        {
            _service = service;
        }
        /*
        [HttpGet]
        [Route("{ID}/clients")]
        public async Task<IActionResult> Get_NAZWA()
        {
            return Ok();
        }*/

/*      [HttpDelete] -usuniecie
        [HttpPost] - dodanie
        [HttpPut] - aktualizacja
        public IActionResult Add/Delete/Update()
        {
            return Ok();
        }
*/
    }
}
