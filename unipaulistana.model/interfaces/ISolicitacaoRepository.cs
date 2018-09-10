namespace unipaulistana.model
{
    using System;
    using System.Collections.Generic;

    public interface ISolicitacaoRepository
    {
        IEnumerable<Solicitacao> ObterTodos();
        Solicitacao ObterPorID(int solicitacaoID);
        int Adicionar(Solicitacao solicitacao);
        void Atualizar(Solicitacao solicitacao);
        void Excluir(int solicitacaoID);
        void Concluir(int solicitacaoID);
    } 
}