namespace unipaulistana.model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class GrupoDeSeguranca
    {
        public GrupoDeSeguranca(){}

        public GrupoDeSeguranca(int grupoDeSegurancaID, string nome)
        {
            this.GrupoDeSegurancaID = grupoDeSegurancaID;
            this.Nome = nome;
        }

        public int GrupoDeSegurancaID { get; set; }

        [Required(ErrorMessage="O campo nome é obrigatório")]
        public string Nome { get; set; }
    }
}








