import { NgModule } from '@angular/core';
import {Routes, RouterModule} from '@angular/router';

export const routes: Routes = [
    {
        path: '', loadChildren: () => import('./modulos/usuario/usuario.module').then(m => m.UsuarioModule)
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule{}