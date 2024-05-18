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

        public ContatoModel AtualizarCadastro(ContatoModel contato)
        {
            ContatoModel contatoDB = FindById(contato.Id);

            if (contatoDB == null)
            {
                throw new Exception("Usuario não encontrado.");
            }

            contatoDB.nome = contato.nome;
            contatoDB.email = contato.email;
            contatoDB.celular  = contato.celular;
            
            banco.Update(contatoDB);
            banco.SaveChanges();


            return contatoDB;
            
        }

        public ContatoModel DeleteById(int Id)
        {
            var contato = FindById(Id);

            if (contato == null) throw new Exception("Usuario não encontrado");

            banco.contatos.Remove(contato);
            banco.SaveChanges();

            return null;
            
            
        }

        public ContatoModel FindById(int Id)
        {
            try
            {
           
             var contato  =  banco?.Find<ContatoModel>(Id);
                return contato;
            }
            catch (Exception e)
            {

                throw new Exception("Usuário não encontrado",e);
            }
            
        }

        public List<ContatoModel> listAll()
        {
            return banco.contatos.ToList() ;
        }

        
    }
}
