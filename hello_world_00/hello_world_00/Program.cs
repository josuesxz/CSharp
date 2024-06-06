List<String> list = new List<string>(); //Lista<tipo> nome = instancia a lista
list.Add("name 1");
list.Add("name 2");
list.Add("name 2");
list.Add("name 2");

var count = 0;
while(count < list.Count){
    Console.WriteLine(list[count]);
    count++;
}
try{
//codigo rodando normalmente 
}
catch (Exception){
   //erro 
	throw;
}

Console.ReadKey();