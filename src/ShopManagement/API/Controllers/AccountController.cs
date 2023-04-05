using AutoMapper;
using Infrastructure.Entities;
using Infrastructure.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ITokenService _tokenService;
        private readonly ILogger<AccountController> _logger;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationRole> roleManager, ITokenService tokenService, ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _tokenService = tokenService;
            _logger = logger;
        }

        [HttpPost, Route("register")]
        public async Task<IActionResult> Register([FromBody] UserModel model)
        {
            _logger.LogInformation($"Register: {model.Email}");
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                _logger.LogInformation($"User Created: {model.Email}");

                //await _roleManager.CreateAsync(new ApplicationRole("Admin"));
                //await _userManager.AddToRoleAsync(user, "Admin");
                //await _userManager.AddClaimAsync(user, new Claim("CRUDProduct", "true"));

                var claims = (await _userManager.GetClaimsAsync(user)).ToList();
                var token = await _tokenService.GetJwtToken(claims);

                return Ok(token);
            }

            return BadRequest(ModelState);
        }

        [HttpPost, Route("login")]
        public async Task<IActionResult> Login([FromBody] UserModel model)
        {
            _logger.LogInformation($"Login: {model.Email}");
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, lockoutOnFailure: false);

                if(result.Succeeded)
                {
                    //var role = await _roleManager.FindByNameAsync("Admin");
                    //var claim = new Claim ("CRUDProduct", "true");

                    //await _roleManager.AddClaimAsync(role, claim);

                    _logger.LogInformation($"User LogIn: {model.Email}");
                    var claims = (await _userManager.GetClaimsAsync(user)).ToList();
                    var token = await _tokenService.GetJwtToken(claims);

                    return Ok(token);
                }
            }
            return BadRequest();
        }
    }
}
