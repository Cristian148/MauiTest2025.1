using MauiTest.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.MVVM.ViewModels
{
    public class PeopleViewModels
    {
        public PeopleViewModels()
        {
            People2 = new()
            {
                new Person {
                        Age= 48,
                        BirthDate = new DateTime(1977,01/10),
                        IsMarried = false,
                        LunchTime = new TimeSpan(12,30,0),
                        Name="Cristian",
                        Weight=57 },
                new Person {
                        Age= 89,
                        BirthDate = new DateTime(1936,04/13),
                        IsMarried = true ,
                        LunchTime = new TimeSpan(12,30,0),
                        Name="Omar",
                        Weight=75 },
                new Person {
                        Age= 50,
                        BirthDate = new DateTime(1975,04/13),
                        IsMarried = false,
                        LunchTime = new TimeSpan(12,30,0),
                        Name="Ale",
                        Weight=78 },
            };
        }

        public List<Person> People2 { get; set; }
    }
}