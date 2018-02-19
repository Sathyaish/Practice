/*=====================================================================
**
** Source:  SetFileAttributesW.c
**
** Purpose: Tests the PAL implementation of the SetFileAttributesW function
** Test that we can set the defined attributes aside from READONLY on a
** file, and that it doesn't return failure.  Note, these attributes won't
** do anything to the file, however.
**
** 
**  Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
** 
**  The use and distribution terms for this software are contained in the file
**  named license.txt, which can be found in the root of this distribution.
**  By using this software in any fashion, you are agreeing to be bound by the
**  terms of this license.
** 
**  You must not remove this notice, or any other, from this software.
** 
**
**===================================================================*/

#define UNICODE

#include <palsuite.h>

/* this cleanup method tries to revert the file back to its initial attributes */
void do_cleanup(WCHAR* filename,DWORD attributes)
{
  DWORD result;
  result = SetFileAttributes(filename, attributes);
  if (result == 0)
	  {	Fail("ERROR:SetFileAttributesW returned 0,failure in the do_cleanup "
		     "method when trying to revert the file back to its initial attributes");
	  }
}

int __cdecl main(int argc, char **argv)
{
    DWORD TheResult;
	DWORD initialAttr;
    WCHAR FileName[MAX_PATH];
    
    if (0 != PAL_Initialize(argc,argv))
    {
        return FAIL;
    }
    
    /* Make a wide character string for the file name */
    
    MultiByteToWideChar(CP_ACP,
                        0,
                        "test_file",
                        -1,
                        FileName,
                        MAX_PATH);

	/* Get the initial attributes of the file */
    initialAttr = GetFileAttributesW(FileName);

	/* Try to set the file to HIDDEN */

    TheResult = SetFileAttributes(FileName,FILE_ATTRIBUTE_HIDDEN);
    
    if(TheResult == 0)
    {
        do_cleanup(FileName,initialAttr);
		Fail("ERROR: SetFileAttributes returned 0, failure, when trying "
               "to set the FILE_ATTRIBUTE_HIDDEN attribute.  This should "
               "not do anything in FreeBSD, but it shouldn't fail.");
    }

    /* Try to set the file to ARCHIVE */

    TheResult = SetFileAttributes(FileName,FILE_ATTRIBUTE_ARCHIVE);
    
    if(TheResult == 0)
    {
        do_cleanup(FileName,initialAttr);
		Fail("ERROR: SetFileAttributes returned 0, failure, when trying "
               "to set the FILE_ATTRIBUTE_ARCHIVE attribute.");
    }

    /* Try to set the file to SYSTEM */

    TheResult = SetFileAttributes(FileName,FILE_ATTRIBUTE_SYSTEM);
    
    if(TheResult == 0)
    {
        do_cleanup(FileName,initialAttr);
		Fail("ERROR: SetFileAttributes returned 0, failure, when trying "
               "to set the FILE_ATTRIBUTE_SYSTEM attribute.");
    }

    /* Try to set the file to DIRECTORY */

    TheResult = SetFileAttributes(FileName,FILE_ATTRIBUTE_DIRECTORY);
    
    if(TheResult == 0)
    {
        do_cleanup(FileName,initialAttr);
		Fail("ERROR: SetFileAttributes returned 0, failure, when trying "
               "to set the FILE_ATTRIBUTE_DIRECTORY attribute.");
    }
    
	do_cleanup(FileName,initialAttr);
    PAL_Terminate();
    return PASS;
}
