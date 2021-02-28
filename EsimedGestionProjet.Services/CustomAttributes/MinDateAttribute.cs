using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsimedGestionProjet.Services.CustomAttributes
{
    public class MinDateAttribute : RangeAttribute
    {
        public MinDateAttribute()
            : base(typeof(DateTime), DateTime.Now.ToString(), DateTime.Now.AddYears(100).ToString())
        {
            this.ErrorMessage = "La date de fin previsionelle doit etre superieur a la date d'aujourd'hui";
        }
    }
}
