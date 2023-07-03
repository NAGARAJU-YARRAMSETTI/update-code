using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetapp.Models;
using System.Data.SqlClient;
using System.Data;

namespace dotnetapp.Controllers
{
    [Route("api/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private BusinessLayer bussiness_layer = new BusinessLayer();

        [HttpPost("user/addProfile")]
        public string addUser(ProfileModel pm)
        {
            return bussiness_layer.addUser(pm);
        }

        [HttpGet("user/getProfile/{userId}")]
        public IActionResult getUser(string userId)
        {
            return Ok(bussiness_layer.getUser(userId));
        }


        [HttpPut("user/editProfile/{userId}")]
        public string editUser(string userId, ProfileModel user)
        {
            return bussiness_layer.editUser(userId, user);
        }

        [HttpDelete("user/deleteProfile/{userId}")]
        public string deleteUser(string userId)
        {
            return bussiness_layer.deleteUser(userId);
        }

    }
}



