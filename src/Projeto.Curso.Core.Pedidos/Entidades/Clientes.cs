﻿using Projeto.Curso.Core.Domain.Shared.Entidades;
using Projeto.Curso.Domain.Pedidos.AgregacaoPedidos;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Curso.Core.Domain.Pedidos.Entidades
{
    public class Clientes : Pessoa
    {
        public ICollection<Pedidoss> Pedidos { get; set; }
        public override bool EstaConsistente()
        {
            ApelidoDeveSerPreenchido();
            ApelidoDeveTerUmTamanhoLimite(20);
            NomeDeveSerPreenchido();
            NomeDeveTerUmTamanhoLimite(100);
            CPFouCNPJDeveSerPreenchido();
            CPFouCNPJDeveSerValido();
            EmaiDeveSerValido();
            EmailDeveTerUmTamanhoLimite(100);
            EnderecoDeveSerPreenchido();
            EnderecoDeveTerUmTamanhoLimite(100);
            BairroDeveTerUmTamanhoLimite(30);
            CidadeDeveSerPreenchida();
            CidadeDeveTerUmTamanhoLimite(30);
            UFDeveSerPreenchida();
            UFDeveSerValida();
            CepDeveSerValido();
            return !ListaErros.Any();
        }
    
    }
}
