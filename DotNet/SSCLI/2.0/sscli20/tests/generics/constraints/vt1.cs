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
interface IncrDecr {
	void Incr(int a);
	void Decr(int a);
	int Val();
}
struct MyInt : IncrDecr
{
int x;
public void Incr(int a) { x+=a; }
public void Decr(int a) { x-=a; }
public int Val() { return x; }
}
class MyCounter<T> where T : IncrDecr
{
	T counter;
	T[] counters = new T[1];
	public void Increment()
	{
		counter.Incr(100);
	}
	public void Decrement()
	{
		counter.Decr(100);
	}
	public void Increment(int index)
	{
		counters[index].Incr(100);
	}
	public void Decrement(int index)
	{
		counters[index].Decr(100);
	}
	public virtual void Increment2(T cnter)
	{
		cnter.Incr(100);
		counter = cnter;
	}
	public virtual void Decrement2(T cnter)
	{
		cnter.Decr(100);
		counter = cnter;
	}
	public int Val()
	{
		return counter.Val();
	}
	public int Val(int index)
	{
		return counters[index].Val();
	}
}
class test
{
	public static int Main()
	{
		MyCounter<MyInt> mc = new MyCounter<MyInt>();
		mc.Increment();
		if (mc.Val()!=100)
		{
			Console.WriteLine("FAILED 1");
			Console.WriteLine("Expected: 100, Actual: {0}", mc.Val());
			return 1;
		}
		mc.Decrement();
		if (mc.Val()!=0)
		{
			Console.WriteLine("FAILED 2");
			Console.WriteLine("Expected: 0, Actual: {0}", mc.Val());
			return 2;
		}
		mc.Increment(0);
		if (mc.Val(0)!=100)
		{
			Console.WriteLine("FAILED 3");
			Console.WriteLine("Expected: 100, Actual: {0}", mc.Val(0));
			return 3;
		}
		mc.Decrement(0);
		if (mc.Val(0)!=0)
		{
			Console.WriteLine("FAILED 4");
			Console.WriteLine("Expected: 0, Actual: {0}", mc.Val(0));
			return 4;
		}
		MyInt mi = new MyInt();
		mc.Increment2(mi);
		if (mc.Val()!=100)
		{
			Console.WriteLine("FAILED 5");
			Console.WriteLine("Expected: 100, Actual: {0}", mc.Val());
			return 5;
		}
		mc.Decrement2(mi);
		if (mc.Val()!=-100)
		{
			Console.WriteLine("FAILED 6");
			Console.WriteLine("Expected: -100, Actual: {0}", mc.Val());
			return 6;
		}		
		Console.WriteLine("PASSED");
		return 0;
	}
}

