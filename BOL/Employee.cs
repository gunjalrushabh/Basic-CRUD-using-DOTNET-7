namespace BOL;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Employee
{

    public  int EmpId{set;get;}
    public  String Firstname {set;get;}
    public  String Lastname {set;get;}
    public  Int64 Contact {set;get;}

    public Employee():this(1,"virat","kolhi",874565487445){

    }
    public Employee(int empid,String firstname,String lastname,Int64 contact){
        this.EmpId=empid;
        this.Firstname=firstname;
        this.Lastname=lastname;
        this.Contact=contact;
    }
    public override String ToString(){
        return EmpId+" "+Firstname+" "+Lastname+" "+Contact; 

    } 
    
}
