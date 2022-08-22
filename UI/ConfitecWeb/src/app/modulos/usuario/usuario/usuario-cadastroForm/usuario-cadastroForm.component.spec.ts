import { ComponentFixture, TestBed } from '@angular/core/testing';
import { UsuarioCadastroFormComponent } from './usuario-cadastroForm.component';


describe('UsuarioFormComponent', () => {
  let component: UsuarioCadastroFormComponent;
  let fixture: ComponentFixture<UsuarioCadastroFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UsuarioCadastroFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UsuarioCadastroFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
