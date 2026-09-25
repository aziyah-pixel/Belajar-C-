Console.WriteLine("Masukan Angka Pertama");
double angka1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Masukan Operator (+, -, *, /): ");
string operasi = Console.ReadLine();

Console.WriteLine("Masukan Angka Kedua");
double angka2 = Convert.ToDouble(Console.ReadLine());

double hasil = 0;

if (operasi == "+"){
    hasil = angka1 + angka2;
} else if (operasi == "-"){
    hasil = angka1 - angka2;
} else if (operasi == "*"){
    hasil = angka1 * angka2;
} else if (operasi == "/"){
    hasil = angka1 / angka2;
} else {
    Console.WriteLine("operator tidak di temukan");
    return;
}

Console.WriteLine("hasil :"+ hasil);