using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace model_binding_attributes.Models
{
    public class Person
    {
        //[BindNever]
        public int id { get; set; }
        [BindRequired]
        public string? name { get; set; }
        public string? family { get; set; }
        [BindRequired]
        public int age { get; set; }
    }
}
