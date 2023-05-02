using System.Globalization;
using System.Windows.Markup;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FrameworkElement.LanguageProperty.OverrideMetadata(
                typeof( FrameworkElement ),
                new FrameworkPropertyMetadata( XmlLanguage.GetLanguage( CultureInfo.CurrentCulture.IetfLanguageTag ) ) );
        }
    }
}