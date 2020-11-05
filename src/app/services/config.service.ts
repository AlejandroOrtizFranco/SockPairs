import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Sock } from '../models/sock';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {

  constructor(private http:HttpClient) {}


  postPairs(socks:Sock):Observable<any>{
    return this.http.post<any>("https://localhost:44330/api/sock",socks);
  }
}
