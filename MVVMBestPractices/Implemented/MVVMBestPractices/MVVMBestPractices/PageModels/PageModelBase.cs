using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using MVVMBestPractices.Annotations;
using SpecFlow.XForms.IViewModel;
using Xamarin.Forms;

namespace MVVMBestPractices.PageModels
{
    public abstract class PageModelBase : FreshBasePageModel, IViewModel
    {
        public INavigation Navigation { get; set; }

        public abstract void SetViewModel(object initData);

        public PageModelBase()
        {
            SetViewModel(null);
        }

        public virtual void Init(object initData)
        {
            base.Init(initData);
            SetViewModel(initData);
            
        }
    }
}
