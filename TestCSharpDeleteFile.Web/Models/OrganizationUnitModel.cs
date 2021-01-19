using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Utilities.Mvc.Foundation;

namespace TestCSharpDeleteFile.Web.Models
{
	public class OrganizationUnitModel: CommonModel<TestCSharpDeleteFile.Entities.OrganizationUnit>
	{
		
		public override void PopulateFrom(TestCSharpDeleteFile.Entities.OrganizationUnit entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
		}
		
		public override void PopulateTo(TestCSharpDeleteFile.Entities.OrganizationUnit entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
		}
	}
}
