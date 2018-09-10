namespace unipaulistana.model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SolicitacaoItem
    {
        public SolicitacaoItem(){}

        public SolicitacaoItem(int solicitacaoItemID, 
                                int solicitacaoID, 
                                string descricao,
                                int usuarioID)
        {
            this.SolicitacaoItemID = solicitacaoID;
            this.SolicitacaoID = solicitacaoID;
            this.Descricao = descricao;
            this.UsuarioID = usuarioID;
        }

        public int SolicitacaoItemID { get; set; }
        public int SolicitacaoID { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int UsuarioID { get; set; }
    }
}








