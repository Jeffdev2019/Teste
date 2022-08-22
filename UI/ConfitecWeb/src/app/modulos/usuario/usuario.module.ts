import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UsuarioComponent } from './usuario/usuario.component';
import { UsuarioService } from './service/usuarioservice';
import { MatTableModule } from '@angular/material/table';
import { UsuarioRoutingModule } from './usuario-rounting.module';
import { HttpClientModule } from '@angular/common/http';
import { UsuarioFormComponent } from './usuario/usuario-form/usuario-form.component';
import { MatDialogModule } from '@angular/material/dialog';
import {MatIconModule} from '@angular/material/icon';
import { CdkColumnDef } from '@angular/cdk/table';
import { FormBuilder, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { UsuarioCadastroFormComponent } from './usuario/usuario-cadastroForm/usuario-cadastroForm.component';
import { UsuarioDeleteViewComponent } from './usuario/usuario-deleteView/usuario-deleteView.component';



@NgModule({
  declarations: [
    UsuarioComponent,
    UsuarioFormComponent,
    UsuarioCadastroFormComponent,
    UsuarioDeleteViewComponent
  ],
  imports: [
    CommonModule,
    UsuarioRoutingModule,
    HttpClientModule,
    MatTableModule,
    MatDialogModule,
    MatIconModule,
    FormsModule,
    MatFormFieldModule,
    ReactiveFormsModule
  ],
  providers:[
    UsuarioService,
    CdkColumnDef,
    FormBuilder
  ]
})
export class UsuarioModule { }
