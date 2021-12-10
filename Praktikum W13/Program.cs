using System;

namespace Praktikum_W13
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Berapa Data = ");
			int jumlahData = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			string[,] Angka = new string[jumlahData * 2, 6];
			int statusData = 0;
			while (statusData == 0)
			{
				for (int i = 0; i < jumlahData + 1; i++)
				{
					for (int j = 0; j < 6; j++)
					{
						if (j == 0 && i > 0)
						{
							Console.Write($"data ke- { i }\nNIM\t\t: ");
							string nomorInduk = Convert.ToString(Console.ReadLine());
							Angka[i, 0] = nomorInduk;
							for (int k = 0; k <= i; k++)
							{
								if (i - 1 != k)
								{
									while (Angka[i - 1, 0] == Angka[k, 0])
									{
										Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
										Console.Write("NIM\t\t: ");
										Angka[i - 1, 0] = Console.ReadLine();
									}
								}
							}
						}

						else if (j == 1 && i > 0)
						{
							Console.Write("NAMA\t\t: ");
							string Nama = Convert.ToString(Console.ReadLine());
							Angka[i, 1] = Nama;
						}
						else if (j == 2 && i > 0)
						{
							Console.Write("JENIS KELAMIN\t: ");
							string jenisKelamin = Convert.ToString(Console.ReadLine());
							Angka[i, 2] = jenisKelamin;
						}
						else if (j == 3 && i > 0)
						{
							Console.Write("TAHUN MASUK\t: ");
							string tahunMasuk = Convert.ToString(Console.ReadLine());
							Angka[i, 3] = tahunMasuk;
						}
						else if (j == 4 && i > 0)
						{
							Console.Write("PROGRAM STUDI\t: ");
							string jenisKelamin = Convert.ToString(Console.ReadLine());
							Angka[i, 4] = jenisKelamin;
						}
						else if (j == 5 && i > 0)
						{
							Console.Write("KELAS\t\t: ");
							string Kelas = Convert.ToString(Console.ReadLine());
							Angka[i, 5] = Kelas;
						}
						else
						{
							statusData = 1;
						}

					}
				}
				Console.Write("PRINT HASIL ? (y/n) ... ");
				string Pilihan = Convert.ToString(Console.ReadLine());

				if (Pilihan == "y") ;
				{
					Console.Clear();
					Console.WriteLine(String.Format("{0,-8}{1,-8}{2,-20}{3,-25}{4,-20}{5,-20}{6,-15}", "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS"));
					for (int i = 0; i < jumlahData; i++)
					{
						Console.WriteLine(String.Format("{0,-8}{1,-8}{2,-20}{3,-25}{4,-20}{5,-20}{6,-15}", i + 1, Angka[i + 1, 0], Angka[i + 1, 1], Angka[i + 1, 2], Angka[i + 1, 3], Angka[i + 1, 4], Angka[i + 1, 5]));
					}
					Console.Write("Tambah Data? (y/n) ... ");
					string tambahData = Convert.ToString(Console.ReadLine());
					if (tambahData == "y")
					{
						Console.WriteLine("Berapa Data = ");
						int jumlahData2 = Convert.ToInt32(Console.ReadLine());
						jumlahData = jumlahData + jumlahData2;
						statusData = 0;
					}
					else
					{
						statusData = 1;
					}
				}
			}
		}
	}
}

