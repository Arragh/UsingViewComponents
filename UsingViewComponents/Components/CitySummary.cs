using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
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
        //public IViewComponentResult Invoke() => View(new CityViewModel { Cities = repository.Cities.Count(), Population = repository.Cities.Sum(c => c.Population) });
        //public IViewComponentResult Invoke() => new HtmlContentViewComponentResult(new HtmlString("This is a <h3><i>string</i></h3>"));
        public IViewComponentResult Invoke(bool showList)
        {
            if (showList)
            {
                return View("CityList", repository.Cities);
            }
            else
            {
                return View(new CityViewModel { Cities = repository.Cities.Count(), Population = repository.Cities.Sum(c => c.Population) });
            }
        }
    }
}
