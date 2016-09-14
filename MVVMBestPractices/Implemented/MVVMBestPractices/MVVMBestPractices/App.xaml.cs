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
            try
            {
                InitializeComponent();
            }
            catch (InvalidOperationException soe)
            {
                if (!soe.Message.Contains("MUST"))
                    throw;
            }

            MainPage =
                new NavigationPage(
                    FreshMvvm.FreshPageModelResolver.ResolvePageModel
                    <ToDoListPageModel>());
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
