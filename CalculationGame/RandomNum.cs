using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationGame
{
	class RandomNum
	{
		private int easyNum; /*= rand.Next(1, 11);*/
		private int normalNum;
		private int hardnum;
		private int randomOperator;

		Random rand = new Random();

		public RandomNum()
		{
			easyNum = rand.Next(1, 11);
			normalNum = rand.Next(10, 101);
			hardnum = rand.Next(100, 1001);
			randomOperator = rand.Next(1, 5);
		}

		public int EasyNum
		{
			get  { return easyNum; }
		}
		public int NormalNum
		{
			get { return normalNum; }
		}
		public int Hardnum
		{
			get { return hardnum; }
		}
		public int RandomOperator
		{
			get { return randomOperator; }
		}
	}
}
