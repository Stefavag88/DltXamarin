
using ReactiveUI.XamForms;
using System.ComponentModel;


namespace DilotiXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ReactiveContentPage<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();

            ViewModel = new MainPageViewModel();
        }

        
    }
}
