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
        

        private static int BaseSize = 100; //количество элементов в списке
        List<Sportsman> Base = new List<Sportsman>(BaseSize);//создание списка

        string password = "7777";

        public Form1()
        {
            int infinity = 100000000;
            for (int i = 0;i < infinity; i++)
            {
                if (InputBox.Show("Пароль", password) == password)//проверяю пароль
                {
                    InitializeComponent();
                    break;
                }
                else
                    MessageBox.Show("Вы ввели неправелный пароль");
            }
        }

        private void Form1_Load(object sender, EventArgs e)//подсказки для пользователя
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(AddButton, "Кнопка добавления спортсмена в базу");
            t.SetToolTip(DelButton, "Удаляет спортсмена по фамилии");
            t.SetToolTip(PrizeListButton, "Выдает список призеров всех стран");
            t.SetToolTip(InfoMedalButton, "Выдает информацию о медалях всех стран в таблице");
            t.SetToolTip(CountryPrizeButton, "Выдает призеров только выбраной страны");
            t.SetToolTip(DataBaseInfo, "Таблица где можно увидет информацию об спортсменах");
            t.SetToolTip(NumberOfSportsmanNumericUpDown, "Поле для ввода номера спортсмена");
            t.SetToolTip(SurnameTextBox, "Поле для ввода фамилии спортсмена");
            t.SetToolTip(NameTextBox, "Поле для ввода имени спортсмена");
            t.SetToolTip(PatronymicTextBox, "Поле для ввода отчества спортсмена");
            t.SetToolTip(CountryComboBox, "Поле для ввода страны спортсмена");
            t.SetToolTip(KindOfSportComboBox, "Поле для ввода вида спорта спортсмена");
            t.SetToolTip(PlaceOfSportsmanNummericUpDown, "Поле для ввода места которое занял спортсмен");
        }

        public bool Slovo(string mas) //метод проверки вводимого на слово
        {
            foreach (char s in mas)
            {
                if (!char.IsLetter(s) && s != ' ' && s != '-') return false;
            }
            return true;
        }

        private void AddElement()//метод добавления спортсмена в таблицу
        {
            DataBaseInfo.Rows.Clear();
            foreach (var element in Base)
            {
                DataBaseInfo.Rows.Add
                (
                    element.Regestration_Number,         
                    element.Surname+" "+
                    element.Name+" "+
                    element.Patronymic,
                    element.Country,
                    element.Kind_OfSport,
                    element.Place
                );
            }
        }

        private void AddButton_Click(object sender, EventArgs e)//добавление спортсмена в базу данных с всеми проверками
        {
            foreach (var element in Base)
            {
                if (NumberOfSportsmanNumericUpDown.Value == element.Regestration_Number) 
                {
                    MessageBox.Show("Такой номер учасника уже есть!\r\n");
                    return;
                }
            }

           foreach (var element in Base)
            {
                if (PlaceOfSportsmanNummericUpDown.Value == element.Place && CountryComboBox.Text == element.Country&& KindOfSportComboBox.Text == element.Kind_OfSport)
                {
                    MessageBox.Show("В этой стрнае по этому виду спорта уже есть чемпион с таким местом");
                    return;
                }
            } 
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
                Base.Add(new Sportsman((int)NumberOfSportsmanNumericUpDown.Value, SurnameTextBox.Text,NameTextBox.Text,PatronymicTextBox.Text, CountryComboBox.Text, KindOfSportComboBox.Text, (int)PlaceOfSportsmanNummericUpDown.Value));
                AddElement();
                NumberOfSportsmanNumericUpDown.Value += 1;
            }
            
        }

        private void DelButton_Click(object sender, EventArgs e)//кнопка удаления спортсмена из базы данных по фамилии
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

        private void PrizeListButton_Click(object sender, EventArgs e)//выдает список призеров всех стран мира
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

       

        private void CountryPrizeButton_Click(object sender, EventArgs e)//выдает список призеров только нужной нам страны
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

        private void InfoMedalButton_Click(object sender, EventArgs e)//информаци о медалях каждой страны
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
                richTextBox1.Text += "\n"+Name[h];
                for (int i = 1; i < 4; i++)
                {
                    counter = 0;
                    for (int j = 0; j < DataBaseInfo.RowCount; j++)
                    {
                        if (DataBaseInfo.Rows[j].Cells[2].Value == Name) 
                        {
                            if(Convert.ToString(DataBaseInfo.Rows[j].Cells[2].Value) ==Name[h])
                            if (Convert.ToInt32(DataBaseInfo.Rows[j].Cells[4].Value) == i)
                                counter += 1;
                        }
                        if (i == 1)
                            prize = "Золотых медалей";
                        else if (i == 2)
                            prize = "серебряных медалей";
                        else
                            prize = "Бронзовых медалей";
                        count = j;
                    }
                    richTextBox1.Text += "\nКоличество " + prize + counter;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)// сохранение информации в файл
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = saveFileDialog1.FileName;
            BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
            int counter = 0;
            for (int i = 0; i < DataBaseInfo.RowCount; i++)
            {
                for (int j = 0; j < DataBaseInfo.ColumnCount; j++)
                {
                    writer.Write(DataBaseInfo.Rows[i].Cells[j].Value.ToString());
                }
                counter++;
            }
            writer.Close();
            richTextBox1.Text = "База данных успешно сохранена";
        }

        private void DowanloadButton_Click(object sender, EventArgs e)//чтение из файла информации
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DataBaseInfo.Rows.Add();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialog1.FileName;
            BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
            int counter = 0;
            for (int i = 0; i < DataBaseInfo.RowCount; i++)
            {
                
                if (reader.PeekChar() != -1)
                {
                    counter += 1;
                    for (int j = 0; j < DataBaseInfo.ColumnCount; j++)
                    {
                        DataBaseInfo.Rows[i].Cells[j].Value = reader.ReadString();
                    }
                    DataBaseInfo.Rows.Add();
                }
            }
            DataBaseInfo.Rows.RemoveAt(counter);
            
        }

       
    }
}
