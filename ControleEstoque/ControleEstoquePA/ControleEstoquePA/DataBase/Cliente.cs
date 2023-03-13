using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoquePA.DataBase
{
    [Table("Cliente")]
    public class Cliente
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Idade { get; set; } 
        public double Telefone { get; set; }
        public List<string> UltimasCompras { get; set; }
    }
}
