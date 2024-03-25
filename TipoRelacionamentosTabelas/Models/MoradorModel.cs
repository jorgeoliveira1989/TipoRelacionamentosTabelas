using System.Security.Cryptography.X509Certificates;

namespace TipoRelacionamentosTabelas.Models
{
    public class MoradorModel
    {

        public int Id { get; set; }
        public string Nome { get; set;}
        public List<casaModel> Casas { get; set; }

    }
}
