using System;
using MetaShare.Common.Core.Daos;

namespace TestCSharpDeleteFile.Daos
{
	public class RegisterDaos
	{
		public static void RegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, true,sqlDialect,sqlDialectVersion);
		}
		
		public static void UnRegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, false,sqlDialect,sqlDialectVersion);
		}
		
		public static void Register(DaoFactory factory, bool isRegister, Type sqlDialect, Type sqlDialectVersion)
		{
			factory.Register(typeof(TestCSharpDeleteFile.Daos.Interfaces.IOrganizationUnitDao), new TestCSharpDeleteFile.Daos.OrganizationUnitDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
		}
	}
}
