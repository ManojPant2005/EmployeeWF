create table employees
(
  id int primary key identity(1,1),
  employee_id varchar(max) null,
  fullname varchar(max) null,
  gender varchar(max) null,
  contact_number varchar(max) null,
    department varchar(max) null,
  image varchar(max) null,
    salary int null,
  insert_date date null,
  update_date date null,
  delete_date date null,

);

alter table employees
add status varchar(max) null;




select * from employees;