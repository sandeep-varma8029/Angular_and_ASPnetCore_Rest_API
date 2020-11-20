import { EmployeeService } from './../../employee/employee.service';
import { Employee } from './../../models/employee.model';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-update-busskill',
  templateUrl: './update-busskill.component.html',
  styleUrls: ['./update-busskill.component.css']
})
export class UpdateBusskillComponent implements OnInit {

  public stri = 'busskill'
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
        this.router.navigate(['/business']);
      });
      alert(" updated successfully.");

      this.router.navigate(['/business']);

 
  };
}
