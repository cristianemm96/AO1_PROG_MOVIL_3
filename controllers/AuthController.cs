
using AO1_PROG_MOVIL_3.models;
using AO1_PROG_MOVIL_3.services;
using Microsoft.AspNetCore.Mvc;

namespace AO1_PROG_MOVIL_3.controllers;

[ApiController]
[Route("api/auth/login")]
public class AuthController: ControllerBase
{
    private AuthService authService;

    public AuthController(AuthService authService)
    {
        this.authService = authService;
    }

    [HttpPost]
    public IActionResult Login([FromBody] Usuario request)
    {
        if (authService.Login(request.NombreUsuario, request.Password))
        {
            var token = authService.GenerarToken(request.NombreUsuario);    
            return Ok(new { Message = "Login successful", Token = token });
        }

        return Unauthorized(new { Message = "Invalid credentials" });
    }
}