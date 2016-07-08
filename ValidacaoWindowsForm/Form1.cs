using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValidacaoWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnGravar_Click(object sender, EventArgs e)
        {
            ModAluno aluno = new ModAluno();
            try
            {
                aluno.Id = Convert.ToInt32(txtID.Text);
            }
            catch
            {
                aluno.Id = 0;
            }

            try
            {
                aluno.Cadastro = Convert.ToDateTime(txtCadastro.Text);
            }
            catch
            {
                aluno.Cadastro = null;
            }

            aluno.Nome = txtNome.Text;
            aluno.Email = txtEmail.Text;

            if (Validacao.ValidarModelo(aluno)==true)
            {
                // Coloque aqui sua rotina para salvar seus dados

                MessageBox.Show("Registro salvo com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
