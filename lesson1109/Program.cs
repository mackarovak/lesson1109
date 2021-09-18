using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1109
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("1 часть");
			Console.WriteLine("Задание 1");
			Console.WriteLine("Введите число");
			double chiclo = double.Parse(Console.ReadLine());
			Console.WriteLine(Math.Round(chiclo, 2));

			Console.WriteLine("Задание 2");
			Console.WriteLine("{0:N1}", Math.Exp(1));

			Console.WriteLine("Задание 3");
			string a = Console.ReadLine();
			Console.WriteLine($"Вы ввели число:{a}");

			Console.WriteLine("Задание 4");
			string b = Console.ReadLine();
			Console.WriteLine($"{b} — вот какое число Вы ввели");

			Console.WriteLine("Задание 5");
			int m, k, z;
			m = 1; k = 13; z = 49;
			Console.WriteLine($"{m} {k} {z}");

			Console.WriteLine("Задание 6");
			int q, w, e;
			q = 7; w = 15; e = 100;
			Console.WriteLine($"{q}  {w}  {e}");

			Console.WriteLine("Задание 7");
			Random pt = new Random();
			double pt1 = pt.Next();
			double pt2 = pt.Next();
			double pt3 = pt.Next();
			Console.WriteLine($"{pt1} {pt2} {pt3}");

			Console.WriteLine("Задание 8");
			Random lo = new Random();
			double lo1 = pt.Next();
			double lo2 = pt.Next();
			double lo3 = pt.Next();
			double lo4 = pt.Next();
			Console.WriteLine($"{lo1} {lo2} {lo3} {lo4}");

			Console.WriteLine("Задание 9");
			int r, t;
			r = 50; t = 10;
			Console.WriteLine(r);
			Console.WriteLine(t);

			Console.WriteLine("Задание 10");
			int u = 5;
			int i = 10;
			int o = 21;
			Console.WriteLine(u);
			Console.WriteLine(i);
			Console.WriteLine(o);

			Console.WriteLine("Задание 11");
			Random ag = new Random();
			double ag1 = ag.Next();
			double ag2 = ag.Next();
			double ag3 = ag.Next();
			double ag4 = ag.Next();
			Console.WriteLine($"{ag1}\n {ag2}\n {ag3}\n {ag4}");

			Console.WriteLine("Задание 12");
			int p, s, d;
			p = 5; s = 10; d = 7;
			string izm = "см";
			Console.WriteLine($"{p} {s}\n{d} {izm}");

			Console.WriteLine("Задание 13");
			int g = 2;
			int h = 13;
			int j = 17;
			string mas = "кг";
			Console.WriteLine($"{g} {mas} \n{h} {j}");


			Console.WriteLine("2 часть");
			Console.WriteLine("Задание 1a");
			double x = double.Parse(Console.ReadLine());
			double y;
			y = x * x * 7 + 3 * x + 6;
			Console.WriteLine(y);
			Console.WriteLine("Задание 1b");
			double v = double.Parse(Console.ReadLine());
			double po;
			po = v * v * 12 + 7 * v + 12;
			Console.WriteLine(po);

			Console.WriteLine("Задание 2");
			double storona = double.Parse(Console.ReadLine());
			double perimetr;
			perimetr = storona * 4;
			Console.WriteLine(perimetr);

			Console.WriteLine("Задание 3");
			double radius = double.Parse(Console.ReadLine());
			double diametr;
			diametr = storona * 2;
			Console.WriteLine(diametr);

			Console.WriteLine("Задание 4");
			int R;
			double BG;
			R = 6350;
			double AB = Convert.ToDouble(Console.ReadLine());
			BG = Math.Sqrt((AB + R) * (AB + R) - R * R);
			Console.WriteLine(BG);

			Console.WriteLine("Задание 5");
			double rebro = double.Parse(Console.ReadLine());
			double V, plo;
			V = Math.Pow(rebro, 3);
			plo = 4 * rebro * rebro;
			Console.WriteLine(V);
			Console.WriteLine(plo);

			Console.WriteLine("Задание 6");
			double dlina, ploshad;
			double rad = double.Parse(Console.ReadLine());
			dlina = 2 * Math.PI * rad;
			ploshad = Math.PI * rad * rad;
			Console.Write(dlina);
			Console.WriteLine(ploshad);

			Console.WriteLine("Задание 7");
			int ch1 = Convert.ToInt32(Console.ReadLine());
			int ch2 = Convert.ToInt32(Console.ReadLine());
			double srar, srge;
			srar = (ch1 + ch2) / 2;
			srge = Math.Sqrt(ch1 * ch2);
			Console.Write(srar);
			Console.WriteLine(srge);

			Console.WriteLine("Задание 8");
			double plot;
			double ob = Convert.ToDouble(Console.ReadLine());
			double massa = Convert.ToDouble(Console.ReadLine());
			plot = ob / massa;
			Console.WriteLine(plot);

			Console.WriteLine("Задание 9");
			double plotnas;
			double pronas = Convert.ToDouble(Console.ReadLine());
			double col = Convert.ToDouble(Console.ReadLine());
			plotnas = pronas / col;
			Console.WriteLine(plotnas);

			Console.WriteLine("Задание 10");
			double ab = Convert.ToDouble(Console.ReadLine());
			double ba = Convert.ToDouble(Console.ReadLine());
			double ac;
			ac = -ab / ba;
			Console.WriteLine(ac);

			Console.WriteLine("Задание 11");
			double katet1 = Convert.ToDouble(Console.ReadLine());
			double katet2 = Convert.ToDouble(Console.ReadLine());
			double gip;
			gip = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
			Console.WriteLine(gip);

			Console.WriteLine("Задание 12");
			double Radius = Convert.ToDouble(Console.ReadLine());
			double radiusm = Convert.ToDouble(Console.ReadLine());
			double plosh;
			plosh = Math.PI * (Math.Pow(Radius, 2) - Math.Pow(radiusm, 2));
			Console.WriteLine(plosh);

			Console.WriteLine("Задание 13");
			double katet3 = Convert.ToDouble(Console.ReadLine());
			double katet4 = Convert.ToDouble(Console.ReadLine());
			double gip1;
			gip1 = Math.Sqrt(katet3 * katet3 + katet4 * katet4);
			perimetr = katet3 + katet4 + gip1;
			Console.WriteLine(perimetr);

			Console.WriteLine("Задание 13a");
			double ch3 = Convert.ToDouble(Console.ReadLine());
			double ch4 = Convert.ToDouble(Console.ReadLine());
			double srar1, srge1;
			srar1 = (Math.Abs(ch3) + Math.Abs(ch4)) / 2;
			srge1 = Math.Sqrt(Math.Abs(ch3) * Math.Abs(ch4));
			Console.Write(srar1);
			Console.WriteLine(srge1);

			Console.WriteLine("Задание 14");
			double osn1 = Convert.ToDouble(Console.ReadLine());
			double osn2 = Convert.ToDouble(Console.ReadLine());
			double vys = Convert.ToDouble(Console.ReadLine());
			double stor, per;
			stor = Math.Sqrt((osn1 - osn2) * (osn1 - osn2) + vys * vys);
			per = 2 * stor + osn1 + osn2;
			Console.WriteLine(per);

			Console.WriteLine("Задание 14а");
			double stor1 = Convert.ToDouble(Console.ReadLine());
			double stor2 = Convert.ToDouble(Console.ReadLine());
			double peri, diag;
			peri = 2 * (stor1 + stor2);
			diag = Math.Sqrt(stor1 * stor1 + stor2 * stor2);
			Console.Write(peri);
			Console.WriteLine(diag);

			Console.WriteLine("Задание 15");
			double jk = Convert.ToDouble(Console.ReadLine());
			double jh = Convert.ToDouble(Console.ReadLine());
			double sum, razn, proiz, chast;
			sum = jk + jh;
			razn = jk - jh;
			proiz = jk * jh;
			chast = jk / jh;
			Console.WriteLine(sum);
			Console.WriteLine(razn);
			Console.WriteLine(proiz);
			Console.WriteLine(chast);

			Console.WriteLine("Задание 16");
			double a1 = Convert.ToDouble(Console.ReadLine());
			double a2 = Convert.ToDouble(Console.ReadLine());
			double a3 = Convert.ToDouble(Console.ReadLine());
			double obem, ploshadb;
			obem = a1 * a2 * a3;
			ploshadb = 2 * a3 * (a1 + a2);
			Console.WriteLine(obem);
			Console.WriteLine(ploshadb);

			Console.WriteLine("Задание 17");
			double xa = Convert.ToDouble(Console.ReadLine());
			double xb = Convert.ToDouble(Console.ReadLine());
			double ya = Convert.ToDouble(Console.ReadLine());
			double yb = Convert.ToDouble(Console.ReadLine());
			double rast;
			rast = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2));
			Console.WriteLine(rast);

			Console.WriteLine("Задание 18-повтор 14");

			Console.WriteLine("Задание 19");
			double osnm = Convert.ToDouble(Console.ReadLine());
			double osnb = Convert.ToDouble(Console.ReadLine());
			double ugol = Convert.ToDouble(Console.ReadLine());
			double ploshadtrap, vysot;
			vysot = (osnb - osnm) / 2 * Math.Tan(ugol);
			ploshadtrap = (osnm + osnb) / 2 * vysot;
			Console.WriteLine(ploshadtrap);

			Console.WriteLine("Задание 20");
			double x1 = Convert.ToDouble(Console.ReadLine());
			double y1 = Convert.ToDouble(Console.ReadLine());
			double x2 = Convert.ToDouble(Console.ReadLine());
			double y2 = Convert.ToDouble(Console.ReadLine());
			double x3 = Convert.ToDouble(Console.ReadLine());
			double y3 = Convert.ToDouble(Console.ReadLine());
			double op, op1, op2, i1, i2, i3;
			op = Math.Sqrt((Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)));
			op1 = Math.Sqrt((Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2)));
			op2 = Math.Sqrt((Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)));
			i1 = op + op1 + op2;
			i2 = i1 / 2;
			i3 = Math.Sqrt(i2 * (i2 - op) * (i2 - op1) * (i2 - op2));
			Console.WriteLine(i1);
			Console.WriteLine(i3);

			Console.WriteLine("Задание 21");
			double na1 = Convert.ToDouble(Console.ReadLine());
			double an1 = Convert.ToDouble(Console.ReadLine());
			double na2 = Convert.ToDouble(Console.ReadLine());
			double an2 = Convert.ToDouble(Console.ReadLine());
			double na3 = Convert.ToDouble(Console.ReadLine());
			double an3 = Convert.ToDouble(Console.ReadLine());
			double gh, gh1, gh2, kl1, kl2, kl3;
			gh = Math.Sqrt((Math.Pow((na1 - na2), 2) + Math.Pow((an1 - an2), 2)));
			gh1 = Math.Sqrt((Math.Pow((na2 - na3), 2) + Math.Pow((an2 - an3), 2)));
			gh2 = Math.Sqrt((Math.Pow((na3 - na1), 2) + Math.Pow((an3 - an1), 2)));
			kl1 = gh + gh1 + gh2;
			kl2 = kl1 / 2;
			kl3 = Math.Sqrt(kl2 * (kl2 - gh) * (kl2 - gh1) * (kl2 - gh2));
			double bz1 = Convert.ToDouble(Console.ReadLine());
			double zb1 = Convert.ToDouble(Console.ReadLine());
			double bz2 = Convert.ToDouble(Console.ReadLine());
			double zb2 = Convert.ToDouble(Console.ReadLine());
			double bz3 = Convert.ToDouble(Console.ReadLine());
			double zb3 = Convert.ToDouble(Console.ReadLine());
			double to, to1, to2, ut1, ut2, ut3, lop;
			to = Math.Sqrt((Math.Pow((bz1 - bz2), 2) + Math.Pow((zb1 - zb2), 2)));
			to1 = Math.Sqrt((Math.Pow((bz2 - bz3), 2) + Math.Pow((zb2 - zb3), 2)));
			to2 = Math.Sqrt((Math.Pow((bz3 - bz1), 2) + Math.Pow((zb3 - zb1), 2)));
			ut1 = to + to1 + to2;
			ut2 = ut1 / 2;
			ut3 = Math.Sqrt(ut2 * (ut2 - to) * (ut2 - to1) * (kl2 - to2));
			lop = ut3 + kl3;
			Console.WriteLine(lop);

			Console.WriteLine("Задание 22");
			double ki = Convert.ToDouble(Console.ReadLine());
			double pe = Convert.ToDouble(Console.ReadLine());
			double yab = Convert.ToDouble(Console.ReadLine());
			double kki = Convert.ToDouble(Console.ReadLine());
			double kpe = Convert.ToDouble(Console.ReadLine());
			double kyab = Convert.ToDouble(Console.ReadLine());
			double summ;
			summ = ki * kki + pe * kpe + yab * kyab;
			Console.WriteLine(summ);

			Console.WriteLine("Задание 23");
			double mon = Convert.ToDouble(Console.ReadLine());
			double sist = Convert.ToDouble(Console.ReadLine());
			double kla = Convert.ToDouble(Console.ReadLine());
			double mouse = Convert.ToDouble(Console.ReadLine());
			double komp3, kompn;
			double ni = Convert.ToDouble(Console.ReadLine());
			komp3 = (mon + sist + kla + mouse) * 3;
			kompn = (mon + sist + kla + mouse) * ni;
			Console.WriteLine(komp3);
			Console.WriteLine(kompn);

			Console.WriteLine("Задание 24");
			double Tanya = Convert.ToDouble(Console.ReadLine());
			double Mitya = Convert.ToDouble(Console.ReadLine());
			double srednee, otTanya, otMitya;
			srednee = (Tanya + Mitya) / 2;
			otTanya = Math.Abs(Tanya - srednee);
			otMitya = Math.Abs(Mitya - srednee);
			Console.WriteLine(otTanya);
			Console.WriteLine(srednee);
			Console.WriteLine(otMitya);

			Console.WriteLine("Задание 25");
			double v1 = Convert.ToDouble(Console.ReadLine());
			double v2 = Convert.ToDouble(Console.ReadLine());
			double vremya;
			double rust = Convert.ToDouble(Console.ReadLine());
			vremya = rust / (v1 + v2);
			Console.WriteLine(vremya);

			Console.WriteLine("Задание 26");
			double v3 = Convert.ToDouble(Console.ReadLine());
			double v4 = Convert.ToDouble(Console.ReadLine());
			double s2 = Convert.ToDouble(Console.ReadLine());
			double s3;
			s3 = s2 + (v3 - v4) * 0.5;
			Console.WriteLine(s3);

			Console.WriteLine("Задание 27");
			double tempc = Convert.ToDouble(Console.ReadLine());
			double tempk, tempf;
			tempf = tempc * 1.8 + 32;
			tempk = 273.15 + tempc;
			Console.WriteLine(tempf);
			Console.WriteLine(tempk);

			Console.WriteLine("Задание 28");
			int temp = 450;
			double tempcel;
			tempcel = (temp - 32) / 1.8;
			Console.WriteLine(tempcel);

			Console.WriteLine("3 часть");
			Console.WriteLine("Задание 1");
			double q1 = Convert.ToDouble(Console.ReadLine());
			double q2 = Convert.ToDouble(Console.ReadLine());
			q1 = q1 + q2;
			q2 = q1 - q2;
			q1 = q1 - q2;

			Console.WriteLine("Задание 2a");
			double t1 = Convert.ToDouble(Console.ReadLine());
			double t2 = Convert.ToDouble(Console.ReadLine());
			double t3 = Convert.ToDouble(Console.ReadLine());
			double tempp;
			tempp = t1;
			t1 = t2;
			t2 = t3;
			t3 = tempp;

			Console.WriteLine("Задание 2б");
			double p1 = Convert.ToDouble(Console.ReadLine());
			double p2 = Convert.ToDouble(Console.ReadLine());
			double p3 = Convert.ToDouble(Console.ReadLine());
			double butter;
			butter = t1;
			t1 = t3;
			t3 = t2;
			t2 = butter;

			Console.WriteLine("Задание 3");
			double b1 = Convert.ToDouble(Console.ReadLine());
			b1 = b1 * b1;
			b1 = b1 * b1;
			double b2 = Convert.ToDouble(Console.ReadLine());
			b2 = b2 * b2;
			b2 = b2 * b2;
			b2 = b2 * b2;
			double b3 = Convert.ToDouble(Console.ReadLine());
			double b4, b5, b6, b7;
			b4 = b3 * b3;
			b5 = b4 * b3;
			b6 = b5 * b5;
			b7 = b6 * b4;
			double w1 = Convert.ToDouble(Console.ReadLine());
			double w2, w3, w4;
			w2 = w1 * w1;
			w3 = w2 * w2;
			w4 = w3 * w3;
			double r1 = Convert.ToDouble(Console.ReadLine());
			double r2, r3, r4, r5;
			r2 = r1 * r1;
			r3 = r2 * r2;
			r4 = r3 * r3;
			r5 = r4 * r1;
			double o1 = Convert.ToDouble(Console.ReadLine());
			double o2, o3, o4, o5;
			o2 = o1 * o1;
			o3 = o2 * o2;
			o4 = o3 * o3;
			o5 = o4 * o2;

			Console.WriteLine("Задание 4");
			double l1 = Convert.ToDouble(Console.ReadLine());
			double l2, l3, l4, l5;
			l2 = l1 * l1;
			l3 = l2 * l1;
			l4 = l3 * l2;
			l5 = l4 * l4;
			double j1 = Convert.ToDouble(Console.ReadLine());
			double j2, j3, j4, j5, j6;
			j2 = j1 * j1;
			j3 = j2 * j2;
			j4 = j3 * j3;
			j5 = j4 * j4;
			j6 = j5 * j2;
			double g1 = Convert.ToDouble(Console.ReadLine());
			double g2, g3, g4, g5, g6;
			g2 = g1 * g1;
			g3 = g2 * g2;
			g4 = g3 * g1;
			g5 = g3 * g3;
			g6 = g5 * g4;
			double f1 = Convert.ToDouble(Console.ReadLine());
			double f2, f3, f4, f5, f6, f7;
			f2 = f1 * f1;
			f3 = f2 * f2;
			f4 = f3 * f1;
			f5 = f4 * f4;
			f6 = f5 * f4;
			f7 = f6 * f3;
			double n1 = Convert.ToDouble(Console.ReadLine());
			double n2, n3, n4, n5, n6, n7;
			n2 = n1 * n1;
			n3 = n2 * n2;
			n4 = n3 * n1;
			n5 = n4 * n4;
			n6 = n5 * n4;
			n7 = n6 * n2;
			double d1 = Convert.ToDouble(Console.ReadLine());
			double d2, d3, d4, d5, d6, d7;
			d2 = d1 * d1;
			d3 = d2 * d2;
			d4 = d3 * d3;
			d5 = d4 * d3;
			d6 = d4 * d4;
			d7 = d5 * d6;

			Console.WriteLine("Задание 5");
			double frog = Math.Pow(10, 10);
			double rog, og;
			rog = frog - 1 + 9;
			og = rog / 1000;
			Console.WriteLine("og");
			Console.ReadKey();
		}
    }
}
