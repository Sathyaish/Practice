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
using System.Collections;
using System.Globalization;
using System.IO;
public class Co8563Clone
{
 public static String s_strActiveBugNums = "";
 public static String s_strDtTmVer       = "";
 public static String s_strClassMethod   = "CharEnumerator.Clone()";
 public static String s_strTFName        = "Co8563Clone.cs";
 public static String s_strTFAbbrev      = s_strTFName.Substring(0,6);
 public static String s_strTFPath        = Environment.CurrentDirectory;
 public bool runTest()
   {
   Console.WriteLine(s_strTFPath + "\\" + s_strTFName + " , for " + s_strClassMethod + " , Source ver " + s_strDtTmVer);
   String strLoc = "Loc_000oo";
   String strValue = String.Empty;
   int iCountErrors = 0;
   int iCountTestcases = 0;
   String str1;
   CharEnumerator enu;
   CharEnumerator enu1;
   Char ch1;
   Int32 count;
   Object obj;
   try
     {
     strLoc = "Loc_9347sg";
     iCountTestcases++;
     str1 = "Hello World";
     enu = str1.GetEnumerator();
     enu1 = (CharEnumerator)enu.Clone();
     strLoc = "Loc_93746tsfg";
     iCountTestcases++;
     try{
     obj = enu1.Current;
     iCountErrors++;
     Console.WriteLine( "Err_32495dsg! No exception thrown");
     }catch(InvalidOperationException){
     }catch(Exception ex){
     iCountErrors++;
     Console.WriteLine( "Err_32495dsg! Wrong exception thrown, " + ex.GetType().Name);
     }						
     count=0;
     while(enu1.MoveNext()){
     ch1 = (Char)enu1.Current;
     if(ch1!=str1[count]){
     iCountErrors++;
     Console.WriteLine( "Err_973425sdg! wrong value returned. Expected: {0}, Returned: {1}", str1[count], ch1);
     }
     count++;
     }
     strLoc = "Loc_93746tsfg";
     iCountTestcases++;
     try{
     obj = enu1.Current;
     iCountErrors++;
     Console.WriteLine( "Err_32495dsg! No exception thrown");
     }catch(InvalidOperationException){
     }catch(Exception ex){
     iCountErrors++;
     Console.WriteLine( "Err_32495dsg! Wrong exception thrown, " + ex.GetType().Name);
     }
     } catch (Exception exc_general ) {
     ++iCountErrors;
     Console.WriteLine (s_strTFAbbrev + " : Error Err_8888yyy!  strLoc=="+ strLoc +", exc_general=="+exc_general.ToString());
     }
   if ( iCountErrors == 0 )
     {
     Console.WriteLine( "paSs. "+s_strTFName+" ,iCountTestcases=="+iCountTestcases.ToString());
     return true;
     }
   else
     {
     Console.WriteLine("FAiL! "+s_strTFName+" ,inCountErrors=="+iCountErrors.ToString()+" , BugNums?: "+s_strActiveBugNums );
     return false;
     }
   }
 public static void Main(String[] args)
   {
   bool bResult = false;
   Co8563Clone cbA = new Co8563Clone();
   try {
   bResult = cbA.runTest();
   } catch (Exception exc_main){
   bResult = false;
   Console.WriteLine(s_strTFAbbrev + " : FAiL! Error Err_9999zzz! Uncaught Exception in main(), exc_main=="+exc_main.ToString());
   }
   if (!bResult)
     {
     Console.WriteLine ("Path: "+s_strTFPath+"\\"+s_strTFName);
     Console.WriteLine( " " );
     Console.WriteLine( "FAiL!  "+ s_strTFAbbrev);
     Console.WriteLine( " " );
     }
   if (bResult) Environment.ExitCode = 0; else Environment.ExitCode = 1;
   }
}
