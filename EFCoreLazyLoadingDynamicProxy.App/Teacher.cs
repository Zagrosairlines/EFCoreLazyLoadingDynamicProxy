﻿using System.Collections.Generic;

namespace EFCoreLazyLoadingDynamicProxy.App
{
    public class Teacher
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}