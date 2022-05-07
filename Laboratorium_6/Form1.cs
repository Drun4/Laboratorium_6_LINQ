using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium_6
{
    public partial class Form1 : Form
    {
        //  Examples for testing:
        //  Al4 has a nice CAT
        //  Al 19/Mike 20/Andrew 15/JOHN 32

        string numbers = "0123456789";

        bool isPersonModeOn = false;

        public List<Person> getPeopleFromString()
        {
            List<Person> people = new List<Person>();

            string[] persons = txt_input.Text.Split('/');
            string[] personCharacteristics = new string[2];
            for (int i = 0; i < persons.Length; i++)
            {
                personCharacteristics = persons[i].Split(' ');
                people.Add(new Person { name = personCharacteristics[0], age = Convert.ToInt32(personCharacteristics[1]) });
            }

            return people;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_input.Text = "";
            txt_output.Text = "";
        }

        //#1 Filtering
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            txt_output.Text = "";
            if (isPersonModeOn)
            {
                if (checkbx_IsLength.Checked)
                {
                    getPeopleFromString().Where(s => s.name.Length > 2).ToList().ForEach(s =>
                    {
                        txt_output.Text += s.name + " " + s.age + "/";
                    });
                    txt_output.Text = txt_output.Text.Substring(0, txt_output.Text.Length - 1);
                }
                else
                {
                    MessageBox.Show("Choose a filter!");
                }
                //List<Person> personList = ;
            }
            else
            {
                string[] str = txt_input.Text.Split(' ');

                IEnumerable<string> filterTable = str;
                if (checkbx_IsLength.Checked)
                {
                    filterTable = filterTable.Where(s => s.Length >= 3).ToList();
                }
                if (checkbx_IsOdd.Checked)
                {
                    filterTable = filterTable.Where(s => s.Length % 2 == 1).ToList();
                }
                if (checkbx_IsCapitalLetters.Checked)
                {
                    //for (int i = 0; i < capitalLetters.Length; i++)
                    //{
                    //    filterTable =
                    //        from word in filterTable
                    //        where word[0] == (word[0].toLower() - ('a' - 'A'))
                    //        select word;
                    //}
                    filterTable = filterTable.Where(s => s[0] == s[0].toLower() - ('a' - 'A')).ToList();
                }

                foreach (var word in filterTable)
                {
                    txt_output.Text += word.ToString() + " ";
                }
            }
        }

        //#2 Sorting
        private void btn_Ascending_Click(object sender, EventArgs e)
        {
            txt_output.Text = "";
            if (isPersonModeOn)
            {
                getPeopleFromString().OrderBy(s => s.name[0]).ThenBy(s => s.age).ToList().ForEach(s =>
                {
                    txt_output.Text += s.name + " " + s.age + "/";
                });
                txt_output.Text = txt_output.Text.Substring(0, txt_output.Text.Length - 1);
            }            
            else 
            {
                string[] str = txt_input.Text.Split(' ');
                str.OrderBy(s => s).ToList().ForEach(s =>
                {
                    txt_output.Text += s + " ";
                });
            }
        }

        private void btn_Descending_Click(object sender, EventArgs e)
        {
            txt_output.Text = "";
            string[] str = txt_input.Text.Split(' ');
            str.OrderByDescending(s => s).ToList().ForEach(s =>
            {
                txt_output.Text += s + " ";
            });
        }

        //#3 Transform
        private void btn_CapitalTransform_Click(object sender, EventArgs e)
        {
            txt_output.Text = "";
            if (isPersonModeOn)
            {
                getPeopleFromString().Select(s => new
                {
                    Name = s.name.ToUpper(),
                    Age = s.age
                }).ToList().ForEach(s =>
                {
                    txt_output.Text += s.Name + " " + s.Age + "/";
                });
                txt_output.Text = txt_output.Text.Substring(0, txt_output.Text.Length - 1);
            }
            else
            {
                string[] str = txt_input.Text.Split(' ');
                str.Select(s => s.ToUpper()).ToList().ForEach(s =>
                {
                    txt_output.Text += s + " ";
                });
            }

        }
        private void btn_LowercaseTransform_Click(object sender, EventArgs e)
        {
            txt_output.Text = "";
            string[] str = txt_input.Text.Split(' ');
            str.Select(s => s.ToLower()).ToList().ForEach(s =>
            {
                txt_output.Text += s + " ";
            });
        }
        private void btn_JumpingTransform_Click(object sender, EventArgs e)
        {
            txt_output.Text = "";
            string[] str = txt_input.Text.Split(' ');
            IEnumerable<string> jumpingTable =
                from word in str
                let w = word.jumpingLetters()
                select w;
            foreach (var a in jumpingTable)
            {
                txt_output.Text += a.ToString() + " ";
            }
        }

        //#4 Checking
        private void btn_IfCapital_Click(object sender, EventArgs e)
        {
            txt_output.Text = "";
            string[] str = txt_input.Text.Split(' ');

            bool ifContains = str.Where(s => s == s.ToUpper()).Any();
            txt_output.Text = ifContains.ToString();

            //str.Where(s => s == s.ToUpper()).ToList().ForEach(s =>
            //{
            //    txt_output.Text += " " + s;
            //});
        }
        private void btn_IfLowercase_Click(object sender, EventArgs e)
        {
            txt_output.Text = "";
            string[] str = txt_input.Text.Split(' ');

            bool ifContains = str.Where(s => s == s.ToLower()).Any();
            txt_output.Text = ifContains.ToString();

            //str.Where(s => s == s.ToLower()).ToList().ForEach(s =>
            //{
            //    txt_output.Text += " " + s;
            //});
        }
        private void btn_IfNumber_Click(object sender, EventArgs e)
        {
            if (isPersonModeOn)
            {
                txt_output.Text = "";
                getPeopleFromString().Where(s => s.age > 18).ToList().ForEach(s =>
                {
                    txt_output.Text += s.name + " " + s.age + "/";
                });
                txt_output.Text = txt_output.Text.Substring(0, txt_output.Text.Length - 1);
            }
            else
            {
                bool result = false;
                string[] str = txt_input.Text.Split(' ');
                IEnumerable<string> containsNumTable = str;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result = containsNumTable.Where(s => s.Contains(numbers[i])).Any();
                    if (result)
                    {
                        break;
                    }
                }
                txt_output.Text = result.ToString();
            }
        }

        //#5 Aggregating
        private void btn_AvgLength_Click(object sender, EventArgs e)
        {
            txt_output.Text = " ";
            if (isPersonModeOn)
            {
                txt_output.Text = Math.Round(getPeopleFromString().Average(s => s.age), 3).ToString();
            }
            else
            {
                string[] str = txt_input.Text.Split(' ');
                txt_output.Text = Math.Round(str.Average(s => s.Length), 3).ToString();
            }

        }
        private void btn_MinLength_Click(object sender, EventArgs e)
        {
            txt_output.Text = " ";
            string[] str = txt_input.Text.Split(' ');

            txt_output.Text = str.Min(s => s.Length).ToString();
        }
        private void btn_MaxLength_Click(object sender, EventArgs e)
        {
            txt_output.Text = " ";
            string[] str = txt_input.Text.Split(' ');

            txt_output.Text = str.Max(s => s.Length).ToString();
        }

        //Change mode event
        private void checkbx_ChangeMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbx_ChangeMode.Checked)
            {
                isPersonModeOn = true;

                checkbx_IsLength.ForeColor = Color.Green;
                checkbx_IsLength.Text = "Is name length greater then 2?";
                checkbx_IsOdd.ForeColor = Color.Red;
                checkbx_IsCapitalLetters.ForeColor = Color.Red;

                btn_Ascending.ForeColor = Color.Green;
                btn_Descending.ForeColor = Color.Red;

                btn_capitalTransform.ForeColor = Color.Green;
                btn_lowercaseTransform.ForeColor = Color.Red;
                btn_jumpingTransform.ForeColor = Color.Red;

                btn_IfCapital.ForeColor = Color.Red;
                btn_IfLowercase.ForeColor = Color.Red;
                btn_IfNumber.ForeColor = Color.Green;
                btn_IfNumber.Text = "Is older then 18?";

                btn_AvgLength.ForeColor = Color.Green;
                btn_AvgLength.Text = "Average age";
                btn_MinLength.ForeColor = Color.Red;
                btn_MaxLength.ForeColor = Color.Red;

                lbl_PersonInputTooltip.Text = "To split persons use '/'\nExample: Name Age/Name Age ...";
                lbl_PersonInputTooltip.ForeColor = Color.Blue;
            }
            else
            {
                isPersonModeOn = false;

                checkbx_IsLength.ForeColor = Color.Black;
                checkbx_IsLength.Text = "Is length greater then 2?";
                checkbx_IsOdd.ForeColor = Color.Black;
                checkbx_IsCapitalLetters.ForeColor = Color.Black;

                btn_Ascending.ForeColor = Color.Black;
                btn_Descending.ForeColor = Color.Black;

                btn_capitalTransform.ForeColor = Color.Black;
                btn_lowercaseTransform.ForeColor = Color.Black;
                btn_jumpingTransform.ForeColor = Color.Black;

                btn_IfCapital.ForeColor = Color.Black;
                btn_IfLowercase.ForeColor = Color.Black;
                btn_IfNumber.ForeColor = Color.Black;
                btn_IfNumber.Text = "Number";

                btn_AvgLength.ForeColor = Color.Black;
                btn_AvgLength.Text = "Average length";
                btn_MinLength.ForeColor = Color.Black;
                btn_MaxLength.ForeColor = Color.Black;

                lbl_PersonInputTooltip.Text = "...";
                lbl_PersonInputTooltip.ForeColor = Color.Black;
            }
        }
    }
}

        //private void btn_IfCapital_Click(object sender, EventArgs e)
        //{
        //    txt_output.Text = "";
        //    string[] str = txt_input.Text.Split(' ');
        //    IEnumerable<string> ifCapital =
        //        from word in str
        //        from w in word
        //        where w == w.toLower() - ('a' - 'A')
        //        select word;

        //    foreach (var word in ifCapital)
        //    {
        //        txt_output.Text += word.ToString() + " ";
        //    }
        //}