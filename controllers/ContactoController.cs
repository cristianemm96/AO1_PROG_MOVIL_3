using AO1_PROG_MOVIL_3.models;
using AO1_PROG_MOVIL_3.services;
using Microsoft.AspNetCore.Mvc;

namespace AO1_PROG_MOVIL_3.controllers;

    [ApiController]
    [Route("api/contacto")]

    public class ContactoController : ControllerBase
{
    private readonly ContactoService contactoService;   

    public ContactoController(ContactoService contactoService)
    {
        this.contactoService = contactoService;
    }

    [HttpGet("{id}")]
    public ActionResult<Contacto> GetById(int id)
    {
        var contacto = contactoService.ObtenerPorId(id);
        if (contacto == null) return NotFound();
        return Ok(contacto);
    }
}
