import { EscolaridadeModel } from "./EscolaridadeModel";
import { HistoricoEscolarModel } from "./HistoricoEscolarModel";

export class UsuarioModel {
    public idUsuario: number;
    public nome: string;
    public sobreNome: string;
    public email: string;
    public dataNascimento: Date;
    public HistoricoEscolarId: string;
    public HistoricoEscolar: HistoricoEscolarModel;
    public EscolaridadeId: string;
    public Escolaridade: EscolaridadeModel;
}