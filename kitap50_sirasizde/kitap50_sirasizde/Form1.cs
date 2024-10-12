using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap50_sirasizde
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj;
            if (sicaklik < 10)
            
                mesaj = "Hava soğuk";
            
            else if (string >= 10 && string <= 25)
                mesaj = "Hava hafif sıcak";
            
            else
                mesaj = "Hava sıcak";
        
           }
        }
    }
}
