--DbType = CARETRACKER
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'Facility_InsertTrigger')
	DROP TRIGGER dbo.Facility_InsertTrigger

INCLUDE Test.TestSqlBad