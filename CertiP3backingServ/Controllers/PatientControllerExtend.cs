using CertiP3backingServ.Models;
using Microsoft.AspNetCore.Mvc;

namespace CertiP3backingServ.Controllers
{
    public class PatientControllerExtend : Controller
    {
        [HttpPost("api/patientcode")]
        public IActionResult CalculateCode([FromBody]Patient input)
        {
            string code = $"{input.Name[0]}{input.LastName[0]}-{input.CI}";
            return Ok(code);
        }
    }
}
