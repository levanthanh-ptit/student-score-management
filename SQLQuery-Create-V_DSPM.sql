CREATE view V_DSPM 
AS
SELECT DISTINCT description, subscriber_server FROM (SELECT description, pubid FROM [QLDSV].dbo.sysmergepublications) AS Publisher 
INNER JOIN (SELECT subscriber_server, pubid FROM [QLDSV].dbo.sysmergesubscriptions  WHERE subscriber_server LIKE '%\%') AS Subscriber 
ON Publisher.pubid = Subscriber.pubid