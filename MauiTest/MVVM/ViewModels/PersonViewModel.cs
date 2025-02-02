using MauiTest.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Person = new Person
            {
                Age = 55,
                Name = "Omar",
                BirthDate = new DateTime(1936, 3, 13),
                IsMarried = true,
                LunchTime = new TimeSpan(10, 0, 0),
                Weight = 65
            };
        }

        public Person Person { get; set; }
    }
}