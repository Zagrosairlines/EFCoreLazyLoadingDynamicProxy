namespace EFCoreLazyLoadingDynamicProxy.WebApi.Models
{
    public interface IHaveIntId
    {
        int Id { get; set; }
    }
    public interface IHaveLongId
    {
        long Id { get; set; }
    }
}