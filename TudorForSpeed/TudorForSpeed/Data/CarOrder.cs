using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TudorForSpeed.Data
{
    public class CarOrder
    {
        public int OrderID { get; set; }                            //1OrderID = ID dell'ordine effettuato
        [Required]
        public string Name { get; set; }                            //2Name = Nome della persona che ha effettuato l'ordine
        [Required]
        public string Surname { get; set; }                         //3Surname = Cognome della persona che ha effettuato l'ordine
        [Required]
        public string Modello { get; set; }                         //4Modello = Marca e Modello della vettura ordinata
        [Required]
        public string Email { get; set; }                           //5Email = Email della persona che ha ordinato
        [Required]
        public string Phone { get; set; }                           //6Phone = Numero di telefono della persona che ha ordinato
        public DateTime DataOrdine { get; set; }                      //7DataOrdine = Data e Giorno dell'ordine in cui e' stata effettuata
        public decimal Prezzo { get; set; }                         //8Prezzo = Costo della vettura che e' stata ordinata
    }
}
