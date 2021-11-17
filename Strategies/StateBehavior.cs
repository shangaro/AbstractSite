using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AbstractSite.Enums;
using AbstractSite.ViewModels;
using AbstractSite.ViewModels.HtmlElements;

namespace AbstractSite.Strategies
{
    public class StateBehavior<T> where T : BaseViewModel, new()
    {
        public StateBehavior(T model)
        {
            Model = model;
        }

        public T Model { get; }

        public void Apply(NotificationState state)
        {
            switch (state)
            {
                case NotificationState.VIEW:
                    Model.DescriptionElem.HtmlAttribute.Set(x => x.Disabled, "disabled")
                        .Set(x => x.Hidden, "hidden")
                        .Set(x => x.Readonly, "readonly");
                    Model.NameElement.HtmlAttribute.Set(x => x.Disabled, "disabled")
                        .Set(x => x.Hidden, "hidden")
                        .Set(x => x.Readonly, "readonly");
                    Model.EmailElem.HtmlAttribute.Set(x => x.Disabled, "disabled")
                        .Set(x => x.Hidden, "hidden")
                        .Set(x => x.Readonly, "readonly");

                    break;


            }
        }
    }

}