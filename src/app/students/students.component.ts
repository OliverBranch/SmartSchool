import { Component, OnInit } from '@angular/core';
import { Student } from "../../models/Student";

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent implements OnInit {

  title = "Alunos";
  public SelectedStudent? : Student;
  public students = [
    { id: 1,name: "Marta", lastName:"Kent", phoneNumber: "27988731234"},
    { id: 2,name: "Paula", lastName:"Isabela", phoneNumber: "27988735634"},
    { id: 3,name: "Laura", lastName:"Antonia", phoneNumber: "27988736473"},
    { id: 4,name: "Luiza", lastName:"Maria", phoneNumber: "27988738372"},
    { id: 5,name: "Lucas", lastName:"Machado", phoneNumber: "27988739382"},
    { id: 6,name: "Pedro", lastName:"Alvaro", phoneNumber: "27988737362"},
    { id: 7,name: "Paulo", lastName:"José", phoneNumber: "27988738317"}

    ];
    selectStudent(student: Student){
      this.SelectedStudent = student;
    }

    back(){
      this.SelectedStudent = undefined;
    }




  constructor() { }

  ngOnInit(): void {
  }

}
