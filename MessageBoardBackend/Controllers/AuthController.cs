using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using MessageBoardBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace MessageBoardBackend.Controllers
{

    



    public class JwtPacket
    {
        public string Token { get; set; }
    }


    [Produces("application/json")]
    [Route("auth")]//--------------------new auth contller 
    public class AuthController : Controller
    {
        [HttpPost("register")]//----------------router= auth/register
        public JwtPacket Register([FromBody]User user)
        {
            //--------------------save user----need migrate---------------------------------
           // MessagesController.db.Users.AddAsync(new Models.User
          //  {
          //      FirstName = user.FirstName,
          //      LastName = user.LastName,
          //      Email = user.Email,
           //     Password = user.Password
          //  });

           // MessagesController.db.SaveChangesAsync();
            //-------------------------------------------------------------- 

            var jwt = new JwtSecurityToken();
            
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            


            return new JwtPacket() { Token= encodedJwt};
        }
    }
}