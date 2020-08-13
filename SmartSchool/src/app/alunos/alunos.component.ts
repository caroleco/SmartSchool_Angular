import { Component, OnInit, TemplateRef } from '@angular/core';
import { Aluno } from '../models/Aluno';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { AlunoService } from './aluno.service'
@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  public modalRef: BsModalRef;
  public alunoForm: FormGroup;
  public alunoSelected: Aluno;
  public title = 'Alunos';
  public alunos = [];
  public modo = 'post';

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder,
    private modalService: BsModalService,
    private alunoService: AlunoService) {
    this.criarForm();
  }

  ngOnInit(): void {
    this.carregarAlunos();
  }

  carregarAlunos() {
    this.alunoService.getAll().subscribe(
      (alunos: Aluno[]) => {
        this.alunos = alunos;
      },
      (erro: any) => {
        console.error(erro);
      }
    );
  }

  criarForm() {
    this.alunoForm = this.fb.group({
      id: [''],
      nome: ['', Validators.required],
      sobrenome: ['', Validators.required],
      telefone: ['', Validators.required]
    });
  }

  salvarAluno(aluno: Aluno) {
    (aluno.id === 0) ? this.modo = 'post' : this.modo = 'put';

    this.alunoService[this.modo](aluno).subscribe(
      (aluno: Aluno) => {
        console.log(aluno);
        this.carregarAlunos();
      },
      (erro: any) => {
        console.error(erro);
      }
    );
  }

  alunoSubmit() {
    this.salvarAluno(this.alunoForm.value)
  }

  alunoSelect(aluno: Aluno) {
    this.alunoSelected = aluno;
    this.alunoForm.patchValue(aluno);
  }

  cadastrar() {
    this.alunoSelected = new Aluno();
    this.alunoForm.patchValue(this.alunoSelected);
  }

  deletarAluno(aluno: Aluno) {
    this.alunoService.delete(aluno.id).subscribe(
      (model: any) => {
        console.log(model);
        this.carregarAlunos();
      },
      (erro: any) => {
        console.error(erro);
      }
    );
  }

  voltar() {
    this.alunoSelected = null;
  }


}
