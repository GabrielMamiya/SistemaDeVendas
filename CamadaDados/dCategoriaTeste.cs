using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using Dapper;

namespace CamadaDados
{
    public class dCategoriaTeste
    {
        public int idCategoria { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string textoBuscar { get; set; }



    }
}

/* mostrarCategoria = select * from categoria order by idCategoria desc;  
 * buscarNome = select * from categoria where nome like 'TEXTOBUSCADO%'
 * inserirCategoria = insert into categoria (nome, descricao) values (@nome, @descricao);
 * editarCategoria = update categoria set nome = @nome, descricao = @descricao where idCategoria = @idCategoria;
 * deletarCategoria = delete from categoria where idCategoria = @idCategoria;



*/