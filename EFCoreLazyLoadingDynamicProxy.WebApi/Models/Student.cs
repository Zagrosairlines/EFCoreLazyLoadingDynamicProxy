using System;
using System.Runtime.Serialization;

namespace EFCoreLazyLoadingDynamicProxy.WebApi.Models
{
    [Serializable]
    public class Student /*: IHaveIntId, IHaveName*/
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [IgnoreDataMember]
        public int TeacherId { get; set; }
        public Teacher LeaderProfessor { get; set; }
    }
}