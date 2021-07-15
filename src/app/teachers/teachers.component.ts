import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {Teacher} from "../../models/Teacher"

@Component({
  selector: 'app-teachers',
  templateUrl: './teachers.component.html',
  styleUrls: ['./teachers.component.css']
})
export class TeachersComponent implements OnInit {

  public title = "Professores";
  public teacherForm!: FormGroup;
  public SelectedTeacher?: Teacher;
  public textSimple?: string;

  public teachers = [
    {id: 1, name: "Mauricio", subject:"Matemática"},
    {id: 2, name: "Sarah", subject:"Física"},
    {id: 3, name: "Eric", subject:"Português"},
    {id: 4, name: "Léo", subject:"Inglês"},
    {id: 5, name: "Alexandre", subject:"Programação"}
  ];

  constructor(private fb: FormBuilder) {
    this.formCreate();
   }

  ngOnInit() {
  }

  formCreate(){
    this.teacherForm = this.fb.group({
      name:['', Validators.required],
      subject:['', Validators.required]
    });
  }

  submitTeacher(){
    console.log(this.teacherForm.value)
  }
  selectTeacher(teacher: Teacher){
    this.SelectedTeacher = teacher;
    this.teacherForm.patchValue(teacher);
  }

  back(){
    this.SelectedTeacher = undefined;
  }


}
