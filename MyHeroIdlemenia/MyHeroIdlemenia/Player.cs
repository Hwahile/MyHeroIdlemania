using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyHeroIdlemenia
{
	public class Player : INotifyPropertyChanged
	{

		// test
		//double str_akt, str_hp, dex_cr, con_hp, int_cd;

		#region Properties (private)

		/// <summary>
		/// Name des Spielers
		/// </summary>
		private string _Name = "";

		/// <summary>
		/// Erfahrung des Spielers
		/// </summary>
		private int _Experience = 0;

		private double _Dexterity = 20.0;
		private double _Strength = 20.0;
		private double _Constitution = 20.0;
		private double _Intelligence = 20.0;
		private double _CritRate = 0.0;

		private int _Level = 0;
		private int _ExpPerSecond = 1;
		private int _Statuspoints = 250;
		private int _CurrentExp = 0;
		private int _CurrentMaxExp = 0;

		#endregion Properties (private)

		#region Constructors

		/// <summary>
		/// Standard Konstruktor
		/// </summary>
		public Player(string pName = "")
		{
			if (!string.IsNullOrWhiteSpace(pName))
				this.Name = pName;

		}

		#endregion Constructors
		
		#region Properties (public)

		public string Name
		{
			get { return this._Name; }
			set { this._Name = value; }
		}

		public int Experience
		{
			get { return this._Experience; }
			set { this._Experience = value; }
		}

		public double Strength
		{
			get { return this._Strength; }
			set
			{
				this._Strength = value;
				NotifyPropertyChanged();
			}
		}

		public double Dexterity
		{
			get { return this._Dexterity; }
			set
			{
				this._Dexterity = value;
				NotifyPropertyChanged();
			}
		}

		public double Constitution
		{
			get { return this._Constitution; }
			set { this._Constitution = value; NotifyPropertyChanged(); }
		}

		public double Intelligence
		{
			get { return this._Intelligence; }
			set { this._Intelligence = value; NotifyPropertyChanged(); }
		}

		public double CritRate
		{
			get { return this._CritRate; }
			set { this._CritRate = value; NotifyPropertyChanged(); }
		}

		public int Level
		{
			get { return this._Level; }
			set { this._Level = value; NotifyPropertyChanged(); }
		}

		public int ExpPerSecond
		{
			get { return this._ExpPerSecond; }
			set { this._ExpPerSecond = value; NotifyPropertyChanged(); }
		}

		public int Statuspoints
		{
			get { return this._Statuspoints; }
			set { this._Statuspoints = value; NotifyPropertyChanged(); }
		}

		public int CurrentExp
		{
			get { return this._CurrentExp; }
			set { this._CurrentExp = value; NotifyPropertyChanged(); }
		}

		public int CurrentMaxExp
		{
			get { return this._CurrentMaxExp; }
			set { this._CurrentMaxExp = value; NotifyPropertyChanged(); }
		}

		public int CurrentMaxExpMinusOne
		{
			get { return this._CurrentMaxExp-1; }
		}

		public event PropertyChangedEventHandler PropertyChanged;
		
		#endregion Properties (public)
		
		// This method is called by the Set accessor of each property.
		// The CallerMemberName attribute that is applied to the optional propertyName
		// parameter causes the property name of the caller to be substituted as an argument.
		private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

			// Wenn CurrentMaxExp sich ändert müssen auch die Bindings auf CurrentMaxExpMinusOne reagieren
			if (propertyName == "CurrentMaxExp")
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentMaxExpMinusOne"));
		}

		/// <summary>
		/// Enum, für die 4 Hauptwerte
		/// </summary>
		public enum Stat
		{
			Strength = 0,
			Dexterity = 1,
			Constitution = 2,
			Intelligence = 3,
		}
	}
}
