using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsernamePasswordProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowDataPage : ContentPage
    {
        /*
        public ObservableCollection<User> usernameListView { get; set; }
        public ObservableCollection<Pass> passwordListView { get; set; }
        public class User
        {
            public string Username { get; set; }
        }
        public class Pass
        {
            public string Password { get; set; }
        }
        */

        public ShowDataPage()
        {
            InitializeComponent();

            /*
            usernameListView = new ObservableCollection<User>();
            passwordListView = new ObservableCollection<Pass>();
            usernameListView.Add(new User() { Username = "Alyssa" });
            usernameListView.Add(new User() { Username = "Brennan" });
            passwordListView.Add(new Pass() { Password = "abc" });
            passwordListView.Add(new Pass() { Password = "123" });
           
            BindingContext = this;
            */
        }

        async void OnItemClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}