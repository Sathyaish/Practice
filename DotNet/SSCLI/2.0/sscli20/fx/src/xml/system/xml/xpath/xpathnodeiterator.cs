//------------------------------------------------------------------------------
// <copyright file="XPathNodeIterator.cs" company="Microsoft">
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

namespace System.Xml.XPath {
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Text;

    [DebuggerDisplay("Position={CurrentPosition}, Current={Current == null ? null : (object) new XPathNavigator.DebuggerDisplayProxy(Current)}")]
    public abstract class XPathNodeIterator : ICloneable, IEnumerable {
        internal int count = -1;

        object ICloneable.Clone() { return this.Clone(); }

        public abstract XPathNodeIterator Clone();
        public abstract bool MoveNext();
        public abstract XPathNavigator Current { get; }
        public abstract int CurrentPosition { get; }
        public virtual int Count {
            get { 
                if (count == -1) {
                    XPathNodeIterator clone = this.Clone();
                    while(clone.MoveNext()) ;
                    count = clone.CurrentPosition;
                }
                return count;
            } 
        }
        public virtual IEnumerator GetEnumerator() {
            return new Enumerator(this);
        }

        /// <summary>
        /// Implementation of a resetable enumerator that is linked to the XPathNodeIterator used to create it.
        /// </summary>
        private class Enumerator : IEnumerator {
            private XPathNodeIterator original;     // Keep original XPathNodeIterator in case Reset() is called
            private XPathNodeIterator current;
            private bool iterationStarted;

            public Enumerator(XPathNodeIterator original) {
                this.original = original.Clone();
            }

            public virtual object Current {
                get {
                    // 1. Do not reuse the XPathNavigator, as we do in XPathNodeIterator
                    // 2. Throw exception if current position is before first node or after the last node
                    if (this.iterationStarted) {
                        // Current is null if iterator is positioned after the last node
                        if (this.current == null)
                            throw new InvalidOperationException(Res.GetString(Res.Sch_EnumFinished, string.Empty));

                        return this.current.Current.Clone();
                    }

                    // User must call MoveNext before accessing Current property
                    throw new InvalidOperationException(Res.GetString(Res.Sch_EnumNotStarted, string.Empty));
                }
            }

            public virtual bool MoveNext() {
                // Delegate to XPathNodeIterator
                if (!this.iterationStarted) {
                    // Reset iteration to original position
                    this.current = this.original.Clone();
                    this.iterationStarted = true;
                }

                if (this.current == null || !this.current.MoveNext()) {
                    // Iteration complete
                    this.current = null;
                    return false;
                }
                return true;
            }

            public virtual void Reset() {
                this.iterationStarted = false;
            }
        }
    }
}
