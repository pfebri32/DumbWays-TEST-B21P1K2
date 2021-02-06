using System;
using System.Collections.Generic;
					
// C# Programming Language

public class Program
{
    // Declaration
    public static int tunjanganIstri = 200000;
    public static int tunjanganPerAnak = 100000;
    public static int potonganPensiun = 200000;
    public static int potonganBPJS = 150000;
    public static Dictionary<string, bool> genderList = new Dictionary<string, bool>();
    public static Dictionary<string, int> gajiPokokPerGolongan = new Dictionary<string, int>();
    public static Dictionary<string, int> tunjanganPerGolongan = new Dictionary<string, int>();
    
	public static void Main()
	{
	    // Initiate Dictionary.
	    genderList.Add("L", false);
	    genderList.Add("Laki", false);
	    genderList.Add("Laki-laki", false);
	    genderList.Add("Pria", false);
	    genderList.Add("Male", false);
	    genderList.Add("P", true);
	    genderList.Add("Perempuan", true);
	    genderList.Add("Wanita", true);
	    genderList.Add("Female", true);
	    
	    gajiPokokPerGolongan.Add("Golongan I", 1500000);
	    gajiPokokPerGolongan.Add("Golongan II", 2000000);
	    gajiPokokPerGolongan.Add("Golongan III", 3000000);
	    gajiPokokPerGolongan.Add("Golongan IV", 4000000);
	    
	    tunjanganPerGolongan.Add("Golongan I", 200000);
	    tunjanganPerGolongan.Add("Golongan II", 400000);
	    tunjanganPerGolongan.Add("Golongan III", 600000);
	    tunjanganPerGolongan.Add("Golongan IV", 1000000);
	    
	    hitungGaji("Golongan IV", "L", "Menikah", 1);
	}
	
	public static void hitungGaji(string golongan, string gender, string marriageStatus, int ownKids) 
	{
	    if (!validate(golongan, gender, ownKids)) {
	        Console.WriteLine("Dimohon memasukkan data yang baik dan benar.");
	        return;
	    }
	    
	    bool isFemale = genderList[gender];
	    string genderText = "Laki-laki";
	    int hasilTunjanganIstri = 0;
	    int hasilTunjanganAnak = ownKids * tunjanganPerAnak;
	    
	    if (isFemale) genderText = "Perempuan";
	    if (!isFemale && marriageStatus == "Menikah") hasilTunjanganIstri = tunjanganIstri;
	    if (ownKids > 2) hasilTunjanganAnak = 200000;
	    
	    int totalGaji = gajiPokokPerGolongan[golongan] 
	        + tunjanganPerGolongan[golongan] 
	        + hasilTunjanganIstri 
	        + hasilTunjanganAnak;
	    int totalPajak = totalGaji / 10;
	    
	    string liner = "===============================";
	    Console.WriteLine("HASIL PERHITUNGAN GAJI");
	    Console.WriteLine(liner);
	    Console.WriteLine("INFO PEGAWAI");
	    Console.WriteLine(liner);
	    Console.WriteLine("Pegawai yang bersangkutan");
	    Console.WriteLine($"Golongan: {golongan}");
	    Console.WriteLine($"Jenis Kelamin: {genderText}");
	    Console.WriteLine($"Jumlah anak: {ownKids}");
	    Console.WriteLine(liner);
	    Console.WriteLine("GAJI DAN TUNJANGAN");
	    Console.WriteLine(liner);
	    Console.WriteLine($"Gaji Pokok: {gajiPokokPerGolongan[golongan]}");
	    Console.WriteLine($"Tunjangan: {tunjanganPerGolongan[golongan]}");
	    Console.WriteLine($"Tunjangan Istri: {hasilTunjanganIstri}");
	    Console.WriteLine($"Tunjangan Anak: {hasilTunjanganAnak}");
	    Console.WriteLine($"Total: {totalGaji}");
	    Console.WriteLine($"Pajak 10%: {totalPajak}");
	    Console.WriteLine("Gaji Sementara: " + (totalGaji - totalPajak));
	    Console.WriteLine(liner);
	    Console.WriteLine("GAJI BERSIH");
	    Console.WriteLine(liner);
	    Console.WriteLine($"Potongan pensiun: {potonganPensiun}");
	    Console.WriteLine($"Potongan BPJS: {potonganBPJS}");
	    Console.WriteLine("GAJI BERSIH: " 
	        + (totalGaji - totalPajak - potonganPensiun - potonganBPJS));
	}
	
	public static bool validate(string golongan, string gender, int ownKids) 
	{
	    bool isValid = true;
	    
	    if (!gajiPokokPerGolongan.ContainsKey(golongan)) {
	        isValid = false;
	        Console.WriteLine("* Data golongan yang dimasukkan salah.");
	    }
	    
	    if (!genderList.ContainsKey(gender)) {
	        isValid = false;
	        Console.WriteLine("* Data jenis kelamin yang dimasukkan salah.");
	    }
	    
	    if (ownKids < 0) {
	        isValid = false;
	        Console.WriteLine("* Data jumlah anak tidak boleh kurang dari 0.");
	    }
	    
	    return isValid;
	}
}