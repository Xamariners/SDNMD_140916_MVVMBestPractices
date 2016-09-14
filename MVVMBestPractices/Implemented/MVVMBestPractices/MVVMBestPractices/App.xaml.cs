using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVVMBestPractices.PageModels;
using Xamarin.Forms;

namespace MVVMBestPractices
{
    public partial class App : Application
    {
        public App()
        {

            var toDoList = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ToDoListPageModel>();
            var navContainer = new FreshMvvm.FreshNavigationContainer(toDoList);
            MainPage = navContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
