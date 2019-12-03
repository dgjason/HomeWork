using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyMVC.Pages
{
	public class Land
	{
		public Land()
		{			
		}
		public Land(string address, double landping, string owner)
		{
			Address = address;
			Landping = landping;
			Owner = owner;
		}

		string _address;
		double _landping;
		string _owner;

		//[Required]
		[Display(Name = "Land Address")]
		[Required(ErrorMessage = "{0} must input")]
		public string Address
		{
			get
			{
				return _address;
			}

			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					_address = value;
				}
				else
				{
					throw new Exception("Address can not be empty");
				}
			}
		}

		[Required]
		[Display(Name = "Land Landping")]		
		public double Landping
		{
			get
			{
				return _landping;
			}

			set
			{
				if (!double.IsNaN(value) && value > 0)
				{
					_landping = value;
				}
				else
				{
					throw new Exception("Land Ping must be a number");
				}
			}
		}

		[Display(Name = "Land Owner", Prompt = "DG ")]		
		public string Owner
		{
			get
			{
				return _owner;
			}

			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					_owner = value;
				}
				else
				{
					throw new Exception("Owner can not be empty");
				}
			}
		}

		public void ShowLand()
		{
			//Console.WriteLine($"Address={Address}");
			//Console.WriteLine($"Land Pings={Landping}");
			//Console.WriteLine($"Owner={Owner}");
			//Console.WriteLine("");
		}
	}
}
