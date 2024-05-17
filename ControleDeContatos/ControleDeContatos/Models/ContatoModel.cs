using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        [Key]
        public int Id {  get; set; }
        
        public string nome { get; set; }

        public string email { get; set; }

        public string celular {  get; set; }


    }
}
