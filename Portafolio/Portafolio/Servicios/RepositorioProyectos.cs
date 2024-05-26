using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {

        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                titulo = "Primer proyectp",
                descripcion = "Descripcion del proy inventado",
                link = "proyecto.com",
                imagenUrl = "/imagenes/descarga1.jpg"
            },
                new Proyecto
            {
                titulo = "Segundo proyecto",
                descripcion = "Descripcion del segundo proyecto",
                link = "proyecto.com",
                imagenUrl = "/imagenes/descarga1.jpg"
            },
                new Proyecto
            {
                titulo = "Tercer proyecto",
                descripcion = "Descripcion del tercer proyecto",
                link = "proyecto.com",
                imagenUrl = "/imagenes/descarga3.jpg"
            },
                new Proyecto
            {
                titulo = "Cuarto proyecto",
                descripcion = "Descripcion del cuarto proyecto",
                link = "proyecto.com",
                imagenUrl = "/imagenes/descarga4.jpg"
            },

            };
        }
    }
}
