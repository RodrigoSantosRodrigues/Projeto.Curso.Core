using Projeto.Curso.Core.Domain.Shared.Entidades;

namespace Projeto.Curso.Core.Domain.Pedidos.Entidades
{
    public class Clientes : Pessoa
    {
        private void ApelidoDeveSerPreenchido()
        {
            if (string.IsNullOrEmpty(Apelido)) ListaErros.Add("Preencher Apelido!");
        }

        private void ApelidoDeveTerUmTamanhoLimite()
        {
            if (Apelido.Trim().Length > 20) ListaErros.Add("Campo Apelido Máximo de 20 caracteres!");
        }

        private void NomeDevePreenchido()
        {
            if (string.IsNullOrEmpty(Nome)) ListaErros.Add("Nome deve ser preenchido");
        }

        private void NomeDeveTerUmTamanhoLimite()
        {
            if (Nome.Trim().Length > 20) ListaErros.Add("Nome deve ser maior que 20!");
        }

        public override bool EstaConsistente()
        {
            throw new System.NotImplementedException();
        }

    }
}
