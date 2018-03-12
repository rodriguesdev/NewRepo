using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGTECH.Test.Project.Web.Models
{
    public class Cliente
    {
        public int Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public bool Ativo { get; set; }
    }
}