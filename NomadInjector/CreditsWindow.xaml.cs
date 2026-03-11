using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace NomadInjector
{
    public partial class CreditsWindow : Window
    {
        public CreditsWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/u1ni/NomadInjector") { UseShellExecute = true });
        }
    }
}
