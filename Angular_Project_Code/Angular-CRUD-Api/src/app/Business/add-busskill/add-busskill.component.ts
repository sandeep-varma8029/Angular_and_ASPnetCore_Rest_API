import { skillgroup,Employeq,Prof,profgroup } from './../../models/skillgroup.model';
import { EmployeeService } from './../../employee/employee.service';
import { Employee } from './../../models/employee.model';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-busskill',
  templateUrl: './add-busskill.component.html',
  styleUrls: ['./add-busskill.component.css']
})
export class AddBusskillComponent implements OnInit {

  public f: boolean= false;
  public stri = 'busskill'
  public skill = "skills/2"
  public prof = "proficiency/2"
 employee: Employee = new Employee();
  //public employee : Employee;
  public emp: Employeq;
  public profi: Prof;
  constructor(private router: Router, private employeeService: EmployeeService) {

  }
  ngOnInit() {
    this.employeeService.getskills(this.skill)
      .subscribe(data => {
        if (data) {
          this.emp = data;
          this.f = true;
       // console.log(this.employee);
        }
    
    });
    this.employeeService.getprof(this.prof)
    .subscribe(dat => {
      if (dat) {
        this.profi = dat;
        this.f = true;
      //console.log(this.employee);
      }
  
  });
  
  };
  createEmployee(): void {
    this.employeeService.createEmployee(this.employee,this.stri)
        .subscribe( data => {
          alert(" created successfully.");
          this.router.navigate(['/business']);
        });

  };
}
