import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { UsuarioModel } from 'src/app/modulos/model/UsuarioModel';

@Component({
  selector: 'app-usuario-form',
  templateUrl: './usuario-cadastroForm.component.html',
  styleUrls: ['./usuario-cadastroForm.component.css']
})
export class UsuarioCadastroFormComponent implements OnInit {
  isEdit = false;
  isNew = false;
  isView = false;
  typeAction = '';
  selected: any;
  formGroup: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public dialogRef: MatDialogRef<UsuarioCadastroFormComponent>
  ) { }

  ngOnInit(): void {
    this.initForm();
    this.typeAction = this.data.typeAction;
    if (this.typeAction === 'edit') {
      this.isEdit = true;
    }
    else if (this.typeAction === 'new') {
      this.isNew = true;
    }
    else {
      this.isView = true;
      this.formGroup.disable();
    }
  }

  initForm() {
    this.formGroup = this.formBuilder.group({
      nome: [''],
      sobrenome: [''],
      email: [''],
      dataNascimento: []
    });
  }

   submitForm(): void {
  //   for (const i in this.formGroup.controls) {
  //     this.formGroup.controls[i].markAsDirty();
  //     this.formGroup.controls[i].updateValueAndValidity();
  //   }

  //   var item = this.formGroup.getRawValue();
  //   if (this.isNew) {
  //     this.propostaService.save(item).subscribe((result) => {
  //       if (result) {
  //         Swal.hideLoading();
  //         this.dialogRef.close({ event: 'sucesso' });
  //       }
  //     }, err => {
  //       this.errorService.handleError(err);
  //     })
  //   } else {
  //     this.propostaService.Update(item).subscribe((result) => {
  //       if (result) {
  //         Swal.hideLoading();
  //         this.dialogRef.close({ event: 'sucesso' });
  //       }
  //     }, err => {
  //       this.errorService.handleError(err);
  //     })
  //   }
  }
}