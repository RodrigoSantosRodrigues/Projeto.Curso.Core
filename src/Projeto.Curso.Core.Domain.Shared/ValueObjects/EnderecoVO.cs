using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Curso.Core.Domain.Shared.ValueObjects
{
    public class EnderecoVO
    {
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public UfVO UF { get; set; }
        public CepVO CEP { get; set; }

        public EnderecoVO()
        {
            UF = new UfVO();
            CEP = new CepVO();
        }
    }
}
