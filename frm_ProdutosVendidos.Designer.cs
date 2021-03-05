namespace EasyShop
{
    partial class frm_ProdutosVendidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProdutosVendidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Lucro = new System.Windows.Forms.Label();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Detalhes = new System.Windows.Forms.Button();
            this.comboBox_Produtos = new System.Windows.Forms.ComboBox();
            this.produtosParaVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.easyShopBDDataSet = new EasyShop.EasyShopBDDataSet();
            this.produtosVendidosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosVendidosTableAdapter = new EasyShop.EasyShopBDDataSetTableAdapters.ProdutosVendidosTableAdapter();
            this.tableAdapterManager = new EasyShop.EasyShopBDDataSetTableAdapters.TableAdapterManager();
            this.produtosParaVendaTableAdapter = new EasyShop.EasyShopBDDataSetTableAdapters.ProdutosParaVendaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyShopBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(761, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel2.Controls.Add(this.lbl_Lucro);
            this.panel2.Controls.Add(this.lbl_Quantidade);
            this.panel2.Controls.Add(this.lbl_Nome);
            this.panel2.Controls.Add(this.btn_Detalhes);
            this.panel2.Controls.Add(this.comboBox_Produtos);
            this.panel2.Controls.Add(this.produtosVendidosDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 410);
            this.panel2.TabIndex = 8;
            // 
            // lbl_Lucro
            // 
            this.lbl_Lucro.AutoSize = true;
            this.lbl_Lucro.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lucro.ForeColor = System.Drawing.Color.White;
            this.lbl_Lucro.Location = new System.Drawing.Point(380, 198);
            this.lbl_Lucro.Name = "lbl_Lucro";
            this.lbl_Lucro.Size = new System.Drawing.Size(60, 24);
            this.lbl_Lucro.TabIndex = 5;
            this.lbl_Lucro.Text = "Lucro:";
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantidade.ForeColor = System.Drawing.Color.White;
            this.lbl_Quantidade.Location = new System.Drawing.Point(380, 150);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(172, 24);
            this.lbl_Quantidade.TabIndex = 4;
            this.lbl_Quantidade.Text = "Quantidade Vendida:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.lbl_Nome.Location = new System.Drawing.Point(380, 102);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(152, 24);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome do Produto:";
            // 
            // btn_Detalhes
            // 
            this.btn_Detalhes.BackColor = System.Drawing.Color.White;
            this.btn_Detalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detalhes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detalhes.ForeColor = System.Drawing.Color.Black;
            this.btn_Detalhes.Location = new System.Drawing.Point(643, 39);
            this.btn_Detalhes.Name = "btn_Detalhes";
            this.btn_Detalhes.Size = new System.Drawing.Size(135, 28);
            this.btn_Detalhes.TabIndex = 2;
            this.btn_Detalhes.Text = "Ver Detalhes";
            this.btn_Detalhes.UseVisualStyleBackColor = false;
            this.btn_Detalhes.Click += new System.EventHandler(this.btn_Detalhes_Click);
            // 
            // comboBox_Produtos
            // 
            this.comboBox_Produtos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Produtos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Produtos.DataSource = this.produtosParaVendaBindingSource;
            this.comboBox_Produtos.DisplayMember = "Nome do Produto";
            this.comboBox_Produtos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Produtos.FormattingEnabled = true;
            this.comboBox_Produtos.Location = new System.Drawing.Point(375, 39);
            this.comboBox_Produtos.Name = "comboBox_Produtos";
            this.comboBox_Produtos.Size = new System.Drawing.Size(262, 28);
            this.comboBox_Produtos.TabIndex = 1;
            this.comboBox_Produtos.SelectedIndexChanged += new System.EventHandler(this.comboBox_Produtos_SelectedIndexChanged);
            // 
            // produtosParaVendaBindingSource
            // 
            this.produtosParaVendaBindingSource.DataMember = "ProdutosParaVenda";
            this.produtosParaVendaBindingSource.DataSource = this.easyShopBDDataSet;
            // 
            // easyShopBDDataSet
            // 
            this.easyShopBDDataSet.DataSetName = "EasyShopBDDataSet";
            this.easyShopBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosVendidosDataGridView
            // 
            this.produtosVendidosDataGridView.AllowUserToAddRows = false;
            this.produtosVendidosDataGridView.AllowUserToDeleteRows = false;
            this.produtosVendidosDataGridView.AutoGenerateColumns = false;
            this.produtosVendidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosVendidosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.produtosVendidosDataGridView.DataSource = this.produtosVendidosBindingSource;
            this.produtosVendidosDataGridView.Location = new System.Drawing.Point(3, 6);
            this.produtosVendidosDataGridView.Name = "produtosVendidosDataGridView";
            this.produtosVendidosDataGridView.ReadOnly = true;
            this.produtosVendidosDataGridView.Size = new System.Drawing.Size(350, 400);
            this.produtosVendidosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 155;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 152;
            // 
            // produtosVendidosBindingSource
            // 
            this.produtosVendidosBindingSource.DataMember = "ProdutosVendidos";
            this.produtosVendidosBindingSource.DataSource = this.easyShopBDDataSet;
            // 
            // produtosVendidosTableAdapter
            // 
            this.produtosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.ProdutosParaVendaTableAdapter = null;
            this.tableAdapterManager.ProdutosVendidosTableAdapter = this.produtosVendidosTableAdapter;
            this.tableAdapterManager.UpdateOrder = EasyShop.EasyShopBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtosParaVendaTableAdapter
            // 
            this.produtosParaVendaTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ProdutosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ProdutosVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ProdutosVendidos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyShopBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panel2;
        private EasyShopBDDataSet easyShopBDDataSet;
        private System.Windows.Forms.BindingSource produtosVendidosBindingSource;
        private EasyShopBDDataSetTableAdapters.ProdutosVendidosTableAdapter produtosVendidosTableAdapter;
        private EasyShopBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_Detalhes;
        private System.Windows.Forms.ComboBox comboBox_Produtos;
        private System.Windows.Forms.DataGridView produtosVendidosDataGridView;
        private System.Windows.Forms.BindingSource produtosParaVendaBindingSource;
        private EasyShopBDDataSetTableAdapters.ProdutosParaVendaTableAdapter produtosParaVendaTableAdapter;
        private System.Windows.Forms.Label lbl_Lucro;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}