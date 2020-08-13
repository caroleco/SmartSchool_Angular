import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { environment } from '../../environments/environment.prod';
import { Observable } from 'rxjs';
import { Aluno } from '../models/Aluno';

@Injectable({
  providedIn: 'root'
})
export class AlunoService {

  mainUrl = `${environment.baseUrl}/api/aluno`;

  constructor(private http: HttpClient) { }

  getAll(): Observable<Aluno[]> {
    return this.http.get<Aluno[]>(`${this.mainUrl}`);
  }

  getById(id: number): Observable<Aluno> {
    return this.http.get<Aluno>(`${this.mainUrl}/${id}`);
  }

  post(aluno: Aluno){
    return this.http.post(`${this.mainUrl}`, aluno);
  }

  put(aluno: Aluno){
    return this.http.put(`${this.mainUrl}/${aluno.id}`, aluno);
  }

  delete(id: number) {
    return this.http.delete(`${this.mainUrl}/${id}`);
  }
}
