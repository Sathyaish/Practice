// ==++==
//
//   
//    Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//   
//    The use and distribution terms for this software are contained in the file
//    named license.txt, which can be found in the root of this distribution.
//    By using this software in any fashion, you are agreeing to be bound by the
//    terms of this license.
//   
//    You must not remove this notice, or any other, from this software.
//   
//
// ==--==

using System;

interface I1 {
    int F1(string Msg);
    string F2(string Msg);
}

class Class1 : I1 {

    public int F1(string Msg) {
        Console.WriteLine("Class1.F1: {0}", Msg);
        return 1;
    }

    public string F2(string Msg) {
        Console.WriteLine("Class1.F2: {0}", Msg);
        return "String returned from Class1.F2:" + Msg;
    }

    public string NonVirtualFunc(int n) {
        Console.WriteLine("Class1.NonVirtualFunc: {0}", n);
        return "String returned from Class1.NonVirtualFunc:" + n;
    }
}

class Class2 : I1 {

    public int F1(string Msg) {
        Console.WriteLine("Class2.F1: {0}", Msg);
        return 2;
    }

    public string F2(string Msg) {
        Console.WriteLine("Class2.F2: {0}", Msg);
        return "String returned from Class2.F2:" + Msg;
    }

    public string NonVirtualFunc(int n) {
        Console.WriteLine("Class2.NonVirtualFunc: {0}", n*2);
        return "String returned from Class2.NonVirtualFunc:" + n*2;
    }
}

class MainApp {

    static bool failed = false;
    
    static void CheckReturnedInt(int actual, int expected) {
        Console.WriteLine("actual={0} expected={1}", actual, expected);
        if (actual != expected) {
            Console.WriteLine("!!!!!!!!!!! Error detected !!!!!!!!!!!!");
            failed = true;
        }
    }

    static void CheckReturnedString(string actual, string expected) {
        Console.WriteLine("actual=\"{0}\" expected=\"{1}\"", actual, expected);
        if (actual != expected) {
            Console.WriteLine("!!!!!!!!!!! Error detected !!!!!!!!!!!!");
            failed = true;
        }
    }

    public static void Main() {

        Class1 obj1=new Class1();
        CheckReturnedInt(obj1.F1("obj1"), 1);
        CheckReturnedString(obj1.F2("obj1"), "String returned from Class1.F2:obj1");
        CheckReturnedString(obj1.NonVirtualFunc(11), "String returned from Class1.NonVirtualFunc:11");
        Console.WriteLine("");

        Class2 obj2=new Class2();
        CheckReturnedInt(obj2.F1("obj2"), 2);
        CheckReturnedString(obj2.F2("obj2"), "String returned from Class2.F2:obj2");
        CheckReturnedString(obj2.NonVirtualFunc(15), "String returned from Class2.NonVirtualFunc:30");
        Console.WriteLine("");

        I1 itf;

        itf = obj1;
        CheckReturnedInt(itf.F1("itf is now obj1"), 1);
        CheckReturnedString(itf.F2("itf is now obj1"), "String returned from Class1.F2:itf is now obj1");        
        Console.WriteLine("");

        itf = obj2;
        CheckReturnedInt(itf.F1("itf is now obj2"), 2);
        CheckReturnedString(itf.F2("itf is now obj2"), "String returned from Class2.F2:itf is now obj2");
        Console.WriteLine("");

        if (failed) {
             System.Environment.ExitCode = 1;
        }
        else {
             System.Environment.ExitCode = 0;
        }
    }
        
}
