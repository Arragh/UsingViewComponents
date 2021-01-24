using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingViewComponents.Models;

namespace UsingViewComponents.Components
{
    public class CitySummary : ViewComponent
    {
        private ICityRepository repository;
        public CitySummary(ICityRepository repository)
        {
            this.repository = repository;
        }

        //public string Invoke() => $"{repository.Cities.Count()} cities, {repository.Cities.Sum(c => c.Population)} people";
        public IViewComponentResult Invoke() => View(new CityViewModel { Cities = repository.Cities.Count(), Population = repository.Cities.Sum(c => c.Population) });
    }
}
