namespace felgaApp
{
    public partial class MainPage : ContentPage
    {
        int currentPicture = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void displayFelga()
        {
            imgFelgi.Source = $"f{currentPicture}.jpg";
            lblTitle.Text = $"Felga nr {currentPicture + 1}";
        }

        private void onPrevClicked(object sender, EventArgs e)
        {
            currentPicture--;
            if (currentPicture < 0) {
                currentPicture = 9;
            }
            displayFelga();
        }

        private void onNextClicked(object sender, EventArgs e) { 
            currentPicture++;
            if (currentPicture > 9) {
                currentPicture = 0;
            }
            displayFelga();
        }

        private void onRandClicked(object sender, EventArgs e) { 
            Random random = new Random();
            currentPicture = random.Next(10);
            displayFelga();
        }

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
