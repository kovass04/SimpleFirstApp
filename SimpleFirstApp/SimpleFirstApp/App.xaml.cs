using SimpleFirstApp.Views.Logins;
using System;
using Xamarin.Forms;
using System.IO;
using System.Reflection;

namespace SimpleFirstApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "accounts13.db";
        public static AccountAsyncRepository database;
        public static AccountAsyncRepository Database
        {
            get
            {
                if (database == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME);

                    if (!File.Exists(dbPath))
                    {
                        var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;

                        using (Stream stream = assembly.GetManifestResourceStream($"SimpleFirstApp.{DATABASE_NAME}"))
                        {
                            using (FileStream fs = new FileStream(dbPath, FileMode.OpenOrCreate))
                            {
                                stream.CopyTo(fs);
                                fs.Flush();
                            }
                        }
                    }

                    database = new AccountAsyncRepository(dbPath);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();


            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
