using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    public partial class frm_cadastro_aluno : Form
    {
        String[] nomes = new string[5];
        int contador = 0;

        public frm_cadastro_aluno()
        {
            InitializeComponent();

            nomes[0] = "Gustavo";
            nomes[1] = "Fernanda";
            nomes[2] = "Neto";
            nomes[3] = "Vitor";
            nomes[4] = "Otávio";
            lbl_nome_aluno.Text = nomes[0];
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

            if (contador > 0)
            {
                contador--;
                lbl_nome_aluno.Text = nomes[contador];
            }

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            if (contador < 4)
            {
                contador++;
                lbl_nome_aluno.Text = nomes[contador];
            }
        }
    }
}
