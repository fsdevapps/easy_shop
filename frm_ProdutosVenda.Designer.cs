namespace EasyShop
{
    partial class frm_ProdutosVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProdutosVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_preço = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.dgv_Produtos = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosParaVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.easyShopBDDataSet = new EasyShop.EasyShopBDDataSet();
            this.produtosParaVendaTableAdapter = new EasyShop.EasyShopBDDataSetTableAdapters.ProdutosParaVendaTableAdapter();
            this.tableAdapterManager = new EasyShop.EasyShopBDDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyShopBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 40);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(745, 5);
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
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txt_preço);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_nome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Remover);
            this.panel2.Controls.Add(this.btn_Atualizar);
            this.panel2.Controls.Add(this.btn_Inserir);
            this.panel2.Controls.Add(this.dgv_Produtos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 371);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(366, 263);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 1);
            this.panel4.TabIndex = 11;
            // 
            // txt_preço
            // 
            this.txt_preço.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.txt_preço.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_preço.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txt_preço.ForeColor = System.Drawing.Color.White;
            this.txt_preço.Location = new System.Drawing.Point(434, 240);
            this.txt_preço.Name = "txt_preço";
            this.txt_preço.Size = new System.Drawing.Size(339, 22);
            this.txt_preço.TabIndex = 10;
            this.txt_preço.Text = "Insira o Preço do Produto";
            this.txt_preço.Enter += new System.EventHandler(this.txt_preço_Enter);
            this.txt_preço.Leave += new System.EventHandler(this.txt_preço_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(366, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 1);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(361, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preço:";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.txt_nome.ForeColor = System.Drawing.Color.White;
            this.txt_nome.Location = new System.Drawing.Point(533, 140);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(239, 22);
            this.txt_nome.TabIndex = 6;
            this.txt_nome.Text = "Insira o Nome do Produto";
            this.txt_nome.Enter += new System.EventHandler(this.txt_nome_Enter);
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Produto:";
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.White;
            this.btn_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remover.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.ForeColor = System.Drawing.Color.Black;
            this.btn_Remover.Location = new System.Drawing.Point(652, 36);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(120, 50);
            this.btn_Remover.TabIndex = 3;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.White;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_Atualizar.Location = new System.Drawing.Point(506, 36);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(120, 50);
            this.btn_Atualizar.TabIndex = 2;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.White;
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inserir.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.ForeColor = System.Drawing.Color.Black;
            this.btn_Inserir.Location = new System.Drawing.Point(361, 36);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(120, 50);
            this.btn_Inserir.TabIndex = 1;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // dgv_Produtos
            // 
            this.dgv_Produtos.AllowUserToAddRows = false;
            this.dgv_Produtos.AllowUserToDeleteRows = false;
            this.dgv_Produtos.AutoGenerateColumns = false;
            this.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDoProdutoDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn});
            this.dgv_Produtos.DataSource = this.produtosParaVendaBindingSource;
            this.dgv_Produtos.Location = new System.Drawing.Point(12, 6);
            this.dgv_Produtos.Name = "dgv_Produtos";
            this.dgv_Produtos.ReadOnly = true;
            this.dgv_Produtos.Size = new System.Drawing.Size(343, 365);
            this.dgv_Produtos.TabIndex = 0;
            this.dgv_Produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Produtos_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoProdutoDataGridViewTextBoxColumn
            // 
            this.nomeDoProdutoDataGridViewTextBoxColumn.DataPropertyName = "Nome do Produto";
            this.nomeDoProdutoDataGridViewTextBoxColumn.HeaderText = "Nome do Produto";
            this.nomeDoProdutoDataGridViewTextBoxColumn.Name = "nomeDoProdutoDataGridViewTextBoxColumn";
            this.nomeDoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preçoDataGridViewTextBoxColumn
            // 
            this.preçoDataGridViewTextBoxColumn.DataPropertyName = "Preço";
            this.preçoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.preçoDataGridViewTextBoxColumn.Name = "preçoDataGridViewTextBoxColumn";
            this.preçoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // produtosParaVendaTableAdapter
            // 
            this.produtosParaVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.ProdutosParaVendaTableAdapter = this.produtosParaVendaTableAdapter;
            this.tableAdapterManager.ProdutosVendidosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EasyShop.EasyShopBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_ProdutosVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ProdutosVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ProdutosVenda";
            this.Load += new System.EventHandler(this.frm_ProdutosVenda_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyShopBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panel2;
        private EasyShopBDDataSet easyShopBDDataSet;
        private System.Windows.Forms.BindingSource produtosParaVendaBindingSource;
        private EasyShopBDDataSetTableAdapters.ProdutosParaVendaTableAdapter produtosParaVendaTableAdapter;
        private EasyShopBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.DataGridView dgv_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_preço;
        private System.Windows.Forms.Label label2;
    }
}