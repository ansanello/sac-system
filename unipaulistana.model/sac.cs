namespace unipaulistana.model
{
    using System;

    public class SAC : Base
    {
        public int SacID { get; set; }
        public DateTime DataDeConclusao { get; set; }
        public int UsuarioID { get; set; }
    }
}
