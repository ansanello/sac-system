namespace unipaulistana.model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Cliente
    {
        public Cliente(){}

        public Cliente(int clienteID, string nome)
        {
            this.ClienteID = clienteID;
            this.Nome = nome;
        }

        public int ClienteID { get; set; }

        [Required(ErrorMessage="O campo nome é obrigatório")]
        public string Nome { get; set; }
    }
}
