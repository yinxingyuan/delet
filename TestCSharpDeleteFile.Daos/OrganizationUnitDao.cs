using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using TestCSharpDeleteFile.Daos.Interfaces;
using TestCSharpDeleteFile.Entities;

namespace TestCSharpDeleteFile.Daos
{
	public class OrganizationUnitDao:CommonObjectDao<TestCSharpDeleteFile.Entities.OrganizationUnit>,TestCSharpDeleteFile.Daos.Interfaces.IOrganizationUnitDao
	{
		public class OrganizationUnitSqlBuilder : ObjectSqlBuilder
		{
			public OrganizationUnitSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"OrganizationUnit")
			{
				this.SqlInsert = "INSERT INTO OrganizationUnit(" + this.SqlBaseFieldInsertFront + ") VALUES (" + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE OrganizationUnit SET " + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class OrganizationUnitResultHandler : CommonObjectResultHandler<TestCSharpDeleteFile.Entities.OrganizationUnit>
		{
			public override void GetColumnValues(IDataReader reader,OrganizationUnit item)
			{
				base.GetColumnValues(reader, item);
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, OrganizationUnit item)
			{
				base.AddInsertParameters(context, command, item);
			}
		}
		
		public OrganizationUnitDao(SqlDialect sqlDialect) : base(new OrganizationUnitSqlBuilder(sqlDialect), new OrganizationUnitResultHandler())
		{
		}
	}
}
