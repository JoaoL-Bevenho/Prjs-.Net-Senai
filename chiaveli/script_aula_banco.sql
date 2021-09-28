INSERT INTO employees.employees(emp_no,birth_date,first_name,last_name,gender,hire_date) VALUES(500000, '1997-08-31', 'João Lucas', 'Bevenho', 'M', '2019-03-18');

INSERT INTO employees.salaries(emp_no,salary,from_date,to_date) VALUES(500000,1500,'2019-03-18','9999-01-01');
UPDATE employees.salaries SET salaries.to_date='2019-04-02' WHERE salaries.emp_no=500000 AND from_date='2019-03-18';
SET @from_datesal1:=(SELECT salaries.to_date FROM employees.salaries WHERE salaries.emp_no=500000 AND salaries.from_date='2019-03-18');
SET @salary_oldsal1:=(SELECT salaries.salary FROM employees.salaries WHERE salaries.emp_no=500000 AND salaries.to_date=@from_datesal1);
INSERT INTO employees.salaries(emp_no,salary,from_date,to_date) VALUES(500000,(@salary_oldsal1+@salary_oldsal1*15/100),@from_datesal1,'9999-01-01');

INSERT INTO employees.titles(emp_no,title,from_date,to_date) VALUES(500000, 'Staff', '2019-03-18', '9999-01-01');
UPDATE employees.titles SET titles.to_date='2019-04-02' WHERE titles.emp_no=500000 AND titles.title='Staff' AND titles.from_date='2019-03-18';
SET @from_datetit1:=(SELECT titles.to_date FROM employees.titles WHERE titles.emp_no=500000 AND titles.from_date='2019-03-18');
INSERT INTO employees.titles(emp_no,title,from_date,to_date) VALUES(500000, 'Senior Staff', @from_datetit1, '9999-01-01');

INSERT INTO employees.dept_emp(emp_no,dept_no,from_date,to_date) VALUES(500000, 'd010', '2019-03-18', '9999-01-01');
UPDATE employees.dept_emp SET dept_emp.to_date='2019-04-02' WHERE dept_emp.emp_no=500000 AND dept_emp.from_date='2019-03-18';
SET @from_dateemp1:=(SELECT dept_emp.to_date from employees.dept_emp WHERE dept_emp.emp_no=500000 and dept_emp.from_date='2019-03-18');
INSERT INTO employees.dept_emp(emp_no,dept_no,from_date,to_date) VALUES(500000, 'd005', @from_dateemp1, '9999-01-01');

/*----------------------------------------------------------------------------------------------------------------------------------------------------------------*/

INSERT INTO employees.employees(emp_no,birth_date,first_name,last_name,gender,hire_date) VALUES(500001, '1985-11-25', 'Fernanda', 'Montenegro', 'F', '2007-07-25');

INSERT INTO employees.salaries(emp_no,salary,from_date,to_date) VALUES(500001,3500,'2005-07-25','9999-01-01');
UPDATE employees.salaries SET salaries.to_date='2018-03-18' WHERE salaries.emp_no=500001 AND from_date='2005-07-25';

SET @from_datesal2:=(SELECT salaries.to_date FROM employees.salaries WHERE salaries.emp_no=500001 AND salaries.from_date='2005-07-25');
SET @salary_oldsal2:=(SELECT salaries.salary FROM employees.salaries WHERE salaries.emp_no=500001 AND salaries.to_date=@from_datesal2);
INSERT INTO employees.salaries(emp_no,salary,from_date,to_date) VALUES(500001,(@salary_oldsal2+@salary_oldsal2*15/100),@from_datesal2,'9999-01-01');

INSERT INTO employees.titles(emp_no,title,from_date,to_date) VALUES(500001, 'Engineer', '2005-07-25', '9999-01-01');
UPDATE employees.titles SET titles.to_date='2018-03-18' WHERE titles.emp_no=500001 AND titles.title='Staff' AND titles.from_date='2005-07-25';
SET @from_datetit2:=(SELECT titles.to_date FROM employees.titles WHERE titles.emp_no=500001 AND titles.from_date='2005-07-25');
INSERT INTO employees.titles(emp_no,title,from_date,to_date) VALUES(500001, 'Senior Engineer', @from_datetit2, '9999-01-01');

INSERT INTO employees.dept_manager(emp_no,dept_no,from_date,to_date) VALUES(500001, 'd007', '2005-07-25', '9999-01-01');
UPDATE employees.dept_manager SET dept_manager.to_date='2018-03-18' WHERE dept_manager.emp_no=500001 AND dept_manager.from_date='2005-07-25';
SET @from_dateman2:=(SELECT dept_manager.to_date from employees.dept_manager WHERE dept_manager.emp_no=500001 and dept_manager.from_date='2005-07-25');
INSERT INTO employees.dept_manager(emp_no,dept_no,from_date,to_date) VALUES(500001, 'd006', @from_dateman2, '9999-01-01');

SELECT * FROM employees.salaries WHERE emp_no=500001;


