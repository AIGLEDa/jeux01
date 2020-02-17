using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux01.Personnage
{
    public class De
    {
		private Random random;

		public De()
		{
			random = new Random();
		}

		public int LanceLeDe()
		{
			return random.Next(1, 7);
		}
	}
}
