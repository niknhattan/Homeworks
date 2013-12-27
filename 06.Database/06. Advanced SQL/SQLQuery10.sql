/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [UserID]
      ,[UserName]
      ,[Pwd]
      ,[FullName]
      ,[LastLoginTime]
      ,gr.Name
  FROM Users AS usr 
	   LEFT OUTER JOIN Groups AS gr 
	   ON usr.GroupID = gr.GroupId