import { EmployeeService } from './../../employee/employee.service';
import { Employee } from './../../models/employee.model';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-update-lang',
  templateUrl: './update-lang.component.html',
  styleUrls: ['./update-lang.component.css']
})
export class UpdateLangComponent implements OnInit {

  public stri = 'language'
  employee: any = {};

  constructor(private router: Router, private route: ActivatedRoute, private employeeService: EmployeeService) {
    
  }

  ngOnInit() {
    this.employeeService.getEmployee(this.route.snapshot.params['id'],this.stri)
      .subscribe(data => {
        this.employee = data;
      });
  };

  updateEmployee(): void {
   
      this.employeeService.updateEmployee(this.employee,this.stri)
      .subscribe(data => {
        alert("Employee updated successfully.");
        this.router.navigate(['/lang']);
      });
      alert(" updated successfully.");

      this.router.navigate(['/lang']);

 
  };

}
