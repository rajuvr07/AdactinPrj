import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { MonthlyPremium, Premium } from "./premium";

@Injectable()
export class PremiumService {
  private premiumUrl: string = `${environment.apiUri}/premiums`;

  constructor(private http: HttpClient) { }

  getMonthlyPremium(premium: Premium): Observable<MonthlyPremium> {
    const uri = `${this.premiumUrl}`;

    return this.http.post<MonthlyPremium>(uri, premium);
  }
}