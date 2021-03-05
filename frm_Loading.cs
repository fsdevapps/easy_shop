using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyShop
{
    public partial class frm_Loading : Form
    {
        public frm_Loading()
        {
            InitializeComponent();
        }

        //Evento de Tick do Timer Loading
        private void timer_Loading_Tick(object sender, EventArgs e)
        {
            if(progressBar_Loading.Value < 100) //Caso o valor da ProgressBar for menor que 100:
            {
                progressBar_Loading.Value++; //Adiciona 1 ao valor da ProgressBar
            }
            else //Caso contrário:
            {
                timer_Loading.Enabled = false; //Desativa o timer
                frm_LoginAdmin frm = new frm_LoginAdmin(); //Cria uma instancia para o formulário LoginAdmin
                frm.Show(); //Mostra esse formulário
                this.Hide(); //Esconde este formulário
            }
        }
    }
}
