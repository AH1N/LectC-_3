// See https://aka.ms/new-console-template for more information

int [] arr = {1,2,3,5,7,3,9,8,6,10,1};

void PrintArray(int[] array){
    int count = array.Length;
    
    for(int i = 0; i < count; i++){
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SortMassive(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        //int minPos = i;
        int maxPos = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPos]) maxPos = j;  
        }

        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}
PrintArray(arr);

SortMassive(arr);
PrintArray(arr);

