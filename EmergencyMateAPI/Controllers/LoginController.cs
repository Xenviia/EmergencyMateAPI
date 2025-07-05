using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace EmergencyMateAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        public LoginController(IConfiguration config) => _config = config;

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            connection.Open();
            var command = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Correo = @correo AND Contrasena = @pass", connection);
            command.Parameters.AddWithValue("@correo", request.Correo);
            command.Parameters.AddWithValue("@pass", request.Contrasena);
            int result = (int)command.ExecuteScalar();
            return result > 0 ? Ok() : Unauthorized();
        }
    }
    public class LoginRequest
    {
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}
