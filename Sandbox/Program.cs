﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
	public interface IAbstract
	{
		void F();
		int G();
		string H();
		DateTime I();
	}

	public class BlackHole : IAbstract
	{
		/// <inheritdoc />
		public void F()
		{
			
		}

		/// <inheritdoc />
		public int G()
		{
			return 0;
		}

		/// <inheritdoc />
		public string H()
		{
			return null;
		}

		/// <inheritdoc />
		public DateTime I()
		{
			return default(DateTime);
		}
	}

	public class WhiteHole : IAbstract
	{
		/// <inheritdoc />
		public void F()
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public int G()
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public string H()
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public DateTime I()
		{
			throw new NotImplementedException();
		}
	}

	abstract class Abstract1 : IAbstract
	{
		public abstract void Lol();

		/// <inheritdoc />
		public abstract void F();

		/// <inheritdoc />
		public abstract int G();

		/// <inheritdoc />
		public abstract string H();

		/// <inheritdoc />
		public abstract DateTime I();
	}

	abstract class Abstract2 : Abstract1, IAbstract
	{
		/// <inheritdoc />
		public override void Lol()
		{
			
		}

		public abstract void Lol2();
	}

	class Program
	{
		static void Main(string[] args)
		{
			
		}
	}
}
