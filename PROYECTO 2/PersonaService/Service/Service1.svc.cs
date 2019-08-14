using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Capa_Datos;
using Capa_Negocio;
using Capa_Entidad;

namespace Service
{
   
    public class Service1 : IService1
    {
        public List<E_Persona> ListarPersona()
        {
            return Capa_Negocio.N_Persona.ListarPersona();
        }
        public E_Respuesta RegistrarPersona(E_Persona p)
        {
            return Capa_Negocio.N_Persona.RegistrarPersona(p);
        }
        public E_Persona ListarxId(int id)
        {
            return Capa_Negocio.N_Persona.listarXId(id);
        }

        public E_Respuesta ActualizarPersona(E_Persona p)
        {
            return Capa_Negocio.N_Persona.ActualizarPersona(p);
        }

        public E_Respuesta EliminarPersona(int id)
        {
            return Capa_Negocio.N_Persona.EliminarPersona(id);
        }

    }
}
