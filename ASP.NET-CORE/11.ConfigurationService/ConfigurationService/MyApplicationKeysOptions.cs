using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationService
{
    public class MyApplicationKeysOptions
    {
        public string SMTPServer { get; set; }
        public string AzureSQLServerURL { get; set; }
        public string EmployeePhotoUploadPath { get; set; }
    }
}
