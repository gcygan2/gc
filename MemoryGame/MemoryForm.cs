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

            // startujemy pierwszy timer, którego zadaniem jest odliczanie do rozpoczęcia gry
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

        // metoda timera CzasPodglądu - uruchamia się co 1 sekundę
        // jej zadaniem jest zmniejszenie czasu podglądu
        // oraz, gdy czas się skończy zakrycie wszystkich kart i wystartowanie gry
        private void timerCzasPodgladu_Tick(object sender, EventArgs e)
        {
            // zmniejszamy czas podglądu o 1
            _settings.CzasPodgladu--;

            // aktualizujemy labelkę wyświetlającą czas podglądu
            lblStartInfo.Text = $"Początek gry za {_settings.CzasPodgladu}.";

            // sprawdzamy czy wartość czasu się nie skończyła
            if (_settings.CzasPodgladu <= 0)
            {
                // jeżeli tak to ukrywamy labelkę z czasem odliczania
                lblStartInfo.Visible = false;

                // przechodzimy pętlą po wszystkich kontrolkach w panelu gry
                // - znajdują się tam tylko karty do gry
                foreach (Control kontrolka in panelKart.Controls)
                {
                    // ponieważ zmienna Controls przechowuje wszystkie kontrolki
                    // to każda pobrana kontrolka jest typu Control
                    // używamy operatora rzutowania, aby zamienić typ Control na MemoryCard
                    // możemy to zrobić ponieważ nasza karta dziedziczy po typie Label,
                    //który z kolei dziedziczy po typie Control
                    MemoryCard card = (MemoryCard)kontrolka;
                    // wywołuje metodę zakryj
                    card.Zakryj();
                }

                // zatrzymujemy timer CzasGry, ponieważ zrobił on już swoje
                timerCzasPodgladu.Stop();

                // uruchamiamy za to timer CzasGry
                timerCzasGry.Start();
            }
        }

        // metoda timera CzasGry, która wywołuje się co jedną sekundę
        // jej zadaniem jest zmniejszanie czasu gry oraz sprawdzanie
        // czy gra nie powinna się juz zakończyć
        private void timerCzasGry_Tick(object sender, EventArgs e)
        {
            // zmniejszamy czas gry o jeden
            _settings.CzasGry--;

            // aktualizujemy labelkę wyświetlającą ten czas
            lblCzasWartosc.Text = _settings.CzasGry.ToString();

            // sprawdzamy czy nie nastąpił koniec gry z jednego z dwóch powodów
            // - skończył się czas gry
            // lub odkryliśmy wszystkie karty - czyli zostały zdobyte wszystkie możliwe punkty
            if (_settings.CzasGry <= 0 || _settings.AktualnePunkty == _settings.MaxPunkty)
            {
                // jeżeli tak to zatrzymujemy timer CzasGry oraz timer Zakrywacz
                timerCzasGry.Stop();
                timerZakrywacz.Stop();

                // wyświetlamy MessageBox z wynikiem i zapytaniem czy rozpocząć grę od nowa
                // wynik, który z przycisków został kliknięty zapisujemy do zmiennej
                DialogResult yesNo = MessageBox.Show($"Zdobyte punkty: {_settings.AktualnePunkty}. Grasz ponownie?", "Koniec Gry", MessageBoxButtons.YesNo);

                // sprawdzamy czy wybrano "Yes"
                if (yesNo == DialogResult.Yes)
                {
                    // jeżeli tak to wywołujemy te same metody co przy uruchamianiu programu,
                    // ale dodatkowo restartujemy ustawienia gry
                    _settings.UstawStartowe();

                    // które ustawiają parametry startowe i rozlosowują karty
                    GenerujKarty();
                    UstawKontrolki();
                    // w przypadku nowej rozgrywki aktywujemy panel z przyciskami oraz czyścimi przyciski które mogły być odkryte w poprzeniej rozgrywce
                    panelKart.Enabled = true;
                    _pierwsza = null;
                    _drugi = null;

                    // startujemy ponownie timer CzasPodglądu
                    timerCzasPodgladu.Start();
                }
                else
                {
                    // jezeli wybrano nie to zamykamy program
                    Application.Exit();
                }
            }
        }

        // metoda timera Zakrywacz, którego zadaniem jest zakrycie dwóch niedopasowanych kart
        // dzięki zastosowaniu do tego timera, dajemy graczowi czas na przyjrzenie się drugiej
        // odkrytej karcie
        private void timerZakrywacz_Tick(object sender, EventArgs e)
        {
            // zakrywamy obie karty
            _pierwsza.Zakryj();
            _drugi.Zakryj();

            // czyścimy zmienne pomocnicze przypisując im wartość null
            _pierwsza = null;
            _drugi = null;

            // aktywujemy panel gry, który został zamrożony na czas podglądu odkrytych kart
            panelKart.Enabled = true;

            // zatrzymujemy timer Zakrywacz, ponieważ chcemy,
            // żeby uruchomił się tylko raz na rządanie
            timerZakrywacz.Stop();
        }

        // metoda podpięta pod zdarzenie kliknięcie każdej z kart
        // jej zadaniem jest sprawdzanie czy odkrywane karty zostały dopasowane
        // i w zalezności od tego zarządzać ich chowaniem,
        // a jeżeli zgadliśmy to zwiększenie punktów i pozostawienie 
        // kart odkrytych
        private void BtnClicked(object sender, EventArgs e)
        {
            MemoryCard btn = (MemoryCard)sender;
            if (_pierwsza == null)
            {
                _pierwsza = btn;
                _pierwsza.Odkryj();
            }
            else
            {
                _drugi = btn;
                _drugi.Odkryj();
                panelKart.Enabled = false;
                if (_pierwsza.Id == _drugi.Id)
                {
                    _settings.AktualnePunkty++;
                    lblPunktyWartosc.Text = _settings.AktualnePunkty.ToString();
                    _pierwsza = null;
                    _drugi = null;
                    panelKart.Enabled = true;
                }
                else
                {
                    // w przeciwnym razie nie udało nam się dopasować kart
                    // uruchamiamy timer zakrywacz, który po chwili zakryje obie karty i odblokuje panel
                    timerZakrywacz.Start();
                }
            }
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
                    //b.Click += BtnClicked;
                    b.Odkryj();
                    panelKart.Controls.Add(b);
                    buttons.Remove(b);
                }
            }

        }
    }
}
