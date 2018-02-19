//------------------------------------------------------------------------------
// <copyright file="XmlImplementation.cs" company="Microsoft">
//     
//      Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//     
//      The use and distribution terms for this software are contained in the file
//      named license.txt, which can be found in the root of this distribution.
//      By using this software in any fashion, you are agreeing to be bound by the
//      terms of this license.
//     
//      You must not remove this notice, or any other, from this software.
//     
// </copyright>
//------------------------------------------------------------------------------

using System.Globalization;

namespace System.Xml {

    // Provides methods for performing operations that are independent of any
    // particular instance of the document object model.
    public class XmlImplementation {

        private XmlNameTable nameTable;

        // Initializes a new instance of the XmlImplementation class.
        public XmlImplementation() : this( new NameTable() ) {
        }

        public XmlImplementation( XmlNameTable nt ) {
            nameTable = nt;
        }

        // Test if the DOM implementation implements a specific feature.
        public bool HasFeature(string strFeature, string strVersion) {
            if (String.Compare("XML", strFeature, StringComparison.OrdinalIgnoreCase) == 0) {
                if (strVersion == null || strVersion == "1.0" || strVersion == "2.0")
                    return true;
            }
            return false;
        }

        // Creates a new XmlDocument. All documents created from the same 
        // XmlImplementation object share the same name table.
        public virtual XmlDocument CreateDocument() {
            return new XmlDocument( this );
        }

        internal XmlNameTable NameTable {
            get { return nameTable; }
        }
    }
}
