using Tommy;

// Parse into a node
// using(StreamReader reader = File.OpenText("configuration.toml"))
// {
//     // Parse the table
//     TomlTable table = TOML.Parse(reader);

//     System.Console.WriteLine(table["title"].ToString());  // Prints "TOML Example"

//     // You can check the type of the node via a property and access the exact type via As*-property
//     System.Console.WriteLine(table["owner"]["dob"].IsDateTime);  // Prints "True"

//     // You can also do both with C# 7 syntax
//     if(table["owner"]["dob"] is TomlDateTime date)
//         System.Console.WriteLine(date.AsDateTime.ToString()); // Some types contain additional properties related to formatting

//     // You can also iterate through all nodes inside an array or a table
//     foreach(TomlNode node in table["database"]["ports"])
//         System.Console.WriteLine(node.ToString());
// }


// Parse into a node
using(StreamReader reader = File.OpenText("learntoml.toml"))
{
    try
    {
        TomlTable table = TOML.Parse(reader);

        System.Console.WriteLine($"multiLineLiteralString = {table["multiLineLiteralString"]}"); 
    }
    catch (Tommy.TomlParseException e)
    {
        System.Console.WriteLine( $"錯誤：{e.Message}");
    }
    
}


