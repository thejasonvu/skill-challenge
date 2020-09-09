using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Linq;

namespace Skills.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = JsonSerializer.Deserialize<Form>(System.IO.File.ReadAllText("fields.json"), new JsonSerializerOptions { IgnoreNullValues = true, PropertyNameCaseInsensitive = true });

            var strBuilder = new StringBuilder();

            // I use LINQ to sort the fields because form.Fields is IEnumerable which is read-only
            // A way to sort without using LINQ is to instantiate a list and then sort on that but
            // using LINQ is more succinct and semantic. Example:
            // List<Field> listOfFields = form.Fields.ToList();
            // listOfFields.Sort((x, y) => x.Order.CompareTo(y.Order));
            var sortedFields = form.Fields.OrderByDescending(i => i.Order);

            foreach (var field in sortedFields)
            {
                strBuilder.AppendLine($"{field.Order}) {field.Name} = {field.Value}");
            }

            Console.WriteLine(strBuilder.ToString());
            Console.Read();
        }
    }
}
