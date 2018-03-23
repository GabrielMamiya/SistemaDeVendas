using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using Dapper;

namespace CamadaDados
{
    public class dCategoria
    {
        private int _Idcategoria { get; set; }
        private string _Nome { get; set; }
        private string _Descricao { get; set; }
        private string _TextoBuscar { get; set; }

        public dCategoria(){
            
        }

        public dCategoria(int idCategoria, string nome, string descricao, string textoBuscar){
            this._Idcategoria = idCategoria;
            this._Nome = nome;
            this._Descricao = descricao;
            this._TextoBuscar = textoBuscar;
        }

        //metodo inserir
        public static void Inserir(dCategoria categoria){
            string resp = "";
            MySqlConnection MySqlCon = new MySqlConnection();
            try {

                MySqlCon.ConnectionString = Conexao.cn;
                MySqlCon.Open();
                try{
                    MySqlCon.Execute("insert into tbCategoria (nome, descricao) values (@_Nome, @_Descricao);", new {_Nome = categoria._Nome, _Descricao = categoria._Descricao});
                    resp = "Dados inseridos com sucesso: \n Nome: " + categoria._Nome + "\n Descricao: " + categoria._Descricao;
                }
                catch(Exception e){
                    Console.WriteLine("Erro ao inserir dados: " + e);
                }
            }
            catch (Exception e){
                resp = e.Message;
            }
            finally{
                if(MySqlCon.State == ConnectionState.Open){
					MySqlCon.Close();
                } 
            }
            Console.WriteLine(resp);
        }

        ////metodo editar
        public static void Editar(dCategoria categoria){
            string resp = "";
            MySqlConnection MySqlCon = new MySqlConnection();
            try
            {
                MySqlCon.ConnectionString = Conexao.cn;
                MySqlCon.Open();
                try
                {
                    MySqlCon.Execute("update tbCategoria set nome = @_Nome, descricao = @_Descricao where idCategoria = @_Idcategoria", new { _Nome = categoria._Nome, _Descricao = categoria._Descricao, _idCategoria = categoria._Idcategoria });
                    resp = "Dados editados com sucesso: \n ID Alterado: " +  categoria._Idcategoria + " \n Novo Nome: " + categoria._Nome + "\n Nova Descricao: " + categoria._Descricao;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao editar dados: " + e);
                }
            }
            catch (Exception e)
            {
                resp = e.Message;
            }
            finally
            {
                if (MySqlCon.State == ConnectionState.Open)
                {
                    MySqlCon.Close();
                }
            }
            Console.WriteLine(resp);
        }

        ////metodo excluir
        public static void Excluir(dCategoria categoria){
            string resp = "";
            MySqlConnection MySqlCon = new MySqlConnection();
            try
            {
                MySqlCon.ConnectionString = Conexao.cn;
                MySqlCon.Open();
                try
                {
                    MySqlCon.Execute("delete from tbCategoria where idCategoria = @_idCategoria", new { _idCategoria = categoria._Idcategoria });
                    resp = "Dados excluidos com sucesso: \n ID excluido: " + categoria._Idcategoria;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao excluir dados: " + e);
                }
            }
            catch (Exception e)
            {
                resp = e.Message;
            }
            finally
            {
                if (MySqlCon.State == ConnectionState.Open)
                {
                    MySqlCon.Close();
                }
            }
            Console.WriteLine(resp);   
        }

        ////metodo mostrar
        public static void Mostrar(){
            string resp = "";
            MySqlConnection MySqlCon = new MySqlConnection();
            try
            {
                MySqlCon.ConnectionString = Conexao.cn;
                MySqlCon.Open();
                try
                {

                    List<dCategoriaTeste> listaDeCategoria = MySqlCon.Query<dCategoriaTeste>(@"select * from tbCategoria order by idCategoria").ToList();

                    listaDeCategoria.ForEach(item => {
                        Console.WriteLine(item.nome);
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao excluir dados: " + e);
                }
            }
            catch (Exception e)
            {
                resp = e.Message;
            }
            finally
            {
                if (MySqlCon.State == ConnectionState.Open)
                {
                    MySqlCon.Close();
                }
            }
        }

        ////metodo buscarnome
        //public string BuscarNome(dCategoria categoria){
            
        //}

    }
}

/* mostrarCategoria = select * from categoria order by idCategoria desc;  
 * buscarNome = select * from categoria where nome like 'TEXTOBUSCADO%'
 * inserirCategoria = insert into categoria (nome, descricao) values (@nome, @descricao);
 * editarCategoria = update categoria set nome = @nome, descricao = @descricao where idCategoria = @idCategoria;
 * deletarCategoria = delete from categoria where idCategoria = @idCategoria;



*/