import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UsuarioModel } from '../../model/UsuarioModel';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CrudService } from '../../service/crud.service';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService extends CrudService<UsuarioModel, number> {

  constructor(protected override http: HttpClient) {
    super(http, environment.baseUrl + '/Usuario');
  }
}
