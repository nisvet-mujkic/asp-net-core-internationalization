using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.OData.Query.SemanticAst;
using Microsoft.Extensions.Localization;
using RequestLocalization.Enumerations;
using RequestLocalization.Models;

namespace RequestLocalization.Controllers
{
    public class EnumerationsController : Controller
    {
        private readonly IStringLocalizer<Gender> localizer;

        public EnumerationsController(IStringLocalizer<Gender> localizer)
        {
            this.localizer = localizer;
        }
        public IActionResult Genders()
        {
            List<Select> selectList = new List<Select>();

            Array values = Enum.GetValues(typeof(Gender));

            foreach (object value in values)
            {
                selectList.Add(new Select()
                {
                    Value = (int)value,
                    Name = localizer[value.ToString()]
                });
            }

            return Ok(selectList);
        }
    }
}