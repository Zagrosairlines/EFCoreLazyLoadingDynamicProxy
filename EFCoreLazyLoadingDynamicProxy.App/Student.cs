namespace EFCoreLazyLoadingDynamicProxy.App
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public virtual Teacher LeaderProfessor { get; set; }
    }
}