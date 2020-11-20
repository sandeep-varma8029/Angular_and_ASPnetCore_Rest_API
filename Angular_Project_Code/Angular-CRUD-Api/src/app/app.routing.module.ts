import { UpdateLangComponent } from './languages/update-lang/update-lang.component';
import { AddLangComponent } from './languages/add-lang/add-lang.component';
import { LangComponent } from './languages/lang/lang.component';
import { CertComponent } from './Certifications/cert/cert.component';
import { UpdateBusskillComponent } from './Business/update-busskill/update-busskill.component';
import { AddBusskillComponent } from './Business/add-busskill/add-busskill.component';
import { BusinessskillComponent } from './Business/businessskill/businessskill.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeComponent } from './employee/employee.component';
import { AddEmployeeComponent } from './employee/add-employee.component';
import { UpdateEmployeeComponent } from './employee/update-employee.component';
import { AddCertComponent } from './Certifications/add-cert/add-cert.component';
import { UpdateCertComponent } from './Certifications/update-cert/update-cert.component';
const routes: Routes = [
  { path: 'tech', component: EmployeeComponent },
  { path: 'business', component: BusinessskillComponent },
  { path: 'business/add', component: AddBusskillComponent },
  { path: 'business/update/:id', component: UpdateBusskillComponent },
  { path: 'cert', component: CertComponent },
  { path: 'cert/add', component: AddCertComponent },
  { path: 'cert/update/:id', component: UpdateCertComponent },
  { path: 'lang', component: LangComponent },
  { path: 'lang/add', component: AddLangComponent },
  { path: 'lang/update/:id', component:  UpdateLangComponent },
  { path: 'add', component: AddEmployeeComponent },
  { path: 'update/:id', component: UpdateEmployeeComponent },
  { path: '', redirectTo: '/tech', pathMatch: 'full'}
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class AppRoutingModule { }