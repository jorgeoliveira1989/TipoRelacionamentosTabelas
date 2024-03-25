namespace TipoRelacionamentosTabelas.Models
{
    public class moradaModel
    {

        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int CasaId { get; set; }
        public casaModel Casa { get; set; }
    }
}
