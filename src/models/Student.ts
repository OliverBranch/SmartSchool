export class Student{
    id: number;
    name: string;
    lastName: string;
    phoneNumber: string;

    constructor (id:number, name:string, lastName:string, phoneNumber:string){
        this.id = id;
        this.name =name;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
    }
}