﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClickServ2022.Models
{
    public class Endereco 
    {
        public int EnderecoID { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Observacao { get; set; }
        public Cliente Cliente { get; set; }
        public Equipamento Equipamento { get; set; }

        public IEnumerable<Equipamento> Equipamentos;
    }
}
