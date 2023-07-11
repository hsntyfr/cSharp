using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Security.Policy;

namespace project
{

    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Material.materials = Material.Read("C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");
            List<Material> lista = new List<Material>();


            DateTime da = DateTime.Now;
            Material mat = new Material("abc", da, da, 12, 12);
            Material mat1 = new Material("sssc", da, da, 12, 12);
            Material mat2 = new Material("adddddc", da, da, 12, 12);
            Material mat3 = new Material("adddddc", da, da, 12, 12);

            lista.Add(mat);
            lista.Add(mat2);
            lista.Add(mat1);
            lista.Add(mat3);

        }

        private void orterTabOpenButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void repoTabOpenButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        private void menuTabOpenButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}