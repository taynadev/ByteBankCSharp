﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }

        private string _cpf;
        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                //escrevo minha lógica de validação de CPF
                _cpf = value;
            }

        }
        public string Profissao { get; set; }
    }
}