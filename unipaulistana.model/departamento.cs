namespace unipaulistana.model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Departamento
    {
        public Departamento(){}

        public Departamento(int departamentoID, string nome)
        {
            this.DepartamentoID = departamentoID;
            this.Nome = nome;
        }

        public int DepartamentoID { get; set; }

        [Required(ErrorMessage="O campo nome é obrigatório")]
        public string Nome { get; set; }
    }
}








