1.
���������ݿ�,�����нű�

CREATE TABLE [dbo].[t_AttendanceWebData](
	[LogDate] [datetime] NOT NULL,
	[LogTime] [datetime] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[ExternalRef] [nvarchar](100) NULL,
	[InterfaceID] [int] NULL,
	[AttendanceInterfaceCenterID] [int] NULL,
	[RemoteIdent] [int] NULL,
	[StaffName] [nvarchar](200) NULL,
	[StaffNumber] [nvarchar](50) NOT NULL,
	[DeviceID] [nvarchar](50) NULL,
	[DeviceName] [nvarchar](100) NULL,
	[Zone] [nvarchar](100) NULL,
	[Department] [nvarchar](100) NULL,
	[OTMinute] [int] NULL,
	[LateMinute] [int] NULL,
	[EarlyLeaveMinute] [int] NULL,
	[PairNo] [int] NULL,
	[ImportID] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateUser] [int] NULL,
	[GpsLocation] [nvarchar](200) NULL,
	[GpsLocationName] [nvarchar](200) NULL,
	[PositionID] [int] NULL
) ON [PRIMARY]

2.������վ��webconfig��2�����ݿ�
1.��һ�����������ݿ�.(Ҳ��������Ϊhrdb)
2.hrdb