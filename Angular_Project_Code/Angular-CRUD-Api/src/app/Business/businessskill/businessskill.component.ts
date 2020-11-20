import { EmployeeService } from './../../employee/employee.service';
import { Employee } from './../../models/employee.model';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-businessskill',
  templateUrl: './businessskill.component.html',
  styleUrls: ['./businessskill.component.css']
})
export class BusinessskillComponent implements OnInit {
  public stri='busskill'
  employees: Employee[];

  constructor(private router: Router, private employeeService: EmployeeService) {

  }

  ngOnInit() {
    this.employeeService.getEmployees(this.stri)
      .subscribe( data => {
        this.employees = data;
      });
      
  };

  deleteEmployee(employee: Employee): void {
    this.employeeService.deleteEmployee(employee,this.stri)
      .subscribe( data => {
        this.employees = this.employees.filter(u => u !== employee);
        alert(" Deleted successfully.");
        this.router.navigate(['/employees']);
      })
    alert(" Deleted successfully.");
    this.refresh();
        
  };
  refresh() {
    this.employeeService.getEmployees(this.stri)
    .subscribe( data => {
      this.employees = data;
    });
  };

}
