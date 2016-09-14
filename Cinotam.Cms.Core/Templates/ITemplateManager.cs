﻿using Abp.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinotam.Cms.Core.Templates
{
    public interface ITemplateManager : IDomainService
    {
        Task<string> GetTemplateContentAsync(string templateName);
        Task<List<string>> GetAvailableTemplatesAsync();
    }
}