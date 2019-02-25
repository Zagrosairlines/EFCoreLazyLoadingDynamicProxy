using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreLazyLoadingDynamicProxy.App
{
    class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<Person> Students { get; set; }
    }
}
