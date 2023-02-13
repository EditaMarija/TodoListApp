using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TodoListApp
{
    class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();
            TodoItems.Add(new TodoItem("Learn more about backend", true));
            TodoItems.Add(new TodoItem("Meet a friend", false));
            TodoItems.Add(new TodoItem("Practise API", false));
        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewTodoInputValue { get; set; }
        public void AddTodoItem()
        {  
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));
            NewTodoInputValue = string.Empty;
            NewTodoInputValue = null;
                
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            TodoItems.Remove(todoItemBeingRemoved);
        }      

    }
}
