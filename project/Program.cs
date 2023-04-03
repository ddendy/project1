string[] array = {"hello", "-345", "world", "al", "me", "i", "love", "IT"};

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length > 3) array[i] = "";
}

Console.WriteLine(String.Join(" " , array));