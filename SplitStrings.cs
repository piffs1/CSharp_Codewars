// https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/csharp
//Задача. Приходит строка
// 'abc' => string[]{"ab", "c_"};
// Нужно выдать пары символов. Если нечетное количество, добавить в конце _
// 'abcd' => string[]{"ab","cd"};

using System.Collections.Generic;
using System.Linq;

public class SplitString
{
  public static string[] Solution(string str)
  {
    if (str.Length % 2 == 1)
		str += "_";
  
  	List<string> list = new List<string>();
    for (int i = 0; i < str.Length; i += 2)
  	{
  		list.Add(str[i].ToString() + str[i+1]);
  	}
  	
  	return list.ToArray();
  }
}