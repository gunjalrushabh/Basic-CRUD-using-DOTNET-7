using BOL;
using System.Text.Json;
using System.Text.Json.Serialization;

//populate.pupulation(); -> dont do this mistake Exception overwriting the data and we lost the previous data entries
string fileName=@"E:\Rushabh_Gunjal\DotNet\day5\TestBOL\Emplyoee.json";

 string jsonString = File.ReadAllText(fileName);
 if(jsonString=="")
       populate.pupulation(); 

 List<Employee> li = JsonSerializer.Deserialize<List<Employee>>(jsonString);
  String produtsJson;
int ch=0,tempId=0;
Boolean flag=false;
Console.WriteLine("------------MENU--------");
Console.WriteLine("1:Add Employee\n2:delete employee\n3:update Employee \n4:desplay all Employee\n5:Exit");
Console.WriteLine("Enter your choice");
ch=int.Parse(Console.ReadLine());
switch(ch){
case 1:
Console.WriteLine("Enter EmpID firstname lastname and mobile no");
 li.Add(new Employee(int.Parse(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(),Int64.Parse(Console.ReadLine())));
 produtsJson=JsonSerializer.Serialize<List<Employee>>(li);
 File.WriteAllText(fileName,produtsJson);
break;
case 2:
Console.WriteLine("Enter empID");
tempId=int.Parse(Console.ReadLine());
for(int i=0;i<li.Count();i++){
    if(li[i].EmpId==tempId){
        li.RemoveAt(i);
     produtsJson=JsonSerializer.Serialize<List<Employee>>(li);
        File.WriteAllText(fileName,produtsJson);
        flag=true;
        break;
        
    }
}
if(flag==false){
    Console.WriteLine("Employee not Exist");
}
flag=false;
break;
case 3:
Console.WriteLine("Enter empID");
tempId=int.Parse(Console.ReadLine());
for(int i=0;i<li.Count();i++){
    if(li[i].EmpId==tempId){
        Console.WriteLine("Enter firstname lastname and contact");
        li[i].Firstname=Console.ReadLine();
        li[i].Lastname=Console.ReadLine();
        li[i].Contact=Int64.Parse(Console.ReadLine());
     produtsJson=JsonSerializer.Serialize<List<Employee>>(li);
        File.WriteAllText(fileName,produtsJson);
        flag=true;
        break; 
    }
}
if(flag==false){
    Console.WriteLine("Employee not Exist");
}
flag=false;
break;
case 4:
Console.WriteLine("All employee are");
foreach(Employee e in li){
    Console.WriteLine(e);
}
break;
default:
Console.WriteLine("Enter valid option");
break;
}