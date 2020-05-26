using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class ProjetoAltelta : Form
    {
        public ProjetoAltelta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_IMC.Text = objAtleta.calcularIMC();
        }

        private void ProjetoAltelta_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Nota: Use virgulas em vez de pontos!");
        }

        private void btn_calcularidade_Click(object sender, EventArgs e)
        {
            txt_idade.Text = objAtleta.calcularIdade();
        }

        Atleta objAtleta = new Atleta();

        private void btn_criarAtleta_Click(object sender, EventArgs e)
        {
            try
            {
                objAtleta.Nome = txt_nome.Text;
                objAtleta.Altura = double.Parse(txt_altura.Text);
                objAtleta.Peso = double.Parse(txt_peso.Text);
                objAtleta.DataNasimento = dtp_nascimento.Value;
                btn_calcularidade.Enabled = true;
                btn_calcularIMC.Enabled = true;
                MessageBox.Show("Dados cadastrados com sucesso.");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Erro. \n" +ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_nome.Focus();
            }

            
        }
    }
}
