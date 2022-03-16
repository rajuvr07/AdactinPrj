import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PremiumComponent } from './Premium/premium.component';

const routes: Routes = [
  { path: '', component: PremiumComponent },
  { path: 'premiums', component: PremiumComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
