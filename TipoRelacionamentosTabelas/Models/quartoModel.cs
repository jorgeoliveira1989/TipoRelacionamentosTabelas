namespace TipoRelacionamentosTabelas.Models
{
    public class quartoModel
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CasaId {  get; set; }
        public casaModel Casa { get; set; }
    }
}
