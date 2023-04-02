namespace LinQ
{
    public partial class Form1 : Form
    {
        List<Person> people;
        List<Department> department;
        List<Employ> employs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            people = new List<Person>();
            department = new List<Department>();
            employs = new List<Employ>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("TaskOne.txt"))
            {
                string[] lines = File.ReadAllLines("TaskOne.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');
                    string family = parts[0];
                    string name = parts[1];
                    string otchestvo = parts[2];
                    int age = Int32.Parse(parts[3]);
                    int weight = Int32.Parse(parts[4]);
                    Person person = new Person(family, name, otchestvo, age, weight);
                    people.Add(person);
                    listBox1.Items.Add(person.GetInfo());
                }
            }
            else MessageBox.Show("Ошибка", "Такого файла нет", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Person> peolList = new List<Person>();
            peolList.Clear();
            listBox1.Items.Clear();
            peolList = people.Where(people => people.Age < 40).ToList();
            foreach (Person person in peolList)
            {
                listBox1.Items.Add(person.GetInfo());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == true)
            {
                listBox1.Items.Clear();
            }

            if (listBox2.Visible == true)
            {
                listBox2.Items.Clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            listBox1.Visible = true;
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            button7.Visible = false;
            listBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            listBox1.Visible = false;
            button4.Visible = true;
            button6.Visible = true;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            button3.Visible = true;
            button7.Visible = true;
            button4.Visible = false;
            button5.Visible = true;
            button6.Visible = false;
            button8.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            department.Add(new Department() { Name = "Отдел закупок", Reg = "Германия" });
            department.Add(new Department() { Name = "Отдел продаж", Reg = "Испания" });
            department.Add(new Department() { Name = "Отдел маркетинга", Reg = "Испания" });
            employs.Add(new Employ() { Name = "Иванов", departament = "Отдел закупок" });
            employs.Add(new Employ() { Name = "Петров", departament = "Отдел закупок" });
            employs.Add(new Employ() { Name = "Сидоров", departament = "Отдел продаж" });
            employs.Add(new Employ() { Name = "Лямин", departament = "Отдел продаж" });
            employs.Add(new Employ() { Name = "Сидоренко", departament = "Отдел маркетинга" });
            employs.Add(new Employ() { Name = "Кривоносок", departament = "Отдел продаж" });
            var query = from emp in employs
                        join dep in department on emp.departament equals dep.Name
                        group emp by dep into depGroup
                        select new
                        {
                            Department = depGroup.Key.Name,
                            Employees = depGroup.Select(emp => emp.Name)
                        };
            foreach (var group in query)
            {
                listBox2.Items.Add(group.Department);
                foreach (var emp in group.Employees)
                {
                    listBox2.Items.Add(" " + emp);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var result = from employ in employs
                         join dep in department on employ.departament equals dep.Name
                         where dep.Reg.StartsWith("И")
                         select new { employ.Name, dep.Reg };

            foreach (var item in result)
            {
                listBox2.Items.Add(item.Name + " - " + item.Reg);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}