using Xamarin.Forms;

namespace PROYECTO
{
    public partial class MainPage : ContentPage
    {
        private bool isDarkMode = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnYouTubeClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://www.youtube.com/@VictorQuezada-qr9td"));
        }

        private void OnGitHubClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://github.com/VictorAQuezada"));
        }

        private void OnLinkedInClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://www.linkedin.com/in/v%C3%ADctor-quezada-7a9617253/"));
        }

        private void OnDarkModeClicked(object sender, System.EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                // Cambiar a modo oscuro
                BackgroundColor = Color.FromHex("#121212");
                foreach (var child in ((StackLayout)Content).Children)
                {
                    if (child is Label label)
                    {
                        label.TextColor = Color.White;
                    }
                }
            }
            else
            {
                // Cambiar a modo claro
                BackgroundColor = Color.FromHex("#F5F5F5");
                foreach (var child in ((StackLayout)Content).Children)
                {
                    if (child is Label label)
                    {
                        label.TextColor = Color.Black;
                    }
                }
            }
        }
    }
}