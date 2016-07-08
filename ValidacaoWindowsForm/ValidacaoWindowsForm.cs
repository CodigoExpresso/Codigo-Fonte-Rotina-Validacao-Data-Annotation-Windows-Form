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
using System.Windows.Forms;


public static class Validacao
{
    public static IEnumerable<ValidationResult> getValidationErros(object obj)
    {
        var resultadoValidacao = new List<ValidationResult>();
        var contexto = new ValidationContext(obj, null, null);
        Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
        return resultadoValidacao;
    }

    /// <summary>
    /// Responsavel pela Chamada da validação de nosso Modelo
    /// </summary>
    /// <param name="obj">Modelo (Classe)</param>
    /// <returns>String com erros ou null se não existir erros</returns>
    public static Boolean ValidarModelo(object obj)
    {
        var erros = Validacao.getValidationErros(obj);
        string strErros = "";
        foreach (var error in erros)
        {
            //MessageBox.Show((error.ErrorMessage));
            strErros += error.ErrorMessage + Environment.NewLine;
        }
        if (strErros.Length>0)
        {
            strErros = "Corrija os problemas abaixo: " + Environment.NewLine + Environment.NewLine + strErros;
            MessageBox.Show(strErros, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }
}

