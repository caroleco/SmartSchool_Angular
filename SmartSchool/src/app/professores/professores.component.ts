import { Component, OnInit, TemplateRef } from '@angular/core';
import { Professor } from '../models/Professor';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

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

  professores = [
    { id: 1, nome: 'Amadeu', disciplina: 'Matemática' },
    { id: 2, nome: 'Bruno', disciplina: 'Português' },
    { id: 3, nome: 'Larissa', disciplina: 'História' },
    { id: 4, nome: 'Eduarda', disciplina: 'Geografia' },
    { id: 5, nome: 'Lucas', disciplina: 'Programação' }
  ];
 
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder, private modalService: BsModalService) {
    this.criarForm();
  }

  ngOnInit(): void {
  }

  criarForm() {
    this.professorForm = this.fb.group({
      nome: ['', Validators.required],
      disciplina: ['', Validators.required]
    });
  }

  professorSubmit() {
    console.log(this.professorForm.value);
  }

  professorSelect(professor: Professor) {
    this.professorSelected = professor;
    this.professorForm.patchValue(professor);
  }

  voltar() {
    this.professorSelected = null;
  }


}
