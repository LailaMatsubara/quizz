using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            rdb1certo.TabStop = false;
            rdb1errado1.TabStop = false;
            rdb1errado2.TabStop = false;

            rdb2certo.TabStop = false;
            rdb2errado1.TabStop = false;
            rdb2errado2.TabStop = false;

            ckbcerto1.TabStop = false;
            ckbcerto2.TabStop = false;
            ckberrado.TabStop = false;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

            rdb1certo.Checked = false;
            rdb1errado1.Checked = false;
            rdb1errado2.Checked = false;

            rdb2certo.Checked = false;
            rdb2errado1.Checked = false;
            rdb2errado2.Checked = false;

            ckbcerto1.Checked  = false;
            ckbcerto2.Checked = false;
            ckberrado.Checked = false;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnprox_Click(object sender, EventArgs e)
        {
            if (rdb1certo.Checked == true)
            {
                Class1.pontos += 1;
            }

            if (rdb1errado1.Checked == true)
            {
                Class1.ptnerrados += 1;
            }

            if (rdb1errado2.Checked == true)
            {
                Class1.ptnerrados += 1;
            }


            if (rdb2certo.Checked == true)
            {
                Class1.pontos += 1;
            }

            if (rdb2errado1.Checked == true)
            {
                Class1.ptnerrados += 1;
            }

            if (rdb2errado2.Checked == true)
            {
                Class1.ptnerrados += 1;
            }


            if (ckberrado.Checked == true)
            {
                Class1.ptnerrados += 1;
            }

            if (ckbcerto1.Checked == true)
            {
                if (ckbcerto2.Checked == true)
                {
                    Class1.pontos += 1;
                }

                if (ckbcerto2.Checked == false)
                {
                    Class1.ptnerrados += 1;
                }
            }
            else
            {
                Class1.ptnerrados += 1;
            }


            Form Form3 = new Form3();
            Form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
