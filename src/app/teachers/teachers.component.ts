import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-teachers',
  templateUrl: './teachers.component.html',
  styleUrls: ['./teachers.component.css']
})
export class TeachersComponent implements OnInit {

  title = "Professores"

  public teachers = [
    {name: "Mauricio"},
    {name: "Sarah"},
    {name: "Eric"}
  ]

  constructor() { }

  ngOnInit() {
  }

}
