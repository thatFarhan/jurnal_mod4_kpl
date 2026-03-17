using System;

public class MesinKopi
{
	enum State { OFF, STANDBY, BREWING, MAINTENANCE };
	public static void Main()
	{
		State state = State.OFF;
		string[] screenName = { "Off", "Standby", "Brewing", "Maintenance" };

        Console.WriteLine("Mesin Off");
        while (true)
		{
			State previousState = state;
			Console.Write("Masukkan command: ");
			string command = Console.ReadLine();
			switch (state)
			{
				case State.OFF:
					if (command == "POWER_ON")
					{
						state = State.STANDBY;
					}
					break;
				case State.STANDBY:
					if (command == "POWER_OFF")
					{
						state = State.OFF;
					} else if (command == "START_BREW")
					{
						state = State.BREWING;
					} else if (command == "START_MAINTENANCE")
					{
						state = State.MAINTENANCE;
					}
					break;
				case State.BREWING:
					if (command == "FINISH_BREW")
					{
						state = State.STANDBY;
					}
					break;
				case State.MAINTENANCE:
					if (command == "FINISH_MAINTENANCE")
					{
						state = State.STANDBY;
					}
					break;
			}
			if (previousState == state)
			{
				Console.WriteLine("Perubahan state tidak valid");
			} else
			{
				Console.WriteLine($"Mesin {screenName[(int)previousState]} berubah menjadi {screenName[(int)state]}");
			}
		}
	}
}
