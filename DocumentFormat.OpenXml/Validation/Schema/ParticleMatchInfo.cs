﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /// <summary>
    /// Information about particle match.
    /// </summary>
    [DebuggerDisplay("Match={Match}")]
    internal partial class ParticleMatchInfo
    {
        static partial void IncressInstanceCount();

        /// <summary>
        /// Initializes a new instance of the ParticleMatchInfo.
        /// </summary>
        internal ParticleMatchInfo()
        {
            this.Match = ParticleMatch.Nomatch;

            IncressInstanceCount();
        }

        /// <summary>
        /// Initializes a new instance of the ParticleMatchInfo.
        /// </summary>
        /// <param name="startElement"></param>
        internal ParticleMatchInfo(OpenXmlElement startElement)
        {
            this.Match = ParticleMatch.Nomatch;
            this.StartElement = startElement;

            IncressInstanceCount();
        }

        /// <summary>
        /// Particle match result.
        /// </summary>
        internal ParticleMatch Match { get; set; }

        /// <summary>
        /// The start element to be matched by a particle rule.
        /// </summary>
        internal OpenXmlElement StartElement { get; private set; }

        /// <summary>
        /// The last element matched by the particle match.
        /// </summary>
        internal OpenXmlElement LastMatchedElement { get; set; }

        /// <summary>
        /// On Partial match, return the errors.
        /// </summary>
        /// <remarks>
        /// TODO: how can this be decopled from the validator?
        /// </remarks>
        internal string ErrorMessage { get; set; }

        /// <summary>
        /// The element type ids of expected children.
        /// Fill this field on partial match.
        /// </summary>
        /// <remarks>
        /// Will be null if matched or not matched.
        /// Will contains the expected child element types if partial match.
        /// </remarks>
        internal ExpectedChildren ExpectedChildren { get; private set; }

        /// <summary>
        /// The .ExpectedChildren will be non-null after this call.
        /// </summary>
        internal void InitExpectedChildren()
        {
            if (this.ExpectedChildren == null)
            {
                this.ExpectedChildren = new ExpectedChildren();
            }
            else
            {
                this.ExpectedChildren.Clear();
            }
        }

        /// <summary>
        /// Purpose:
        /// Resue this.ExpectedChildren data field.
        /// Avoid this.ExpectedChildren be referenced by more than one object (so "this.ExpectedChildren = other.ExpectedChildren" is not allowed).
        /// </summary>
        /// <param name="expectedChildren"></param>
        internal void SetExpectedChildren(ExpectedChildren expectedChildren)
        {
            if (expectedChildren == null || expectedChildren.Count == 0)
            {
                if (this.ExpectedChildren != null)
                {
                    this.ExpectedChildren.Clear();
                }
                // else, both are null, just return, nothing to do.
            }
            else
            {
                if (this.ExpectedChildren == null)
                {
                    this.ExpectedChildren = new ExpectedChildren();
                }
                this.ExpectedChildren.Clear();
                this.ExpectedChildren.Add(expectedChildren);
            }
        }

        ///// <summary>
        ///// Returns a flag which indicate whether the ExpectedChildren is empty.
        ///// </summary>
        //internal bool HasExpectedChildren
        //{
        //    get
        //    {
        //        return this.ExpectedChildren != null && this.ExpectedChildren.Count > 0;
        //    }
        //}

        internal void Reset(OpenXmlElement startElement)
        {
            this.StartElement = startElement;
            this.Match = ParticleMatch.Nomatch;
            this.LastMatchedElement = null;
            this.ErrorMessage = null;
            if (this.ExpectedChildren != null)
            {
                this.ExpectedChildren.Clear();
            }
        }
    }
}
