
public class LabW
{
    static void Main(string[] args)
    {
        string s = new string(Console.ReadLine());
        //Только 1 пробел между словами
        while (s.Contains("  "))
        {
            s = s.Replace("  ", " ");
        }
        Console.WriteLine(s);

        //Определить количество слов длина которых нечетная && первый и последний символ совпадают
        int count = 0;
        string[] arr = s.Split(new char[] { ' ' });
        foreach(var word  in arr)
        {
            bool NechLength = false;
            bool Sovpad = false;
            if(word.Length % 2 != 0)
            {
                NechLength = true;
                
            }
            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == word[word.Length - 1])
                {
                    Sovpad=true;
                    break;
                }
            }
            if(Sovpad&&NechLength)
            {
                count++;
            }
        }
        Console.WriteLine(count);

        //Определить кол-во слов в которых на четных местах стоят гласные буквы
        int coun1t = 0;
        string[] arrword = s.Split(new char[] { ' ' });
        char[] ch = { 'a', 'i', 'e', 'u', 'o','A','I','E','U','O' };
        foreach (var word in arrword)
        {
            bool HaveCh = false;
            for (int i = 1; i < word.Length; i += 2)
            {
                if (ch.Contains(word[i]))
                {
                    HaveCh = true;
                    break;
                }
            }
            if (HaveCh)
            {
                count++;
            }
        }
        Console.WriteLine(count);

        //Выдать все слова в которых присутствует хотя бы один символ "a"
        string[] arrword1 = s.Split(new char[] { ' ' });
        char[] a = { 'a', 'A' };
        foreach(var word in arrword1)
        {
            for (int i = 0;i< word.Length; i++)
            {
                if(a.Contains(word[i]))
                {
                Console.WriteLine(word);
                }
            }
        }
        
    }
}

