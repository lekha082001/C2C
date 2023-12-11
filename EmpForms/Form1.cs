using EmpLib;

namespace EmpForms
{
    public partial class Form1 : Form
    {
        Employee KPMGEmp = new Employee();
        Employee KGSEmp = new Employee();
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click2;
            button1.Click += Button1_Click3;

            KPMGEmp.Join += Srikar_Join;
            KPMGEmp.Join += Rohith_Join;
            KPMGEmp.Join += Lekha_Join;

            KGSEmp.Resign += Rahul_Resign;
            KGSEmp.Resign += Raghav_Resign;
        }

        private void Raghav_Resign(object? sender, EventArgs e)
        {
            MessageBox.Show("Raghav resigned KGS successfully!");
        }

        private void Rahul_Resign(object? sender, EventArgs e)
        {
            MessageBox.Show("Rahul resigned KGS successfully!");
        }

        private void Lekha_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Lekha joined KPMG successfully!");
        }

        private void Rohith_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Rohith joined KPMG successfully!");
        }

        private void Srikar_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Srikar joined KPMG successfully!");
        }

        private void Button1_Click3(object? sender, EventArgs e)
        {
            MessageBox.Show("I am a subscriber 3 of click event");
        }

        private void Button1_Click2(object? sender, EventArgs e)
        {
            MessageBox.Show("I am subscriber 2 of cick event");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am subscriber 1 of click event");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KPMGEmp.TriggerJoinEvent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KGSEmp.TriggerResignEvent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}