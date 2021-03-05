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
    public partial class frm_Funcionarios : Form
    {
        int id = 0; //Variavel que guarda o ID do funcionário
        public frm_Funcionarios()
        {
            InitializeComponent();
        }

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

        //Evento quando o formulario carrega
        private void frm_Funcionarios_Load(object sender, EventArgs e)
        {
            this.funcionáriosTableAdapter.Fill(this.easyShopBDDataSet.Funcionários); //Preenche a tabela com os valores da base de dados
        }

        //Função que verifica se o utilizador escreveu alguma coisa nas caixas
        private bool checkBadInfo()
        {
            if (txt_nome.Text == "" || txt_nome.Text == "Insira o Nome do Funcionário" || txt_user.Text == "" || txt_user.Text == "Insira o Username do Funcionário" || txt_senha.Text == "" || txt_senha.Text == "Insira a Password do Funcionário") return true; //Caso o utilizador não tenha escrito nada, retorna verdadeiro
            else return false; //Caso contrario retorna falso
        }

        //Evento de click do botão Inserir
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (checkBadInfo()) //Caso a função checkBadInfo retorne verdadeiro
            {
                MessageBox.Show("Insira corretamente todas as informações!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Apresenta uma mensagem de erro
                return; //Quebra o ciclo
            }
            try //Tenta executar o seguinte código:
            {
                if (MessageBox.Show("Tem a certeza que quer adicionar o Funcionário ao Registo?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Faz uma pergunta ao utilizador e caso ele responda sim:
                {
                    funcionáriosTableAdapter.InsertData(txt_nome.Text, txt_user.Text, txt_senha.Text); //Insere dados na base de dados
                    this.funcionáriosTableAdapter.Fill(this.easyShopBDDataSet.Funcionários); //Preenche a tabela com os valores da base de dados
                }
                else //Caso o utilizador responde-se não:
                {
                    MessageBox.Show("Operação Cancelada com Sucesso!"); //Apresenta uma mensagem a dizer que a operação foi cancelada
                }
            }
            catch (Exception ex) //Caso ocorra algum erro:
            {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Apresenta uma mensagem com o erro
            }
        }

        //Evento quando uma celula da tabela é clicada
        private void dgv_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value); //Guarda o ID do funcionario numa variavel
            txt_nome.Text = dgv_Produtos.Rows[e.RowIndex].Cells[1].Value.ToString(); //Escreve o nome do funcionário dentro de uma caixa de texto
            txt_user.Text = dgv_Produtos.Rows[e.RowIndex].Cells[2].Value.ToString(); //Escreve o username do funcionário dentro de uma caixa de texto
            txt_senha.Text = dgv_Produtos.Rows[e.RowIndex].Cells[3].Value.ToString(); //Escreve a senha do funcionário dentro de uma caixa de texto
        }

        //Evento de click do botão atualizar
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (checkBadInfo()) //Caso a função checkBadInfo retorne verdadeiro
            {
                MessageBox.Show("Insira corretamente todas as informações!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Apresenta uma mensagem de erro
                return; //Quebra o ciclo
            }
            try //Tenta executar o seguinte código:
            {
                if (MessageBox.Show("Tem a certeza que quer atualizar as informações do Funcionário?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Faz uma pergunta ao utilizador e caso ele responda sim:
                {
                    funcionáriosTableAdapter.UpdateData(txt_nome.Text, txt_user.Text, txt_senha.Text, id); //Atualiza dados na base de dados
                    this.funcionáriosTableAdapter.Fill(this.easyShopBDDataSet.Funcionários); //Preenche a tabela com os valores da base de dados
                }
                else //Caso o utilizador responde-se não:
                {
                    MessageBox.Show("Operação Cancelada com Sucesso!"); //Apresenta uma mensagem a dizer que a operação foi cancelada
                }
            }
            catch (Exception ex) //Caso ocorra algum erro:
            {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Apresenta uma mensagem com o erro
            }
        }

        //Evento de click do botão remover
        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (checkBadInfo()) //Caso a função checkBadInfo retorne verdadeiro
            {
                MessageBox.Show("Insira corretamente todas as informações!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Apresenta uma mensagem de erro
                return; //Quebra o ciclo
            }
            try //Tenta executar o seguinte código:
            {
                if (MessageBox.Show("Tem a certeza que quer remover o Funcionário do Registo?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Faz uma pergunta ao utilizador e caso ele responda sim:
                {
                    funcionáriosTableAdapter.DeleteData(id); //Apaga dados na base de dados
                    this.funcionáriosTableAdapter.Fill(this.easyShopBDDataSet.Funcionários); //Preenche a tabela com os valores da base de dados
                }
                else //Caso o utilizador responde-se não:
                {
                    MessageBox.Show("Operação Cancelada com Sucesso!"); //Apresenta uma mensagem a dizer que a operação foi cancelada
                }
            }
            catch (Exception ex) //Caso ocorra algum erro:
            {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Caso ocorra algum erro:
            }
        }

        //Evento de click do botão close
        private void close_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha o formulário
        }

        //Evento quando o utilizador entra na textbox do Nome
        private void txt_nome_Enter(object sender, EventArgs e)
        {
            if (txt_nome.Text == "Insira o Nome do Funcionário") txt_nome.Text = ""; //Caso o texto seja "Insira o Nome do Funcionário" limpa o texto textbox
        }

        //Evento quando o utilizador sai da textbox do Nome
        private void txt_nome_Leave(object sender, EventArgs e)
        {
            if (txt_nome.Text == "") txt_nome.Text = "Insira o Nome do Funcionário"; //Caso a textbox esteja vazia escreve "Insira o Nome do Funcionário"
        }

        //Evento quando o utilizador entra na textbox do Username
        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Insira o Username do Funcionário") txt_user.Text = ""; //Caso o texto seja "Insira o Username do Funcionário" limpa o texto textbox
        }

        //Evento quando o utilizador sai da textbox do Username
        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "") txt_user.Text = "Insira o Username do Funcionário"; //Caso a textbox esteja vazia escreve "Insira o Username do Funcionário"
        }

        //Evento quando o utilizador entra na textbox da Senha
        private void txt_senha_Enter(object sender, EventArgs e)
        {
            if (txt_senha.Text == "Insira a Password do Funcionário") txt_senha.Text = ""; //Caso o texto seja "Insira a Password do Funcionário" limpa o texto textbox
        }

        //Evento quando o utilizador sai da textbox da Senha
        private void txt_senha_Leave(object sender, EventArgs e)
        {
            if (txt_senha.Text == "") txt_senha.Text = "Insira a Password do Funcionário"; //Caso a textbox esteja vazia escreve "Insira a Password do Funcionário"
        }
    }
}
