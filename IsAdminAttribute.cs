using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeExample 
{
    [AttributeUsage(AttributeTargets.Method)]
    class IsAdminAttribute : Attribute
    {
        public bool IsAdmin { get; }

        public IsAdminAttribute(bool isAdmin)
        {
            IsAdmin = isAdmin;
        }
    }
}
