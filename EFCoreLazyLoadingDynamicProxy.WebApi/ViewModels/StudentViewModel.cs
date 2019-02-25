using EFCoreLazyLoadingDynamicProxy.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLazyLoadingDynamicProxy.WebApi.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public TeacherDto Professor { get; set; }
    }
    public class TeacherDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
