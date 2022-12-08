using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonManager.WpfApp.ViewModel
{
    public class PersonViewModel : BaseViewModel
    {
        private ICommand? saveCommand = null;
        private ICommand? closeCommand = null;
        private Logic.Repositories.PersonalRepository Repository { get; } = new();
        private PersonManager.Logic.Models.Person Model { get; set; } = new();

        public Action? CloseWindow { get; set; }

        public ICommand SaveCommand 
        { 
            get
            {
                return RelayCommand.CreateCommand(ref saveCommand, (p) => Save());
            }
        }
        public ICommand CloseCommand
        {
            get
            {
                return RelayCommand.CreateCommand(ref saveCommand, (p) => Close());
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

        public void Save()
        {

        }

        public void Close()
        {
            CloseWindow?.Invoke();
        }
    }
}
