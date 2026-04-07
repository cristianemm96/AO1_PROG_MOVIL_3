using AO1_PROG_MOVIL_3.models;

namespace AO1_PROG_MOVIL_3.services;

public class ContactoService
{
    private List<Contacto> contactos = new List<Contacto>();

    public List<Contacto> ObtenerTodos(){
        return this.contactos;
    }

    public Contacto? ObtenerPorId(int id)
    {
        return contactos.Find((c) =>c.Id  == id);
    }
}