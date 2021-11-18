using System.Collections.Generic;
using AbstractSite.Enums;
using AbstractSite.ViewModels.HtmlElements;

namespace AbstractSite.ViewModels
{
    public class ReviewNotification : BaseNotification<RNViewModel>
    {
        public ReviewNotification(NotificationState state) : base(state)
        {
        }


        public void Frequency()
        {
            _modelWrapper.FrequencyElem.Model.Frequency = "Review Frequency";
            _modelWrapper.FrequencyElem.HtmlAttributes = new List<HtmlAttribute>{new HtmlAttribute(value:"0", text:"Daily"),
                                                                                new HtmlAttribute(value:"1", text:"Weekly"),
                                                                                new HtmlAttribute(value:"2", text:"Monthly")};

        }
        public override RNViewModel Finalize()
        {
            Frequency();
            return _modelWrapper;
        }
    }

    public class NewReviewNotification : ReviewNotification
    {
        public NewReviewNotification() : base(NotificationState.NEW)
        {
            
        }
        public override void Name()
        {
            _modelWrapper.NameElement.Model.Name = "New Review Name";
            
        }
    }
    public class EditReviewNotification : ReviewNotification
    {
        public EditReviewNotification() : base(NotificationState.EDIT)
        {
        }
        public override void Name()
        {
            _modelWrapper.NameElement.Model.Name = "Edit Review Name";
        }
    }
    public class ViewReviewNotification : ReviewNotification
    {
        public ViewReviewNotification() : base(NotificationState.VIEW)
        {
        }
        public override void Name()
        {
            _modelWrapper.NameElement.Model.Name = "View Review Name";
        }
    }
}
