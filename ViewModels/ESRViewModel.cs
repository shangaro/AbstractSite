using AbstractSite.ViewModels.HtmlElements;

namespace AbstractSite.ViewModels
{
    public class ESRViewModel : BaseViewModel
    {
        public HtmlElement<SourceViewModel> Sources { get; set; } = new HtmlElement<SourceViewModel>();
    }
}
