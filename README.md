# Complementary DNA

### What we must do?
Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.

If you want to know more [WIKI](http://en.wikipedia.org/wiki/DNA)

In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". You have function with one side of the DNA (string, except for Haskell); you need to get the other complementary side. DNA strand is never empty or there is no DNA at all (again, except for Haskell).

More similar exercise are found [here](http://rosalind.info/problems/list-view/)

Example: (input: output)
```cs
MakeComplement("ATTGC") => "TAACG"

MakeComplement("GTAT") => "CATA"
```

### What we did?
1. Каждый символ нашой строки мы перевели в массив для того, что бы потом сравнивать отдельные элемент массива.
```cs
char[] dnaArr = dna.ToCharArray();
```
2. Запишим длинну этого массива в переменную. 
3. Дальше создаём еще 4 массива, для каждой буквы ДНК, с которыми будут сравниваться наши элементы массива. (сделали мы это, что бы в будущем мы без проблем смогли изменить char[] с помощью другого char[], иначе будет ошибка. <br/>
Примичание: что бы мы смогли сделать этот массив нам надо в качестве текста установить два сивола, без разницы какие, главное что бы среди них был тот символ который нам нужен, без этого это будет обычная переменная string и тогда у нас не получится изменить char[].)
4. Создаем цикл FOR который будет работать пока переменная счёта "i" меньше длинный нашего массива. С каждым кругом i++. 
5. В нашем цыкле создаем оператор "ЕСЛИ" с условием, что если данный элемент массива, который переображён в строку с помощью такой формулы:
```cs
dnaArr[i].ToString()
```
равен букве "А" то мы заменяем эту букву на "Т". В простивном случаи, если данный элемент массива равен букве "Т", то мы меняем эту букву на "А". В противном случаи, если данный элемент массива равен букве "G", то мы меняем эту букву на "C". В противном случаи, если данный элемент массива равен букве "C", то мы меняем эту букву на "G".
6. Выйдя из цыкла, мы возвращаем строку, в которой все элементы массива соеденены в одну строку таким кодом:
```cs
string.Join("", dnaArr);
```

#FUNDAMENTALS #STRINGS
