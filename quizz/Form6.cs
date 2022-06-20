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
    public partial class Form6 : Form
    {
        public Form6()
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

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

            rdb1certo.Checked = false;
            rdb1errado1.Checked = false;
            rdb1errado2.Checked = false;

            rdb2certo.Checked = false;
            rdb2errado1.Checked = false;
            rdb2errado2.Checked = false;

            ckbcerto1.Checked = false;
            ckbcerto2.Checked = false;
            ckberrado.Checked = false;
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


            Form Form5 = new Form5();
            Form5.Show();


        }
    }
}
