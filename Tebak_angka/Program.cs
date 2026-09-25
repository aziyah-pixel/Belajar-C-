Random random = new Random();

int angkaRahasia = random.Next(1, 101);
int tebakan = 0;
int jumlahPercobaan = 0;

Console.WriteLine("GAME TEBAK ANGKA");
Console.WriteLine("saya sudah memilih angka dari 1 samapi 100");
Console.WriteLine("coba tebak angka tersebut");

while (tebakan != angkaRahasia)
{
    Console.WriteLine("masukan tebakan kamu: ");
    tebakan = Convert.ToInt32(Console.ReadLine());

    jumlahPercobaan++;

    if(tebakan < angkaRahasia){
        Console.WriteLine("Terlalu Kecil");
    } else if (tebakan > angkaRahasia){
        Console.WriteLine("Terlalu Besar");
    }else{
        Console.WriteLine("Selamat Tebakan Kamu Benar");
        Console.WriteLine("Angka Rahasianya " + angkaRahasia);
        Console.WriteLine("kamu berhasil dalam " + jumlahPercobaan + " percobaan");
    }
}