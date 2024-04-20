using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ADAuth.Models;

namespace ADAuth.Controllers
{
    public class NamesController : Controller
    {
        [Authorize(Roles = "Ap.ReadOnly,Ap.ReadWrite")]
        [HttpGet ("GetNames")]
        public IActionResult Get()
        {
            return Ok(Datas.Names);
        }

        [Authorize(Roles = "Ap.ReadWrite")]
        [HttpPost ("SetNames")]
        public IActionResult Set([FromBody] Names names)
        {
            Datas.Names.Add(names);
            return Ok(Datas.Names);
        }
    }
}
