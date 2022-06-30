int[] array = { 16, 23, 31, 34, 55, 69, 87, 38, 95 };

int n = array.Length;
int find = 87;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}