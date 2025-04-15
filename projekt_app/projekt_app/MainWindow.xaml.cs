using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projekt_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            dodajUzytkownika dodajUzytkownika = new();
            dodajUzytkownika.ShowDialog();

            Osoba uczen = new();
            uczen.m_strPesel = dodajUzytkownika.pesel.Text;
            uczen.m_strImie = dodajUzytkownika.imie.Text;
            uczen.m_strDrugieImie = dodajUzytkownika.drugie_imie.Text;
            uczen.m_strNazwisko = dodajUzytkownika.nazwisko.Text;
            uczen.m_strDataUr = dodajUzytkownika.data_ur.Text;
            uczen.m_strTelefon = dodajUzytkownika.telefon.Text;
            uczen.m_strAdres = dodajUzytkownika.adres.Text;
            uczen.m_strMiejscowosc = dodajUzytkownika.miejscowosc.Text;
            uczen.m_strKodPocztowy = dodajUzytkownika.kod_pocztowy.Text;

            listaUczniow.Items.Add(uczen);

        }

        class Osoba
        {
            public string? m_strPesel { get; set; }
            public string? m_strImie { get; set; }
            public string? m_strDrugieImie { get; set; }
            public string? m_strNazwisko { get; set; }
            public string? m_strDataUr { get; set; }
            public string? m_strTelefon { get; set; }
            public string? m_strAdres { get; set; }
            public string? m_strMiejscowosc { get; set; }
            public string? m_strKodPocztowy { get; set; }
            public Osoba()
            {
                m_strPesel = "00000000000";
                m_strImie = "";
                m_strDrugieImie = "";
                m_strNazwisko = "";
                m_strDataUr = "";
                m_strTelefon = "";
                m_strAdres = "";
                m_strMiejscowosc = "";
                m_strKodPocztowy = "";

            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewRecord_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void RemoveSel_Click(object sender, RoutedEventArgs e)
        {
            while (listaUczniow.SelectedItems.Count > 0)
            {
                listaUczniow.Items.Remove(listaUczniow.SelectedItems[0]);
            }
        }
    }
}