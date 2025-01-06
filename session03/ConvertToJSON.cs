using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session03
{
    internal class ConvertToJSON
    {
        public string Execute(object obj)
        {
            var WhatsType = obj.GetType();
            string Res = "{";
            foreach (var x in WhatsType.GetProperties())
            {
                Res += $"{x.Name}";
            }
            return Res + "}"; 
        }
    }
}
