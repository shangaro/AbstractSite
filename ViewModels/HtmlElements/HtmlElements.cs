using System.Collections.Generic;

namespace AbstractSite.ViewModels.HtmlElements
{
    public class HtmlElements<T> where T : class, new()
    {
        public string ViewName { get; set; }
        public T Model { get; set; }
        public IList<HtmlAttribute> HtmlAttributes { get; set; }
        public HtmlElements()
        {
            Model = new T();
            HtmlAttributes = new List<HtmlAttribute>();
        }
    }
}