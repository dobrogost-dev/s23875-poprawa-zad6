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
    public class DoctorController : ControllerBase
    {
        private readonly IMyService _service;

        public DoctorController(IMyService service)
        {
            _service = service;
        }
 
        [HttpGet]
        [Route("doctors/{doctorId}")]
        public async Task<IActionResult> GetDoctorById(int doctorId)
        {
            var doctor = await _service.GetDoctorById(doctorId);
            if (doctor is null)
            {
                return NotFound("Doctor with this id does not exist");
            }
            return Ok(doctor);
        }
        [HttpGet]
        [Route("doctors")]
        public async Task<IActionResult> GetDoctors()
        {
            return Ok(await _service.GetDoctors());
        }
        [HttpPost]
        public async Task<IActionResult> AddDoctor(GetDoctorWithoudIdDTO doctor)
        {
            await _service.AddDoctor(doctor);
            return Created("", "");
        }
        [HttpPut]
        public async Task<IActionResult> Update(GetDoctorDTO doctor)
        {
            if (await _service.UpdateDoctor(doctor))
            {
                return Ok();
            }
            else
            {
                return NotFound("Doctor with this id does not exist");
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDoctor(int doctorId)
        {
            if (await _service.DeleteDoctor(doctorId))
            {
                return Ok();
            }
            else
            {
                return NotFound("Doctor with this id does not exist");
            }
        }
    }
}
