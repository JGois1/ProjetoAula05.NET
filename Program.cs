using ProjetoAula05.Entities;
using ProjetoAula05.Enums;
using ProjetoAula05.Repositories;

var funcionario = new Funcionario();

funcionario.Id = Guid.NewGuid();
funcionario.Nome = "Funcionario Teste";
funcionario.Cpf = "12345678900";
funcionario.DataAdmissao = DateTime.Now;
funcionario.TipoFuncionario = TipoFuncionario.Estagio;

var funcionarioRepository = new FuncionarioRepository();
funcionarioRepository.Inserir(funcionario);

Console.WriteLine("\nFUNCIONARIO CADASTRADO COM SUCESSO.");

Console.ReadKey();


