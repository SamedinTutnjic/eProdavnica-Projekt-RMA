using eProdavnica.ViewModels;

namespace eProdavnica
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel vm;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = ViewModels = new MainPageViewModel();
        }

        public MainPageViewModel ViewModels { get; }
    }

}
