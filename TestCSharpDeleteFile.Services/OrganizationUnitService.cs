using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using TestCSharpDeleteFile.Entities;
using TestCSharpDeleteFile.Services.Interfaces;
using TestCSharpDeleteFile.Daos.Interfaces;

namespace TestCSharpDeleteFile.Services
{
	public class OrganizationUnitService:Service<TestCSharpDeleteFile.Entities.OrganizationUnit>,IOrganizationUnitService
	{
		public OrganizationUnitService() : base(typeof(IOrganizationUnitDao))
		{
		}
		
		public List<OrganizationUnit> SelectAllWithReferenceData(List<OrganizationUnit> items)        {            if (items != null && items.Count > 0)            {                 return this.SelectBy(items, this.CreateReferenceInfoAggregation());            }                return items;        }
		
		private ServiceAggregationInfo CreateReferenceInfoAggregation()
		{
		    ServiceAggregationInfo aggregation = ServiceAggregationInfo.CreateRoot(typeof(TestCSharpDeleteFile.Entities.OrganizationUnit),typeof(TestCSharpDeleteFile.Daos.Interfaces.IOrganizationUnitDao));
		
		    return aggregation;
		}
	}
}
