using Projeto.Curso.Core.Domain.Shared.ValueObjects;

namespace Projeto.Curso.Core.Domain.Shared.Entidades
{
    public abstract class Pessoa : EntidadeBase
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public CpfCnpjVo CPFCNPJ { get; set; }
        public EmailVo Email { get; set; }
        public EnderecoVO Endereco { get; set; }
 
    }
}
