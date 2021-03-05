namespace EasyShop
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_PreçoTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Queue = new System.Windows.Forms.ListView();
            this.txt_ProcuraProduto = new System.Windows.Forms.TextBox();
            this.btn_Aceitar = new System.Windows.Forms.Button();
            this.produtosParaVendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosParaVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.easyShopBDDataSet = new EasyShop.EasyShopBDDataSet();
            this.btn_Recusar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.produtosParaVendaTableAdapter = new EasyShop.EasyShopBDDataSetTableAdapters.ProdutosParaVendaTableAdapter();
            this.tableAdapterManager = new EasyShop.EasyShopBDDataSetTableAdapters.TableAdapterManager();
            this.produtosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosVendidosTableAdapter = new EasyShop.EasyShopBDDataSetTableAdapters.ProdutosVendidosTableAdapter();
            this.adicionarFuncionários = new System.Windows.Forms.PictureBox();
            this.produtosVendidos = new System.Windows.Forms.PictureBox();
            this.produtosParaVenda = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyShopBDDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adicionarFuncionários)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.39847F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.60153F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_PreçoTotal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(580, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 59);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_PreçoTotal
            // 
            this.lbl_PreçoTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PreçoTotal.AutoSize = true;
            this.lbl_PreçoTotal.BackColor = System.Drawing.Color.Black;
            this.lbl_PreçoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PreçoTotal.ForeColor = System.Drawing.Color.Lime;
            this.lbl_PreçoTotal.Location = new System.Drawing.Point(342, 14);
            this.lbl_PreçoTotal.Name = "lbl_PreçoTotal";
            this.lbl_PreçoTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_PreçoTotal.Size = new System.Drawing.Size(71, 31);
            this.lbl_PreçoTotal.TabIndex = 1;
            this.lbl_PreçoTotal.Text = "0,0€";
            this.lbl_PreçoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // lst_Queue
            // 
            this.lst_Queue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Queue.HideSelection = false;
            this.lst_Queue.Location = new System.Drawing.Point(580, 136);
            this.lst_Queue.Name = "lst_Queue";
            this.lst_Queue.Size = new System.Drawing.Size(416, 500);
            this.lst_Queue.TabIndex = 2;
            this.lst_Queue.UseCompatibleStateImageBehavior = false;
            this.lst_Queue.View = System.Windows.Forms.View.Tile;
            // 
            // txt_ProcuraProduto
            // 
            this.txt_ProcuraProduto.Location = new System.Drawing.Point(12, 71);
            this.txt_ProcuraProduto.Name = "txt_ProcuraProduto";
            this.txt_ProcuraProduto.Size = new System.Drawing.Size(343, 20);
            this.txt_ProcuraProduto.TabIndex = 2;
            this.txt_ProcuraProduto.TextChanged += new System.EventHandler(this.txt_ProcuraProduto_TextChanged);
            this.txt_ProcuraProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProcuraProduto_KeyPress);
            // 
            // btn_Aceitar
            // 
            this.btn_Aceitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aceitar.AutoEllipsis = true;
            this.btn_Aceitar.BackColor = System.Drawing.Color.Green;
            this.btn_Aceitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceitar.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Aceitar.Location = new System.Drawing.Point(580, 651);
            this.btn_Aceitar.Name = "btn_Aceitar";
            this.btn_Aceitar.Size = new System.Drawing.Size(190, 66);
            this.btn_Aceitar.TabIndex = 4;
            this.btn_Aceitar.Text = "Aceitar";
            this.btn_Aceitar.UseVisualStyleBackColor = false;
            this.btn_Aceitar.Click += new System.EventHandler(this.btn_Aceitar_Click);
            // 
            // produtosParaVendaDataGridView
            // 
            this.produtosParaVendaDataGridView.AllowUserToAddRows = false;
            this.produtosParaVendaDataGridView.AllowUserToDeleteRows = false;
            this.produtosParaVendaDataGridView.AutoGenerateColumns = false;
            this.produtosParaVendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosParaVendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.produtosParaVendaDataGridView.DataSource = this.produtosParaVendaBindingSource;
            this.produtosParaVendaDataGridView.Location = new System.Drawing.Point(12, 100);
            this.produtosParaVendaDataGridView.Name = "produtosParaVendaDataGridView";
            this.produtosParaVendaDataGridView.ReadOnly = true;
            this.produtosParaVendaDataGridView.Size = new System.Drawing.Size(343, 536);
            this.produtosParaVendaDataGridView.TabIndex = 1;
            this.produtosParaVendaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosParaVendaDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome do Produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preço";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            // btn_Recusar
            // 
            this.btn_Recusar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Recusar.BackColor = System.Drawing.Color.Red;
            this.btn_Recusar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recusar.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Recusar.Location = new System.Drawing.Point(806, 651);
            this.btn_Recusar.Name = "btn_Recusar";
            this.btn_Recusar.Size = new System.Drawing.Size(190, 66);
            this.btn_Recusar.TabIndex = 5;
            this.btn_Recusar.Text = "Recusar";
            this.btn_Recusar.UseVisualStyleBackColor = false;
            this.btn_Recusar.Click += new System.EventHandler(this.btn_Recusar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 40);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(7, 9);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(97, 25);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "Username";
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Black;
            this.minimize.Location = new System.Drawing.Point(929, 15);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 10);
            this.minimize.TabIndex = 0;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(969, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // produtosParaVendaTableAdapter
            // 
            this.produtosParaVendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.ProdutosParaVendaTableAdapter = null;
            this.tableAdapterManager.ProdutosVendidosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EasyShop.EasyShopBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // adicionarFuncionários
            // 
            this.adicionarFuncionários.Image = ((System.Drawing.Image)(resources.GetObject("adicionarFuncionários.Image")));
            this.adicionarFuncionários.Location = new System.Drawing.Point(12, 656);
            this.adicionarFuncionários.Name = "adicionarFuncionários";
            this.adicionarFuncionários.Size = new System.Drawing.Size(60, 70);
            this.adicionarFuncionários.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adicionarFuncionários.TabIndex = 7;
            this.adicionarFuncionários.TabStop = false;
            this.adicionarFuncionários.Click += new System.EventHandler(this.adicionarFuncionários_Click);
            // 
            // produtosVendidos
            // 
            this.produtosVendidos.Image = ((System.Drawing.Image)(resources.GetObject("produtosVendidos.Image")));
            this.produtosVendidos.Location = new System.Drawing.Point(141, 667);
            this.produtosVendidos.Name = "produtosVendidos";
            this.produtosVendidos.Size = new System.Drawing.Size(80, 50);
            this.produtosVendidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.produtosVendidos.TabIndex = 8;
            this.produtosVendidos.TabStop = false;
            this.produtosVendidos.Click += new System.EventHandler(this.produtosVendidos_Click);
            // 
            // produtosParaVenda
            // 
            this.produtosParaVenda.Image = ((System.Drawing.Image)(resources.GetObject("produtosParaVenda.Image")));
            this.produtosParaVenda.Location = new System.Drawing.Point(285, 656);
            this.produtosParaVenda.Name = "produtosParaVenda";
            this.produtosParaVenda.Size = new System.Drawing.Size(70, 70);
            this.produtosParaVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.produtosParaVenda.TabIndex = 9;
            this.produtosParaVenda.TabStop = false;
            this.produtosParaVenda.Click += new System.EventHandler(this.produtosParaVenda_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1008, 737);
            this.Controls.Add(this.adicionarFuncionários);
            this.Controls.Add(this.produtosVendidos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.produtosParaVenda);
            this.Controls.Add(this.btn_Recusar);
            this.Controls.Add(this.btn_Aceitar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txt_ProcuraProduto);
            this.Controls.Add(this.lst_Queue);
            this.Controls.Add(this.produtosParaVendaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Principal_FormClosed);
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyShopBDDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adicionarFuncionários)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosParaVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasyShopBDDataSet easyShopBDDataSet;
        private System.Windows.Forms.BindingSource produtosParaVendaBindingSource;
        private EasyShopBDDataSetTableAdapters.ProdutosParaVendaTableAdapter produtosParaVendaTableAdapter;
        private EasyShopBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_PreçoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_Queue;
        private System.Windows.Forms.TextBox txt_ProcuraProduto;
        private System.Windows.Forms.Button btn_Aceitar;
        private System.Windows.Forms.DataGridView produtosParaVendaDataGridView;
        private System.Windows.Forms.Button btn_Recusar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource produtosVendidosBindingSource;
        private EasyShopBDDataSetTableAdapters.ProdutosVendidosTableAdapter produtosVendidosTableAdapter;
        private System.Windows.Forms.PictureBox adicionarFuncionários;
        private System.Windows.Forms.PictureBox produtosVendidos;
        private System.Windows.Forms.PictureBox produtosParaVenda;
    }
}