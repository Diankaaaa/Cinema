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

namespace Cinema
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Cinemas> cinemas;
        public MainWindow()
        {
            InitializeComponent();
            cinemas = new List<Cinemas>();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Movie_Theatre_Name = MOVIETHEATRENAME.Text;
                DateTime d = DT.SelectedDate.Value;
                string Movie_Title = MOVIETITlE.Text;
                string Genre_ = GENRE.Text;
                string dt = DT1.Text;
                double duration = double.Parse(DURATION.Text);

                Times en = new Times(dt);
                string Ending = (en.AddingTheTimeAndTheSpecifiedNumberOfSeconds(DateTime.Parse(dt), duration)).ToString("HH:mm");
                

                Cinemas cinem = new Cinemas(Movie_Theatre_Name, d, Movie_Title, Genre_, dt, duration, Ending);
                cinemas.Add(cinem);
                
              //  ResultTime();
                AddInList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear(List<Cinemas> cinem)
        {
            Cinemas[] cin = new Cinemas[cinemas.Count];
            cin = cinem.ToArray();
            //   Array.Sort(cin, new Comp());
            Panels.ItemsSource = null;
            Panels.ItemsSource = cin;
            DT.SelectedDate = DateTime.Now;
            
        }
        private void AddInList()
        {
            Panels.ItemsSource = null;
            Panels.ItemsSource = cinemas;
        }

        //
        private void CLEAR_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MOVIETHEATRENAME.Text = String.Empty;
                DT.SelectedDate = null;
                MOVIETITlE.Text = String.Empty;
                GENRE.Text = String.Empty;
                DURATION.Text = String.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Filter_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Cinemas> filter = new List<Cinemas>();
            foreach(Cinemas i in cinemas)
            {
                if (i.Dt == Filter.SelectedDate.Value)
                {
                    filter.Add(i);
                }
            }
            Panels.ItemsSource = null;
            Panels.ItemsSource = filter;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Clear(cinemas);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        //private void ResultTime()
        //{
        //    int Hourse_ = int.Parse(HOURS.Text);
        //    int Minutes_ = int.Parse(MINUTES.Text);
        //    int Duration_ = int.Parse(DURATION.Text);

        //    int res = 0;
        //    int result = Duration_ + Minutes_;
        //    string FinalResult = " ";
        //    if (result > 60)
        //    {
        //        res = Duration_ + Minutes_ - 60;
        //        if (res >= 60)
        //        {
        //            while (res >= 60)
        //            {
        //                res -= 60;
        //                Hourse_ += 1;
        //            }
        //        }
        //        Hourse_ += 1;
        //        FinalResult = String.Join(" ", Hourse_, res);
        //        Cinemas resTime = new Cinemas(FinalResult);
        //        cinemas.Add(resTime);
        //       // AddInList();
        //      //  MessageBox.Show(FinalResult);
        //    } else if(result == 60) 
        //    {
        //        Hourse_ += 1;
        //        FinalResult = Hourse_ + " " + Minutes_;
        //        Cinemas resTime = new Cinemas(FinalResult);
        //        cinemas.Add(resTime);
        //      //  AddInList();
        //     //   MessageBox.Show(FinalResult);
        //    }
        //    else
        //    {
        //        res = Duration_ + Minutes_;
        //        FinalResult = Hourse_ + " " + res;
        //        Cinemas resTime = new Cinemas(FinalResult);
        //        cinemas.Add(resTime);
        //      //  AddInList();
        //       // MessageBox.Show(FinalResult);
        //    }
        //}
    }
}