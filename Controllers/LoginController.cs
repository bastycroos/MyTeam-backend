using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTeam.Model;
using MyTeam.Db;

namespace MyTeam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly TeamDb _logindb;
        public LoginController(TeamDb logindb)
        {
            _logindb = logindb;
        }
        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser(Login loginModels)
        {
            try
            {
                var res = _logindb.Login.Add(loginModels);
                await _logindb.SaveChangesAsync();

                return Ok(res.Entity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser()

        {

            {
                try
                {
                    var res = _logindb.Login.ToList();

                    if (res != null)
                    {
                        return Ok(res);

                    }

                    return null;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }




        }



    }
}
