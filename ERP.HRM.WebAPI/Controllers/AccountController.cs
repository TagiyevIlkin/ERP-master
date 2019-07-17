using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ERP.HRM.DTO;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using ERP.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ERP.HRM.WebAPI.Controllers
{

    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AccountController(IConfiguration configuration,
                                   IMapper mapper,
                                   IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]UserLoginDTO userLoginDto)
        {
            ApiResult result = new ApiResult() { ResultCode = (int)ResultCode.Success };
           
            var user = await _unitOfWork.Repository<User>()
                .FindAsync(x => x.Username == userLoginDto.Username && x.Password == Tools.HashPassword(userLoginDto.Password));

            if (user != null)
            {
                result.Model = GenerateToken(user);

            }
            else
            {
                result.ResultCode = (int)ResultCode.Unauthorize;
            }

            return new ObjectResult(result);
        }

        private string GenerateToken(User user)
        {
            string userRoles = string.Join(",", user.UserRoles.Select(r => r.Role.Name));

            var parameters = new Claim[]{
                new Claim(JwtRegisteredClaimNames.Sid,user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.NameId,user.Username), 
                new Claim("Roles", userRoles) 
            };


            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes((string)Convert.ChangeType(_configuration["JwtTokenConfig:IssuerSigningKey"], typeof(string))));

            var tokenLifeTime = (double)Convert.ChangeType(_configuration["JwtTokenConfig:TokenLifeTime"], typeof(double));

            var token = new JwtSecurityToken(
                issuer: (string)Convert.ChangeType(_configuration["JwtTokenConfig:ValidIssuer"], typeof(string)),
                audience: (string)Convert.ChangeType(_configuration["JwtTokenConfig:ValidAudience"], typeof(string)),
                claims: parameters,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddMinutes(tokenLifeTime),
                signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}