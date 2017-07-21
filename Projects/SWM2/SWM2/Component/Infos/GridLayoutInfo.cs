using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VKTIM.Common;

namespace VKTIM.Component.Infos
{
    public class GridLayoutInfo
    {
        private string _FILE_NAME;  //UNIT_NAME
        private GIRD_COLUMN_TYPE _TYPE; //Grid column type (CheckBox, TextBox, v.v...)

        public GridLayoutInfo()
        {
        }

        public GridLayoutInfo(string FILE_NAME, GIRD_COLUMN_TYPE TYPE)
        {
            this.FILE_NAME = FILE_NAME;
            this.TYPE = TYPE;
        }

        public string FILE_NAME { get => _FILE_NAME; set => _FILE_NAME = value; }
        public GIRD_COLUMN_TYPE TYPE { get => _TYPE; set => _TYPE = value; }
    }
}
