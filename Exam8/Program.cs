Console.WriteLine("Введите число");
int N=int.Parse(Console.ReadLine()!);
if(N==1){
    Console.WriteLine("Четного числа от 1 до "+N+" не может быть");
}
else{
for(int i=1;i<=N;i++){
    if(i%2==0){
    Console.WriteLine(i);    
    }
}
}
