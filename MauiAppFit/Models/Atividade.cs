using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppFit.Models
{
    internal class Atividade
    {
        [PrimaryKey, AutoIncrement]

        public int id { get; set; }
        public string? Descricao { get; set; }

        public DateTime Data { get; set; }


        public double? Peso { get; set; }

        public string? Observações { get; set; }

    }
}
