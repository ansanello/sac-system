namespace unipaulistana.model
{
    using System;

    public class Cliente
    {
        public Cliente(){}

        public Cliente(int clienteID, string nome)
        {
            this.ClienteID = clienteID;
            this.Nome = nome;
        }

        public int ClienteID { get; set; }
        public string Nome { get; set; }
    }
}
