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
using System.Text.RegularExpressions;
using System.Reflection.Metadata.Ecma335;
using System.Linq;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        // структура для внесення в ЛИСТ даних 1 завдання
        public struct First
        {
            public int PunktObminu;
            public int NomerDowidky;
            public string DataCzas;
            public string NameOperator;
            public string SumaTake;
            public string NomerTake;
            public First(int _PunktObminu, int _NomerDowidky, string _DataCzas, string _NameOperator, string _SumaTake,
                string _NomerTake)
            {
                PunktObminu = _PunktObminu;
                NomerDowidky = _NomerDowidky;
                DataCzas = _DataCzas;
                NameOperator = _NameOperator;
                SumaTake = _SumaTake;
                NomerTake = _NomerTake;
            }
        }

        List<First> firstTask = new List<First>();
        public Form1()
        {

            InitializeComponent();
            //висвітлення дати й часу
            labelTime.Text = System.Convert.ToString(DateTime.Now);

            //створення масиву з операторами
            string[] currencies = { "KYIVSTAR", "LIFECELL", "VODAFONE", "UTEL" };

            // приписування значень цього масиву до двох листбоксів
            listBox1.Items.AddRange(currencies);

            // приписування значень за замовчуванням
            listBox1.SelectedIndex = 0;

            textBoxNomerDowidky.SelectedText = "1";
            textBoxNomerPunktuObminu.SelectedText = "1";
            textBoxNomer.SelectedText = "0";
            textBoxSumaPopownenych.SelectedText = "0";

        }
        // кнопка замкнути  + функція
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //доп змінна для номеру довідки 
        double NomerDowidkyDop = 1;


        private void button1_Click(object sender, EventArgs e)
        {

            //робить +1 до номеру довідки;
            NomerDowidkyDop++;
            textBoxNomerDowidky.Text = System.Convert.ToString(NomerDowidkyDop);


            int NomerDowidky = System.Convert.ToInt32(textBoxNomerDowidky.Text);
            int PunktObminu = System.Convert.ToInt32(textBoxNomerPunktuObminu.Text);
            String Nomer = System.Convert.ToString(textBoxNomer.Text);
            String SumaPopownenych = System.Convert.ToString(textBoxSumaPopownenych.Text);
            //ловлення помилок
            bool hasLettersNomer = false;
            hasLettersNomer = Nomer.Any(char.IsLetter);
            if (hasLettersNomer == true)
            {
                Nomer = " ErrNumber";
            }
            bool hasLettersSumma = false;
            hasLettersSumma = SumaPopownenych.Any(char.IsLetter);
            if (hasLettersSumma == true)
            {
                SumaPopownenych = " ErrSumma";
            }
           
            //добавляєм до ЛИСТА firstTask елементи (вверху знаходиться)
            firstTask.Add(new First(PunktObminu, NomerDowidky - 1, System.Convert.ToString(DateTime.Now),
               listBox1.Text, SumaPopownenych, Nomer));
            // створюєм таблицю table
            DataTable table = new DataTable();

            // добавляєм  КОЛОНКИ
            table.Columns.Add("Пункт Обміну ", typeof(int));
            table.Columns.Add("Номер Довідки ", typeof(int));
            table.Columns.Add("Дата й час ", typeof(string));
            table.Columns.Add("Назва Оператора ", typeof(string));
            table.Columns.Add("Сума прийнятих коштів ", typeof(string));
            table.Columns.Add("Номер телефону", typeof(string));

            //динамічно добавляє РЯДИ в таблицю table
            for (int i = 0; i < firstTask.Count; i++)
            {
                table.Rows.Add(firstTask[i].PunktObminu, firstTask[i].NomerDowidky, firstTask[i].DataCzas,
                    firstTask[i].NameOperator, firstTask[i].SumaTake, "+38" + firstTask[i].NomerTake);
            }
            // приписуєм до елементу 
            dataGridView1.DataSource = table;
            //забрати нижню стрічку з листа
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomer = System.Convert.ToString(textBoxNomer.Text);
            String SumaPopownenych = System.Convert.ToString(textBoxSumaPopownenych.Text);

            //ловлення помилок
            bool hasLettersNomer = false;
            hasLettersNomer = nomer.Any(char.IsLetter);
            if (hasLettersNomer == true)
            {
                labelerror.Text = "Помилка вводу телефону";
            }
            else
            {
                labelerror.Text = "Номер введено успішно ";

            }
            bool hasLettersSumma = false;
            hasLettersSumma = SumaPopownenych.Any(char.IsLetter);
            if (hasLettersSumma == true)
            {
                labelErrMoney.Text = "error taked money";
            }
            else
            {
                labelErrMoney.Text = "сумму введено успішно ";

            }
            if (hasLettersNomer != true && hasLettersSumma != true)
            {
                labelResult.Text = "Чек успішно видруковано";
                labelPopowneno.Text = textBoxNomer.Text;
                labelSumaPopownenych.Text = textBoxSumaPopownenych.Text;
                labelOperatorPopownenych.Text = listBox1.Text;
            }
            else
            {
                labelResult.Text = "Чек НЕ видруковано";
            }


        }
    }
}
/*Розробка програмного модулю для терміналу платежів
(Програма повинна відтворювати прийом платежів різних операторів послуг. Кожна оплата містить відомості про абонента:
назва оператора, номер телефону, час поповнення рахунку. Програма повинна забезпечувати вибір за допомогою меню
та виконання однієї з наступних функцій:
-вибір потрібного оператора;
-введення номера телефону;
-прийом готівки;
-друк чека.*/