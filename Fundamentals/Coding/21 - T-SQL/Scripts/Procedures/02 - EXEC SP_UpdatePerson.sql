EXEC SP_UpdatePerson 
    @PersonID = 1, -- The ID of the person you want to update
    @FirstName = 'Ali',
    @LastName = 'Ahmed',
    @Email = 'Ali@example.com';

select * from People where PersonID=1;