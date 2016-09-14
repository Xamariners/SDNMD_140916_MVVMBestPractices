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
using MVVMBestPractices.Services;
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

        private readonly IDataService _dataService;

        public ToDoListPageModel(IDataService dataService)
        {
            _dataService = dataService;
        }

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
            base.Init(initData);
        }

        public async override void SetViewModel(object InitData)
        {
            
            ToDoItems = await FreshMvvm.FreshIOC.Container.Resolve<IDataService>().GetToDoItems();
        }
    } 
}