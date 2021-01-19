using System.Web.Mvc;


namespace TestCSharpDeleteFile.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
       {
            filters.Add(new HandleErrorAttribute());
       }
    }
}
