using System;
using Microsoft.Maui.Controls;

namespace sampledb
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void OnToggleThemeClicked(object sender, EventArgs e)
        {
            // Call the ToggleTheme method in the App class
            if (Application.Current is App app)
            {
                app.ToggleTheme();
            }
        }
    }
}
