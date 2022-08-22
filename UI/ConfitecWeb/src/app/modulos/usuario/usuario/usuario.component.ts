import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { UsuarioModel } from '../../model/UsuarioModel';
import { UsuarioService } from '../service/usuarioservice';
import { UsuarioCadastroFormComponent } from './usuario-cadastroForm/usuario-cadastroForm.component';
import { UsuarioDeleteViewComponent } from './usuario-deleteView/usuario-deleteView.component';
import { UsuarioFormComponent } from './usuario-form/usuario-form.component';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent implements OnInit {

  usuarios: UsuarioModel[];
  displayedColumns: string[] = ['nome', 'sobreNome', 'email', 'dataNascimento', 'actions'];
  dataSource: UsuarioModel[] = [];

  constructor(
    private usuarioService: UsuarioService,
    private dialog: MatDialog
  ) { }

  ngOnInit(): void {
    this.getAll()
  }

  getAll() {
    this.usuarioService.getAll().subscribe(
      (resultado) => {
        this.usuarios = resultado;
        this.dataSource = this.usuarios;
      },
      () => {
        console.log('deu erro');
      }
    )
  }
  addData(){
    const dialogRef = this.dialog.open(UsuarioCadastroFormComponent, {
      data: {
        typeAction: 'view'
      }
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result !== '') {
      }
    });
  }

  openDelete(item: UsuarioModel){
    const dialogRef = this.dialog.open(UsuarioDeleteViewComponent, {
      data: {
        typeAction: 'delete'
      }
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result !== '') {
      }
    });
  }

  openView(item: UsuarioModel) {
    const dialogRef = this.dialog.open(UsuarioFormComponent, {
      data: {
        typeAction: 'view',
        nome: item.nome,
        sobreNome: item.sobreNome,
        email: item.email,
        dataNascimento: item.dataNascimento
      }
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result !== '') {
      }
    });
  }
}
