namespace felgaApp
{
    public partial class MainPage : ContentPage
    {
        int currentPicture = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        /*******************************************************************************
            nazwa funkcji:          displayFelga()
            parametry wejściowe:    brak
            wartości wyjściowe:     brak
            informacje:              Funkcja zamienia źródło zdjęcia oraz tekst w tytule
                                    wartościami odpowiednimi do obecnego indexa wybranego
                                    zdjęcia
            autor:                  123653120123
        *******************************************************************************/
        private void displayFelga()
        {
            imgFelgi.Source = $"f{currentPicture}.jpg";
            lblTitle.Text = $"Felga nr {currentPicture + 1}";
        }

        /*******************************************************************************
            nazwa funkcji:          onPrevClicked()
            parametry wejściowe:    sender - kliknięty przycisk
                                    e - zdarzenia przycisków
            wartości wyjściowe:     brak
            informacje:              Funkcja zmniejsza index wybranego zdjęcia o jeden
                                    (jeżeli jest on mniejszy od 0, ustawia go na 9)
                                    a następnie wyświetla odpowiedni obraz przy użyciu
                                    funkcji displayFelga()
            autor:                  123653120123
        *******************************************************************************/
        private void onPrevClicked(object sender, EventArgs e)
        {
            currentPicture--;
            if (currentPicture < 0) {
                currentPicture = 9;
            }
            displayFelga();
        }

        /*******************************************************************************
            nazwa funkcji:          onNextClicked()
            parametry wejściowe:    sender - kliknięty przycisk
                                    e - zdarzenia przycisków
            wartości wyjściowe:     brak
            informacje:              Funkcja zwiększa index wybranego zdjęcia o jeden
                                    (jeżeli jest on wiekszy od 9, ustawia go na 0)
                                    a następnie wyświetla odpowiedni obraz przy użyciu
                                    funkcji displayFelga()
            autor:                  123653120123
        *******************************************************************************/
        private void onNextClicked(object sender, EventArgs e) { 
            currentPicture++;
            if (currentPicture > 9) {
                currentPicture = 0;
            }
            displayFelga();
        }

        /*******************************************************************************
            nazwa funkcji:          onRandClicked()
            parametry wejściowe:    sender - kliknięty przycisk
                                    e - zdarzenia przycisków
            wartości wyjściowe:     brak
            informacje:              Funkcja losuje liczbę z zakresu 0 - 9, przypisuje ją
                                    do indexa wybranego zdjecia oraz wyświetla odpowiedni
                                    obraz przy użyciu funkcji displayFelga()
            autor:                  123653120123
        *******************************************************************************/
        private void onRandClicked(object sender, EventArgs e) { 
            Random random = new Random();
            currentPicture = random.Next(10);
            displayFelga();
        }

        /*******************************************************************************
            nazwa funkcji:          displayFelga()
            parametry wejściowe:    sender - entry do którego został wpisany tekst
                                    e - zdarzenia objektów entry
            wartości wyjściowe:     brak
            informacje:              Funkcja sprawdza czy wpisany do entJump tekst może być
                                    zamieniony na liczbę całkowitą oraz czy jest ona w zakresie
                                    od 0 do 10, jeżeli tak wyświetla odpowiedni obraz 
                                    przy użyciu funkcji displayFelga()
                                    zdjęcia
            autor:                  123653120123
        *******************************************************************************/
        private void onNrInput(object sender, EventArgs e) {
            if (int.TryParse(entJump.Text, out int entValue))
            {
                if (entValue >0 && entValue < 11)
                {
                    currentPicture = entValue - 1;
                    displayFelga();
                }
            }
                
        }
    }

}
