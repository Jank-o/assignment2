using System;

public class Program
{
	static void instruction()
	{
		Console.WriteLine(" tl | t | tr ");
		Console.WriteLine("----+---+----");
		Console.WriteLine(" ml | m | mr ");
		Console.WriteLine("----+---+----");
		Console.WriteLine(" bl | b | br ");
	}

	static void gameloop()
	{
		bool spot_is_free = false;
		string tl = " ", t = " ", tr = " ", ml = " ", m = " ", mr = " ", bl = " ", b = " ", br = " ";
		string wprowadzone, xoro = "x";
		string wo = "ooo", wx = "xxx";
		instruction();
		for (;;)
		{
			while (spot_is_free == false)
			{
				Console.Write($"choose space for {xoro} : ");
				wprowadzone = Console.ReadLine();
				switch (wprowadzone)
				{
					case "tl":
						if (tl == " ")
						{
							tl = xoro;
							spot_is_free = true;
						}
						else
							Console.WriteLine("Wait, thats illegal.");
						break;
					case "t":
						if (t == " ")
						{
							t = xoro;
							spot_is_free = true;
						}
						else
							Console.WriteLine("Wait, thats illegal.");
						break;
					case "tr":
						if (tr == " ")
						{
							tr = xoro;
							spot_is_free = true;
						}
						else
							Console.WriteLine("Wait, thats illegal.");
						break;
					case "ml":
						if (ml == " ")
						{
							ml = xoro;
							spot_is_free = true;
						}
						else
							Console.WriteLine("Wait, thats illegal.");
						break;
					case "m":
						if (m == " ")
						{
							m = xoro;
							spot_is_free = true;
						}
						else
							Console.WriteLine("Wait, thats illegal.");
						break;
					case "mr":
						if (mr == " ")
						{
							mr = xoro;
							spot_is_free = true;
						}
						else
							Console.WriteLine("Wait, thats illegal.");
						break;
					case "bl":
						if (bl == " ")
						{
							bl = xoro;
							spot_is_free = true;
						}
						else
							Console.WriteLine("Wait, thats illegal.");
						break;
					case "b":
						if (b == " ")
						{
							b = xoro;
							spot_is_free = true;
						}
						else
							Console.WriteLine("Wait, thats illegal.");
						break;
					case "br":
						if (br == " ")
						{
							br = xoro;
							spot_is_free = true;
						}
						else
							Console.WriteLine("Wait, thats illegal.");
						break;
					default:
						break;
				}
			}

			Console.Clear();
			instruction();
			Console.WriteLine("\r\n");
			Console.WriteLine($"  {tl} | {t} | {tr} ");
			Console.WriteLine($" ---+---+---");
			Console.WriteLine($"  {ml} | {m} | {mr} ");
			Console.WriteLine($" ---+---+---");
			Console.WriteLine($"  {bl} | {b} | {br} ");
			if (wx == tl + t + tr || wo == tl + t + tr)
			{
				Console.WriteLine($"Winner is :{tl}");
				break;
			}

			if (ml + m + mr == wx || ml + m + mr == wo)
			{
				Console.WriteLine($"Winner is :{ml}");
				break;
			}

			if (bl + b + br == wx || bl + b + br == wo)
			{
				Console.WriteLine($"Winner is :{bl}");
				break;
			}

			if (tl + ml + bl == wx || tl + ml + bl == wo)
			{
				Console.WriteLine($"Winner is :{tl}");
				break;
			}

			if (t + m + b == wx || t + m + b == wo)
			{
				Console.WriteLine($"Winner is :{t}");
				break;
			}

			if (tr + mr + br == wx || tr + mr + br == wo)
			{
				Console.WriteLine($"Winner is :{tr}");
				break;
			}

			if (tl + m + br == wx || tl + m + br == wo)
			{
				Console.WriteLine($"Winner is :{tl}");
				break;
			}

			if (tr + m + bl == wx || tr + m + bl == wo)
			{
				Console.WriteLine($"Winner is :{bl}");
				break;
			}

			if (xoro == "x")
				xoro = "o";
			else
				xoro = "x";
			spot_is_free = false;
			if (tl != " " && t != " " && tr != " " && ml != " " && m != " " && mr != " " && bl != " " && b != " " && br != " ")
			{
				Console.WriteLine("Issa tie :(");
				break;
			}
		}
	}

	public static void Main()
	{
		bool gameon = true;
		string gamemode;
		while (gameon == true)
		{
			Console.WriteLine("CHOOSE : \r\n 1 -> START GAME \r\n 2 -> ABOUT \r\n 3 -> EXIT \r\n");
			gamemode = Console.ReadLine();
			switch (gamemode)
			{
				case "1":
					Console.Clear();
					gameloop();
					break;
				case "2":
					Console.Clear();
					Console.WriteLine("Game created by Jan Grytczuk, a very cool guy");
					break;
				case "3":
					Console.Clear();
					gameon = false;
					break;
				default:
					break;
			}
		}
	}
}