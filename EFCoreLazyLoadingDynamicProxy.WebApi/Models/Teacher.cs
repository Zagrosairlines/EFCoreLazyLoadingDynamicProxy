using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EFCoreLazyLoadingDynamicProxy.WebApi.Models
{
    [Serializable]
    public class Teacher //: IHaveIntId, IHaveName
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [IgnoreDataMember]
        public ICollection<Student> Students { get; set; }
    }
}