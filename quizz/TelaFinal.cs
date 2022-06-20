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
    public partial class TelaFinal : Form
    {
        public TelaFinal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Class1.pontos >= 7)
            {
                MessageBox.Show($"{Class1.nome}, sua pontuação foi de {Class1.pontos} pontos!", "Parabéns!", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show($"{Class1.nome}, sua pontuação foi de {Class1.pontos} pontos.", "Poxa, menos da metade", MessageBoxButtons.OK);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Application.Exit(); - 2. Visual Studio - 3. int e double \n - 4. CREATE DATABASE - 5. Quadrado e Retangulo - 6. SELECT * FROM \n" +
                " - 7. CSS e HTML - 8. HTML - 9. echo \n - 10. Arduino Wall - 11. 14 - 12. digitalWrite e pinMode \n - 13. Blocos - 14. App Inventor - 15. Amarelo e Azul", "Gabarito", MessageBoxButtons.OK);
        }
    }
}
