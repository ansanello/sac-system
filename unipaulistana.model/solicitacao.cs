namespace unipaulistana.model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Solicitacao
    {
        public Solicitacao() { }

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
                            int usuarioID,
                            int solicitanteID,
                            StatusSolicitacao status,
                            string nomeUsuario,
                            string nomeCliente,
                            string nomeDepartamento,
                            string nomeSolicitante)
        {
            this.SolicitacaoID = solicitacaoID;
            this.Descricao = descricao;
            this.DataDeCriacao = dataDeCriacao;

            if (dataDeConclusao != null && dataDeConclusao != DBNull.Value)
                this.DataDeConclusao = Convert.ToDateTime(dataDeConclusao);

            this.Concluido = concluido;
            this.ClienteID = clienteID;
            this.DepartamentoID = departamentoID;
            this.UsuarioID = usuarioID;
            this.SolicitanteID = solicitanteID;
            this.Status = status;
            this.NomeUsuario = nomeUsuario;
            this.NomeCliente = nomeCliente;
            this.NomeDepartamento = nomeDepartamento;
            this.NomeSolicitante = nomeSolicitante;
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
        public StatusSolicitacao Status { get; set; }
        public int DepartamentoID { get; set; }
        public int UsuarioID { get; set; }
        public int SolicitanteID {get;set;}
        public bool Concluido { get; set; }
        public string NomeUsuario { get; set; }
        public string NomeCliente { get; set; }
        public string NomeDepartamento { get; set; }
        public string NomeSolicitante { get; set; }
    }

    public enum StatusSolicitacao
    {
        nao_iniciado = 1,
        em_analise = 2,
        em_andamento = 3,
        concluido = 4
    }
}








