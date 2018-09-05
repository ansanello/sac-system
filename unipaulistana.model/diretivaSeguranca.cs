namespace unipaulistana.model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DiretivaSeguranca
    {
        public DiretivaSeguranca(){}

        public DiretivaSeguranca(int diretivaSegurancaID, string nome)
        {
            this.DiretivaSegurancaID = diretivaSegurancaID;
            this.Nome = nome;
        }

        public int DiretivaSegurancaID { get; set; }

        [Required(ErrorMessage="O campo nome é obrigatório")]
        public string Nome { get; set; }
    }
}








