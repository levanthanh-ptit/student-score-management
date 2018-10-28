SELECT * FROM [QLDSV].dbo.sysmergepublications
SELECT * FROM [QLDSV].dbo.sysmergesubscriptions

--Sever selection in Login form--
SELECT description, subscriber_server FROM (SELECT description, pubid FROM [QLDSV].dbo.sysmergepublications) AS Publisher 
INNER JOIN (SELECT subscriber_server, pubid FROM [QLDSV].dbo.sysmergesubscriptions  WHERE subscriber_server LIKE '%\%') AS Subscriber 
ON Publisher.pubid = Subscriber.pubid
--Sever selection in Login form--