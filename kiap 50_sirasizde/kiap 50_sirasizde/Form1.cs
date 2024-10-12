using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiap_50_sirasizde
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("Hava sıcaklığını derece cinsinden girin: ");
            string input = Console.ReadLine();

                if (float.TryParse(input, out float sıcaklık))
    

                if (sıcaklık < 10)
                
                    Console.WriteLine("Hava soğuk");
                
                else if (sıcaklık >= 10 && sıcaklık <= 25)
                
                    Console.WriteLine("Hava hafif sıcak");
                else
                
                    Console.WriteLine("Hava sıcak");
                else
            
                    Console.WriteLine("Lütfen geçerli bir sıcaklık değeri girin.");
            }
    }
}
