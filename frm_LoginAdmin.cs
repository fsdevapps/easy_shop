using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyShop
{
    public partial class frm_LoginAdmin : Form
    {
        #region Simula a ação do utilizador arrastar o formulário
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        public frm_LoginAdmin()
        {
            InitializeComponent();
        }

        //Evento de Click do botão Close
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Fecha a aplicação
        }

        //Evento de Click do botão Minimize
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimiza o Form
        }

        #region  Username e Password Hint
        
        //Evento quando o utilizador entra na textBox Username
        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Username") txt_Username.Text = ""; //Caso o texto da textbox seja "Username" limpa o texto desta
        }

        //Evento quando o utilizador entra na textBox Password
        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password") //Caso o texto da textbox seja "Password" limpa o texto desta
            {                                    //e define que o PasswordChar da textbox é '*'
                txt_Password.Text = "";
                txt_Password.PasswordChar = '*';
            }
        }

        //Evento quando o utilizador sai da textBox Username
        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text == "") txt_Username.Text = "Username"; //Caso a textbox esteja vazia define que o texto é igual a "Username"
        }

        //Evento quando o utilizador sai da textBox Password
        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "") //Caso a textbox esteja vazia define que o texto é igual a "Password" e define que o PasswordChar
            {                            //é igual a '\0', ou seja, vazio
                txt_Password.Text = "Password";
                txt_Password.PasswordChar = '\0';
            }
        }
        #endregion

        //Evento de Load do Form
        private void frm_LoginAdmin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1; //Define que o controlo ativo do form é a pictureBox1
            this.funcionáriosTableAdapter.Fill(this.easyShopBDDataSet.Funcionários); //Mostra os dados na tabela
        }

        //Evento de Click do botão Login
        private void btn_Login_Click(object sender, EventArgs e)
        {
            int result = funcionáriosTableAdapter.FillByLoginFuncionario(easyShopBDDataSet.Funcionários, txt_Username.Text, txt_Password.Text); //Verifica se o utilizador existe na base de dados

            if (result == 1) //Caso exista:
            {
                frm_Principal frm = new frm_Principal(); //Inicia uma nova instancia do form Principal
                frm.username = funcionáriosTableAdapter.FillByRetornarNome(txt_Username.Text).ToString(); //Define que a variavel username é igual nome do utilizador 
                frm.Show(); //Mostra o formulário
                this.Hide(); //Esconde este formulário
            }
            else //Caso contrário:
            {
                MessageBox.Show("Username ou Password Inválidos", "Ocorreu um Erro na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error); //Apresenta uma MessageBox com um erro
            }
        }

        //Evento quando o utilizador pressiona uma tecla dentro da textbox Username
        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) //Caso a tecla pressionada seja o Enter
            {
                btn_Login_Click(sender, e); //Simula o click no botão login
            }
        }

        //Evento quando o utilizador pressiona uma tecla dentro da textbox Password
        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Caso a tecla pressionada seja o Enter
            {
                btn_Login_Click(sender, e); //Simula o click no botão login
            }
        }
    }
}
