using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Capa_Datos;
using Capa_Entidad;

namespace Service
{
   
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<E_Persona> ListarPersona();

        [OperationContract]
        E_Respuesta RegistrarPersona(E_Persona p);

        [OperationContract]
        E_Persona ListarxId(int id);

        [OperationContract]
        E_Respuesta ActualizarPersona(E_Persona p);

        [OperationContract]
        E_Respuesta EliminarPersona(int id);

    }

}
