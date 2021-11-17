using AbstractSite.Enums;

namespace AbstractSite.ViewModels
{
    public class ESRNotification : BaseNotification<ESRViewModel>
    {

        public ESRNotification(NotificationState state) : base(state)
        {
        }

        public override void Description()
        {
            base.Description();
        }

        public override void Email()
        {
            base.Email();
        }

        public override ESRViewModel Finalize()
        {
            Sources();
            return _modelWrapper;
        }

        public override void Name()
        {
            base.Name();
        }

        public void Sources()
        {
            _modelWrapper.Sources.Model.Sources = "Name";

        }

    }
}