using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIForSpeed.Models
{
    public class CarOrderClass
    {
        //1OrderID = ID dell'ordine effettuato
        [Key]
        public int OrderID { get; set; }
        //2Name = Nome della persona che ha effettuato l'ordine
        public string Name { get; set; }
        //3Surname = Cognome della persona che ha effettuato l'ordine 
        public string Surname { get; set; }
        //4Modello = Marca e Modello della vettura ordinata
        public string Modello { get; set; }
        //5Email = Email della persona che ha ordinato
        public string Email { get; set; }
        //6Phone = Numero di telefono della persona che ha ordinato
        public string Phone { get; set; }
        //7DataOrdine = Data e Giorno dell'ordine in cui e' stata effettuata
        public DateTime DataOrdine{get; set;}
        //8Prezzo = Costo della vettura che e' stata ordinata
        public decimal Prezzo { get; set; }
    }
}
