import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent implements OnInit {

  title = "Alunos"
  public students = [

    {name: "Marta"},
    {name: "Paula"},
    {name: "Laura"},
    {name: "Luiza"},
    {name: "Lucas"},
    {name: "Pedro"},
    {name: "Paulo"}

    ]

  constructor() { }

  ngOnInit(): void {
  }

}
