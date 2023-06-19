using Microsoft.AspNetCore.Mvc;
using static Kolos_poprawa.Services.Service;

namespace Kolos_poprawa.Controllers
{
    public class PrescriptionController : Controller
    {
        private readonly IMyService _service;

        public PrescriptionController(IMyService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("prescriptions/{PrescriptionId}")]
        public async Task<IActionResult> GetPrescription(int PrescriptionId)
        {
            var prescription = await _service.GetPrescriptionById(PrescriptionId);
            if (prescription is null)
            {
                return NotFound("This prescription does not exist");
            }
            return Ok(prescription);
        }
    }
}
