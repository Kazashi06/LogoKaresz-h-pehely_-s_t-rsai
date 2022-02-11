using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		
		void Koch_fraktál(int év, double meret)
        {
            if (év==1)
            {
               Előre(meret);
            }
            else if(év>1)
            {
				Koch_fraktál(év-1, meret / 3);
				Balra(60);
				Koch_fraktál(év - 1, meret / 3);
				Jobbra(120);
				Koch_fraktál(év - 1, meret / 3);
				Balra(60);
				Koch_fraktál(év - 1, meret / 3);
			}
			
        }

		void pehely(int év, double meret)
        {
            for (int i = 0; i < 6; i++)
            {
				Koch_fraktál(év, meret);
				Jobbra(60);
            }
        }





		void rekurzív_háromszög_oldal(int év, double meret)
        {
			if (év == 1)
			{
				Előre(meret);
			}
			else if (év > 1)
			{
				Balra(30);
				rekurzív_háromszög_oldal(év - 1, meret / 2);
				Jobbra(60);
				rekurzív_háromszög_oldal(év - 1, meret / 2);
				Balra(60);
				rekurzív_háromszög_oldal(év - 1, meret / 2);
				Jobbra(30);
			}
		}
		void Rekurzív_háromszög(int év, double meret)
        {
			for (int i = 0; i < 3; i++)
			{
				rekurzív_háromszög_oldal(év, meret);
				Jobbra(120);
			}
		}



		void Levy_féle_c_görbe(int év, double meret)
        {
			if (év == 1)
			{
				Előre(meret);
			}
			else if (év > 1)
			{
				Jobbra(90);
				Levy_féle_c_görbe(év - 1, meret / 2);
				Balra(90);
				Levy_féle_c_görbe(év - 1, meret / 2);
				Levy_féle_c_görbe(év - 1, meret / 2);
				Balra(90);

				Levy_féle_c_görbe(év - 1, meret / 2);
				Jobbra(90);

			}			
		}



		void virág_fraktál(int év, double meret)
        {
			if (év == 1)
			{
				Előre(meret);
			}
			else if (év > 1)
			{
				
				virág_fraktál(év - 1, meret / 2);
				Jobbra(60);
				virág_fraktál(év - 1, meret / 2);
				Balra(120);
				virág_fraktál(év - 1, meret);
				Jobbra(120);
				virág_fraktál(év - 1, meret / 2);
				Balra(60);

			}

		}
		void virág(int n, int év, double meret)
        {
			double fok = 360 / n;
			for (int i = 0; i < n; i++)
			{
				virág_fraktál(év, meret);
				Jobbra(fok);
			}
		}

		void ötszögesfraktal1(int év,double meret)
        {
			if (év == 1)
			{
				Előre(meret);
			}
			else if (év > 1)
			{

				ötszögesfraktal1(év - 1, meret / 2);
				Jobbra(72);
				ötszögesfraktal1(év - 1, meret / 2);
				Balra(144);
				ötszögesfraktal1(év - 1, meret / 2);
				Balra(72);
				ötszögesfraktal1(év - 1, meret / 2);
				Jobbra(72);
				ötszögesfraktal1(év - 1, meret / 2);
				Jobbra(72);
				ötszögesfraktal1(év - 1, meret / 2);
				
			}
		}

		void fra5(int év, double meret)
        {

			if (év == 1)
			{
				double fok = 360 / 5;
				for (int i = 0; i < 5; i++)
				{
					Előre(meret);
					Jobbra(fok);
				}
			}
			else if (év > 1)
			{

                for (int i = 0; i < 5; i++)
                {
					Előre(meret);
					Balra(72);
					fra5(év - 1, meret);
					Jobbra(72 + 360/5);
                }
				Balra(360 / 5);

			}
		}

		void FELADAT()
		{
			//Teleport(200, 200, észak);
			//Jobbra(90);
			//Levy_féle_c_görbe(7, 200);
            using (new Frissítés(true))
            {
				
            }
			//virág(5,4, 30);
			//ötszögesfraktal1(3, 100);
			fra5(2, 50);
		}
	}
}
