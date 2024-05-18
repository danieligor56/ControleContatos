using ControleDeContatos.Models;

namespace ControleDeContatos.Repository
{
    public interface IContatoRepository
    {   
        List<ContatoModel> listAll();
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel FindById(int Id);

        ContatoModel DeleteById(int Id);

        ContatoModel AtualizarCadastro(ContatoModel contato);
    }
}
