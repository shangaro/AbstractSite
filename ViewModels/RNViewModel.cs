using AbstractSite.ViewModels.HtmlElements;

namespace AbstractSite.ViewModels
{
    public class RNViewModel : BaseViewModel
    {
        public HtmlElements<FrequencyViewModel> FrequencyElem { get; set; } = new HtmlElements<FrequencyViewModel>();
    }
}
