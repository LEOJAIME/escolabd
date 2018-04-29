namespace SistemaEscolar
{
    partial class CadastrarAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnome1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxdata_nasc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxmatric = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxdata_matric = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // textboxID
            // 
            this.textboxID.Enabled = false;
            this.textboxID.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.textboxID.Location = new System.Drawing.Point(280, 113);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(231, 23);
            this.textboxID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome Completo:";
            // 
            // textBoxnome1
            // 
            this.textBoxnome1.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.textBoxnome1.Location = new System.Drawing.Point(280, 206);
            this.textBoxnome1.Name = "textBoxnome1";
            this.textBoxnome1.Size = new System.Drawing.Size(231, 23);
            this.textBoxnome1.TabIndex = 2;
            this.textBoxnome1.TextChanged += new System.EventHandler(this.textBoxnome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data_Nascimento(dd/mm/aaa):";
            // 
            // textBoxdata_nasc
            // 
            this.textBoxdata_nasc.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.textBoxdata_nasc.Location = new System.Drawing.Point(280, 252);
            this.textBoxdata_nasc.Name = "textBoxdata_nasc";
            this.textBoxdata_nasc.Size = new System.Drawing.Size(231, 23);
            this.textBoxdata_nasc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Matricula:";
            // 
            // textBoxmatric
            // 
            this.textBoxmatric.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.textBoxmatric.Location = new System.Drawing.Point(280, 159);
            this.textBoxmatric.Name = "textBoxmatric";
            this.textBoxmatric.Size = new System.Drawing.Size(231, 23);
            this.textBoxmatric.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data_Matricula(dd/mm/aaaa):";
            // 
            // textBoxdata_matric
            // 
            this.textBoxdata_matric.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.textBoxdata_matric.Location = new System.Drawing.Point(280, 296);
            this.textBoxdata_matric.Name = "textBoxdata_matric";
            this.textBoxdata_matric.Size = new System.Drawing.Size(231, 23);
            this.textBoxdata_matric.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(326, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(594, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxdata_matric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxmatric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxdata_nasc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxnome1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarAluno";
            this.Text = "CadastrarAluno";
            this.Load += new System.EventHandler(this.CadastrarAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxnome1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxdata_nasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxmatric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxdata_matric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}