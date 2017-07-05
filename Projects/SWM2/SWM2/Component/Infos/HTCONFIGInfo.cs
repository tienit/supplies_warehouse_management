using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VKTIM.Component
{
    public partial class HTCONFIGInfo
    {
        private int _ID;
        private string _CONFIG_CODE;
        private string _CONFIG_NAME;
        private string _CONFIG_VALUE;
        private string _CONFIG_DESCRIPTION;

        public HTCONFIGInfo(int ID, string CONFIG_CODE, string CONFIG_NAME, string CONFIG_VALUE, string CONFIG_DESCRIPTION)
        {
            this.ID = ID;
            this.CONFIG_CODE = CONFIG_CODE;
            this.CONFIG_NAME = CONFIG_NAME;
            this.CONFIG_VALUE = CONFIG_VALUE;
            this.CONFIG_DESCRIPTION = CONFIG_DESCRIPTION;
        }

        public int ID { get => _ID; set => _ID = value; }
        public string CONFIG_CODE { get => _CONFIG_CODE; set => _CONFIG_CODE = value; }
        public string CONFIG_NAME { get => _CONFIG_NAME; set => _CONFIG_NAME = value; }
        public string CONFIG_VALUE { get => _CONFIG_VALUE; set => _CONFIG_VALUE = value; }
        public string CONFIG_DESCRIPTION { get => _CONFIG_DESCRIPTION; set => _CONFIG_DESCRIPTION = value; }
    }
}
