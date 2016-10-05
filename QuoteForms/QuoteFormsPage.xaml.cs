using Xamarin.Forms;

namespace QuoteForms
{
    public partial class QuoteFormsPage : ContentPage
    {
        public QuoteFormsPage()
        {
            InitializeComponent();

            var quoteViewModel = new QuoteViewModel();
            var label = new Label();
            label.SetBinding(Label.TextProperty, "QuoteName");
            this.OnChildAdded(label);

            BindingContext = quoteViewModel;
        }
    }
}
