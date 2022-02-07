select *
from Employee
join
      (select q.name as chiefName,
      q.salary as salaryChief,
      q.department_id
      from Employee q
      where q.id=q.chief_id) qe
      on qe.department_id=Employee.department_id
where Employee.salary>qe.salaryChief