using ControleDeContatos.Models;
using ControleDeContatos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepository.listAll();
           
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Editar(int Id)
        {   
            ContatoModel contato = _contatoRepository.FindById(Id);
            return View(contato);
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            _contatoRepository.AtualizarCadastro(contato);
            return RedirectToAction("Index");
        }

        public IActionResult ApagarContato(int Id)
        {
            _contatoRepository.DeleteById(Id);
            return RedirectToAction("Index");
        }
    }
}
