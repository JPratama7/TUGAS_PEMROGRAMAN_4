using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace P4_4_1204004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numerik : " + tbnum.Text + "\nChar : " + tbchar.Text + "\nRequired: " + tbreq.Text + "\nRegex : " + tbregex.Text + "\nComparison : " + tbcom1.Text + " " + tbcom2.Text + "\nLength : " + tbleng.Text + "\nUpper : " + tbupper.Text + "\nLower : " + tblower.Text);

        }

        private void tbnum_Leave(object sender, EventArgs e)
        {
            int tbnumval;
            if (int.TryParse(tbnum.Text, out tbnumval))
            {
                epbenar.SetError(tbnum, "OK");
            }

            else
            {
                epwarn.SetError(tbnum, "Silahkan Diisi");
            }

        }

        private void tbchar_Leave(object sender, EventArgs e)
        {
            char tbcharval;
            if (char.TryParse(tbchar.Text, out tbcharval))
            {
                epbenar.SetError(tbchar, "OK");
            }

            else
            {
                epwarn.SetError(tbchar, "Silahkan Diisi");
            }
        }

        private void tbreq_Leave(object sender, EventArgs e)
        {
            if (tbchar.Text != "")
            {
                epbenar.SetError(tbreq, "OK");
            }

            else
            {
                epwarn.SetError(tbreq, "Silahkan Diisi");
            }
        }

        private void tbregex_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbregex.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epbenar.SetError(tbregex, "Betul!");
            }
            else
            {
                epwarn.SetError(tbregex, "Format salah !\nContoh: a@b.c");
            }
        }

        private void tbcom1_Leave(object sender, EventArgs e)
        {
            if ((tbcom1.Text).All(Char.IsNumber))
            {
                if (tbcom1.Text == "")
                {
                    epwarn.SetError(tbcom1, "Angka 2 Belum terisi");
                }

                else
                {
                    epbenar.SetError(tbcom1, "Angka 2 Terisi");
                }
            }

            else if (tbcom1.Text == "")
            {
                epwarn.SetError(tbcom1, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epwarn.SetError(tbcom1, "inputan hanya boleh Angka!");
            }
        }

        private void tbcom2_Leave(object sender, EventArgs e)
        {
            if ((tbcom2.Text).All(Char.IsNumber))
            {
                int Angka1;
                int Angka2;
                int.TryParse(tbcom1.Text, out Angka1);
                int.TryParse(tbcom2.Text, out Angka2);
                if (Angka1 > Angka2)
                {
                    epbenar.SetError(tbcom2, "Angka 1 lebih besar dari angka 2 ");
                }

                else
                {
                    epbenar.SetError(tbcom2, "Angka 2 lebih besar dari angka 1 ");

                }
            }

            else if (tbcom2.Text == "")
            {
                epwarn.SetError(tbcom2, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epwarn.SetError(tbcom2, "inputan hanya boleh Angka!");
            }
        }

        private void tbleng_Leave(object sender, EventArgs e)
        {
            if (tbleng.Text != "")
            {
                int length = tbleng.Text.Length;
                epbenar.SetError(tbleng, "Banyak Kata : " + length);
            }
            else
            {
                epwarn.SetError(tbleng, "Silahkan Diisi");
            }
        }

        private void tbupper_Leave(object sender, EventArgs e)
        {
            if (tbupper.Text.All(char.IsUpper))
            {
                epbenar.SetError(tbupper, "OK");
            }
            else
            {
                epwarn.SetError(tbupper, "Bukan UPPERCASE");
            }
        }

        private void tblower_Leave(object sender, EventArgs e)
        {
            if (tblower.Text.All(char.IsLower))
            {
                epbenar.SetError(tblower, "OK");
            }
            else
            {
                epwarn.SetError(tblower, "Bukan LOWERCASE");
            }
        }
    }
}
