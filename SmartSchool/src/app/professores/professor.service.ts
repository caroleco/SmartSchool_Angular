import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { environment } from '../../environments/environment.prod';
import { Observable } from 'rxjs';
import { Professor } from '../models/Professor';

@Injectable({
  providedIn: 'root'
})
export class ProfessorService {

  mainUrl = `${environment.baseUrl}/api/professor`;

  constructor(private http: HttpClient) { }

  getAll(): Observable<Professor[]> {
    return this.http.get<Professor[]>(`${this.mainUrl}`);
  }

  getById(id:number) : Observable<Professor> {
    return this.http.get<Professor>(`${this.mainUrl}/${id}`);
  }

  post(prof:Professor){
    return this.http.post(`${this.mainUrl}`, prof);
  }

  put(prof:Professor){
    return this.http.put(`${this.mainUrl}/${prof.id}`, prof);
  }
}
