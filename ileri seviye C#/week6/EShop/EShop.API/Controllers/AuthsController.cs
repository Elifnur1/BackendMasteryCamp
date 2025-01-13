using EShop.Service.Abstract;
using EShop.Shared.Dtos.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    //uygulamaadresi/api/auths
    //Bu şekilde rota belirlediğimzde bu adrese ;
    //Post Metotu iile bir istek geldiğinde HttpPost tipindeki metot yani bizde buLogin metotu çalışacak.
    //Get metodu ile bir istek geldiğinde HttpGet tipindeki metot çalışacak.
    //Delete metodu ile bir istek geldiğinde HttpDelete tipindeki metot çalışacaktır.
    [Route("api/[auths")]  //AuthsController'ın yolu
    [ApiController]
    public class AuthsController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthsController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var result = await _authService.LoginAsync(loginDto);
            return StatusCode(result.StatusCode, result.Data);
        }
    }
}
