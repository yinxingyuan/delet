using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using TestCSharpDeleteFile.Entities;

namespace TestCSharpDeleteFile.Services.Interfaces
{
	public interface IOrganizationUnitService: IPagingService<TestCSharpDeleteFile.Entities.OrganizationUnit>
	{
	    List<TestCSharpDeleteFile.Entities.OrganizationUnit> SelectAllWithReferenceData(List<TestCSharpDeleteFile.Entities.OrganizationUnit> items);
	}
}
