using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Course_work
{
    public partial class Form1 : Form
    {
        private static string path = Environment.CurrentDirectory + "/SportsmanDataBase.krs";

        const int BaseSize = 30;
        List<Sportsman> Base = new List<Sportsman>(BaseSize);


        public Form1()
        {
            InitializeComponent();

            

        }
        public bool Slovo(string mas) 
        {
            foreach (char s in mas)
            {
                if (!char.IsLetter(s) && s != ' ' && s != '-') return false;
            }
            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            foreach (var element in Base)
            {
                if (NumberOfSportsmanNumericUpDown.Value == element.Regestration_Number) 
                {
                    
                    MessageBox.Show("Такой номер карты уже есть!\r\n");
                    return;
                }
            }

          /*  foreach (var element in Base)
            {
                if (PlaceOfSportsmanNummericUpDown.Value == element.Place && CountryComboBox.Text == element.Country&& KindOfSportComboBox.Text == element.Kind_OfSport)
                {

                    MessageBox.Show("В этой стрнае по этому виду спорта уже есть чемпион с таким местом");
                    return;
                }
            } */
            DataBaseInfo.Refresh();

            if (SurnameTextBox.Text == ""|| NameTextBox.Text == "" || PatronymicTextBox.Text == ""||CountryComboBox.Text==""||KindOfSportComboBox.Text=="")
            {
                MessageBox.Show("Введите коректные данные");

            }
            if (SurnameTextBox.Text.Length == 0 || !Slovo((String)SurnameTextBox.Text)) 
            {
                MessageBox.Show("Проверьте правильность написания фамилии!");
            }
            else if (NameTextBox.Text.Length == 0 || !Slovo((String)NameTextBox.Text)) 
            {
                MessageBox.Show("Проверьте правильность написания имени");
            }
            else if (PatronymicTextBox.Text.Length == 0 || !Slovo((String)PatronymicTextBox.Text)) 
            {
                MessageBox.Show("Проверьте правильность написания Отчества");
            }
            else
            {
                Sportsman sportsman = new Sportsman(Convert.ToInt32(NumberOfSportsmanNumericUpDown.Value), Convert.ToString(SurnameTextBox.Text), Convert.ToString(NameTextBox.Text), Convert.ToString(PatronymicTextBox.Text), Convert.ToString(CountryComboBox.Text), Convert.ToString(KindOfSportComboBox.Text), Convert.ToInt32(PlaceOfSportsmanNummericUpDown.Value));

                DataBaseInfo.Rows.Add(sportsman.Regestration_Number, sportsman.Surname + " " + sportsman.Name + " " + sportsman.Patronymic, sportsman.Country, sportsman.Kind_OfSport, sportsman.Place);
                NumberOfSportsmanNumericUpDown.Value += 1;
            }
            
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            string surname = "";
            surname = InputBox.Show("Фамилия", surname);
            for (int i = 0; i < DataBaseInfo.RowCount; i++)
            {
                string[] tmpsurname = Convert.ToString(DataBaseInfo.Rows[i].Cells[1].Value).Split(' ');
                if (tmpsurname[0] == surname)
                    DataBaseInfo.Rows.RemoveAt(i);
                tmpsurname = null;
            }
            DataBaseInfo.Refresh();
        }

        private void PrizeListButton_Click(object sender, EventArgs e)
        {
            int prize;
            for (int i = 0; i < DataBaseInfo.RowCount; i++)
            {
                prize = Convert.ToInt32(DataBaseInfo.Rows[i].Cells[4].Value);
                if (prize > 3 )
                {
                    DataBaseInfo.Rows.RemoveAt(i);
                }
                

            }
            DataBaseInfo.Refresh();
        }

       

        private void CountryPrizeButton_Click(object sender, EventArgs e)
        {
            string country = "";
            country = InputBox2.Show2(country);
            int prize;

            for (int i = 0;i< DataBaseInfo.RowCount;i++)
            {
                prize = Convert.ToInt32(DataBaseInfo.Rows[i].Cells[4].Value);
                if (prize > 3 || Convert.ToString(DataBaseInfo.Rows[i].Cells[2].Value) != country)
                {
                    DataBaseInfo.Rows.RemoveAt(i);
                    i -= 1;
                }
            }
            DataBaseInfo.Refresh();
        }

        private void InfoMedalButton_Click(object sender, EventArgs e)
        {
            string[] Name = new string[DataBaseInfo.RowCount];
            int counter=0;
            string prize = "";
            bool firstcountry = true;

            for(int i = 0; i<DataBaseInfo.RowCount;i++)
            {

                if (firstcountry == true)
                {
                    Name[i] = Convert.ToString(DataBaseInfo.Rows[i].Cells[2].Value);
                    firstcountry = false;
                    continue;
                }
                    
                if (Name[i - 1] == Convert.ToString(DataBaseInfo.Rows[i].Cells[2].Value))
                {
                    i += 1;
                }
                else
                    Name[i] = Convert.ToString(DataBaseInfo.Rows[i].Cells[2].Value);
            }
            int count = 0;
            for (int h = 0; h < Name.Length; h++)
            {
                richTextBox1.Text += Name[h];
                for (int i = 1; i < 4; i++)
                {
                    counter = 0;
                    for (int j = 0; j < DataBaseInfo.RowCount; j++)
                    {
                        if (DataBaseInfo.Rows[j].Cells[2].Value == Name) ;
                        {
                            if(Convert.ToString(DataBaseInfo.Rows[j].Cells[2].Value) ==Name[h])
                            if (Convert.ToInt32(DataBaseInfo.Rows[j].Cells[4].Value) == i)
                                counter += 1;
                        }
                        if (i == 1)
                            prize = "gold";
                        else if (i == 2)
                            prize = "silver";
                        else
                            prize = "bronze";
                        count = j;
                    }
                    richTextBox1.Text += "\nколичество " + prize + counter;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(fileStream);

            
            
            for (int i = 0; i < DataBaseInfo.RowCount; i++)
            { 
                Base[i].writeToFile(writer);
            }

            writer.Close();
            fileStream.Close();

            
        }
    }
}
