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
#ifndef _NLSTABLE_H
#define _NLSTABLE_H

////////////////////////////////////////////////////////////////////////////
//
//  Class:    NLSTable
//  Purpose:  The base class for NLS+ table.  This class provides the utility
//            functions to open and map a view of NLS+ data files.
//
//  Date:     August 31, 1999
//
////////////////////////////////////////////////////////////////////////////

typedef  LPWORD        P844_TABLE;     // ptr to 8:4:4 table

//
//  Macros For High and Low Nibbles of a BYTE.
//
#define LO_NIBBLE(b)              ((BYTE)((BYTE)(b) & 0xF))
#define HI_NIBBLE(b)              ((BYTE)(((BYTE)(b) >> 4) & 0xF))

//
//  Macros for Extracting the 8:4:4 Index Values.
//
#define GET8(w)                   (HIBYTE(w))
#define GETHI4(w)                 (HI_NIBBLE(LOBYTE(w)))
#define GETLO4(w)                 (LO_NIBBLE(LOBYTE(w)))

////////////////////////////////////////////////////////////////////////////
//
//  Traverse844Byte
//
//  Traverses the 8:4:4 translation table for the given wide character.  It
//  returns the final value of the 8:4:4 table, which is a BYTE in length.
//
//  NOTE: Offsets in table are in BYTES.
//
//    Broken Down Version:
//    --------------------
//        Incr = pTable[GET8(wch)] / sizeof(WORD);
//        Incr = pTable[Incr + GETHI4(wch)];
//        Value = (BYTE *)pTable[Incr + GETLO4(wch)];
//
////////////////////////////////////////////////////////////////////////////

inline BYTE& Traverse844Byte(LPWORD pTable, WCHAR wch)                                        
{
    return ( 
             ((BYTE *)pTable)[
                pTable[ 
                   (pTable[GET8(wch)] / sizeof(WORD)) + GETHI4(wch)
                ] + GETLO4(wch)
             ]
           );
}

////////////////////////////////////////////////////////////////////////////
//
//  Traverse844Word
//
//  Traverses the 8:4:4 translation table for the given wide character.  It
//  returns the final value of the 8:4:4 table, which is a WORD in length.
//
//    Broken Down Version:
//    --------------------
//        Incr = pTable[GET8(wch)];
//        Incr = pTable[Incr + GETHI4(wch)];
//        Value = pTable[Incr + GETLO4(wch)];
//
////////////////////////////////////////////////////////////////////////////

inline WORD& Traverse844Word(LPWORD pTable, WCHAR wch)
{
    return (pTable[pTable[pTable[GET8(wch)] + GETHI4(wch)] + GETLO4(wch)]);
}

////////////////////////////////////////////////////////////////////////////
//
//  GET_INCR_VALUE
//
//  Gets the value of a given wide character from the given 8:4:4 table.  It
//  then uses the value as an increment by adding it to the given wide
//  character code point.
//
//  NOTE:  Whenever there is no translation for the given code point, the
//         tables will return an increment value of 0.  This way, the
//         wide character passed in is the same value that is returned.
//
//  DEFINED AS A MACRO.
//
////////////////////////////////////////////////////////////////////////////

inline WCHAR GetIncrValue(LPWORD p844Tbl, WCHAR wch)
{
     return ((WCHAR)(wch + Traverse844Word(p844Tbl, wch)));
}

class NLSTable
{
    public:
        NLSTable(Assembly* pAssembly);

        PBYTE  GetResource(LPCSTR pFileName);
        PBYTE  GetResource(LPCWSTR pFileName);

        static HANDLE CreateSharedMemoryMapping(const LPCWSTR pMappingName, const int iSize );
        static PBYTE OpenOrCreateMemoryMapping(const LPCWSTR pMappingName, const int iSize , HANDLE *mappedFile);
    
        // Add this data member so that we can retrieve data table from the specified Assembly
        // in the ctor.
        Assembly* m_pAssembly;
};

#endif  // _NLSTABLE_H
