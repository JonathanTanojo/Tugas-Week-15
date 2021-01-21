using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            makan[0] = "Mie Instan";
            listBoxdaftar.Items.Add(makan[0]);
            makan[1] = "Telor";
            listBoxdaftar.Items.Add(makan[1]);
            makan[2] = "Roti";
            listBoxdaftar.Items.Add(makan[2]);
            makan[3] = "Keju";
            listBoxdaftar.Items.Add(makan[3]);
            makan[4] = "Daging Giling";
            listBoxdaftar.Items.Add(makan[4]);
            minum[0] = "Susu Sapi";
            listBoxdaftar.Items.Add(minum[0]);
            minum[1] = "Kopi";
            listBoxdaftar.Items.Add(minum[1]);
            minum[2] = "Teh";
            listBoxdaftar.Items.Add(minum[2]);
            minum[3] = "Bir";
            listBoxdaftar.Items.Add(minum[3]);
        }
        public string[] makan = new string[10];
        public string[] minum = new string[10];
        int cmakan = 5;
        int cminum = 4;

        private void buttoninput_Click(object sender, EventArgs e)
        {

            
            if (radioButtonmakan.Checked)
            {
                if (textBoxitem.Text == makan[0] || textBoxitem.Text == makan[1] || textBoxitem.Text == makan[2] || textBoxitem.Text == makan[3] || textBoxitem.Text == makan[4] || textBoxitem.Text == makan[5] || textBoxitem.Text == makan[6] || textBoxitem.Text == makan[7] || textBoxitem.Text == makan[8] || textBoxitem.Text == makan[9])
                {
                    MessageBox.Show("Makanan sudah ada");
                }
                else
                {
                    cmakan++;
                    listBoxdaftar.Items.Add(textBoxitem.Text);
                    makan[cmakan] = textBoxitem.Text;
                    
                }
                textBoxitem.Text = "";
                radioButtonmakan.Checked = false;
            }
            else if (radioButtonminum.Checked)
            {
                if (textBoxitem.Text == minum[0] || textBoxitem.Text == minum[1] || textBoxitem.Text == minum[2] || textBoxitem.Text == minum[3] || textBoxitem.Text == minum[4] || textBoxitem.Text == minum[5] || textBoxitem.Text == minum[6] || textBoxitem.Text == minum[7] || textBoxitem.Text == minum[8] || textBoxitem.Text == minum[9])
                {
                    MessageBox.Show("Minuman sudah ada");
                }
                else
                {
                    listBoxdaftar.Items.Add(textBoxitem.Text);
                    minum[cminum] = textBoxitem.Text;
                    cminum++;
                }
            }
            textBoxitem.Text = "";
            radioButtonminum.Checked = false;
        }

        private void buttonpindah_Click(object sender, EventArgs e)
        {
            foreach (object makan in listBoxdaftar.SelectedItems)
            {
                if (listBoxfilter.Items.Contains(listBoxdaftar))
                {

                }
                else
                {
                    listBoxfilter.Items.Add(makan);
                }
            }
            if (checkBoxmakan.Checked)
            {
                listBoxfilter.Items.Add(makan);
            }
        }

        private void buttonhapus_Click(object sender, EventArgs e)
        {
            bool pencet = true;
            if (pencet == true)
            {
                listBoxfilter.Items.Remove(listBoxfilter.SelectedItem);
                
            }
            else
            {
                
                listBoxfilter.Items.Clear();
            }
        }

        private void checkBoxmakan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmakan.Checked == true)
            {
                for (int i = 0; i < cmakan; i++)
                {
                    if (makan[i] == "")
                    {

                    }
                    else
                    {
                       listBoxdaftar.SetSelected(listBoxdaftar.FindString(makan[i]), true);
                    }
                }
            }
            else if (checkBoxmakan.Checked == false)
            {
                listBoxdaftar.ClearSelected();
                if (checkBoxminum.Checked == true)
                {
                    for (int i = 0; i < cminum; i++)
                    {
                        if (minum[i] == "")
                        {

                        }
                        else
                        {
                            listBoxfilter.SetSelected(listBoxfilter.FindString(minum[i]), true);
                        }
                    }
                }
            }
        }

        private void checkBoxminum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxminum.Checked == true)
            {
                for (int i = 0; i < cminum; i++)
                {
                    if (minum[i] == "")
                    {

                    }
                    else
                    {
                        listBoxdaftar.SetSelected(listBoxdaftar.FindString(minum[i]), true);
                    }
                }
            }
            else if (checkBoxminum.Checked == false)
            {
                listBoxdaftar.ClearSelected();
                if (checkBoxmakan.Checked == true)
                {
                    for (int i = 0; i < cmakan; i++)
                    {
                        if (makan[i] == "")
                        {

                        }
                        else
                        {
                            listBoxfilter.SetSelected(listBoxfilter.FindString(makan[i]), true);
                        }
                    }
                }
            }
        }
    }
}
