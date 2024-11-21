

namespace felgaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.MaximumHeight = 800;
            window.MaximumWidth = 500;

            window.MinimumWidth = 500;
            window.MinimumHeight = 800;

            return window;
        }
    }
}
