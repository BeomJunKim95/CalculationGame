using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationGame
{
	class Program
	{
		static void Main(string[] args)
		{
			CalculateGameManager manager = new CalculateGameManager();

			while (true)
			{
				int choice;
				while (true)
				{
					manager.ShowMenu();
					if (int.TryParse(Console.ReadLine(), out choice))
					{
						if (choice < 1 || choice > 4)
						{
							Console.WriteLine("\n메뉴선택을 1 ~ 4 까지의 번호로 해주세요\n");
						}
						else
						{
							break;
						}
					}


				}
				switch (choice)
				{
					case 1:
						manager.EasyMode();
						break;
					case 2: break;
					case 3: break;
					case 4: Console.WriteLine("\n프로그램을 종료합니다\n다음에 다시 플레이 해주세요!!\n"); return;
				}
			}
		}
	}
}
