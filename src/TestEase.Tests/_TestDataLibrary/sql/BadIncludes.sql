--DbType = CARETRACKER

Insert into dbo.Cat (Cat_Table,Cat_Text,Cat_Text2,Facility_Id)
Values ('SeriesCategory','{catText}','Charting.gif', {facilityId})

select SCOPE_IDENTITY() [Cat_Recnum];

