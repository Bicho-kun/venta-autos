using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS_coches
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceCoches
    {
        //método para agregar
        [OperationContract]
        int agregarCoche(Coches coche);
        //Método para editar
        [OperationContract]
        int editarCoche(Coches coche);
        //Método para eliminar
        [OperationContract]
        int eliminarCoche(string matricula);
        //Método para buscar coche
        [OperationContract]
        Coches buscarCoche(string matricula);
        //Método para mostrar todos los coches
        [OperationContract]
        List<Coches> mostrarCoches();
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Coches
    {
        //PROPIEDADES 
        private string _Matricula;
        private string _Marca;
        private string _Modelo;
        private string _Color;
        private decimal _Precio;

        //ENCAPSULACIÓN DE PROPIEDADES
        [DataMember]
        public string Matricula { get => _Matricula; set => _Matricula = value; }
        [DataMember]
        public string Marca { get => _Marca; set => _Marca = value; }
        [DataMember]
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        [DataMember]
        public string Color { get => _Color; set => _Color = value; }
        [DataMember]
        public decimal Precio { get => _Precio; set => _Precio = value; }
    }
}
