import { UpdateLangComponent } from './languages/update-lang/update-lang.component';
import { AddLangComponent } from './languages/add-lang/add-lang.component';
import { LangComponent } from './languages/lang/lang.component';
import { UpdateCertComponent } from './Certifications/update-cert/update-cert.component';
import { AddCertComponent } from './Certifications/add-cert/add-cert.component';
import { CertComponent } from './Certifications/cert/cert.component';
import { UpdateBusskillComponent } from './Business/update-busskill/update-busskill.component';
import { AddBusskillComponent } from './Business/add-busskill/add-busskill.component';
import { BusinessskillComponent } from './Business/businessskill/businessskill.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './employee/employee.component';
import { AppRoutingModule } from './app.routing.module';
import {EmployeeService} from './employee/employee.service';
import {HttpClientModule} from "@angular/common/http";
import {AddEmployeeComponent} from './employee/add-employee.component';
import { UpdateEmployeeComponent } from './employee/update-employee.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    AddEmployeeComponent,
    UpdateEmployeeComponent,
    BusinessskillComponent,
    UpdateBusskillComponent,
    AddBusskillComponent,
    CertComponent,
    AddCertComponent,
    UpdateCertComponent,
    LangComponent,
    AddLangComponent,
    UpdateLangComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
