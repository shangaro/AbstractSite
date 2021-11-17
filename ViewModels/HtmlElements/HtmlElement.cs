using System;
using System.Linq.Expressions;
using System.Reflection;
using AbstractSite.Enums;

namespace AbstractSite.ViewModels.HtmlElements
{
    public class HtmlElement<T> where T : class, new()
    {
        public T Model { get; set; }
        public string ViewName { get; set; }
        public HtmlAttribute HtmlAttribute { get; set; }
        public HtmlElement()
        {
            Model = new T();
            HtmlAttribute = new HtmlAttribute();
        }


    }
    // create a modelbuilder for the html element

}