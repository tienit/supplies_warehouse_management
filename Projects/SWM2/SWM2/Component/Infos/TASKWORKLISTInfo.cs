//*************************************************************
//Author           : Tien NQ
//Created Date     : 10/26/2017
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using System;
using System.Data;

namespace VKTIM.Component
{

public partial class TASKWORKLISTInfo
{

#region "Private Members"
private int _ID;
private string _CODE;
private string _CONTENTS;
private string _CONTROL;
private DateTime _STARTDATE;
private DateTime _ENDDATE;
private int _STATUS;
private int _FINISHED;
private string _REMARKS;
        private int _REPEAT;
        private int _REPEAT_DAY;
        private int _REPEAT_WEEK;
        private int _REPEAT_MONTH;
        private int _REPEAT_YEAR;
        private int _REPEAT_HOUR;
        private TimeSpan _TIME_REMIND;
        private int _REMIND;
        private DateTime _TIME_SPAN_REMIND;
#endregion

        #region "Public Properties"
        public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string CODE {
			get { return _CODE; }
			set { _CODE = value; }
		}

		public string CONTENTS {
			get { return _CONTENTS; }
			set { _CONTENTS = value; }
		}

		public string CONTROL {
			get { return _CONTROL; }
			set { _CONTROL = value; }
		}

		public DateTime STARTDATE {
			get { return _STARTDATE; }
			set { _STARTDATE = value; }
		}

		public DateTime ENDDATE {
			get { return _ENDDATE; }
			set { _ENDDATE = value; }
		}

		public int STATUS {
			get { return _STATUS; }
			set { _STATUS = value; }
		}

		public int FINISHED {
			get { return _FINISHED; }
			set { _FINISHED = value; }
		}

		public string REMARKS {
			get { return _REMARKS; }
			set { _REMARKS = value; }
		}

        public int REPEAT
        {
            get { return _REPEAT; }
            set { _REPEAT = value; }
        }

        public int REPEAT_DAY
        {
            get { return _REPEAT_DAY; }
            set { _REPEAT_DAY = value; }
        }

        public int REPEAT_WEEK
        {
            get { return _REPEAT_WEEK; }
            set { _REPEAT_WEEK = value; }
        }

        public int REPEAT_MONTH
        {
            get { return _REPEAT_MONTH; }
            set { _REPEAT_MONTH = value; }
        }

        public int REPEAT_YEAR
        {
            get { return _REPEAT_YEAR; }
            set { _REPEAT_YEAR = value; }
        }

        public int REPEAT_HOUR
        {
            get { return _REPEAT_HOUR; }
            set { _REPEAT_HOUR = value; }
        }

        public TimeSpan TIME_REMIND
        {
            get { return _TIME_REMIND; }
            set { _TIME_REMIND = value; }
        }

        public int REMIND
        {
            get { return _REMIND; }
            set { _REMIND = value; }
        }

        public DateTime TIME_SPAN_REMIND
        {
            get { return _TIME_SPAN_REMIND; }
            set { _TIME_SPAN_REMIND = value; }
        }
        #endregion

        #region "Constructors"
        public TASKWORKLISTInfo()
{
}

public TASKWORKLISTInfo(int ID, string CODE, string CONTENTS, string CONTROL, DateTime STARTDATE, DateTime ENDDATE, int STATUS, int FINISHED, string REMARKS, int REPEAT, int REPEAT_DAY, int REPEAT_MONTH, int REPEAT_YEAR, int REPEAT_WEEK, int REPEAT_HOUR, TimeSpan TIME_REMIND, int REMIND, DateTime TIME_SPAN_REMIND)
{
	this.ID = ID;
	this.CODE = CODE;
	this.CONTENTS = CONTENTS;
	this.CONTROL = CONTROL;
	this.STARTDATE = STARTDATE;
	this.ENDDATE = ENDDATE;
	this.STATUS = STATUS;
	this.FINISHED = FINISHED;
	this.REMARKS = REMARKS;
            this.REPEAT = REPEAT;
            this.REPEAT_DAY = REPEAT_DAY;
            this.REPEAT_HOUR = REPEAT_HOUR;
            this.REPEAT_MONTH = REPEAT_MONTH;
            this.REPEAT_WEEK = REPEAT_WEEK;
            this.REPEAT_YEAR = REPEAT_YEAR;
            this.TIME_REMIND = TIME_REMIND;
            this.REMIND = REMIND;
            this.TIME_SPAN_REMIND = TIME_SPAN_REMIND;
}
#endregion

}

}