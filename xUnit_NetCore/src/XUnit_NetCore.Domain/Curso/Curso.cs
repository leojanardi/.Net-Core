﻿using System;
using XUnit_NetCore.Domain.Enums;

namespace XUnit_NetCore.Domain
{
    public class Curso
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public double Valor { get; private set; }

        public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, double valor) 
        {
            if(string.IsNullOrEmpty(nome) || cargaHoraria < 1 || valor < 1)
            {
                throw new ArgumentException("Parâmetros inválidos");
            }

            this.Nome = nome;
            this.CargaHoraria = cargaHoraria;
            this.PublicoAlvo = publicoAlvo;
            this.Valor = valor;
        }
    }
}
