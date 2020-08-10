import { Component, OnInit } from '@angular/core';
import { Professor } from '../models/Professor';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {

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

  constructor(private fb: FormBuilder) {
    this.criarForm();
  }

  ngOnInit(): void {
  }

  criarForm() {
    this.professorForm = this.fb.group({
      nome: [''],
      disciplina: ['']
    });
  }

  professorSubmit() {
    console.log(this.professorForm.value);
  }

  professorSelect(professor: Professor) {
    this.professorSelected = professor;
    this.professorForm.
  }

  voltar() {
    this.professorSelected = null;
  }


}
