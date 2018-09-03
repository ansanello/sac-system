namespace unipaulistana.model
{
    using System;
    using System.Collections.Generic;

    public class UsuarioService : IUsuarioService
    {
        public UsuarioService(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        readonly IUsuarioRepository repository;

        public IEnumerable<Usuario> ObterTodos()
            => this.repository.ObterTodos();

        public Usuario ObterPorID(int usuarioID)
            => this.repository.ObterPorID(usuarioID);

        public void Adicionar(Usuario usuario)
        {
            this.repository.Adicionar(usuario);
        } 

        public void Atualizar(Usuario usuario)
        {
            this.repository.Atualizar(usuario);
        } 

        public void Excluir(int usuarioID)
        {
            this.repository.Excluir(usuarioID);
        } 
    }
}
