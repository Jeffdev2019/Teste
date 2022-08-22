import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { UsuarioModel } from '../model/UsuarioModel';

@Injectable({
  providedIn: 'root'
})
export abstract class CrudService<T, ID> {

  constructor(protected http: HttpClient,
    @Inject(String) private _base: string) { }


  getAll(): Observable<T[]> {
    return this.http.get<T[]>(this._base);
  }

  create(t: T): Observable<T> {
    return this.http.post<T>(this._base, t);
  }

  update(t: T): Observable<T> {
    return this.http.put<T>(this._base, t);
  }

  delete(id: string) {
    return this.http.delete(this._base +'/'+ id);
  }
}
