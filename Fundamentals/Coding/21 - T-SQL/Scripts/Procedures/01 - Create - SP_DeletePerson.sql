--DELETE: Remove a Person
CREATE PROCEDURE SP_DeletePerson
    @PersonID INT
AS
BEGIN
    DELETE FROM People WHERE PersonID = @PersonID
END