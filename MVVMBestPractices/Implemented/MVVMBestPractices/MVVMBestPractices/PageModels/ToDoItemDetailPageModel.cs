using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Controls;
using MVVMBestPractices.Shared.Models;
using PropertyChanged;

namespace MVVMBestPractices.PageModels
{
    [ImplementPropertyChanged]
    public class ToDoItemDetailPageModel : PageModelBase
    {
        public ToDoItem ToDoItem { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public override void SetViewModel(object InitData)
        {
            ToDoItem  = InitData as ToDoItem;
        }
    }
}