namespace Exemplos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bGerarDados01 = new System.Windows.Forms.Button();
            this.bGerarDados02 = new System.Windows.Forms.Button();
            this.bExportarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // bGerarDados01
            // 
            this.bGerarDados01.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bGerarDados01.Location = new System.Drawing.Point(12, 19);
            this.bGerarDados01.Name = "bGerarDados01";
            this.bGerarDados01.Size = new System.Drawing.Size(222, 43);
            this.bGerarDados01.TabIndex = 1;
            this.bGerarDados01.Text = "Carregar Dados 01";
            this.bGerarDados01.UseVisualStyleBackColor = true;
            this.bGerarDados01.Click += new System.EventHandler(this.button1_Click);
            // 
            // bGerarDados02
            // 
            this.bGerarDados02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGerarDados02.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bGerarDados02.Location = new System.Drawing.Point(851, 12);
            this.bGerarDados02.Name = "bGerarDados02";
            this.bGerarDados02.Size = new System.Drawing.Size(222, 43);
            this.bGerarDados02.TabIndex = 2;
            this.bGerarDados02.Text = "Carregar Dados 02";
            this.bGerarDados02.UseVisualStyleBackColor = true;
            this.bGerarDados02.Click += new System.EventHandler(this.button2_Click);
            // 
            // bExportarExcel
            // 
            this.bExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExportarExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bExportarExcel.Location = new System.Drawing.Point(824, 514);
            this.bExportarExcel.Name = "bExportarExcel";
            this.bExportarExcel.Size = new System.Drawing.Size(249, 43);
            this.bExportarExcel.TabIndex = 3;
            this.bExportarExcel.Text = "Exportar para Excel";
            this.bExportarExcel.UseVisualStyleBackColor = true;
            this.bExportarExcel.Click += new System.EventHandler(this.bExportarExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 569);
            this.Controls.Add(this.bExportarExcel);
            this.Controls.Add(this.bGerarDados02);
            this.Controls.Add(this.bGerarDados01);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar DataGridView para Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button bGerarDados01;
        private Button bGerarDados02;
        private Button bExportarExcel;
    }
}