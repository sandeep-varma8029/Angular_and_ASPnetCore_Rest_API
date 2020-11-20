import { skillgroup,Employeq,Prof,profgroup } from './../models/skillgroup.model';
import {Injectable} from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Employee } from '../models/employee.model';


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()
export class EmployeeService {

  constructor(private http:HttpClient) {}

  private employeeUrl = 'https://localhost:44364/api/';

  public getEmployees(str) {
    return this.http.get<Employee[]>(this.employeeUrl+str);
  }
  public getskills(str) {
    return this.http.get<Employeq>(this.employeeUrl+str);
  }
  public getprof(str) {
    return this.http.get<Prof>(this.employeeUrl+str);
  }
  public getEmployee(id,str) {
    return this.http.get(this.employeeUrl + str + "/"+  id);
  }

  public deleteEmployee(employee,str) {
    return this.http.delete(this.employeeUrl+ str+ "/"+ employee.id);
  }

  public createEmployee(employee,str) {
    return this.http.post<Employee>(this.employeeUrl+ str, employee);
  }

  public updateEmployee(employee,str) {
    return this.http.put<Employee>(this.employeeUrl + str + "/"+ employee.id, employee);
  }

}
