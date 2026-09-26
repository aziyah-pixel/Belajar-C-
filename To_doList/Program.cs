//impor namespace 
using System;
using System.Collections.Generic;//untuk list T

List<string> daftarTugas = new List<string>();//membuat list dengan nama daftar tugas

bool programBerjalan = true;//membuat variabel untuk menentukan program masih berjalan 

while (programBerjalan)//perulangan selama program masih berjalan
{
    Console.Clear();//membersihkan tampilan 

    Console.WriteLine("==TO Do List==");
    Console.WriteLine("1. Tambah Tugas");
    Console.WriteLine("2. Tambah Tugas");
    Console.WriteLine("3. Tandai tugas selesai"); 
    Console.WriteLine("4. Hapus tugas"); 
    Console.WriteLine("5. Keluar"); 
    Console.Write("Pilih menu: "); 

    string pilihan =  Console.ReadLine();

    switch (pilihan)
    {
        case "1":
            TambahTugas();
            break;

        case "2":
            LihatTugas();
            break;
        
        case "3":
            SelesaikanTugas();
            break;

        case "4":
            HapusTugas();
            break;
        
        case "5":
            programBerjalan = false;
            Console.WriteLine("Program selesai. sampai Jumpa");
            break;

        default:
            Console.WriteLine("pilihan tidak tersedia");
            TekanEnter();
            break;
    }    
   
}

//method tambah tugas
void TambahTugas(){
    Console.Clear();
    Console.WriteLine("== Tambah Tugas ==");

    Console.Write("Masukan Tugas: ");
    string tugas = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(tugas))
    {
        daftarTugas.Add(tugas);
        Console.WriteLine("Tugas Berhasil ditambahkan!");
    }
    else
    {
        Console.WriteLine("Tugas tidak boleh kosong");
    }

    TekanEnter();
}

//Method lihat tugas
void LihatTugas()
{
    Console.Clear();
    Console.WriteLine("==Daftar Tugas==");

    if (daftarTugas.Count == 0)
    {
        Console.WriteLine("Belum ada tugas");
    }
    else{
        for (int i = 0; i < daftarTugas.Count; i++)
        {
           Console.WriteLine($"{i + 1}. {daftarTugas[i]}");
        }
    }
    TekanEnter();
}

//method selesaikan tugas 
void SelesaikanTugas()
{
    Console.Clear();
    Console.WriteLine("--selesaikan tugas--");

    if(daftarTugas.Count==0)
    {
        Console.WriteLine("Belum ada tugas."); 
        TekanEnter(); 
        return;
    }

    for (int i = 0; i < daftarTugas.Count; i++) 
    { 
        Console.WriteLine($"{i + 1}. {daftarTugas[i]}"); 
    }
    Console.Write("Pilih nomor tugas yang selesai: ");

    if (int.TryParse(Console.ReadLine(), out int nomor)) 
    { 
        if (nomor >= 1 && nomor <= daftarTugas.Count) 
        {
             daftarTugas[nomor - 1] += " [Selesai]"; 
             Console.WriteLine("Tugas berhasil ditandai selesai."); 
        } else { 
            Console.WriteLine("Nomor tugas tidak tersedia."); 
            } 
    }
    else { 
        Console.WriteLine("Input harus berupa angka."); 
    }

    TekanEnter();
}

//method hapus tugas
void HapusTugas()
{
    Console.Clear();
    Console.WriteLine("==Hapus Tugas==");

    if (daftarTugas.Count == 0)
    {
        Console.WriteLine("Belum Ada Tugas");
        TekanEnter();
        return;
    }

    for (int i = 0; i < daftarTugas.Count; i++)
    {
       Console.WriteLine($"{i + 1}. {daftarTugas[i]}");
    }
    
    Console.Write("pilih nomer yang akan dihapus: ");
    if (int.TryParse(Console.ReadLine(), out int nomor))
    {
        if (nomor >= 1 && nomor <= daftarTugas.Count)
        {
            daftarTugas.RemoveAt(nomor - 1);
            Console.WriteLine("Tugas berhasil di hapus.");
        }
        else
        {
            Console.WriteLine("Nomor Tugas tidak tersedia");
        }
    }
    else{
        Console.WriteLine("Input Harus berupa Angka.");
    }
    TekanEnter();
}

//method tekan enter
void TekanEnter()
{
    Console.WriteLine();
    Console.WriteLine("Tekan enter untuk melanjutkan...");
    Console.ReadLine();
}