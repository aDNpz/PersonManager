using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonManager.WpfApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ICommand? addCommand = null;
        private Logic.Repositories.PersonalRepository Repository { get; } = new();
        private PersonManager.Logic.Models.Person Model { get; set; } = new();


        public ICommand AddCommand
        { 
            get
            {
                return RelayCommand.CreateCommand(ref addCommand, (p) => AddPerson());
            }
        }

        public void AddPerson()
        {
            PersonWindow personWindow = new PersonWindow();

            personWindow.ShowDialog();
            OnPropertyChanged(nameof(Models));
        }
        public ObservableCollection<Logic.Models.Person> Models 
        { 
            get
            {
               var result = new ObservableCollection<Logic.Models.Person>(Repository.GetAll());
                return result;
            }
        }

        public string Firstname 
        {
            get => Model.Firstname;
            set 
            { 
                Model.Firstname = value;
                OnPropertyChanged(nameof(FullName));

            }
        }

        public string Lastname
        {
            get => Model.Lastname;
            set
            {
                Model.Firstname = value;
                OnPropertyChanged(nameof(FullName));

            }
        }

        public string FullName
        {
            get => Model.Fullname;
        }
    }
}
