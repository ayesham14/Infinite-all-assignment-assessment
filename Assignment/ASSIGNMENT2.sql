create database assgn2

CREATE TABLE EMP (
  EMPNO INT,
  ENAME VARCHAR(255),
  JOB VARCHAR(255),
  MGR_ID INT,
  HIREDATE DATE,
  SAL DECIMAL(10, 2),
  COMM DECIMAL(10, 2),
  DEPTNO INT
);

CREATE TABLE DEPT (
  DEPTNO INT,
  DNAME VARCHAR(255),
  LOC VARCHAR(255)
);

-- Insert data into the EMP and DEPT tables
INSERT INTO EMP (EMPNO, ENAME, JOB, MGR_ID, HIREDATE, SAL, COMM, DEPTNO)
VALUES
  (7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800.00, 0.00, 20),
  (7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600.00, 300.00, 30),
  (7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250.00, 500.00, 30),
  (7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975.00, 0.00, 20),
  (7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250.00, 1400.00, 30),
  (7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850.00, 0.00, 30),
  (7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450.00, 0.00, 10),
  (7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000.00, 0.00, 20),
  (7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000.00, 0.00, 10),
  (7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500.00, 0.00, 30),
  (7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100.00, 0.00, 20),
  (7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950.00, 0.00, 30),
  (7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000.00, 0.00, 20),
  (7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300.00, 0.00, 10);

INSERT INTO DEPT (DEPTNO, DNAME, LOC)
VALUES
  (10, 'ACCOUNTING', 'NEW YORK'),
  (20, 'RESEARCH', 'DALLAS'),
  (30, 'SALES', 'CHICAGO'),
  (40, 'OPERATIONS', 'BOSTON');

-- Task 1: List all employees whose name begins with 'A'
SELECT * FROM EMP WHERE ENAME LIKE 'A%';

-- Task 2: Select all those employees who don't have a manager
SELECT * FROM EMP WHERE MGR_ID IS NULL;

-- Task 3: List employee name, number, and salary for those employees who earn in the range 1200 to 1400
SELECT ENAME, EMPNO, SAL FROM EMP WHERE SAL BETWEEN 1200.00 AND 1400.00;

-- Task 4: Give all the employees in the RESEARCH department a 10% pay rise
SELECT * FROM EMP WHERE DEPTNO = 20;
UPDATE EMP SET SAL = SAL * 1.1 WHERE DEPTNO = 20;
SELECT * FROM EMP WHERE DEPTNO = 20;

-- Task 5: Find the number of CLERKS employed
SELECT COUNT(*) AS "Number of Clerks" FROM EMP WHERE JOB = 'CLERK';

-- Task 6: Find the average salary for each job type and the number of people employed in each job
SELECT JOB, AVG(SAL) AS "Average Salary", COUNT(*) AS "Number of Employees"
FROM EMP
GROUP BY JOB;

-- Task 7: List the employees with the lowest and highest salary
SELECT * FROM EMP WHERE SAL = (SELECT MIN(SAL) FROM EMP) OR SAL = (SELECT MAX(SAL) FROM EMP);

-- Task 8: Find the total salary paid to employees in each department
SELECT DEPTNO, SUM(SAL) AS "Total Salary"
FROM EMP
GROUP BY DEPTNO;

-- Task 9: Find the average salary for each department
SELECT DEPTNO, AVG(SAL) AS "Average Salary"
FROM EMP
GROUP BY DEPTNO;

-- Task 10: List the employees who earn more than the average salary of their department
SELECT E.*
FROM EMP E
JOIN (
  SELECT DEPTNO, AVG(SAL) AS "Average Salary"
  FROM EMP
  GROUP BY DEPTNO
) AS D ON E.DEPTNO = D.DEPTNO
WHERE E.SAL > D."Average Salary";

-- Task 11: Find the number of employees in each department
SELECT DEPTNO, COUNT(*) AS "Number of Employees"
FROM EMP
GROUP BY DEPTNO;

-- Task 12: List the departments that have more than 3 employees
SELECT DEPTNO, COUNT(*) AS "Number of Employees"
FROM EMP
GROUP BY DEPTNO
HAVING COUNT(*) > 3;

--Task 13:Compute yearly salary of SMITH.

SELECT ENAME, SAL*12 AS 'ANNUAL SALARY'
FROM EMP
WHERE ENAME = 'SMITH'

