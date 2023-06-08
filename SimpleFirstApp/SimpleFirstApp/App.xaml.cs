using SimpleFirstApp.Views.Logins;
using System;
using Xamarin.Forms;
using System.IO;
using System.Reflection;
using Xamarin.Essentials;
using SimpleFirstApp.ViewModels;
using SimpleFirstApp.ViewModels.Login;

namespace SimpleFirstApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "accounts.db";
        public static AccountAsyncRepository database;
        public static AccountAsyncRepository Database
        {
            get
            {
                if (database == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME);

                    database = new AccountAsyncRepository(dbPath);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            SetAppTheme();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            WelcomePageViewModel WelcomePage = new WelcomePageViewModel();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        private void SetAppTheme()
        {
            var theme = Preferences.Get("theme", string.Empty);
            if (string.IsNullOrEmpty(theme) || theme == "light")
            {
                Application.Current.UserAppTheme = OSAppTheme.Light;
            }
            else
            {
                Application.Current.UserAppTheme = OSAppTheme.Dark;
            }
        }
    }
}
