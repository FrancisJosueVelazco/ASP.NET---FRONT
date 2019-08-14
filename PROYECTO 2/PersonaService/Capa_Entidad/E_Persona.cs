using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Capa_Entidad
{
    [DataContract]
    public class E_Persona
    {
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public string nombres { get; set; }
        [DataMember]
        public string apellidos { get; set; }
        [DataMember]
        public int edad { get; set; }
        [DataMember]
        public DateTime fecha { get; set; }

    }
}
