﻿using Cinotam.Cms.DatabaseEntities.Templates.Entities;
using Cinotam.Cms.DatabaseTemplateProvider.Provider;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Cinotam.AbpModuleZero.Tests.TemplateDataBaseProvider
{
    public class TemplateDatabaseProvider_Tests : AbpModuleZeroTestBase
    {
        private readonly IDatabaseTemplateProvider _templateContentProvider;

        public TemplateDatabaseProvider_Tests()
        {
            _templateContentProvider = Resolve<IDatabaseTemplateProvider>();
        }

        [Fact]

        public async Task TestDatabaseTemplateProvider()
        {
            var template = new Template()
            {
                Content = "Content",
                Name = "TestTemplate",

            };
            await _templateContentProvider.CreateEditTemplate(template);

            template.Id.ShouldNotBe(0);

        }
    }
}