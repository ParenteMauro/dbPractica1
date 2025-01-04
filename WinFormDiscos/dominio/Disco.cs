using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDiscos
{
    public class Disco
    {
        public Disco(string titulo, DateTime fechaLanzamiento, int cantidadCanciones, string descripcionEstilo, string descripcionEdicion) 
        {
            Titulo = titulo;    
            CantidadCanciones = cantidadCanciones;
            Estilo = new Estilo();
            Edicion = new Edicion();
            FechaLanzamiento = fechaLanzamiento;
            Estilo.Descripcion = descripcionEstilo;
            Edicion.TipoEdicion = descripcionEdicion;

        }

        public string Titulo { get; set; }
        public int CantidadCanciones { get; set; }

        public string UrlImagen {  get; set; }  
        public DateTime FechaLanzamiento { get; set; }
        public Estilo Estilo { get; set; }  
        public Edicion Edicion { get; set; }
    }
}
