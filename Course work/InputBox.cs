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
    public partial class InputBox : Form
    {
        private static InputBox newInputBox;
        private static string returnString;

        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
        }
        public static string Show(string inputBoxText, string Password)
        {
            newInputBox = new InputBox();
            newInputBox.label1.Text = inputBoxText;
            newInputBox.ShowDialog();
            return returnString;
        }

        private void SumbitButton_Click(object sender, EventArgs e)
        {
            if (SearchBox.Enabled && SearchBox.Text == "")
            {
                SearchBox.Text = "Введите Фамилию";
            }
            else
            {
                returnString = SearchBox.Text;
                newInputBox.Dispose();
                Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            newInputBox.Dispose();
            Close();
        }
    }
}
