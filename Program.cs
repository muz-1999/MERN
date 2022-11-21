static void bubblesort(char []arr){
    char temp;

    for(int i=0;i<arr.Length-1;i++){ //n-1
        Console.WriteLine($"the iteration number {i}");
        for(int j=0;j<arr.Length-1;j++){
     Console.WriteLine($"the Phase number {j}");    
            if(arr[j]>arr[j+1]){
                temp = arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
            }
        }
    }
    for(int i=0;i<arr.Length;i++){
        Console.WriteLine(arr[i]);
    }
}
static void selectionsort(char[]arr){
    char temp;
    for (int i=0;i<arr.Length-1;i++){
        Console.WriteLine($"the iteration number {i}");
        for (int j=i+1;j<arr.Length;j++){
        Console.WriteLine($"the Phase number {j}");    
                if(arr[j]>arr[j+1]){
                temp = arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
                    
        }
    }
}
for(int i=0;i<arr.Length;i++){
    Console.WriteLine(arr[i]);
    }
}
static void insertionsort(int [] arr){
    for(int i=0;i<arr.Length-1;i++){
        for (int j=i+1;j>0;j--){
            if(arr[j-1]<arr[j]){
                int temp=arr[j-1];
                arr[j-1]=arr[j];
                arr[j]=temp;
            }
        }
    }
    for(int i=0;i<arr.Length;i++){
        Console.WriteLine(arr[i]);
    }
}
int [] arr2 ={10,20,1,5,35,15};
char[] arr1 ={'p','z','s','j','q','o'};
bubblesort(arr1);
selectionsort(arr1);
insertionsort(arr2);