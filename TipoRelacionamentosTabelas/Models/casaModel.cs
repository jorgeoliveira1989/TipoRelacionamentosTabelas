namespace TipoRelacionamentosTabelas.Models
{
    public class casaModel
    {
        public int Id { get; set; }
        public  string Descricao { get; set; }
        public moradaModel Morada { get; set; }
        public List<quartoModel> Quartos { get; set; }
    }
}
