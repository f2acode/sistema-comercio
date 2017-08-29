using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCategoria
    {
        public static string Inserir(string nome, string descricao)
        {
            DCategoria obj = new CamadaDados.DCategoria();
            obj.Nome = nome;
            obj.Descricao = descricao;
            return obj.Inserir(obj);
        }

        public static string Editar(int idcategoria, string nome, string descricao)
        {
            DCategoria obj = new CamadaDados.DCategoria();
            obj.Nome = nome;
            obj.Descricao = descricao;
            obj.Idcategoria = idcategoria;
            return obj.Editar(obj);
        }

        public static string Excluir(int idcategoria)
        {
            DCategoria obj = new CamadaDados.DCategoria();
            obj.Idcategoria = idcategoria;
            return obj.Excluir(obj);
        }

        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }

        public static DataTable BuscarNome(string textobuscar)
        {
            DCategoria obj = new CamadaDados.DCategoria();
            obj.TextoBuscar = textobuscar;
            return obj.BuscarNome(obj);
        }
    }
}
