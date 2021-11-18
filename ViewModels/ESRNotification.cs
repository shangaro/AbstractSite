using AbstractSite.Enums;

namespace AbstractSite.ViewModels
{
    public class ESRNotification : BaseNotification<ESRViewModel>
    {
        public ESRNotification(NotificationState state) : base(state)
        {
        }

        public override ESRViewModel Finalize()
        {
            Sources();
            return _modelWrapper;
        }


        public void Sources()
        {
            _modelWrapper.Sources.Model.Sources = "Name";

        }

    }
    public class NewESRNotification : ESRNotification
    {
        public NewESRNotification() : base(NotificationState.NEW)
        {
        }
        public override void Name()
        {
            _modelWrapper.NameElement.Model.Name = "new ESR Name";
        }
    }
    public class EditESRNotification : ESRNotification
    {
        public EditESRNotification() : base(NotificationState.EDIT)
        {
        }
        public override void Name()
        {
            _modelWrapper.NameElement.Model.Name = "Edit ESR Name";
        }
    }
    public class ViewESRNotification : ESRNotification
    {
        public ViewESRNotification() : base(NotificationState.VIEW)
        {
        }
        public override void Name()
        {
            _modelWrapper.NameElement.Model.Name = "View ESR Name";
        }
    }   
}