import { EmployeeService } from './../../employee/employee.service';
import { Employee } from './../../models/employee.model';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cert',
  templateUrl: './cert.component.html',
  styleUrls: ['./cert.component.css']
})
export class CertComponent implements OnInit {

  public stri='certification'
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
        this.router.navigate(['/cert']);
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
