namespace unipaulistana.model
{
    using System;

    public class Usuario : Base
    { 
        public Usuario(){}

        public Usuario(int usuarioID, string nome, string email, string senha)
        {
            this.UsuarioID = usuarioID;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