--Task 14: List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 

SELECT ENAME, SAL 
FROM EMP
WHERE SAL <1500 OR SAL>2850

--Task 15: Find all managers who have more than 2 employees reporting to them

SELECT M.ENAME AS "Manager Name", COUNT(E.EMPNO) AS "Number of Employees Reporting"
FROM EMP M
JOIN EMP E ON M.EMPNO = E.MGR_ID
GROUP BY M.ENAME
HAVING COUNT(E.EMPNO) > 2;

--Assignment-3
--1.Retrieve a list of MANAGERS.

SELECT * FROM EMP
WHERE JOB= 'MANAGER'

--2. Find out the names and salaries of all employees earning more than 1000 per month. 

SELECT ENAME, SAL AS 'PER MONTH SALARY'
FROM EMP
WHERE SAL>1000

--3. Display the names and salaries of all employees except JAMES.

SELECT ENAME, SAL
FROM EMP
WHERE ENAME<> 'JAMES'

--4. Find out the details of employees whose names begin with ‘S’. 
SELECT *
FROM EMP
WHERE ENAME LIKE'S%'

--6.Find out the names of all employees that have ‘L’ as their third character in their name. 

SELECT ENAME
FROM EMP
WHERE ENAME LIKE '__L%'

--5.  Find out the names of all employees that have ‘A’ anywhere in their name. 

SELECT ENAME
FROM EMP
WHERE ENAME LIKE '%A%'

--7 Compute daily salary of JONES. 

SELECT ENAME, SAL/ 30 AS 'DAILY SALARY'
FROM EMP
WHERE ENAME LIKE 'JONES'

--8.Calculate the total monthly salary of all employees. 

SELECT SUM(SAL) AS 'TOTAL SALARY OF EMPLOYEES'
FROM EMP

--9. Print the average annual salary . 

SELECT AVG(SAL * 12) AS 'AVERAGE ANNUAL SALARY'
FROM EMP

--10.Select the name, job, salary, department number of all employees except SALESMAN from department number 30.

SELECT ENAME, JOB, SAL, DEPTNO 
FROM EMP
WHERE DEPTNO = 30 AND JOB<> 'SALESMAN'

--11.List unique departments of the EMP table. 

SELECT DISTINCT DEPTNO
FROM EMP

--12.List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.

SELECT ENAME AS 'EMPLOYEE NAME', SAL AS 'MONTHLY SALARY'
FROM EMP
WHERE SAL>1500 AND DEPTNO BETWEEN 10 AND 30

--13.Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 

SELECT ENAME, JOB, SAL 
FROM EMP
WHERE JOB IN('MANAGER', 'ANALYST') AND SAL NOT IN(1000, 3000,5000)

--14.Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 

SELECT ENAME, SAL, COMM
FROM EMP
WHERE COMM >SAL * 1.1

--15.Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
SELECT ENAME
FROM EMP
WHERE (ENAME LIKE '%L%L% AND DEPTNO = 30') OR (MGR_ID = 7782)

--16.Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 

-- Declare a function to calculate months between two dates
DECLARE
    FUNCTION MONTHS_BETWEEN_DATE(SYSDATE, HIREDATE) RETURN NUMBER IS
    BEGIN
        RETURN MONTHS_BETWEEN(SYSDATE, HIREDATE);
    END;
BEGIN
    -- First query: Retrieve names of employees with experience between 30 and 40 years
    SELECT ENAME
    FROM EMP
    WHERE MONTHS_BETWEEN_DATE(SYSDATE, HIREDATE) / 12 BETWEEN 30 AND 40;

    -- Second query: Count employees with experience between 30 and 40 years
    SELECT COUNT(*)
    FROM EMP
    WHERE MONTHS_BETWEEN_DATE(SYSDATE, HIREDATE) / 12 BETWEEN 30 AND 40;
END;

--17.Retrieve the names of departments in ascending order and their employees in descending order. 

SELECT DNAME, COUNT(*) AS 'NUMBER OF EMPLOYEES'
FROM EMP E
JOIN DEPT D ON E.DEPTNO= D.DEPTNO
GROUP BY DNAME
ORDER BY DNAME ASC, 'NUMBER OF EMPLOYEES' DESC

--18. Find out experience of MILLER. 

ALTER TABLE EMP
ADD MONTHS_BETWEEN_DATE BETWEEN SYSDATE AND HIREDATE






