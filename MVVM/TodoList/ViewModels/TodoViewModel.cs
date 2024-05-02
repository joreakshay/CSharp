using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using TodoList.Helpers;
using TodoList.Models;

namespace TodoList.ViewModels 
{
   public class TodoViewModel : ChangeNotifire
    {
        public string Title { get { return $"Todo({toDoModels.Count(x => !x.IsDone)}) Completed({toDoModels.Count(x => x.IsDone)})";  }  }
        private ObservableCollection<ToDoModel> toDoModels=new ObservableCollection<ToDoModel>();

        public ObservableCollection<ToDoModel> TodoModels
        {
            get { return toDoModels; }
            set { toDoModels = value; }
        }

        public ICommand AddCommand { get; set; }

        private string  _newToDo;       

        public string NewToDo
        {
            get { return _newToDo; }
            set { _newToDo = value; OnPropertyChanged(nameof(NewToDo)); }
        }

        internal void AddToDO(object? param)
        {
            if (string.IsNullOrEmpty(_newToDo))
                return;
            ToDoModel toDoModel = new ToDoModel { Title = _newToDo };
            toDoModel.PropertyChanged += ToDoModel_PropertyChanged;
            TodoModels.Add(toDoModel);
            NewToDo = string.Empty;
            OnPropertyChanged(nameof(Title));
        }

        private void ToDoModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Title));
        }

        public TodoViewModel()
        {
            AddCommand = new GenericCommand(AddToDO);
        }
       
    }
}
