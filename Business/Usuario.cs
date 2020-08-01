using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel;

namespace Business
{
    public class Usuario
    {
        public static void Gravar(UsuarioModel usuario)
        {
            new Database.Usuario().Gravar(usuario.Nome, usuario.Telefone, usuario.CPF);
        }

        public static List<UsuarioModel> Todos()
        {
            var list = new List<UsuarioModel>();
            var tabela = new Database.Usuario().Todos();
            if (tabela.Rows.Count > 0)
            {
                foreach (DataRow row in tabela.Rows)
                {
                    list.Add(new UsuarioModel()
                    {
                        Nome = row["nome"].ToString(),
                        Telefone = row["telefone"].ToString(),
                        CPF = row["cpf"].ToString()
                    });
                }
            }
            return list;
        }
    }
}
