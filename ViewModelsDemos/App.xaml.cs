using ViewModelsDemos.ViewModels;
using ViewModelsDemos.Views;

namespace ViewModelsDemos
{
    public partial class App : Application
    {
        private NoteViewModel viewModel;
        public App()
        {
            InitializeComponent();
            viewModel = new NoteViewModel();

            MainPage = new NavigationPage(new AddNotePage(viewModel)); //AppShell();
        }
    }
}
