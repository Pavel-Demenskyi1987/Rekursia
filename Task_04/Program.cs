/*Задание 3. Совместная работа
Семинар 7. Рекурсия
20 мин
Считать строку с консоли, содержащую латинские буквы.
Вывести на экран согласные буквы этой строки.
Указание
Использовать рекурсию. Не использовать цикл.
Пример
“hello” => h l l
“World” => W r l d
“Hello world!” => H l l w r l d*/

System.Console.WriteLine("Введите строку: ");
string word = System.Console.ReadLine();
string ShowSog(string word, int index) 
{
    if(index == word.Length)
        return string.Empty;
    if(IsVowel(word[index]))
        return ShowSog(word, index+1);
    else
        return  word[index] + ShowSog(word, index+1);

}

bool IsVowel(char c)
{
    string vowels = "aoeiu";
    return vowels.Contains(c);
}
System.Console.WriteLine(ShowSog(word,0));
