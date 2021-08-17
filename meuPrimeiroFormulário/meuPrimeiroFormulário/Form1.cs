using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meuPrimeiroFormulário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tabuadaTextBox.Text);
            tabuadaListBox.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                tabuadaListBox.Items.Add($"{i} X {numero} = {i * numero}");
            }
        }
    }
}
