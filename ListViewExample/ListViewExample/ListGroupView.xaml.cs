using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListGroupView : ContentPage
    {

        ObservableCollection<User> users = new ObservableCollection<User>();

        public ObservableCollection<User> Employees = new ObservableCollection<User>();

        public ListGroupView()
        {
            InitializeComponent();
            UserView.ItemsSource = users;
            users.Add(new User { UserID = 1, UserName = "UserOne", GroupID = 1 });
            users.Add(new User { UserID = 2, UserName = "UserTwo", GroupID = 1 });
            users.Add(new User { UserID = 3, UserName = "UserThree", GroupID = 2 });
            users.Add(new User { UserID = 4, UserName = "UserFour", GroupID = 1 });
            users.Add(new User { UserID = 5, UserName = "UserFive", GroupID = 3 });
            users.Add(new User { UserID = 6, UserName = "UserSix", GroupID = 3 });

        }

    }
}