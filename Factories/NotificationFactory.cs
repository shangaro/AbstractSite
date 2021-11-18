using System;
using AbstractSite.Enums;
using AbstractSite.ViewModels;

namespace AbstractSite.Factories
{
    public class NotificationFactory
    {
        public static INotification<BaseViewModel> Create(NotificationState state,NotificationType type)
        {
            switch (state, type)
            {
                case (NotificationState.NEW, NotificationType.REVIEW):
                    return new NewReviewNotification();
                case (NotificationState.EDIT, NotificationType.REVIEW):
                    return new EditReviewNotification();
                case (NotificationState.VIEW, NotificationType.REVIEW):
                    return new ViewReviewNotification();
                case (NotificationState.NEW,NotificationType.ESR):
                    return new NewESRNotification();
                case (NotificationState.EDIT, NotificationType.ESR):
                    return new EditESRNotification();
                case (NotificationState.VIEW, NotificationType.ESR):
                    return new ViewESRNotification();
                default:
                    throw new InvalidOperationException("Notification type and state not found");
            }
           
        }
    }
}
