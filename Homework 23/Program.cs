using Homework_23;

string[] names = new string[5];

StringList namelist= new StringList();

namelist.Add("Sahin");
namelist.Add("Raul");
namelist.Add("Rauf");
namelist.Add("Aytac");


for(int i=0; i<namelist.Length; i++)
{
    Console.WriteLine(namelist[i]);
}

MyList<Car> list = new MyList<Car>();

list.Add(new Car());
