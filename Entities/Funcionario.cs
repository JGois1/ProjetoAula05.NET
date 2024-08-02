using ProjetoAula05.Enums;
using ProjetoAula05.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
    public class Funcionario
    {

        private Guid _id;
        private string? _nome;
        private string? _cpf;
        private DateTime? _dataAdmissao;
        private TipoFuncionario? _tipoFuncionario;

        public Guid Id {
            get => _id;
            set => _id = value; 
        }

        public string? Nome { 
            get => _nome; 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ValidacaoException("O preenchimento do nome é obrigatório.");

                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{6,100}$");
                if (!regex.IsMatch(value))
                    throw new ValidacaoException("Informe um nome válido de 6 a 100 carcteres");

                _nome = value;
            } 
        }

        public string? Cpf { 
            get => _cpf; 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ValidacaoException("O preenchimento do CPF é obrigatór.");

                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ValidacaoException("Informe o CPF com exatamente 11 números");

                _cpf = value;
            }
        }

        public DateTime? DataAdmissao
        {
            get => _dataAdmissao;
            set
            {
                if (value == null)
                    throw new ValidacaoException("O preenchimento da data de admissão é obrigatório");

                _dataAdmissao = value;
            }
        }
        public TipoFuncionario? TipoFuncionario { 
            get => _tipoFuncionario;
            set
            {
                if (value == null)
                    throw new ValidacaoException("O preenchimento do tipo do funcionário é obrigatório.");

                _tipoFuncionario = value;
            }
        }
    }
}
