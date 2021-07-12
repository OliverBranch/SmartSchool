import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-teachers',
  templateUrl: './teachers.component.html',
  styleUrls: ['./teachers.component.css']
})
export class TeachersComponent implements OnInit {

  title = "Professores"

  public teachers = [
    {id: 1, name: "Mauricio", subject:"Matemática"},
    {id: 2, name: "Sarah", subject:"Física"},
    {id: 3, name: "Eric", subject:"Português"},
    {id: 4, name: "Léo", subject:"Inglês"},
    {id: 5, name: "Alexandre", subject:"Programação"}
  ]

  constructor() { }

  ngOnInit() {
  }

}
