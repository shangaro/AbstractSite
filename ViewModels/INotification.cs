namespace AbstractSite.ViewModels
{
    public interface INotification<TModel> where TModel : BaseViewModel,new ()
    {
        void Description();
        void Email();
        void Name();
        
    }
    
}
