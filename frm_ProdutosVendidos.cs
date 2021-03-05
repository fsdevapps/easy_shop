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
    public partial class frm_ProdutosVendidos : Form
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

        string nome = "Selecione um Produto"; //Cria uma string onde guarda o texto "Selecione um Produto"
        string quantidade = "0"; //Cria uma string que guarda a quantidade de produtos vendidos
        string lucro = "0"; //Cria uma string que guarda o lucro de um produto
        public frm_ProdutosVendidos()
        {
            InitializeComponent();
        }

        //Evento de click do botão close
        private void close_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha o formulário
        }

        //Evento quando o formulario carrega
        private void frm_ProdutosVendidos_Load(object sender, EventArgs e)
        {
            this.produtosVendidosTableAdapter.Fill(this.easyShopBDDataSet.ProdutosVendidos); //Preenche a tabela com os valores da base de dados
            comboBox_Produtos.SelectedIndex = -1; //Faz com que nenhum item esteja selecionado na ComboBox
        }

        //Evento quando o tilizador seleciona um item na ComboBox
        private void comboBox_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nome = comboBox_Produtos.GetItemText(comboBox_Produtos.SelectedItem); //Guarda o nome do produto numa variavel
            quantidade = produtosVendidosTableAdapter.FillByProdutosVendidos(easyShopBDDataSet.ProdutosVendidos, nome).ToString(); //Guarda a quantidade vendida do produto numa variavel
            lucro = produtosVendidosTableAdapter.CalcularLucro(nome).ToString(); //Guarda o lucro do produto numa variavel

            produtosVendidosTableAdapter.FillByProdutosVendidos(easyShopBDDataSet.ProdutosVendidos, nome); //Preenche a tabela com os items correspondentes à pesquisa

            if (comboBox_Produtos.SelectedIndex == -1) this.produtosVendidosTableAdapter.Fill(this.easyShopBDDataSet.ProdutosVendidos); //Caso nenhum item esteja selecionado preenche a tabela com todos os dados da base de dados
        }

        //Evento de click do botão detalhes
        private void btn_Detalhes_Click(object sender, EventArgs e)
        {
            lbl_Nome.Text = "Nome do Produto: " + nome; //Escreve o nome do produto numa label
            lbl_Quantidade.Text = "Quantidade Vendida: " + quantidade; //Escreve a quantidade vendida do produto numa label

            if (lucro == "") lbl_Lucro.Text = "Lucro: 0€"; //Caso nenhum produto esteja selecionado escreve 0€ de lucro numa label
            else lbl_Lucro.Text = "Lucro: " + lucro + "€"; //Caso contrário, escreve o lucro do produto numa label
        }
    }
}
