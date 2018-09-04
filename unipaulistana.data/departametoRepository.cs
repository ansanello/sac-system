namespace unipaulistana.model
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using unipaulistana.data;

    public class DepartamentoRepository : IDepartamentoRepository
    {
        public DepartamentoRepository (ConexaoContext conexao)
        {
            this.conexao = conexao;
        }
        readonly ConexaoContext conexao;

        public void Adicionar(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int departamentoID)
        {
            throw new NotImplementedException();
        }

        public Departamento ObterPorID(int departamentoID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departamento> ObterTodos()
        {
            var cmd = new SqlCommand("select * from departamento", this.conexao.ObterConexao());
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
                yield return new Departamento( Convert.ToInt32(sqlDataReader.GetValue(0)), sqlDataReader.GetValue(1).ToString());
        }
    }
}
