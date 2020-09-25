using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationGame
{
	class CalculateGameManager
	{
		Random rand = new Random();
		public void ShowMenu()
		{
			Console.WriteLine("===================== 사칙연산 게임 =====================");
			Console.WriteLine("난이도 선택  =>  1. 하  |  2. 중  |  3. 상  |  4. 게임종료");
			Console.WriteLine("========================================================");
			Console.Write("난이도를 선택해주세요 ( 1 ~ 3 ) : ");
		}

		public void EasyMode()
		{
			RandomNum easyMode = new RandomNum();
			Console.WriteLine("[ 난이도 하 ]를 선택하셨습니다. 이지모드가 시작됩니다!");
			//int oper = easyMode.RandomOperator;
			
			int oper = rand.Next(1, 5);
			switch (oper)
			{
				case 1:
					PlusGame(1);
					break;
				case 2:
					MinusGame(1);
					break;
				case 3:
					MultuplyGame(1);
					break;
				case 4:
					DivideGame(1);
					break;
			}

		}

		private void DivideGame(int x)
		{
			if (x == 1)
			{
				RandomNum num1 = new RandomNum();
				RandomNum num2 = new RandomNum();
				Console.Write($"{num1.EasyNum} / {num2.EasyNum} = ");
				int answer = int.Parse(Console.ReadLine());
				if (num1.EasyNum / num2.EasyNum == answer)
				{
					Console.WriteLine("정답입니다!!");
				}
				else
					Console.WriteLine("오답입니다 ㅠㅠ");
			}
		}

		private void MultuplyGame(int x)
		{
			if (x == 1)
			{
				RandomNum num1 = new RandomNum();
				RandomNum num2 = new RandomNum();
				Console.Write($"{num1.EasyNum} * {num2.EasyNum} = ");
				int answer = int.Parse(Console.ReadLine());
				if (num1.EasyNum * num2.EasyNum == answer)
				{
					Console.WriteLine("정답입니다!!");
				}
				else
					Console.WriteLine("오답입니다 ㅠㅠ");
			}
		}

		private void MinusGame(int x)
		{
			if (x == 1)
			{
				RandomNum num1 = new RandomNum();
				RandomNum num2 = new RandomNum();
				Console.Write($"{num1.EasyNum} - {num2.EasyNum} = ");
				int answer = int.Parse(Console.ReadLine());
				if (num1.EasyNum - num2.EasyNum == answer)
				{
					Console.WriteLine("정답입니다!!");
				}
				else
					Console.WriteLine("오답입니다 ㅠㅠ");
			}
		}

		private void PlusGame(int x)
		{
			//while(true)

			if (x == 1)
			{
				RandomNum num1 = new RandomNum();
				RandomNum num2 = new RandomNum();
				Console.Write($"{num1.EasyNum} + {num2.EasyNum} = ");
				int answer = int.Parse(Console.ReadLine());
				if (num1.EasyNum + num2.EasyNum == answer)
				{
					Console.WriteLine("정답입니다!!");
				}
				else
					Console.WriteLine("오답입니다 ㅠㅠ");
			}
		}
	}
}
