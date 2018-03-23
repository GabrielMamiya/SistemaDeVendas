using System;
using MySql.Data.MySqlClient;
using Dapper;

namespace CamadaDados
{
    public class Conexao
    {
        
            //MySqlConnection conn = new MySqlConnection();
            //conn.ConnectionString = "Data Source=localhost; Initial Catalog = dbComercio;User ID = root; Password = gabriel00";
            public static string cn = "Data Source=localhost; Initial Catalog = dbComercio;User ID = root; Password = gabriel00";
            //conn.Open();
            //Console.WriteLine("Abri a conexao!");
        
    }
}

/* mostrarCategoria = select * from categoria order by idCategoria desc;  
 * buscarNome = select * from categoria where nome like 'TEXTOBUSCADO%'
 * inserirCategoria = insert into categoria (nome, descricao) values (@nome, @descricao);
 * editarCategoria = update categoria set nome = @nome, descricao = @descricao where idCategoria = @idCategoria;
 * deletarCategoria = delete from categoria where idCategoria = @idCategoria;



*/