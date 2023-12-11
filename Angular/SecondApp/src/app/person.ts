export class Person {

    constructor(pAadhar:string='', pName:string='', pAge:number=18){


        this.aadhar=pAadhar;
        this.age=pAge;
        this.name=pName;
    }

    public aadhar:string ='';            //~c# string
    public name:string ='';
    public age:number = 0;               //~c# int,int16,int 32,int64,long,short,decimal
    private secrets:string[] = [];       //~c# Arrays{}
    public isAlive:boolean = true;       //~c# Boolean
    protected hobbies: any = {};         //~c# Object
    protected awardsReceived:any[] = []; //~c# Array
 

    public static People:Person[] = [];

    public static GetPeople():Person[]{
        if (Person.People.length == 0){
         Person.People.push(new Person("AA3456789123456", "Meena", 25));
         Person.People.push(new Person("BB3456789123456", "Teena", 23));
         Person.People.push(new Person("CC3456789123456", "Reena", 29));
        }
         return Person.People;

    }
    public static AddPerson(person:Person):boolean{
        //Add him to person.people array
        if(person == undefined)
             return false;

        Person.People.push(person);
        return true;

    }
}