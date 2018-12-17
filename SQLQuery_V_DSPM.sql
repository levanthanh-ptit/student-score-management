SELECT DISTINCT PUBS.description, SUBS.subscriber_server
FROM dbo.sysmergepublications AS PUBS INNER JOIN dbo.sysmergesubscriptions AS SUBS 
ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server