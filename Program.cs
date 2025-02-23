// See https://aka.ms/new-console-template for more information

// soal A
/*Console.WriteLine("Masukkan satu huruf: ");
char huruf = (char)Console.Read();
if (huruf == 'A' || huruf == 'I' || huruf == 'U' || huruf == 'E' || huruf == 'O'
    || huruf == 'a' || huruf == 'i' || huruf == 'u' || huruf == 'e' || huruf == 'o')
{
    Console.WriteLine("Huruf " + huruf + " merupakan huruf vokal.");
}
else
{
    Console.WriteLine("Huruf " + huruf + " merupakan huruf konsonan.");
}*/

//Soal B
int[] genap = { 2, 4, 6, 8, 10 };
for (int i = 0; i < genap.Length; i++)
{
    Console.WriteLine("Angka Genap " + (i + 1) + " : " + genap[i]);
}