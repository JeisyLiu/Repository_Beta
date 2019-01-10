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

namespace WPFCalculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public class Caculator
    {
        public int NumberCounter;
        public int StringCounter;
        float[] Counts = new float[20];
        public List<string> StrArray = new List<string>();
        float Answer;
        public Caculator()
        {
            for(int i=0;i<20;i++)
            {
                Counts[i] = 0;
            }
            NumberCounter = 0;
            StringCounter = 0;
            Answer = 0;
        }
        public void NumConventor(int Clicked)
        {
            Counts[NumberCounter] = Counts[NumberCounter] * 10 + Clicked;
        }
        public void Num2Strings(int n) {  }
        public float Only4Cutter() { return Counts[NumberCounter]; }
        public void Counts4Cutter() { Counts[NumberCounter] =(float)-0.1; }
        public float Tans() { return Counts[NumberCounter]; }
        public float Ans() { return Answer; }
        public void Plus()
        {
            Answer += Counts[NumberCounter];
        }
        public void Cutter()
        {
            Answer -= Counts[NumberCounter];
        }
        public void Multiply()
        {
            Answer *= Counts[NumberCounter];
        }
        public void Division()
        {
            Answer /= Counts[NumberCounter];
        }
        public void Cleanner()
        {
            Answer = 0;
            StringCounter = 0;
            NumberCounter = 0;
            for (int i = 0; i < 20; i++)
            {
                Counts[i] = 0;
            }
        }
        public void DetectCounter()
        {
        }
    }
    /*****************分割线******************/
    public partial class MainWindow : Window
    {
        Caculator cac = new Caculator();
        private void GTA_Click(object sender,RoutedEventArgs e)
        {
            Browser br = new Browser();
            br.Show();
        }
        private void Indecate(float ans)
        {
            ShowAnswer.Text = "" + ans;
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(1);
            Indecate(cac.Tans());
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(2);
            Indecate(cac.Tans());
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(3);
            Indecate(cac.Tans());
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(4);
            Indecate(cac.Tans());
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(5);
            Indecate(cac.Tans());
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(6);
            Indecate(cac.Tans());
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(7);
            Indecate(cac.Tans());
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(8);
            Indecate(cac.Tans());
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(9);
            Indecate(cac.Tans());
        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            cac.NumConventor(0);
            Indecate(cac.Tans());
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            ShowAnswer.Text = "+";
        }
        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            ShowAnswer.Text = "-";         
        }
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            ShowAnswer.Text = "×";
        }
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            ShowAnswer.Text = "÷";
        }
        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            cac.Cleanner();
            ShowAnswer.Text = "QwQ";
        }
        private void Count_Click(object sender, RoutedEventArgs e)
        {
            ShowAnswer.Text = "=" + cac.Ans();
        }
    }
}
