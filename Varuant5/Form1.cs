using System;
using System.Linq;
using System.Windows.Forms;

namespace Varuant5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(textBox1.Text);
            int a = Convert.ToInt32(textBox5.Text);
            int b = Convert.ToInt32(textBox6.Text);

            int[] arr = new int[size];
            Random rand = new Random();

            arr = arr.Select( l => rand.Next(-10, 16)).ToArray();
            textBox2.Text = String.Join(" ", arr);

            textBox3.Text = arr.Max().ToString();

            int last = Array.IndexOf(arr, arr.Last(l => l > 0)); //поиск последнего положительного элемента

            int sum = 0; // поиск суммы
            for (int i = 0; i < last; i++){
                if (last >= 0)
                    sum += arr[i];
            }
            textBox4.Text = sum.ToString();

            for (int i = 0; i < arr.Length; i++) // проверка в этом ли промежутке чисел массива по модулю
                if (Math.Abs(arr[i]) >= Math.Abs(a) && Math.Abs(arr[i]) <= Math.Abs(b))
                    arr[i] = 0;

            arr = arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
            textBox7.Text = String.Join(" ", arr);
        }
    }
}
