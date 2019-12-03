using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Pages
{
	public class House
	{
		public enum housetype { Thorough, Building };

		public House(Land land, housetype housetype, int floors)
		{
			Land = land;
			Floors = floors;
		}

		Land _land;

		int _floors;

		public List<Room> Rooms = new List<Room>();

		public Land Land
		{
			get
			{
				return _land;
			}
			set
			{
				if (value != null)
				{
					_land = value;
				}
			}
		}

		public int Floors
		{
			get
			{
				return _floors;
			}

			set
			{
				if (value > 0)
				{
					_floors = value;
				}
				else
				{
					throw new Exception("Floors must be a positive number");
				}
			}
		}

		public virtual void ShowHouse()
		{
			int bathrooms = 0;
			int bedrooms = 0;
			int kitchens = 0;
			int livingrooms = 0;
			double totalbuildingping = 0;

			Land.ShowLand();

			totalbuildingping = TotalPings();

			foreach (Room aRoom in Rooms)
			{
				switch (aRoom.Roomtype)
				{
					case Room.roomtype.Bathroom:
						bathrooms++;
						break;
					case Room.roomtype.Bedroom:
						bedrooms++;
						break;
					case Room.roomtype.Kitchen:
						kitchens++;
						break;
					case Room.roomtype.Livingroom:
						livingrooms++;
						break;
					default:
						bedrooms++;
						break;
				}
			}

			//Console.WriteLine($"TotalBuildingPing={totalbuildingping}");
			//Console.WriteLine($"Bedroom={bedrooms}");
			//Console.WriteLine($"Livingroom={livingrooms}");
			//Console.WriteLine($"Kitchen={kitchens}");
			//Console.WriteLine($"Bathroom={bathrooms}");
			//Console.WriteLine("");
		}

		public virtual double TotalPings()
		{
			double totalbuildingping = 0;

			foreach (Room aRoom in Rooms)
			{
				totalbuildingping += aRoom.Roomping;
			}

			return totalbuildingping;
		}

		public virtual void AddRooms(Room room)
		{
			if (CheckRooms(room))
			{
				Rooms.Add(room);
			}
		}

		public virtual bool CheckRooms(Room room)
		{
			bool roomch = true;
			int roomlevel = 0;
			double levelroompings = 0;

			if (room.Level > Floors)
			{
				roomch = false;
				throw new Exception("Room level must be less than or equal to floor");
			}

			Rooms.Sort((x, y) => { return x.Level.CompareTo(y.Level); });

			foreach (Room aRoom in Rooms)
			{
				if (roomlevel != aRoom.Level)
				{
					if (roomlevel != 0 && levelroompings > Land.Landping)
					{
						roomch = false;
						throw new Exception($"Level{ roomlevel }'s Room total pings must be less than or equal to Land ping");
					}

					roomlevel = aRoom.Level;
					levelroompings = aRoom.Roomping;
				}
				else
				{
					levelroompings += aRoom.Roomping;
				}
			}

			return roomch;
		}
	}
}
