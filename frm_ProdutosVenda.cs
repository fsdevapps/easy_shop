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
    public partial class frm_ProdutosVenda : Form
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

        private frm_Principal frm; //Cria uma instancia do Form Principal
        int id = 0; //Cria uma variavel inteira para guardar o ID do Produto
        public frm_ProdutosVenda(frm_Principal frm_principal) //Recebe um argumento
        {
            InitializeComponent();
            frm = frm_principal; //Iguala a instancia do form principal a esse argumento
        }

        //Função que verifica se o utilizador escreveu alguma coisa nas caixas
        private bool checkBadInfo()
        {
            if (txt_nome.Text == "" || txt_nome.Text == "Insira o Nome do Produto" || txt_preço.Text == "" || txt_preço.Text == "Insira o Preço do Produto") return true; //Caso o utilizador não tenha escrito nada, retorna verdadeiro
            else return false; //Caso contrario retorna falso
        }

        //Evento quando o formulario carrega
        private void frm_ProdutosVenda_Load(object sender, EventArgs e)
        {
            this.produtosParaVendaTableAdapter.Fill(this.easyShopBDDataSet.ProdutosParaVenda); //Preenche a tabela com os valores da base de dados
        }

        //Evento de click do botão close
        private void close_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha o formulário
        }

        //Evento quando uma celula da tabela é clicada
        private void dgv_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgv_Produtos.Rows[e.RowIndex].Cells[0].Value); //Guarda o ID do produto numa variavel
            txt_nome.Text = dgv_Produtos.Rows[e.RowIndex].Cells[1].Value.ToString(); //Escreve o nome do produto dentro de uma caixa de texto
            txt_preço.Text = dgv_Produtos.Rows[e.RowIndex].Cells[2].Value.ToString(); //Escreve o preço do produto dentro de uma caixa de texto
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
                if (MessageBox.Show("Tem a certeza que quer inserir o produto?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Faz uma pergunta ao utilizador e caso ele responda sim:
                {
                    produtosParaVendaTableAdapter.InsertData(txt_nome.Text, Convert.ToDecimal(txt_preço.Text)); //Insere dados na base de dados
                    this.produtosParaVendaTableAdapter.Fill(this.easyShopBDDataSet.ProdutosParaVenda); //Preenche a tabela com os valores da base de dados
                    frm.atualizarTabela(); //Preenche a tabela com os valores da base de dados no formulário principal
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
                if (MessageBox.Show("Tem a certeza que quer editar o produto?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Faz uma pergunta ao utilizador e caso ele responda sim:
                {
                    produtosParaVendaTableAdapter.UpdateData(txt_nome.Text, Convert.ToDecimal(txt_preço.Text), id); //Atualiza dados na base de dados
                    this.produtosParaVendaTableAdapter.Fill(this.easyShopBDDataSet.ProdutosParaVenda); //Preenche a tabela com os valores da base de dados
                    frm.atualizarTabela(); //Preenche a tabela com os valores da base de dados no formulário principal
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
                if (MessageBox.Show("Tem a certeza que quer remover o produto?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Faz uma pergunta ao utilizador e caso ele responda sim:
                {
                    produtosParaVendaTableAdapter.DeleteData(id); //Apaga dados na base de dados
                    this.produtosParaVendaTableAdapter.Fill(this.easyShopBDDataSet.ProdutosParaVenda); //Preenche a tabela com os valores da base de dados
                    frm.atualizarTabela(); //Preenche a tabela com os valores da base de dados no formulário principal
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

        //Evento quando o utilizador entra na textbox do Nome
        private void txt_nome_Enter(object sender, EventArgs e)
        {
            if (txt_nome.Text == "Insira o Nome do Produto") txt_nome.Text = ""; //Caso o texto seja "Insira o Nome do Produto" limpa o texto textbox
        }

        //Evento quando o utilizador sai da textbox do Nome
        private void txt_nome_Leave(object sender, EventArgs e)
        {
            if (txt_nome.Text == "") txt_nome.Text = "Insira o Nome do Produto"; //Caso a textbox esteja vazia escreve "Insira o Nome do Funcionário"
        }

        //Evento quando o utilizador entra na textbox do Preço
        private void txt_preço_Enter(object sender, EventArgs e)
        {
            if (txt_preço.Text == "Insira o Preço do Produto") txt_preço.Text = ""; //Caso o texto seja "Insira o Preço do Produto" limpa o texto textbox
        }

        //Evento quando o utilizador sai da textbox do Nome
        private void txt_preço_Leave(object sender, EventArgs e)
        {
            if (txt_preço.Text == "") txt_preço.Text = "Insira o Preço do Produto"; //Caso a textbox esteja vazia escreve "Insira o Nome do Funcionário"
        }
    }
}
