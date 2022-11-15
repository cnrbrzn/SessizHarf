//Algoritma
//Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.

//Örnek: Input: Merhaba Umut Arya

//Output: True False True
string ent = Console.ReadLine();
string[] str = ent.Split(' ');
char[] vovels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
for (int i = 0; i < str.Length; i++)
{
    bool value = false;
    char[] chars = str[i].ToCharArray();
    for (int j = 0; j < chars.Length; j++)
    {
        if (!vovels.Contains(chars[j]) && j != chars.Length - 1 && !vovels.Contains(chars[j + 1]))
        {
            value = true;
            break;
        }
    }
    Console.Write(value + " ");
}