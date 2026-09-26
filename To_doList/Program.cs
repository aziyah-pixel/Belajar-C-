//impor namespace 
using System;
using System.Collections.Generic;//untuk list T

List<string> daftarTugas = new List<string>();//membuat list dengan nama daftar tugas

bool programBerjalan = true;//membuat variabel untuk menentukan program masih berjalan 

while (programBerjalan)//perulangan selama program masih berjalan
{
    Console.Clear();//membersihkan tampilan 

    //menampilkan menu
    Console.WriteLine("==TO Do List==");
    Console.WriteLine("1. Tambah Tugas");
    Console.WriteLine("2. Daftar Tugas");
    Console.WriteLine("3. Tandai tugas selesai"); 
    Console.WriteLine("4. Hapus tugas"); 
    Console.WriteLine("5. Keluar"); 
    Console.Write("Pilih menu: "); 

    string? pilihan =  Console.ReadLine();//input pilihan penguna 
    //string? : nilai boleh bernilai null
    //menentukan tindakan dari inputan user dengan memangil method
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
            programBerjalan = false;//mengubah status program menjadi mati
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
    string tugas = Console.ReadLine();//inputan penguna dan disimpan dalam variabel tugas

    if (!string.IsNullOrWhiteSpace(tugas))//mengecek apaakh tugas kosong atau hanya berisi spasi
    {
        daftarTugas.Add(tugas);//menambahkan tugas ke dalam list daftar tugas
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
        for (int i = 0; i < daftarTugas.Count; i++)//perulangan untuk membaca setiap tugas
        {// i dimulai dari 0 karena index List dimulai dari 0.
           Console.WriteLine($"{i + 1}. {daftarTugas[i]}");
           // i + 1 digunakan agar nomor yang ditampilkan dimulai dari 1. 
           // daftarTugas[i] mengambil isi tugas berdasarkan index.
        }
    }
    TekanEnter();
}

//method selesaikan tugas 
void SelesaikanTugas()
{
    Console.Clear();
    Console.WriteLine("--selesaikan tugas--");

    if(daftarTugas.Count==0)//mengecek apakah ada tugas
    {
        Console.WriteLine("Belum ada tugas."); 
        TekanEnter(); 
        return;
    }
    //menampilkan tugas-tugas
    for (int i = 0; i < daftarTugas.Count; i++) 
    { 
        Console.WriteLine($"{i + 1}. {daftarTugas[i]}"); 
    }

    Console.Write("Pilih nomor tugas yang selesai: ");//input user mana yang mau diselesaikan

    if (int.TryParse(Console.ReadLine(), out int nomor))// Mencoba mengubah input pengguna menjadi integer. 
    // int.TryParse() lebih aman daripada Convert.ToInt32() 
    // karena tidak langsung menghasilkan error jika pengguna memasukkan huruf.
    // nomor = angka yang dimasukkan pengguna.
    { 
        if (nomor >= 1 && nomor <= daftarTugas.Count)//mengecek apakah no berada dalam daftar tugas
        {
            // Menambahkan teks "[Selesai]" ke tugas yang dipilih.
            // nomor - 1 karena nomor pengguna dimulai dari 1,sedangkan index List dimulai dari 0.
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

    if (daftarTugas.Count == 0)//mengecek apakah ada tugas
    {
        Console.WriteLine("Belum Ada Tugas");
        TekanEnter();
        return;
    }

    for (int i = 0; i < daftarTugas.Count; i++)
    {//menampilkan daftar tugas
       Console.WriteLine($"{i + 1}. {daftarTugas[i]}");
    }
    
    Console.Write("pilih nomer yang akan dihapus: ");//inputan no tugas dari penguna
    if (int.TryParse(Console.ReadLine(), out int nomor))//mengubah inputan menjadi int
    {
        if (nomor >= 1 && nomor <= daftarTugas.Count)
        {
            daftarTugas.RemoveAt(nomor - 1);//menghapus tugas dari list tugas
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