using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_system2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[,] Customers = new string[,] { { "Jay", "Miles", "JMLecturer", "Pass123", "100000000" },
                                                  { "Jane", "Milo", "Jane42", "doggy", "547.52" },
                                                  { "Jen", "Smith", "JenLo", "baby", "100.00" },
                                                  { "Gareth", "Jones", "GarethJ", "eggies", "75487.67" },
                                                  { "Molly", "Bells", "MollyB", "pass321", "2.42" },
                                                  { "George", "Holmes", "GeorgeH", "bouncy", "9999.22" },};

            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
