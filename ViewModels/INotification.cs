namespace AbstractSite.ViewModels
{
 
    public interface INotification<out TModel> where TModel : BaseViewModel,new ()
 
    {
        TModel Finalize();

    }
    
}
