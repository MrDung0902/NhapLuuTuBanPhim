namespace NhapLuuTuBanPhim
{
    partial class Nhapdulieu
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
            this.btSave = new System.Windows.Forms.Button();
            this.TxbNhapdulieu = new System.Windows.Forms.TextBox();
            this.Lb1 = new System.Windows.Forms.Label();
            this.TxbLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(551, 151);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(170, 63);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // TxbNhapdulieu
            // 
            this.TxbNhapdulieu.BackColor = System.Drawing.Color.LightSlateGray;
            this.TxbNhapdulieu.Location = new System.Drawing.Point(12, 53);
            this.TxbNhapdulieu.Multiline = true;
            this.TxbNhapdulieu.Name = "TxbNhapdulieu";
            this.TxbNhapdulieu.Size = new System.Drawing.Size(376, 161);
            this.TxbNhapdulieu.TabIndex = 1;
            this.TxbNhapdulieu.TextChanged += new System.EventHandler(this.TxbNhapdulieu_TextChanged);
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lb1.Location = new System.Drawing.Point(12, 18);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(109, 20);
            this.Lb1.TabIndex = 2;
            this.Lb1.Text = "Nhập Dữ liệu";
            // 
            // TxbLog
            // 
            this.TxbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbLog.Location = new System.Drawing.Point(16, 300);
            this.TxbLog.Multiline = true;
            this.TxbLog.Name = "TxbLog";
            this.TxbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxbLog.Size = new System.Drawing.Size(709, 216);
            this.TxbLog.TabIndex = 3;
            this.TxbLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Aquamarine;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(551, 53);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(170, 80);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete_Log";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Nhapdulieu
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 528);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbLog);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.TxbNhapdulieu);
            this.Controls.Add(this.btSave);
            this.Name = "Nhapdulieu";
            this.Text = "Nhập dữ liệu từ bàn phím";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox TxbNhapdulieu;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.TextBox TxbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDelete;
    }
}

