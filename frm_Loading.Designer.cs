namespace EasyShop
{
    partial class frm_Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Loading));
            this.timer_Loading = new System.Windows.Forms.Timer(this.components);
            this.progressBar_Loading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timer_Loading
            // 
            this.timer_Loading.Enabled = true;
            this.timer_Loading.Interval = 10;
            this.timer_Loading.Tick += new System.EventHandler(this.timer_Loading_Tick);
            // 
            // progressBar_Loading
            // 
            this.progressBar_Loading.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar_Loading.ForeColor = System.Drawing.Color.Lime;
            this.progressBar_Loading.Location = new System.Drawing.Point(12, 286);
            this.progressBar_Loading.Name = "progressBar_Loading";
            this.progressBar_Loading.Size = new System.Drawing.Size(600, 23);
            this.progressBar_Loading.TabIndex = 0;
            // 
            // frm_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.progressBar_Loading);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_Loading;
        private System.Windows.Forms.ProgressBar progressBar_Loading;
    }
}

