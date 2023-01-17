List<int> myList = getList();

foreach (var item in myList) {
    Console.WriteLine(item);
}



List<int> getList()
{
    List<int> myList = new List<int>();
    myList.Add(0);
    myList.Add(1);
    myList.Add(2);
    myList.Add(3);
    myList.Add(4);
    myList.Add(5);
    myList.Add(6);

    return myList;
}




Console.Read();