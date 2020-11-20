import { skillgroup,Employeq,Prof,profgroup } from './../models/skillgroup.model';
import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { Employee } from '../models/employee.model';
import { EmployeeService } from './employee.service';

@Component({
  selector: 'app-employee-create',
  templateUrl: './add-employee.component.html'
})
export class AddEmployeeComponent {
  public f: boolean= false;
  public stri = 'techskill'
  public skill = "skills/1"
  public prof = "proficiency/1"
 employee: Employee = new Employee();
  public emp: Employeq;//populates Skill Dropdown
  public profi: Prof;//Populates Proficiency Dropdown
  constructor(private router: Router, private employeeService: EmployeeService) {

  }
  ngOnInit() {
    this.employeeService.getskills(this.skill)
      .subscribe(data => {
        if (data) {
          this.emp = data;
          this.f = true;
   
        }
    
    });
    this.employeeService.getprof(this.prof)
    .subscribe(dat => {
      if (dat) {
        this.profi = dat;
        this.f = true;
    
      }
  
  });
  
  };
  createEmployee(): void {
    this.employeeService.createEmployee(this.employee,this.stri)
        .subscribe( data => {
          alert(" created successfully.");
          this.router.navigate(['/tech']);
        });

  };

}