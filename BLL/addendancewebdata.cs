using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Model
{
    //goodsMaster
    public class t_AttendanceWebData
    {
        private DateTime _logdate;
        public DateTime LogDate
        {
            get { return _logdate; }
            set { _logdate = value; }
        }

        private DateTime _logtime;
        public DateTime LogTime
        {
            get { return _logtime; }
            set { _logtime = value; }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _externalref;
        public string ExternalRef
        {
            get { return _externalref; }
            set { _externalref = value; }
        }

        private int _interfaceid;
        public int InterfaceID
        {
            get { return _interfaceid; }
            set { _interfaceid = value; }
        }

        private int _attendanceinterfacecenterid;
        public int AttendanceInterfaceCenterID
        {
            get { return _attendanceinterfacecenterid; }
            set { _attendanceinterfacecenterid = value; }
        }

        private int _remoteident;
        public int RemoteIdent
        {
            get { return _remoteident; }
            set { _remoteident = value; }
        }

        private string _staffname;
        public string StaffName
        {
            get { return _staffname; }
            set { _staffname = value; }
        }

        private string _staffnumber;
        public string StaffNumber
        {
            get { return _staffnumber; }
            set { _staffnumber = value; }
        }

        private string _deviceid;
        public string DeviceID
        {
            get { return _deviceid; }
            set { _deviceid = value; }
        }

        private string _devicename;
        public string DeviceName
        {
            get { return _devicename; }
            set { _devicename = value; }
        }

        private string _zone;
        public string Zone
        {
            get { return _zone; }
            set { _zone = value; }
        }

        private string _department;
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        private int _otminute;
        public int OTMinute
        {
            get { return _otminute; }
            set { _otminute = value; }
        }

        private int _lateminute;
        public int LateMinute
        {
            get { return _lateminute; }
            set { _lateminute = value; }
        }

        private int _earlyleaveminute;
        public int EarlyLeaveMinute
        {
            get { return _earlyleaveminute; }
            set { _earlyleaveminute = value; }
        }

        private int _pairno;
        public int PairNo
        {
            get { return _pairno; }
            set { _pairno = value; }
        }

        private int _importid;
        public int ImportID
        {
            get { return _importid; }
            set { _importid = value; }
        }

        private DateTime _createdate = new DateTime(1900, 1, 1);
        public DateTime CreateDate
        {
            get { return _createdate; }
            set { _createdate = value; }
        }

        private int _createuser;
        public int CreateUser
        {
            get { return _createuser; }
            set { _createuser = value; }
        }

        private string _gpslocation;
        public string GpsLocation
        {
            get { return _gpslocation; }
            set { _gpslocation = value; }
        }

        private string _gpslocationname;
        public string GpsLocationName
        {
            get { return _gpslocationname; }
            set { _gpslocationname = value; }
        }

        private int _positionid;
        public int PositionID
        {
            get { return _positionid; }
            set { _positionid = value; }
        }

    }
}