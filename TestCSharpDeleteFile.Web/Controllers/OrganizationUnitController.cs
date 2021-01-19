using System.Collections.Generic;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Web.Utilities.Mvc.Foundation;

namespace TestCSharpDeleteFile.Web.Controllers
{
	public class OrganizationUnitController: CommonController<TestCSharpDeleteFile.Entities.OrganizationUnit,TestCSharpDeleteFile.Services.Interfaces.IOrganizationUnitService,TestCSharpDeleteFile.Web.Models.OrganizationUnitModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "OrganizationUnit";
		}
		
		protected override List<TestCSharpDeleteFile.Entities.OrganizationUnit> GetPagerData(Pager pager)
		{
			return this.Service.SelectAllWithReferenceData(this.Service.SelectAll(pager));
		}
		
		protected override List<TestCSharpDeleteFile.Entities.OrganizationUnit> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<TestCSharpDeleteFile.Entities.OrganizationUnit> lists = this.Service.SelectBy(pagerSearchModel.Pager,new TestCSharpDeleteFile.Entities.OrganizationUnit { Name = pagerSearchModel.Name }, OrganizationUnit => OrganizationUnit.Name.Contains(pagerSearchModel.Name));
			return this.Service.SelectAllWithReferenceData(lists);
		}
		
		protected override TestCSharpDeleteFile.Entities.OrganizationUnit GetEntity(int id)
		{
			return this.Service.SelectById(new TestCSharpDeleteFile.Entities.OrganizationUnit { Id = id }, true);
		}
		
		protected override void LoadViewReferenceData(TestCSharpDeleteFile.Web.Models.OrganizationUnitModel model)
		{
			if (model == null) return;
			base.LoadViewReferenceData(model);
			
		}
	}
}
