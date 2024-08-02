using ProjetoAula05.Contexts;
using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Repositories
{
    /// <summary>
    /// Repositório de dados para a entidade Funcionario
    /// </summary>
    public class FuncionarioRepository
    {
        public void Inserir(Funcionario funcionario)
        {
            //abrindo conexão com o banco de dados do sqlserver
            using (var dataContext = new DataContext())
            {
                
                dataContext.Add(funcionario);//adicionando funcionario (INSERT)
                dataContext.SaveChanges();//executando 
            }
        }

        public void Atualizar(Funcionario funcionario)
        {
            //abrindo conexao com o banco de dados do sqlserver
            using (var dataContext = new DataContext())
            {
                dataContext.Update(funcionario);//atualizando funcionario (UPDATE)
                dataContext.SaveChanges();//executando
            }
        }

        public void Excluir(Funcionario funcionario)
        {
            //abrindo conexão com o banco de dados sqlserver
            using(var dataContext = new DataContext())
            {
                dataContext.Remove(funcionario);//removendo funcionario (DELETE)
                dataContext.SaveChanges();//executando
            }
        }

        public List<Funcionario> Consultar()
        {
            //abrindo conexão com o banco de dados sqlserver
            using(var dataContext = new DataContext())
            {
                return dataContext.Set<Funcionario>().ToList();
            }
        }
    }
}
