create database ProfileSocialMedia

select * from profileData
select * from community
select * from loginData


INSERT INTO community (name)
SELECT DISTINCT userName
FROM loginData;


DECLARE @ImageData VARBINARY(MAX);
SELECT @ImageData = BulkColumn FROM OPENROWSET(BULK N'C:\icons\pic.png', SINGLE_BLOB) AS x;
UPDATE profileData	 
SET picture = @ImageData;


alter table profileData
add picture VARBINARY(MAX)
select * from community
alter table profileData 
add userName varchar(255);

update loginData 
set userName='user3'
where userName='test3'


alter table profileData
EXEC sp_rename 'user1', 'profileData';
select *from profileData

insert into profile 

select * from loginData

alter table loginData 
add fullName varchar(100);

delete from loginData
where userName='test3'

ALTER table loginData 
add picture varbinary (max);


SELECT name FROM community WHERE name !='user2' and name!=(SELECT followingName FROM profileData WHERE userName = 'user2') 

SELECT name 
FROM community 
WHERE name != 'user2' 
AND name != (
    SELECT TOP 1 followingName 
    FROM profileData 
    WHERE userName = 'user2'
)
