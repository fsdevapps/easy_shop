using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyShop
{
    public partial class frm_Principal : Form
    {
        double preçoTotal = 0.00; //Variavel que guarda o preço total da compra atual
        List<produto> Queue = new List<produto> { }; //Lista onde guarda os produtos
        public string username; //String que guarda o Username

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
        public frm_Principal()
        {
            InitializeComponent();
        }

        //Função quando o Form é fechado
        private void frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Fecha a aplicação
        }

        //Função publica que atualiza a tabela
        public void atualizarTabela()
        {
            this.produtosParaVendaTableAdapter.Fill(this.easyShopBDDataSet.ProdutosParaVenda); //Preenche a tabela com os valores da base de dados
        }

        //Evento quando o form é carregado
        private void frm_Principal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-Vindo " + username); //Apresenta uma mensagem a dizer bem vindo ao utilizador
            lbl_Username.Text = username; //Escreve o username numa label
            this.produtosParaVendaTableAdapter.Fill(this.easyShopBDDataSet.ProdutosParaVenda); //Preenche a tabela com os valores da base de dados
        }

        //Função que insere produtos dentro da lista e atualiza a listview
        private void AtualizarInfo(string nomeProduto, double preço)
        {
            produto _produto = new produto(); //Cria um novo produto
            bool repetido = false; //Cria uma variavel do tipo booleano que indica que o produto ainda não existe na lista
            _produto.Nome = nomeProduto; //Define o nome do produto
            _produto.Preço = preço; //Define o preço do produto
            foreach(produto x in Queue) //Verifica todos os produtos dentro da lista
            {
                if(x.Nome == nomeProduto && x.Quantidade >= 1) //Caso o produto exista, adiciona 1 à quantidade deste e diz que o produto é repetido
                {
                    x.Quantidade++;
                    repetido = true;
                    break;
                }
                else //Caso contrário, diz que o produto não é repetido
                {
                    repetido = false;
                }
            }

            if(!repetido) Queue.Add(_produto); //Caso o produto não seja repetido adiciona este à lista
            preçoTotal = 0; //Indica que o preço total é igual a 0
            lst_Queue.Clear(); //Limpa a lista
            foreach(produto x in Queue) //Para cada produto da lista:
            {
                lst_Queue.Items.Add(x.Quantidade + "x" + " " + x.Nome + " " + x.Preço.ToString() + "€"); //Adiciona o produto à listview
                preçoTotal += x.Preço * x.Quantidade; //Adiciona o preço do produto ao preço total
            }

            lbl_PreçoTotal.Text = preçoTotal + "€"; //Indica o preço total numa label
        }

        //Função que define o nome do produto e o preço indo buscar estes à base de dados
        private void DefinirValores()
        {
            if (produtosParaVendaDataGridView.Rows.Count == 0) return; //Caso não exista produtos na tabela quebra o ciclo (para evitar erros)
            String produtoClicado = produtosParaVendaDataGridView.CurrentRow.Cells[1].Value.ToString(); //Guarda o nome do produto numa variavel
            double preçoProduto = Convert.ToDouble(produtosParaVendaDataGridView.CurrentRow.Cells[2].Value); //Guarda o preço do produto numa variavel
            AtualizarInfo(produtoClicado, preçoProduto); //Executa a função "AtualizarInfo" e envia o nome e o preço do produto
        }

        //Evento de double click numa célula da tabela
        private void produtosParaVendaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DefinirValores(); //Executa a função definir valores
        }

        //Evento quando o texto da textbox muda
        private void txt_ProcuraProduto_TextChanged(object sender, EventArgs e)
        {
            if (produtosParaVendaDataGridView.Rows.Count > 0) produtosParaVendaDataGridView.Rows[0].Selected = true; //Seleciona o primeiro item da tabela caso este exista
            this.produtosParaVendaTableAdapter.FillBySearchNomeProduto(easyShopBDDataSet.ProdutosParaVenda, txt_ProcuraProduto.Text); //Preenche a tabela com os items correspondentes à pesquisa

        }

        //Evento quando é clicada numa tecla dentro da textbox
        private void txt_ProcuraProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Caso a tecla seja Enter executa a função definir valores
            {
                DefinirValores();
            }
        }

        //Evento de click do botão minimize
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimiza a janela
        }

        //Evento de click do botão close
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Fecha a aplicação
        }

        //Evento de click do botão aceitar
        private void btn_Aceitar_Click(object sender, EventArgs e)
        {
            foreach(produto x in Queue) //Para cada produto da lista:
            {
                for(int i = 0; i < x.Quantidade; i++) //Para cada quantidade de um produto:
                produtosVendidosTableAdapter.InsertData(x.Nome, Convert.ToDecimal(x.Preço)); //Adiciona o produto à base de dados
            }
            Queue.Clear(); //Limpa a lista
            lst_Queue.Clear(); //Limpa a listview
            lbl_PreçoTotal.Text = "0,0€"; //Limpa o preço da label
        }

        //Evento de click do botão aceitar
        private void btn_Recusar_Click(object sender, EventArgs e)
        {
            Queue.Clear(); //Limpa a lista
            lst_Queue.Clear(); //Limpa a listview
            lbl_PreçoTotal.Text = "0,0€"; //Limpa o preço da label
        }

        //Evento de click do botão Funcionários
        private void adicionarFuncionários_Click(object sender, EventArgs e)
        {
            new frm_Funcionarios().ShowDialog(); //Abre o formulário dos funcionários
        }

        //Evento de click do botão Produtos Vendidos
        private void produtosVendidos_Click(object sender, EventArgs e)
        {
            new frm_ProdutosVendidos().ShowDialog(); //Abre o formulário dos produtos vendidos
        }

        //Evento de click do botão Produtos para Venda
        private void produtosParaVenda_Click(object sender, EventArgs e)
        {
            new frm_ProdutosVenda(this).ShowDialog(); //Abre o formulário dos produtos para venda e envia este formulário como argumento
        }
    }
}
