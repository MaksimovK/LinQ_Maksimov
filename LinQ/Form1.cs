namespace LinQ
{
    public partial class Form1 : Form
    {
        private List<Person> people;
        List<Department> department;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            people = new List<Person>();
            department = new List<Department>();
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
                    if (age < 40)
                    {
                        people.Add(person);
                        listBox1.Items.Add(line);
                    }
                }
            }
            else MessageBox.Show("Ошибка", "Такого файла нет", MessageBoxButtons.OK, MessageBoxIcon.Error);


            //dasdasdasd
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}