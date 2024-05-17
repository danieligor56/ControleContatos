using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext banco;
        public ContatoRepository(BancoContext bancoContext)
        {
            banco = bancoContext;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            banco.Add(contato);
            banco.SaveChanges();


            return contato;
        }

        public List<ContatoModel> listAll()
        {
            return banco.contatos.ToList() ;
        }
    }
}
