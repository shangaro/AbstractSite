using AbstractSite.ViewModels.HtmlElements;

namespace AbstractSite.ViewModels
{
    public class BaseViewModel
    {
        public HtmlElement<NameViewModel> NameElement { get; set; }
        public HtmlElement<EmailViewModel> EmailElem { get; set; }
        public HtmlElement<DescriptionViewModel> DescriptionElem { get; set; }
        public BaseViewModel()
        {
            NameElement = new HtmlElement<NameViewModel>();
            EmailElem = new HtmlElement<EmailViewModel>();
            DescriptionElem = new HtmlElement<DescriptionViewModel>();
        }
    }
}
