using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == "Kiraz" ||
                    listBox1.Items[i].ToString() == "Çilek" ||
                    listBox1.Items[i].ToString() == "Mandalina" ||
                    listBox1.Items[i].ToString() == "Şeftali" ||
                    listBox1.Items[i].ToString() == "Üzüm" ||
                    listBox1.Items[i].ToString() == "Ayva")
                {
                    listBox2.Items.Add(listBox1.Items[i]);

                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                }
                
            } 

        }
    }
}
