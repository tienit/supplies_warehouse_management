using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VKTIM.Component
{
    public partial class DTDEVICESInfo
    {
        private int _ID;
        private string _NAME;
        private string _IPv4;
        private string _IPv6;
        private int _ORGANIZATION_ID;
        private string _ORGANIZATION_NAME;
        private bool _LOCKED;
        private string _REMARK;

        public DTDEVICESInfo(int ID, string NAME, string IPv4, string IPv6, int ORGANIZATION_ID, string ORGANIZATION_NAME, bool LOCKED, string REMARK)
        {
            this.ID = ID;
            this.NAME = NAME;
            this.IPv4 = IPv4;
            this.IPv6 = IPv6;
            this.ORGANIZATION_ID = ORGANIZATION_ID;
            this.ORGANIZATION_NAME = ORGANIZATION_NAME;
            this.LOCKED = LOCKED;
            this.REMARK = REMARK;
        }

        public int ID { get => _ID; set => _ID = value; }
        public string NAME { get => _NAME; set => _NAME = value; }
        public string IPv4 { get => _IPv4; set => _IPv4 = value; }
        public string IPv6 { get => _IPv6; set => _IPv6 = value; }
        public int ORGANIZATION_ID { get => _ORGANIZATION_ID; set => _ORGANIZATION_ID = value; }
        public string ORGANIZATION_NAME { get => _ORGANIZATION_NAME; set => _ORGANIZATION_NAME = value; }
        public bool LOCKED { get => _LOCKED; set => _LOCKED = value; }
        public string REMARK { get => _REMARK; set => _REMARK = value; }
    }
}
