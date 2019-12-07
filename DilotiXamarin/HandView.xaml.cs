using ReactiveUI.XamForms;
using Xamarin.Forms.Xaml;

namespace DilotiXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HandView : ReactiveContentView<HandViewModel>
    {
        public HandView()
        {
            InitializeComponent();

            ViewModel = new HandViewModel();
        }
    }
}