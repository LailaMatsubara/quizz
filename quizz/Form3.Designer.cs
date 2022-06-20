
namespace quizz
{
    partial class Form3
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckberrado = new System.Windows.Forms.CheckBox();
            this.ckbcerto2 = new System.Windows.Forms.CheckBox();
            this.ckbcerto1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb2errado2 = new System.Windows.Forms.RadioButton();
            this.rdb2certo = new System.Windows.Forms.RadioButton();
            this.rdb2errado1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb1errado2 = new System.Windows.Forms.RadioButton();
            this.rdb1errado1 = new System.Windows.Forms.RadioButton();
            this.rdb1certo = new System.Windows.Forms.RadioButton();
            this.btnprox = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckberrado);
            this.groupBox3.Controls.Add(this.ckbcerto2);
            this.groupBox3.Controls.Add(this.ckbcerto1);
            this.groupBox3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Lime;
            this.groupBox3.Location = new System.Drawing.Point(290, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 242);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "No BrModelo, quais formas correspondem a uma entidade?";
            // 
            // ckberrado
            // 
            this.ckberrado.AutoSize = true;
            this.ckberrado.Location = new System.Drawing.Point(34, 123);
            this.ckberrado.Name = "ckberrado";
            this.ckberrado.Size = new System.Drawing.Size(98, 23);
            this.ckberrado.TabIndex = 2;
            this.ckberrado.Text = "Losango";
            this.ckberrado.UseVisualStyleBackColor = true;
            // 
            // ckbcerto2
            // 
            this.ckbcerto2.AutoSize = true;
            this.ckbcerto2.Location = new System.Drawing.Point(34, 176);
            this.ckbcerto2.Name = "ckbcerto2";
            this.ckbcerto2.Size = new System.Drawing.Size(118, 23);
            this.ckbcerto2.TabIndex = 1;
            this.ckbcerto2.Text = "Retângulo";
            this.ckbcerto2.UseVisualStyleBackColor = true;
            // 
            // ckbcerto1
            // 
            this.ckbcerto1.AutoSize = true;
            this.ckbcerto1.Location = new System.Drawing.Point(34, 71);
            this.ckbcerto1.Name = "ckbcerto1";
            this.ckbcerto1.Size = new System.Drawing.Size(108, 23);
            this.ckbcerto1.TabIndex = 0;
            this.ckbcerto1.Text = "Quadrado";
            this.ckbcerto1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb2errado2);
            this.groupBox2.Controls.Add(this.rdb2certo);
            this.groupBox2.Controls.Add(this.rdb2errado1);
            this.groupBox2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(545, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 242);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Como mostrar todas as linhas e colunas?";
            // 
            // rdb2errado2
            // 
            this.rdb2errado2.AutoSize = true;
            this.rdb2errado2.Location = new System.Drawing.Point(20, 177);
            this.rdb2errado2.Name = "rdb2errado2";
            this.rdb2errado2.Size = new System.Drawing.Size(117, 23);
            this.rdb2errado2.TabIndex = 3;
            this.rdb2errado2.TabStop = true;
            this.rdb2errado2.Text = "USE TABLE";
            this.rdb2errado2.UseVisualStyleBackColor = true;
            // 
            // rdb2certo
            // 
            this.rdb2certo.AutoSize = true;
            this.rdb2certo.Location = new System.Drawing.Point(20, 123);
            this.rdb2certo.Name = "rdb2certo";
            this.rdb2certo.Size = new System.Drawing.Size(157, 23);
            this.rdb2certo.TabIndex = 2;
            this.rdb2certo.TabStop = true;
            this.rdb2certo.Text = "SELECT * FROM";
            this.rdb2certo.UseVisualStyleBackColor = true;
            // 
            // rdb2errado1
            // 
            this.rdb2errado1.AutoSize = true;
            this.rdb2errado1.Location = new System.Drawing.Point(20, 75);
            this.rdb2errado1.Name = "rdb2errado1";
            this.rdb2errado1.Size = new System.Drawing.Size(137, 23);
            this.rdb2errado1.TabIndex = 1;
            this.rdb2errado1.TabStop = true;
            this.rdb2errado1.Text = "SELECT FROM";
            this.rdb2errado1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb1errado2);
            this.groupBox1.Controls.Add(this.rdb1errado1);
            this.groupBox1.Controls.Add(this.rdb1certo);
            this.groupBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(22, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 242);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qual o comando usado para criar um banco de dados?";
            // 
            // rdb1errado2
            // 
            this.rdb1errado2.AutoSize = true;
            this.rdb1errado2.Location = new System.Drawing.Point(25, 123);
            this.rdb1errado2.Name = "rdb1errado2";
            this.rdb1errado2.Size = new System.Drawing.Size(177, 23);
            this.rdb1errado2.TabIndex = 2;
            this.rdb1errado2.TabStop = true;
            this.rdb1errado2.Text = "CREATE DATABANK";
            this.rdb1errado2.UseVisualStyleBackColor = true;
            // 
            // rdb1errado1
            // 
            this.rdb1errado1.AutoSize = true;
            this.rdb1errado1.Location = new System.Drawing.Point(25, 75);
            this.rdb1errado1.Name = "rdb1errado1";
            this.rdb1errado1.Size = new System.Drawing.Size(147, 23);
            this.rdb1errado1.TabIndex = 1;
            this.rdb1errado1.TabStop = true;
            this.rdb1errado1.Text = "CREATE TABLE";
            this.rdb1errado1.UseVisualStyleBackColor = true;
            // 
            // rdb1certo
            // 
            this.rdb1certo.AutoSize = true;
            this.rdb1certo.Location = new System.Drawing.Point(25, 176);
            this.rdb1certo.Name = "rdb1certo";
            this.rdb1certo.Size = new System.Drawing.Size(177, 23);
            this.rdb1certo.TabIndex = 0;
            this.rdb1certo.TabStop = true;
            this.rdb1certo.Text = "CREATE DATABASE";
            this.rdb1certo.UseVisualStyleBackColor = true;
            // 
            // btnprox
            // 
            this.btnprox.BackColor = System.Drawing.Color.Lime;
            this.btnprox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprox.Location = new System.Drawing.Point(667, 367);
            this.btnprox.Name = "btnprox";
            this.btnprox.Size = new System.Drawing.Size(111, 62);
            this.btnprox.TabIndex = 10;
            this.btnprox.Text = "Próxima Fase";
            this.btnprox.UseVisualStyleBackColor = false;
            this.btnprox.Click += new System.EventHandler(this.btnprox_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Lime;
            this.btnsair.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(34, 367);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(94, 62);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Lime;
            this.btnlimpar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(365, 367);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(106, 62);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(201, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Segunda Fase: Banco de Dados";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnprox);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Segunda fase";
            
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckberrado;
        private System.Windows.Forms.CheckBox ckbcerto2;
        private System.Windows.Forms.CheckBox ckbcerto1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb2errado2;
        private System.Windows.Forms.RadioButton rdb2certo;
        private System.Windows.Forms.RadioButton rdb2errado1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb1errado2;
        private System.Windows.Forms.RadioButton rdb1errado1;
        private System.Windows.Forms.RadioButton rdb1certo;
        private System.Windows.Forms.Button btnprox;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label1;
    }
}