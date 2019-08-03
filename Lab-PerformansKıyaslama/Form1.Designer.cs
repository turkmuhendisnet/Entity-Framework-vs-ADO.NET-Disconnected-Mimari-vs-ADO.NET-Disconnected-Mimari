namespace Lab_PerformansKıyaslama
{
    partial class Form1
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
            this.lstconnected = new System.Windows.Forms.ListBox();
            this.lstEntity = new System.Windows.Forms.ListBox();
            this.lstDisconnected = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConnected = new System.Windows.Forms.TextBox();
            this.txtDisconnected = new System.Windows.Forms.TextBox();
            this.txtEntity = new System.Windows.Forms.TextBox();
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.btnEntityFramwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstconnected
            // 
            this.lstconnected.FormattingEnabled = true;
            this.lstconnected.Location = new System.Drawing.Point(15, 37);
            this.lstconnected.Name = "lstconnected";
            this.lstconnected.Size = new System.Drawing.Size(187, 290);
            this.lstconnected.TabIndex = 0;
            // 
            // lstEntity
            // 
            this.lstEntity.FormattingEnabled = true;
            this.lstEntity.Location = new System.Drawing.Point(484, 43);
            this.lstEntity.Name = "lstEntity";
            this.lstEntity.Size = new System.Drawing.Size(187, 290);
            this.lstEntity.TabIndex = 1;
            // 
            // lstDisconnected
            // 
            this.lstDisconnected.FormattingEnabled = true;
            this.lstDisconnected.Location = new System.Drawing.Point(253, 43);
            this.lstDisconnected.Name = "lstDisconnected";
            this.lstDisconnected.Size = new System.Drawing.Size(187, 290);
            this.lstDisconnected.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(250, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Disconnected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(481, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Entiry Framwork";
            // 
            // txtConnected
            // 
            this.txtConnected.Location = new System.Drawing.Point(15, 339);
            this.txtConnected.Name = "txtConnected";
            this.txtConnected.Size = new System.Drawing.Size(184, 20);
            this.txtConnected.TabIndex = 6;
            // 
            // txtDisconnected
            // 
            this.txtDisconnected.Location = new System.Drawing.Point(253, 339);
            this.txtDisconnected.Name = "txtDisconnected";
            this.txtDisconnected.Size = new System.Drawing.Size(187, 20);
            this.txtDisconnected.TabIndex = 7;
            // 
            // txtEntity
            // 
            this.txtEntity.Location = new System.Drawing.Point(484, 339);
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.Size = new System.Drawing.Size(187, 20);
            this.txtEntity.TabIndex = 8;
            // 
            // btnConnected
            // 
            this.btnConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnected.Location = new System.Drawing.Point(14, 365);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(184, 35);
            this.btnConnected.TabIndex = 9;
            this.btnConnected.Text = "Getir";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisconnected.Location = new System.Drawing.Point(253, 365);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(184, 35);
            this.btnDisconnected.TabIndex = 10;
            this.btnDisconnected.Text = "Getir";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // btnEntityFramwork
            // 
            this.btnEntityFramwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEntityFramwork.Location = new System.Drawing.Point(484, 365);
            this.btnEntityFramwork.Name = "btnEntityFramwork";
            this.btnEntityFramwork.Size = new System.Drawing.Size(184, 35);
            this.btnEntityFramwork.TabIndex = 11;
            this.btnEntityFramwork.Text = "Getir";
            this.btnEntityFramwork.UseVisualStyleBackColor = true;
            this.btnEntityFramwork.Click += new System.EventHandler(this.btnEntityFramwork_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 430);
            this.Controls.Add(this.btnEntityFramwork);
            this.Controls.Add(this.btnDisconnected);
            this.Controls.Add(this.btnConnected);
            this.Controls.Add(this.txtEntity);
            this.Controls.Add(this.txtDisconnected);
            this.Controls.Add(this.txtConnected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDisconnected);
            this.Controls.Add(this.lstEntity);
            this.Controls.Add(this.lstconnected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstconnected;
        private System.Windows.Forms.ListBox lstEntity;
        private System.Windows.Forms.ListBox lstDisconnected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConnected;
        private System.Windows.Forms.TextBox txtDisconnected;
        private System.Windows.Forms.TextBox txtEntity;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.Button btnEntityFramwork;
    }
}

