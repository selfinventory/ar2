﻿using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;
using GrapeCity.ActiveReports.Aspnetcore.Designer;
using WebDesigner_CustomSharedDataSources.Datasets;
using System.Linq;

namespace WebDesigner_CustomSharedDataSources.Implementation
{
	public class CustomDataSetTemplates : IDataSetsService
	{
		public DataSetTemplate GetDataSet(string id)
		{
			CustomDataSetTemplatesStore.Items.TryGetValue(id, out DataSetTemplate dataSet);
			return dataSet;
		}

		public DataSetTemplateInfo[] GetDataSetsList()
		{
			return CustomDataSetTemplatesStore.Items
				.Select(i => new DataSetTemplateInfo
				{
					Id = i.Key,
					Name = i.Key
				})
				.ToArray();
		}
	}
}