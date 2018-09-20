namespace unipaulistana.model
{
    using System;
    using System.Collections.Generic;

    public class SolicitacaoService : ISolicitacaoService
    {
        public SolicitacaoService(ISolicitacaoRepository repository)
        {
            this.repository = repository;
        }

        readonly ISolicitacaoRepository repository;

        public IEnumerable<Solicitacao> ObterTodos()
            => this.repository.ObterTodos();

        public Solicitacao ObterPorID(int solicitacaoID)
            => this.repository.ObterPorID(solicitacaoID);

        public int Adicionar(Solicitacao solicitacao, int solicitanteID)
        {
            solicitacao.SolicitanteID = solicitanteID;
            solicitacao.UsuarioID = solicitanteID;
            solicitacao.DataDeCriacao = DateTime.Now;
            return this.repository.Adicionar(solicitacao);
        } 

        public void Atualizar(Solicitacao solicitacao)
        {
            this.repository.Atualizar(solicitacao);
        } 

        public void Excluir(int solicitacaoID)
        {
            this.repository.Excluir(solicitacaoID);
        }

        public void Concluir(int solicitacaoID)
        {
            this.repository.Concluir(solicitacaoID);
        }

        public IEnumerable<SolicitacaoItem> ObterPorSolicitacaoItens(int solicitacaoID)
            => this.repository.ObterPorSolicitacaoItens(solicitacaoID);

        public void AdicionarItem(SolicitacaoItem solicitacaoItem, int usuarioID)
        {
            this.repository.AdicionarItem(solicitacaoItem, usuarioID);
        }
    }
}
