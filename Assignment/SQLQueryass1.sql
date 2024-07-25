use infinite

CREATE  FUNCTION COUNT_MALE_EMPLOYEES(@gender char)
RETURN char
as
    
BEGIN
    RETURN (select count(*) total_male from tblemployees where @gender = 'male')
END 
select gender as 'Employee male' dbo.COUNT_MALE_EMPLOYEES(Gender) from tblemployees




-- Create the function to count male employees
CREATE FUNCTION GetTotalMaleEmployees()
RETURNS INT
AS
BEGIN
    -- Calculate the count of male employees and return directly
    RETURN (
        SELECT COUNT(*)
        FROM Employees
        WHERE Gender = 'M'  -- Assuming 'Gender' column stores gender information
    );
END;


 
