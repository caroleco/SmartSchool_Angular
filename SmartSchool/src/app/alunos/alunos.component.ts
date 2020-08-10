import { Component, OnInit } from '@angular/core';
import {Aluno} from '../models/Aluno';
@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  title = 'Alunos';
  public alunoSelected:Aluno;
  alunos = [
    { id: 1, nome: 'Marta', sobrenome: 'Silva', telefone: 32998965874 },
    { id: 2, nome: 'Paula', sobrenome: 'Oliveira', telefone: 32984565625 },
    { id: 3, nome: 'Laura', sobrenome: 'Santos', telefone: 32984525654 },
    { id: 4, nome: 'Pedro', sobrenome: 'Moreira', telefone: 32987541452 },
    { id: 5, nome: 'Paulo', sobrenome: 'Medeiros', telefone: 32984547541 },
  ];

  alunoSelect(aluno:Aluno){
    this.alunoSelected = aluno;
  }

  voltar(){
    this.alunoSelected = null;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
