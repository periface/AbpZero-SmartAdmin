﻿namespace Cinotam.Cms.FileSystemTemplateProvider.Provider.JsonEntities
{
    public class JsonConfigurarion
    {
        public string TemplateName { get; set; }
        public string FileType { get; set; }
        public bool IsPartial { get; set; }
        public string TemplateFullName { get; set; }
        public bool OverrideFolder { get; set; }
        public string DisplayName { get; set; }
        public ExternalResources ExternalResources { get; set; }
    }

    public class ExternalResources
    {
        public string[] Css { get; set; }
        public string[] Js { get; set; }
    }
}