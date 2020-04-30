using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace SEND
{
	public class account_базаданныхсайта
	{
		public Class1()
		{
			/*создаем коллекуцию*/
			List<account_базаданныхсайта> Col1 = new List<account_базаданныхсайта>();

			Col1 x1 = new Col1("Skogen", "TrineHjerbb");
			Col1 x2 = new Col1("kristian", "KristianBerg");

			Col1.Add(x1);
			Col2.Add(x2);

			/*Linq*/
			string x = x.Where(a => (a.name == "Skogen") && (a.x == "TrineHjerbb")).Count();
			Console.WriteLine(x);

			x = (from a in x where ((a.name == "Skogen") && (a.x == "TrineHjerbb")) select a).Count();
			Console.WriteLine(x);

		}

	}
}
