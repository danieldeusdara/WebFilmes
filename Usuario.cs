using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Usuario
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Login é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha é obrigatória")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Confirmar a senha é obrigatório")]
        [Compare("Senha", ErrorMessage = "Senha e Confirmar Senha devem ser iguais")]
        [DataType(DataType.Password)]
        public string ConfirmarSenha { get; set; }
    }
}
