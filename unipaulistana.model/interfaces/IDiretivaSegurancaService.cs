namespace unipaulistana.model
{
    using System;
    using System.Collections.Generic;

    public interface IDiretivaSegurancaService
    {
        IEnumerable<DiretivaSeguranca> ObterTodos();
        DiretivaSeguranca ObterPorID(int diretivaSegurancaID);
        IEnumerable<DiretivaSeguranca> ObterDiretivasNaoAssociadasAoGrupoDoUsuario(int usuarioID);
        IEnumerable<DiretivaSeguranca> ObterDiretivasAssociadasGrupoDoUsuario(int usuarioID);
  
    } 
}