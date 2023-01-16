using System.Text.Json;
using System.Text.Json.Serialization;
using BOL;

public class populate{
    public static void pupulation(){
        List<Employee> li=new List<Employee>();
        li.Add(new Employee(1,"rohan","sakale",9209962520));
        li.Add(new Employee(2,"Aditya","Pawaskar",9209962520));
        li.Add(new Employee(3,"Bhushan","Shinde",9209962520));
        li.Add(new Employee(4,"Saurabh","Raut",9209962520));
        li.Add(new Employee(5,"Satyam","Pandey",9209962520));
        // dynamic data type variable
            // var options=new JsonSerializerOptions {IncludeFields=true};
            String produtsJson=JsonSerializer.Serialize<List<Employee>>(li);
            string fileName=@"E:\Rushabh Gunjal\DotNet\day5\TestBOL\Emplyoee.json";
            //Serialize all Flowers into json file
            File.WriteAllText(fileName,produtsJson);
            // File.AppendAllText(fileName,produtsJson);
    }
}