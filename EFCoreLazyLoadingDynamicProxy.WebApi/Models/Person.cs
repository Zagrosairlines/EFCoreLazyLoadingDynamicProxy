namespace EFCoreLazyLoadingDynamicProxy.WebApi.Models
{
    public class Person : IBaseEntity
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
    }
}