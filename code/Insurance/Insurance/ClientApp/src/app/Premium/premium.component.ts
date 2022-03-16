import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Premium } from './premium';

import { PremiumService } from './premium.service';

@Component({
  selector: 'app-premium',
  templateUrl: './premium.component.html',
  styleUrls: ['./premium.component.scss'],
})
export class PremiumComponent implements OnInit {
  premiumCalculator: FormGroup;
  premium: Premium;
  title: string = 'Monthly Premiums';
  monthlyPremium: Number;

  constructor(
    private formBuilder: FormBuilder,
    private premiumService: PremiumService
  ) {
    this.premiumCalculator = this.formBuilder.group({
      name: ['', [Validators.required]],
      age: ['', [Validators.required]],
      dateOfBirth: [new Date(), [Validators.required]],
      occupation: ['', [Validators.required]],
      sumInsured: ['', [Validators.required]],
    });

    this.premium = {
      name: '',
      age: 0,
      dateOfBirth: '',
      occupation: '',
      sumInsured: 0,
    };

    this.monthlyPremium = 0;
  }

  ngOnInit() {}

  calculateMonthlyPremium() {
    this.premiumService
      .getMonthlyPremium(this.premiumCalculator.value)
      .subscribe((monthlyPremium) => {
        this.monthlyPremium = monthlyPremium.totalMonthlyPremium;
      });
  }
}
