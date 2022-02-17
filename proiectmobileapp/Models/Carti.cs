using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace proiectmobileapp.Models
{
    public class Carti
    {
        
          [PrimaryKey, AutoIncrement]
          public int ID { get; set; }
          public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Gen { get; set; }
        public string Descriere { get; set; }
        

    }
}
