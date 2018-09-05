namespace unipaulistana.model
{
    using System;
    using System.Collections.Generic;

    public class DiretivaSegurancaService : IDiretivaSegurancaService
    {
        public DiretivaSegurancaService(IDiretivaSegurancaRepository repository)
        {
            this.repository = repository;
        }

        readonly IDiretivaSegurancaRepository repository;

        public IEnumerable<DiretivaSeguranca> ObterTodos()
            => this.repository.ObterTodos();

        public DiretivaSeguranca ObterPorID(int diretivaSegurancaID)
            => this.repository.ObterPorID(diretivaSegurancaID);

        public IEnumerable<DiretivaSeguranca> ObterDiretivasNaoAssociadasAoGrupoDoUsuario(int usuarioID)
            => this.repository.ObterDiretivasNaoAssociadasAoGrupoDoUsuario(usuarioID);

        public IEnumerable<DiretivaSeguranca> ObterDiretivasAssociadasGrupoDoUsuario(int usuarioID)
            => this.repository.ObterDiretivasAssociadasGrupoDoUsuario(usuarioID);
    }
}
