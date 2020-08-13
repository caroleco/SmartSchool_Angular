import { Component, OnInit, TemplateRef } from '@angular/core';
import { Professor } from '../models/Professor';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import {ProfessorService} from './professor.service';

@Component({
  selector: 'app-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {

  public modalRef: BsModalRef;
  public professorForm: FormGroup;
  public professorSelected: Professor;
  public title = 'Professores';
  public simpleText: string;
  public modo = 'post';
  professores = [];
 
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder, private modalService: BsModalService,
    private professorService: ProfessorService) {
    this.criarForm();
  }

  ngOnInit(): void {
    this.carregarProfessores();
  }

  carregarProfessores() {
    this.professorService.getAll().subscribe(
      (professores: Professor[]) => {
        this.professores = professores;
      },
      (erro: any) => {
        console.error(erro);
      }
    );
  }

  criarForm() {
    this.professorForm = this.fb.group({
      id:[''],
      nome: ['', Validators.required],
      disciplina: ['']
    });
  }


  salvarProfessor(prof: Professor) {
    (prof.id === 0) ? this.modo = 'post' : this.modo = 'put';
    this.professorService[this.modo](prof).subscribe(
      (prof: Professor) => {
        console.log(prof);
        this.carregarProfessores();
      },
      (erro: any) =>{
        console.error(erro);
      }
    );
  }

  professorSubmit() {
    this.salvarProfessor(this.professorForm.value);
  }

  professorSelect(professor: Professor) {
    this.professorSelected = professor;
    this.professorForm.patchValue(professor);
  }

  cadastrar(){
    this.professorSelected = new Professor();
    this.professorForm.patchValue(this.professorSelected);
  }

  voltar() {
    this.professorSelected = null;
  }


}
