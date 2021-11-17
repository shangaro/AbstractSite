using System;
using System.Linq.Expressions;
using AbstractSite.Enums;
using AbstractSite.Strategies;

namespace AbstractSite.ViewModels
{

    // create a generic class that takes HtmlElement<T> as a parameter
    // and implements the IHtmlElement interface
    public abstract class BaseNotification<TModel> : INotification<TModel> where TModel : BaseViewModel, new()

    {
        protected TModel _modelWrapper;
        private readonly StateBehavior<TModel> _stateBehavior;
        public BaseNotification(NotificationState state)
        {
            _modelWrapper = new TModel();
            _stateBehavior = new StateBehavior<TModel>(_modelWrapper);
            _stateBehavior.Apply(state);
            Prepare();
        }

        public void Prepare()
        {
            Description();
            Email();
            Name();
        }
        public virtual void Description()
        {
            _modelWrapper.DescriptionElem.Model.Description = "Description";

        }
        public abstract TModel Finalize();


        public virtual void Email()
        {
            _modelWrapper.EmailElem.Model.Email = "Email";
        }

        public virtual void Name()
        {
            _modelWrapper.NameElement.Model.Name = "Name";
        }



    }

}
