using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace PostalApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            //Bardzo długo próbowałem ale nie wiem jak zrobić, próbowałem StackOverflow, Youtube
            //oraz inne źródła informacji ale po prostu nie wiem jak więc odsyłam narazie w tej formie i proszę o jakieś
            //Materiały z wytłumaczeniem jak to zrobić
            if (PocztowkaRadioButton.IsChecked == true)
            {
                //ImageViewer.Source = new BitmapImage(new Uri("pack://application:resources/pocztowka.png"));
                CenaTextBlock.Text = "Cena: 1 zł";
            }
            else if (ListRadioButton.IsChecked == true)
            {
                //ImageViewer.Source = new BitmapImage(new Uri("pack://application:resources/letter.png"));
                CenaTextBlock.Text = "Cena: 1,5 zł";
            }
            else if (PaczkaRadioButton.IsChecked == true)
            {
                //ImageViewer.Source = new BitmapImage(new Uri("pack://application:resources/package.png"));
                CenaTextBlock.Text = "Cena: 10 zł";
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            string kod = KodTextBox.Text;

            if (kod.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (!int.TryParse(kod, out _))
                //"TryParse" próbuje przekonwertować kod pocztowy, który w zapisałem w zmiennej "kod" jako string,
                //z powrotem na intiger, a "out" oznacza że element zostanie zaraz potem odrzucony("Zapomniany")
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
        }
    }
}
