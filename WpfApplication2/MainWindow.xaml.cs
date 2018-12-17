using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BallonFunctions;
using Premier;
using System.ComponentModel;
using System.Diagnostics;
using WpfApplication2;
using ClassLibrary1;

namespace WpfApplication2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Thread> ballons = new List<Thread>();
        private List<Thread> premiers = new List<Thread>();

        public MainWindow()
        {
            InitializeComponent();
        }
 

        /// <summary>
        /// this function updates the text Block of the number of running Threads
        /// </summary>

        private void setRunningThreadsNbr()
        {
            String status;
            // ballons
            //get the text bx component

            var myTextBlock = (TextBlock)this.FindName("textBlock");
            status = "Number of running 'Ballon' Threads :  ";
            //set number of running processes
            myTextBlock.Text = String.Concat(status, this.ballons.Count);

            //premiers
            var myTextBlockPremier = (TextBlock)this.FindName("textBlock_Premier");
            status = "Number of running 'Premier' Threads :  ";
            //set number of running processes
            myTextBlockPremier.Text = String.Concat(status, this.premiers.Count);

        }

        // cette fonction permet de lancer un ballon
        private void lancerBallon()
        {
            WindowBallon b = new WindowBallon();
            b.Show();
            System.Windows.Threading.Dispatcher.Run();
        }
        private void lancerPremiers()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetBufferSize(132, 600);
            Console.SetWindowSize(16, 32);

            for (int p = 1; p < 1000000; p++)
            {
                int i = 2;
                while ((p % i) != 0 && Math.Sqrt(i) < p)
                {
                    i++;
                }
                if (i == p)
                    Console.WriteLine(p.ToString());
                Thread.Sleep(50);


            }
        }

        private void BallonThread_Click(object sender, RoutedEventArgs e)
        {

            // on crée un thread et on fait appel à la fonction lancer ballon
            Thread b = new Thread(new ThreadStart(lancerBallon));
            b.SetApartmentState(ApartmentState.STA);
            b.Start();

            //add to Threads List
            this.ballons.Add(b);
            //Update information Text Blocks
            this.setRunningThreadsNbr();

        }

        private void PremierThread_Click(object sender, RoutedEventArgs e)
        {
            //init and start Thread
            // passing the event handler to the delegate to handle process closing
            Class1 premier = new Class1(); 
            Thread p = new Thread(new ThreadStart(premier.NombresPremiers));
            p.SetApartmentState(ApartmentState.STA);
            p.Start();

            //app to thread list
            premiers.Add(p);
            //Update information Text Blocks
            this.setRunningThreadsNbr();
        }



        private void process_exited(object sender, EventArgs e) {

            // look for and remove the exited process => I coudln't use (Process)sender because the process is no longer running
            

            //invoke dispatcher to update the pid lists and number of running processes on the main window
            Application app = System.Windows.Application.Current;
            if (app != null)
            {
                app.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, (Action)delegate
                {
                    this.setRunningThreadsNbr();
                });
            }
        }


        private void closeAllThreads(object sender, RoutedEventArgs e)
        {
            // loop and Kill
            int ballonsCount = this.ballons.Count;
            int premiersCount = this.premiers.Count;
            for (int i = 0; i <= ballonsCount + 1; i++)
            {
                this.CloseLastBalon(sender,e);
            }
            for (int i = 0; i <= premiersCount + 1; i++)
            {
                this.CloseLastPremier(sender, e);
            }

            //re init process lists
            this.ballons = new List<Thread>();
            this.premiers = new List<Thread>();
            // update text blocks
            this.setRunningThreadsNbr();
        }

        private void CloseLastThread(object sender, RoutedEventArgs e)
        {
            //update text blocks
            this.setRunningThreadsNbr();


        }

        /// <summary>
        /// Closes Last Ballon Thread
        /// </summary>
        private void CloseLastBalon(object sender, RoutedEventArgs e)
        {
            //update information text blocks
            this.setRunningThreadsNbr();
        }

        private void CloseLastPremier(object sender, RoutedEventArgs e)
        {

            //update information text blocks
            this.setRunningThreadsNbr();
        }
        private void DataWindow_Closing(object sender, CancelEventArgs e)
        {
            //added to call close all threads
            RoutedEventArgs x = new RoutedEventArgs();
            //closing all threads before quitting the application
            //this.closeAllThreads(sender,x);
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
