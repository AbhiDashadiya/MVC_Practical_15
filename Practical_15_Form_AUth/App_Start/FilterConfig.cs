using System.Web;
using System.Web.Mvc;

namespace Practical_15_Form_AUth
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
