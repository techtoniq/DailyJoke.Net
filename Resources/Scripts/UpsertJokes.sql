CREATE TABLE #TempJokes
(
	[Id] BIGINT,
	[Text] NVARCHAR(250)
)
 
INSERT INTO #TempJokes (Id, Text)
VALUES
(1,'I got a pair of mittens as my Secret Santa present at work. I think I know who they''re from, but I don''t want to point any fingers.')

SET IDENTITY_INSERT [dbo].[Jokes] ON;

MERGE [dbo].[Jokes] AS Target
USING #TempJokes AS Source
ON Source.Id = Target.Id
WHEN MATCHED THEN UPDATE SET
	Target.Text = Source.Text

WHEN NOT MATCHED By Target THEN
	INSERT (Id, Text, UsageCount) 
	VALUES (Source.Id, Source.Text, 0);

SET IDENTITY_INSERT [dbo].[Jokes] OFF;
DROP TABLE #TempJokes