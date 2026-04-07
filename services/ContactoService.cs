using AO1_PROG_MOVIL_3.models;

namespace AO1_PROG_MOVIL_3.services;

public class ContactoService
{
    private List<Contacto> contactos = new List<Contacto>();

    private static int nuevoId = 1;

    public List<Contacto> ObtenerTodos()
    {
        return this.contactos;
    }

    public Contacto? ObtenerPorId(int id)
    {
        return contactos.Find((c) => c.Id == id);
    }

    public Contacto Crear(Contacto contacto)
    {
        contacto.Id = nuevoId;
        nuevoId++;
        contactos.Add(contacto);
        return contacto;
    }
    public bool Eliminar (int Id)
    {
        var contacto = ObtenerPorId(Id);
        if(contacto == null)
        {
            return false;
        }
        contactos.Remove(contacto);
        return true;
    }



}