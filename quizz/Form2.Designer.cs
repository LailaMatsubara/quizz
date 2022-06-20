
namespace quizz
{
    partial class Form2
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
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnprox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb1errado2 = new System.Windows.Forms.RadioButton();
            this.rdb1errado1 = new System.Windows.Forms.RadioButton();
            this.rdb1certo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb2errado2 = new System.Windows.Forms.RadioButton();
            this.rdb2certo = new System.Windows.Forms.RadioButton();
            this.rdb2errado1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckberrado = new System.Windows.Forms.CheckBox();
            this.ckbcerto2 = new System.Windows.Forms.CheckBox();
            this.ckbcerto1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(111, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeira Fase: Desenvolvimento de Sistemas";
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Lime;
            this.btnlimpar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(355, 376);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(106, 62);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Lime;
            this.btnsair.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(24, 376);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(94, 62);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnprox
            // 
            this.btnprox.BackColor = System.Drawing.Color.Lime;
            this.btnprox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprox.Location = new System.Drawing.Point(657, 376);
            this.btnprox.Name = "btnprox";
            this.btnprox.Size = new System.Drawing.Size(111, 62);
            this.btnprox.TabIndex = 3;
            this.btnprox.Text = "Próxima Fase";
            this.btnprox.UseVisualStyleBackColor = false;
            this.btnprox.Click += new System.EventHandler(this.btnprox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb1errado2);
            this.groupBox1.Controls.Add(this.rdb1errado1);
            this.groupBox1.Controls.Add(this.rdb1certo);
            this.groupBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qual é o comando de \"Sair\" para uma aplicação C#?";
            // 
            // rdb1errado2
            // 
            this.rdb1errado2.AutoSize = true;
            this.rdb1errado2.Location = new System.Drawing.Point(25, 177);
            this.rdb1errado2.Name = "rdb1errado2";
            this.rdb1errado2.Size = new System.Drawing.Size(77, 23);
            this.rdb1errado2.TabIndex = 2;
            this.rdb1errado2.Text = "if {}";
            this.rdb1errado2.UseVisualStyleBackColor = true;
            // 
            // rdb1errado1
            // 
            this.rdb1errado1.AutoSize = true;
            this.rdb1errado1.Location = new System.Drawing.Point(25, 123);
            this.rdb1errado1.Name = "rdb1errado1";
            this.rdb1errado1.Size = new System.Drawing.Size(97, 23);
            this.rdb1errado1.TabIndex = 1;
            this.rdb1errado1.Text = "Exit();";
            this.rdb1errado1.UseVisualStyleBackColor = true;
            // 
            // rdb1certo
            // 
            this.rdb1certo.AutoSize = true;
            this.rdb1certo.Location = new System.Drawing.Point(25, 71);
            this.rdb1certo.Name = "rdb1certo";
            this.rdb1certo.Size = new System.Drawing.Size(217, 23);
            this.rdb1certo.TabIndex = 0;
            this.rdb1certo.Text = "Application.Exit();";
            this.rdb1certo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb2errado2);
            this.groupBox2.Controls.Add(this.rdb2certo);
            this.groupBox2.Controls.Add(this.rdb2errado1);
            this.groupBox2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(275, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 242);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "O aplicativo usado para escrever programas em C# é: ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdb2errado2
            // 
            this.rdb2errado2.AutoSize = true;
            this.rdb2errado2.Location = new System.Drawing.Point(20, 177);
            this.rdb2errado2.Name = "rdb2errado2";
            this.rdb2errado2.Size = new System.Drawing.Size(117, 23);
            this.rdb2errado2.TabIndex = 3;
            this.rdb2errado2.TabStop = true;
            this.rdb2errado2.Text = "Notepad++";
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
            this.rdb2certo.Text = "Visual Studio";
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
            this.rdb2errado1.Text = "Visual Code";
            this.rdb2errado1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckberrado);
            this.groupBox3.Controls.Add(this.ckbcerto2);
            this.groupBox3.Controls.Add(this.ckbcerto1);
            this.groupBox3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Lime;
            this.groupBox3.Location = new System.Drawing.Point(535, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 242);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecione possíveis tipos de variáveis:";
            // 
            // ckberrado
            // 
            this.ckberrado.AutoSize = true;
            this.ckberrado.Location = new System.Drawing.Point(34, 177);
            this.ckberrado.Name = "ckberrado";
            this.ckberrado.Size = new System.Drawing.Size(68, 23);
            this.ckberrado.TabIndex = 2;
            this.ckberrado.Text = "word";
            this.ckberrado.UseVisualStyleBackColor = true;
            // 
            // ckbcerto2
            // 
            this.ckbcerto2.AutoSize = true;
            this.ckbcerto2.Location = new System.Drawing.Point(34, 123);
            this.ckbcerto2.Name = "ckbcerto2";
            this.ckbcerto2.Size = new System.Drawing.Size(88, 23);
            this.ckbcerto2.TabIndex = 1;
            this.ckbcerto2.Text = "double";
            this.ckbcerto2.UseVisualStyleBackColor = true;
            // 
            // ckbcerto1
            // 
            this.ckbcerto1.AutoSize = true;
            this.ckbcerto1.Location = new System.Drawing.Point(34, 71);
            this.ckbcerto1.Name = "ckbcerto1";
            this.ckbcerto1.Size = new System.Drawing.Size(58, 23);
            this.ckbcerto1.TabIndex = 0;
            this.ckbcerto1.Text = "int";
            this.ckbcerto1.UseVisualStyleBackColor = true;
            this.ckbcerto1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
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
            this.Name = "Form2";
            this.Text = "Primeira Fase";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnprox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb1errado2;
        private System.Windows.Forms.RadioButton rdb1errado1;
        private System.Windows.Forms.RadioButton rdb1certo;
        private System.Windows.Forms.RadioButton rdb2errado2;
        private System.Windows.Forms.RadioButton rdb2certo;
        private System.Windows.Forms.RadioButton rdb2errado1;
        private System.Windows.Forms.CheckBox ckberrado;
        private System.Windows.Forms.CheckBox ckbcerto2;
        private System.Windows.Forms.CheckBox ckbcerto1;
    }
}