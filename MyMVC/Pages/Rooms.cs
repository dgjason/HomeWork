using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Pages
{
	public class Room
	{
		public enum roomtype { Bedroom, Livingroom, Kitchen, Bathroom };

		public Room(double roomping, int windows, roomtype roomtype, int level)
		{
			Roomping = roomping;
			Windows = windows;
			Roomtype = roomtype;
			Level = level;
		}

		double _roomping;
		int _windows;
		int _level;

		public double Roomping
		{
			get
			{
				return _roomping;
			}

			set
			{
				if (!double.IsNaN(value) && value > 0)
				{
					_roomping = value;
				}
				else
				{
					throw new Exception("Room Ping must be a positive number");
				}
			}
		}

		public Int32 Windows
		{
			get
			{
				return _windows;
			}

			set
			{
				if (value >= 0)
				{
					_windows = value;
				}
				else
				{
					throw new Exception("The number of windows must be greater than or equal to 0");
				}
			}
		}

		public roomtype Roomtype { get; set; }

		public Int32 Level
		{
			get
			{
				return _level;
			}

			set
			{
				if (value >= 0)
				{
					_level = value;
				}
				else
				{
					throw new Exception("Level must be a positive number");
				}
			}
		}

		public void ShowRoom()
		{
			//Console.WriteLine($"Roomping={Roomping}");
			//Console.WriteLine($"Windows={Windows}");
			//Console.WriteLine($"Roomtype={Roomtype}");
			//Console.WriteLine("");
		}
	}
}
