import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Employee } from '../models/employee.model';
import { EmployeeService } from './employee.service';

@Component({
  selector: 'app-employee-read',
  templateUrl: './employee.component.html',
  styles: []
})
export class EmployeeComponent implements OnInit {

  employees: Employee[];

  constructor(private router: Router, private employeeService: EmployeeService) {

  }
public stri = 'techskill'
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
        this.router.navigate(['/tech']);
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