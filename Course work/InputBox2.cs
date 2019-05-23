using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_work
{
    public partial class InputBox2 : Form
    {

        private static InputBox2 newInputBox2;
        private static string returnString;

        public InputBox2()
        {
            InitializeComponent();
        }

        private void InputBox2_Load(object sender, EventArgs e)
        {

        }
        public static string Show2(string Country)
        {

            newInputBox2 = new InputBox2();

            
            newInputBox2.ShowDialog();
            return returnString;
        }

        private void SumbitButton_Click(object sender, EventArgs e)
        {
            if (SearchComboBox.Enabled && SearchComboBox.Text == "")
            {
                SearchComboBox.Text = "Введите Cтрану";

            }
            else
            {
                returnString = SearchComboBox.Text;
                newInputBox2.Dispose();
                Close();

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            newInputBox2.Dispose();
            Close();
        }
    }
    
}
