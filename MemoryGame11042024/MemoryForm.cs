using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MemoryForm : Form
    {
        // obiekt na ustawienia gry
        private GameSettings _settings;

        // zmienne pomocnicze na odkrywane karty
        MemoryCard _pierwsza = null;
        MemoryCard _drugi = null;

        public MemoryForm()
        {
            InitializeComponent();
            // tworzymy obiekt z ustawieniami gry
            _settings = new GameSettings();

            // wywołujemy metodę ustawiającą dane formularza
            UstawKontrolki();

            // wywołujemy metodę, która utworzy karty do odkrywania
            GenerujKarty();
            timerCzasPodgladu.Start();
        }

        // metoda ustawiająca ustawienia startowe formularza
        // wykorzystamy ją podczas pierwszego uruchomienia
        // oraz przy restartowaniu gry od nowa
        private void UstawKontrolki()
        {
            // żeby nie przejmować się dopasowywaniem okna w designerze,
            // obliczymy, ile miejsca potrzeba na wszystkie karty na podstawie właściwości,
            // które przechowujemy w obiekcie settings
            // obliczamy długość i szerokość dla panelu z kartami 
            panelKart.Width = _settings.Bok * _settings.Kolumny + _settings.Margines * (_settings.Kolumny - 1);
            panelKart.Height = _settings.Bok * _settings.Wiersze + _settings.Margines * (_settings.Wiersze - 1);
            // panel znajduje sie na formularzu, więc też musimy go powiększyć
            // dodając dodatkowe kilkadziesiąd pikseli merginesu (metodą prób i błędów)
            Width = panelKart.Width + 40;
            Height = panelKart.Height + 100;

            // ustawiamy teksty na labelkach
            lblStartInfo.Text = $"Początek gry za {_settings.CzasPodgladu}.";
            lblPunktyWartosc.Text = _settings.AktualnePunkty.ToString();
            lblCzasWartosc.Text = _settings.CzasGry.ToString();
            // oraz widoczność labelki na odliczanie dopoczątku gry
            // gdy gra się rozpocznie będziemy ją ukrywać
            lblStartInfo.Visible = true;
        }



        // metoda generująca karty oraz losowo układjąca je po panelu gry
        private void GenerujKarty()
        {
            // pobieramy ściezki do plików z obrazkami
            string[] memories = Directory.GetFiles(_settings.FolderObrazki);
            // ustawiamy maksymalną liczę punktów do zdobycia na podstawie 
            // ilości pobranych obrazków
            _settings.MaxPunkty = memories.Length;
            // tworzymy listę na karty do gry
            List<MemoryCard> buttons = new List<MemoryCard>();
            // dla każdego z obrazka tworzymy po dwie karty
            foreach (string img in memories)
            {
                // twrzymy unikalny identyfikator dla karty
                Guid id = Guid.NewGuid();
                // tworzymy pierszą kartę
                MemoryCard b1 = new MemoryCard(id, _settings.PlikLogo, img);
                // i dodajemy ją do listy
                buttons.Add(b1);
                // tworzymy drugą kartę
                MemoryCard b2 = new MemoryCard(id, _settings.PlikLogo, img);
                // i dodajemy ją do listy
                buttons.Add(b2);
            }


            // tworzymy generator liczb pseudolosowych
            // wykorzystamy go do losowego rozmieszczania kart na panelu
            Random random = new Random();

            panelKart.Controls.Clear();

            for (int x = 0; x < _settings.Kolumny; x++)
            {
                for (int y = 0; y < _settings.Wiersze; y++)
                {
                    int index = random.Next(0, buttons.Count);
                    MemoryCard b = buttons[index];
                    b.Location = new Point((x * _settings.Bok) + (_settings.Margines * x),
                        (y * _settings.Bok) + (_settings.Margines * y));
                    b.Width = _settings.Bok;
                    b.Height = _settings.Bok;
                    b.Click += MemoryCard_Click;
                    b.Odkryj();
                    panelKart.Controls.Add(b);
                    buttons.Remove(b);
                }
            }

        }

        private void TimerCzasPodgladu_Tick(object sender, EventArgs e)
        {
            _settings.CzasPodgladu--;
            lblStartInfo.Text = $"Początek gry za {_settings.CzasPodgladu}";
            if (_settings.CzasPodgladu <= 0)
            {
                foreach (Control kontrolka in panelKart.Controls)
                {
                    MemoryCard c = (MemoryCard)kontrolka;
                    c.Zakryj();
                }
                timerCzasPodgladu.Stop();
                timerCzasGry.Start();
            }
        }
        private void MemoryCard_Click(object sender, EventArgs e)
        {
            MemoryCard btn = (MemoryCard)sender;
            btn.Odkryj();
        }
    }
}
