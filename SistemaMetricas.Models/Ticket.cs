namespace SistemaMetricas.Models
{
    public class Ticket
    {

        //create table Tickets(
        //Id INTEGER prymary key auto_increment,
        //Titulo text,
        //Area text,
        //Prioridad text,
        //Tipos text,
        //Descripcion text,
        //FechaAlta text,
        //FechaCierre text,
        //Estado text
        //);
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Area { get; set; }
        public string Prioridad { get; set; }
        public string Tipos { get; set; }
        public string Descripcion { get; set; }
        public string FechaAlta { get; set; }
        public string FechaCierre { get; set; }
        public string Estado { get; set; }
    }
}