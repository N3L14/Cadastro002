using Cadastro.Models;

namespace Cadastro.Repositorios.Interfaces
{
    public interface IPessoaFisicaRepositorio
    {
        Task<List<PessoaFisicaModel>> BuscarTodasPessoas();
        Task<PessoaFisicaModel> BuscarId();
        Task<PessoaFisicaModel> Adicionar(PessoaFisicaModel pessoaFisica);
        Task<PessoaFisicaModel> Atualizar(PessoaFisicaModel pessoaFisica, int Id);
        Task<bool> Deletar(int Id);
    }
}
