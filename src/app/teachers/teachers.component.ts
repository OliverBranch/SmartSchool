import { Component, OnInit } from '@angular/core';
import {Teacher} from "../../models/Teacher"

@Component({
  selector: 'app-teachers',
  templateUrl: './teachers.component.html',
  styleUrls: ['./teachers.component.css']
})
export class TeachersComponent implements OnInit {

  public title = "Professores";
  public SelectedTeacher: Teacher;

  public teachers = [
    {id: 1, name: "Mauricio", subject:"Matemática"},
    {id: 2, name: "Sarah", subject:"Física"},
    {id: 3, name: "Eric", subject:"Português"},
    {id: 4, name: "Léo", subject:"Inglês"},
    {id: 5, name: "Alexandre", subject:"Programação"}
  ];

  selectTeacher(teacher:Teacher){
    this.SelectedTeacher = teacher.name;
  }

  back(){
    this.SelectedTeacher = null;
  }

  constructor() { }

  ngOnInit() {
  }

}
