using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Annotations;
using MVVMBestPractices.Controls;
using MVVMBestPractices.Data.Fake;
using MVVMBestPractices.Shared.Models;
using PropertyChanged;
using SpecFlow.XForms.IViewModel;
using Xamarin.Forms;

namespace MVVMBestPractices.PageModels
{
    [ImplementPropertyChanged]
    public class ToDoListPageModel : PageModelBase
    {
        public List<ToDoItem> ToDoItems { get; set; }

        private ToDoItem _selectedToDoItem;
        public ToDoItem SelectedToDoItem
        {
            get { return _selectedToDoItem; }
            set
            {
                _selectedToDoItem = value;
                if (value != null)
                    CoreMethods.PushPageModel<ToDoItemDetailPageModel>(value);
            }
        }

        public override void Init(object initData)
        {
            SetViewModel();
            base.Init(initData);
        }

        protected override void SetViewModel()
        {
            ToDoItems = FakeToDoData.FakeData;
        }
    }
}