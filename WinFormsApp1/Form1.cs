using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = { textBox1.Text, textBox2.Text, comboBox4.Text, "", comboBox1.Text, comboBox2.Text, comboBox3.Text };
            if(radioButton2.Checked == true)
            {
                data[3] = radioButton2.Text;
            } else
            {
                data[3] = radioButton1.Text;
            }
            bool check = true;
            foreach(string item in data)
            {
                if(item == "" && Array.IndexOf(data, item) != 3)
                {
                    DialogResult checkField = MessageBox.Show("A field is empty!\nDo you want continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(checkField == DialogResult.Yes)
                    {
                        break;
                    } else
                    {
                        check = false;
                        textBox1.Focus();
                        break;
                    }
                }
            }
            if(check)
            {
                dataGridView1.Rows.Add(data);
                comboBox4.Items.Add(comboBox4.Text);//Add string collection for comboBox4
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox1.Focus();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this form?", "Close form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                e.Cancel = false;
            } else
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Control[] c = { textBox1, textBox2, comboBox4, radioButton1, comboBox1, comboBox2, comboBox3 };
            for(int i = 0; i < c.Length; i++)
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[i].Value != null)
                {
                    if (c[i] is TextBox)
                    {
                        c[i].Text = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                    if (c[i] is RadioButton)
                    {
                        string temp = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                        if (temp == "Male")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                    }
                    if (c[i] is ComboBox)
                    {
                        c[i].Text = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] data = { textBox1.Text, textBox2.Text, comboBox4.Text, "", comboBox1.Text, comboBox2.Text, comboBox3.Text };
            if (radioButton2.Checked == true)
            {
                data[3] = radioButton2.Text;
            }
            else
            {
                data[3] = radioButton1.Text;
            }
            bool check = true;
            foreach (string item in data)
            {
                if (item == "" && Array.IndexOf(data, item) != 3)
                {
                    DialogResult checkField = MessageBox.Show("A field is empty!\nDo you want continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (checkField == DialogResult.Yes)
                    {
                        break;
                    }
                    else
                    {
                        check = false;
                        textBox1.Focus();
                        break;
                    }
                }
            }
            if (check)
            {
                button3_Click(sender, e);
                dataGridView1.Rows.Add(data);
                comboBox4.Items.Add(comboBox4.Text);//Add string collection for comboBox4
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox1.Focus();
        }
    }
}
