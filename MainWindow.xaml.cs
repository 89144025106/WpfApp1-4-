using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1_Практическая_4_Гуляева
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            static void Main(string[] args)
            {
                Console.Write("Введите начало интервала: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("конец интервала: ");
                int y = int.Parse(Console.ReadLine());

                Random rand = new Random();

                int A = rand.Next(x, y);
                int l = 0;
                while (true)
                {
                    Console.WriteLine("Введите число");

                    int B = int.Parse(Console.ReadLine());

                    l++;
                    if (B == A)
                    {
                        Console.WriteLine("Вы угадали c {0} попытки:", l);

                        break;
                    }

                    else if (B > A)
                    {
                        Console.WriteLine("Ваше число больше");
                    }
                    else
                    {
                        Console.WriteLine("Ваше число меньше");
                    }
    }
}
