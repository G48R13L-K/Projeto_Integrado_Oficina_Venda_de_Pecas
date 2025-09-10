using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrado
{
    public static class InicializarDados
    {
        public static void Semear()//Para criar um usuario admin na primeira vez que o sistema for aberto
        {
            using(var banco = new VendasDbContest())
            {
                if (!banco.Usuario.Any())
                {
                    banco.Usuario.Add(new Usuario
                    {
                        CPF = "",
                        Email = "adm",
                        Funcao = "Administrador",
                        NomeCliente = "Admin",
                        PerfilUsuario = "Admin",
                        Senha = "admin",
                        Telefone = ""
                    });
                    
                }
                banco.SaveChanges();

            }
        }
    }
}
