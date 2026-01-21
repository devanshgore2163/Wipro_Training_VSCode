using System;
using System.Collections;
using System.Collections.Generic;

Console.WriteLine("Non Generic Collection implementation");
ArrayList ordercollection = new ArrayList();
ordercollection.Add("laptop");
ordercollection.Add(1233);
ordercollection.Add(34.34);
ordercollection.Add(new DateTime(2026,1,16));

Console.WriteLine("Items in order collection");
foreach(var item in ordercollection)
{
    Console.WriteLine(item);
}