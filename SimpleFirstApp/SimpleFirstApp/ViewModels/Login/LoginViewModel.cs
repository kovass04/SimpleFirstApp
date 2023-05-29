using SimpleFirstApp.Models;
using SimpleFirstApp.Views.Logins;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SimpleFirstApp.ViewModels.Login
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private LoginRequestModel myloginRequestModel = new LoginRequestModel();
        public LoginRequestModel MyloginRequestModel
        {
            get { return myloginRequestModel; }
            set
            {
                myloginRequestModel = value;

                OnPropertyChanged(nameof(MyloginRequestModel));
            }
        }


        public ICommand LoginCommand { get; }



        public LoginViewModel()
        {

            LoginCommand = new Command(PerformLoginOperation);
        }

        private async void PerformLoginOperation(object obj)
        {
            //Perform API Operation/ DB Operation

            var data = MyloginRequestModel;
            await App.Database.CreateTable();
            var data2 = await App.Database.GetItemsAsync();

            foreach (var item in data2)
            {
                if (data.UserName == item.UserName && data.Password == item.Password)
                {

                    Preferences.Set("UserAlreadyloggedIn", true);


                    await Application.Current.MainPage.Navigation.PushAsync(new DashboardPage());
                }
            }
            


        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
