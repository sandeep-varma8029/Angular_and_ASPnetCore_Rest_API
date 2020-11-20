import { EmployeeService } from './../../employee/employee.service';
import { Employee } from './../../models/employee.model';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-update-cert',
  templateUrl: './update-cert.component.html',
  styleUrls: ['./update-cert.component.css']
})
export class UpdateCertComponent implements OnInit {

  public stri = 'certification'
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
        this.router.navigate(['/cert']);
      });
      alert(" updated successfully.");

      this.router.navigate(['/cert']);

 
  };

}
