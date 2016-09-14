using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace MVVMBestPractices.PageModels
{
    [ImplementPropertyChanged]
    public class ToDoItemDetailPageModel : PageModelBase
    {
        public override void Init(object initData)
        {
            base.Init(initData);

        }

        protected override void SetViewModel()
        {
           
        }
    }
}