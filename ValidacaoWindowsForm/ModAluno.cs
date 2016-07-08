/* 
 * Atributo Validação Data Annotation Windows Form
 * 
 * Visite nossa página http://www.codigoexpresso.com.br
 * 
 * by Antonio Azevedo
 *  
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ValidacaoWindowsForm
{
    class ModAluno
    {
        [Display(Name = "Código")]
        [Range(1, 999, ErrorMessage="Código Aluno deve estar entre 1 e 999")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Nome é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Nome, números e caracteres especiais não são permitidos.")]
        public string Nome { get; set; }

        [EmailBrasil(EmailRequerido=true,ErrorMessage="E-mail inválido")]
        public string Email { get; set; }

        [Display(Name = "Data Cadastro")]
        [DataBrasil(DataRequerida=true,ErrorMessage="Data de Cadastro inválida")]
        public DateTime Cadastro {get;set;}
    }
}
