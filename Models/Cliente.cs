public class Cliente
{
    public int idCliente { get; set; }
    public string NombreCompleto { get; set; }
    public string Telefono1 { get; set; }
    public string Telefono2 { get; set; }
    public string Mail { get; set; }

    // Constructor por defecto
    public Cliente() { }

    // Constructor con parámetros
    public Cliente(int idCliente, string nombreCompleto, string telefono1, string telefono2, string mail)
    {
        this.idCliente = idCliente; // Usar 'this' para distinguir entre el campo y el parámetro
        this.NombreCompleto = nombreCompleto;
        this.Telefono1 = telefono1;
        this.Telefono2 = telefono2;
        this.Mail = mail;
    }
}

// public class Cliente {
//  String nombreCompleto;
//  String mail;
//  int telefono;
//  int telefono2;
// float cuenta;

// public Cliente(){

// }
// //constructor lleno
// public Cliente( String nombreCompleto,String mail,int telefono,int telefono2,float cuenta){
//     this.nombreCompleto=nombreCompleto;
//     this.mail=mail;
//     this.telefono=telefono;
//     this.telefono2=telefono2;
//     this.cuenta=cuenta;
// }

//  // Getters
//     public string getNombreCompleto {
// this.nombrecompleto = nonmbrecompleto;
//}
//         get { return nombreCompleto; }
//         set { nombreCompleto = value; }

//     }

//     public string Mail {
//         get { return mail; }
//         set { mail = value; }
//     }

//     public int Telefono {
//         get { return telefono; }
//         set { telefono = value; }
//     }

//     public int Telefono2 {
//         get { return telefono2; }
//         set { telefono2 = value; }
//     }

//     public float Cuenta {
//         get { return cuenta; }
//         set { cuenta = value; }
//     } 

// }