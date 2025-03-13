using CustomAttributeExample;
using System;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main()
    {
        UserActions actions = new UserActions();
        ExecuteMethodWithPermissionCheck(actions, "DeleteUser", isAdmin: false); // Make the obj as Non-admin
        ExecuteMethodWithPermissionCheck(actions, "DeleteUser", isAdmin: true);  // Admin
    }

    static void ExecuteMethodWithPermissionCheck(object obj, string methodName, bool isAdmin)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);
        var attribute = (IsAdminAttribute)method.GetCustomAttributes(typeof(IsAdminAttribute), false).FirstOrDefault();

        if (attribute != null && attribute.IsAdmin != isAdmin)
        {
            Console.WriteLine("Access Denied! Admin privileges required.");
            return;
        }

        method.Invoke(obj, null);
    }
}
