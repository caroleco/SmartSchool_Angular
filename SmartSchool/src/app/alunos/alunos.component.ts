import { Component, OnInit, TemplateRef } from '@angular/core';
import { Aluno } from '../models/Aluno';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
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

  alunos = [
    { id: 1, nome: 'Marta', sobrenome: 'Silva', telefone: 32998965874 },
    { id: 2, nome: 'Paula', sobrenome: 'Oliveira', telefone: 32984565625 },
    { id: 3, nome: 'Laura', sobrenome: 'Santos', telefone: 32984525654 },
    { id: 4, nome: 'Pedro', sobrenome: 'Moreira', telefone: 32987541452 },
    { id: 5, nome: 'Paulo', sobrenome: 'Medeiros', telefone: 32984547541 },
  ];
  
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder,
    private modalService: BsModalService) {
    this.criarForm();
  }

  ngOnInit(): void {
  }

  criarForm() {
    this.alunoForm = this.fb.group({
      nome: ['', Validators.required],
      sobrenome: ['', Validators.required],
      telefone: ['', Validators.required]
    });
  }

  alunoSubmit() {
    console.log(this.alunoForm.value)
  }

  alunoSelect(aluno: Aluno) {
    this.alunoSelected = aluno;
    this.alunoForm.patchValue(aluno);
  }

  voltar() {
    this.alunoSelected = null;
  }


}
