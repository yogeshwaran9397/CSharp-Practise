// See https://aka.ms/new-console-template for more information
using Learnings.Delegate;
using Learnings.Demo;
using Learnings.DSA;
using Learnings.DSA.LinkedList;
using Learnings.SampleProblems;
using Learnings.OOP.Abstract;
using Learnings.SampleTask.XML;
using Learnings.SampleTask.FileHandling;
using Learnings.SampleTask.FileHandling.Serialization;

Console.WriteLine("Welcome Yogesh");

if (true)
{
    Serialization objSerialization = new Serialization();
    objSerialization.DataSerialize();
    object deSerializedData = objSerialization.DataDeSerialize();
}

if (false)
{
    TextDoc obj = new TextDoc();
    obj.ReadWriteDoc();
}

if (false)
{
    XMLReader reader = new XMLReader();
    reader.ReadXML();
}

//Abstract Class
if (false)
{
    DerivedClass obj = new DerivedClass();
    obj.SampleAbstractMethod();
    obj.SampleVirtualMethod();
    obj.SampleDemoMethod();
}

//Bits 
if (false)
{
    Bit objBit = new Bit();
    objBit.sampleMethod();
}


//Single Linked List 
if (false)
{
    Console.WriteLine("Linked List");
    SLinkedList ObjSLinkedList = new SLinkedList(null);
    ObjSLinkedList.CreatingLinkedList();
}


// Sorting
if (false)
{
    Console.WriteLine("Sorting");
    Sorting sort = new Sorting();
    sort.MergeSorting();
}


//Searching Bar Problem 
if (false)
{
    Console.WriteLine("Search Bar Problem");
    SearchBar searchBar = new SearchBar();
    searchBar.SearchBarImplementation();
}

//Delegate
if (false)
{
    Console.WriteLine("Delegate");
    DelegateClass objDeleagte = new DelegateClass();
    objDeleagte.DelegateMethod();
}


