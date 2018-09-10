namespace unipaulistana.model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Solicitacao
    {
        public Solicitacao(){}

        public Solicitacao(int solicitacaoID, 
                            string descricao,
                            int clienteID,
                            int departamentoID,
                            int usuarioID)
        {
            this.SolicitacaoID = solicitacaoID;
            this.DataDeCriacao = DateTime.Now;
            this.Concluido = false;
            this.Descricao = descricao;
            this.ClienteID = clienteID;
            this.DepartamentoID = departamentoID;
            this.UsuarioID = usuarioID;
        }

        public Solicitacao(int solicitacaoID, 
                            string descricao,
                            DateTime dataDeCriacao,
                            object dataDeConclusao,
                            bool concluido,
                            int clienteID,
                            int departamentoID,
                            int usuarioID)
        {
            this.SolicitacaoID = solicitacaoID;
            this.Descricao = descricao;
            this.DataDeCriacao = dataDeCriacao;
            
            if (dataDeConclusao != null)
                this.DataDeConclusao = Convert.ToDateTime(dataDeConclusao);

            this.Concluido = concluido;
            this.ClienteID = clienteID;
            this.DepartamentoID = departamentoID;
            this.UsuarioID = usuarioID;
        }

        public void ConcluirSolicitacao()
        {
            this.DataDeConclusao = DateTime.Now;
            this.Concluido = true;
        }

        public int SolicitacaoID { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public Nullable<DateTime> DataDeConclusao { get; set; }
        public string Descricao { get; set; }
        public int ClienteID { get; set; }
        public int DepartamentoID { get; set; }
        public int UsuarioID { get; set; }
        public bool Concluido { get; set; }
    }
}








