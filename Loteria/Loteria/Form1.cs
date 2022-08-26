using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public Random q = new Random();
        public int n1, n2, n3, n4, n5;
        public double numero1;
        public double numero2;
        public double numero3;
        public double dinero01;
        public double dinero02;
        public double dinero03;
        public double tripleta;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_tripleta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_masrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Premio1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_premio3_TextChanged(object sender, EventArgs e)
        {

        }

        public double dinero1;
        public double dinero2;
        public double dinero3;

        private void button1_Click(object sender, EventArgs e)


        {
            numero1 = Convert.ToDouble(txt_Numero1.Text);
            numero2 = Convert.ToDouble(txt_Numero2.Text);
            numero3 = Convert.ToDouble(txt_Numero3.Text);
            dinero01 = Convert.ToDouble(txt_Dinero1.Text);
            dinero02 = Convert.ToDouble(txt_Dinero2.Text);
            dinero03 = Convert.ToDouble(txt_Dinero3.Text);
            tripleta = dinero1 + dinero2 + dinero3;


            n1 = q.Next(0, 9);
            n2 = q.Next(0, 9);
            n3 = q.Next(0, 9);


            txt_Nu1.Text = n1.ToString();
            txt_Nu2.Text = n2.ToString();
            txt_Nu3.Text = n3.ToString();

            txt_Premio1.Text = "";
            txt_Premio2.Text = "";
            txt_premio3.Text = "";
        

            if (numero1 > 100)

            {
                MessageBox.Show("El numero debe ser entre 0 y 100");
            }

            if (numero1 == n1 && numero2 == n2 && numero3 == n3)
            {
                dinero1 = dinero01 * 20;
                txt_Premio1.Text = dinero1.ToString();
                dinero2 = dinero02 * 10;
                txt_Premio2.Text = dinero2.ToString();
                dinero3 = dinero03 * 5;
                txt_premio3.Text = dinero3.ToString();
                txt_tripleta.Text = tripleta.ToString();
                MessageBox.Show("Te sacaste la tripleta");
            }


            else if (numero2 > 100)
            {
                MessageBox.Show("El numero debe ser entre 0 y 100");
            }
            else if (numero3 > 100)
            {
                MessageBox.Show("El numero debe ser entre 0 y 100");
            }
            else if (numero1 == n1)
            {
                dinero1 = dinero01 * 20;
                txt_Premio1.Text = dinero1.ToString();

                MessageBox.Show("Te sacaste en primera");
            }
            else if (numero2 == n2)
            {
                dinero2 = dinero02 * 10;
                txt_Premio2.Text = dinero2.ToString();

                MessageBox.Show("Te sacaste en segunda");
            }
            else if (numero3 == n3)
            {
                dinero3 = dinero03 * 5;
                txt_premio3.Text = dinero3.ToString();

                MessageBox.Show("Te sacaste en tercera");
            }
            dataGridView1.Rows.Add(txt_Nu1.Text, txt_Nu2.Text, txt_Nu3.Text, DateTime.UtcNow);

            int count = dataGridView1.Rows.Count;


            for (int i = 0; i <= count - 3; i++)
            {

                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView1.Rows[count - 2].Cells[0].Value.ToString())
                {

                    dataGridView1.Rows.RemoveAt(count - 2);

                    count = count - 1;
                    txt_masrep.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }


            }
        }
    }
}
