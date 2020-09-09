using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Skills.Challenge
{
	class Program
	{
		static void Main(string[] args)
		{
			var form = JsonSerializer.Deserialize<Form>(System.IO.File.ReadAllText("fields.json"), new JsonSerializerOptions { IgnoreNullValues = true, PropertyNameCaseInsensitive = true });

			var strBuilder = new StringBuilder();

			foreach (var field in form.Fields)
			{
				strBuilder.AppendLine($"{field.Name} = {field.Value}");
			}

			Console.WriteLine(strBuilder.ToString());
			Console.Read();
		}
	}
}
