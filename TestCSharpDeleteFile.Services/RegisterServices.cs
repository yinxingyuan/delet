using MetaShare.Common.Core.CommonService;

namespace TestCSharpDeleteFile.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}
		
		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}
		
		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(TestCSharpDeleteFile.Services.Interfaces.IOrganizationUnitService), new TestCSharpDeleteFile.Services.OrganizationUnitService(), isRegister);
		}
	}
}
