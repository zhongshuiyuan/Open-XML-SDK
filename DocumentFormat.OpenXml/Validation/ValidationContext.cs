﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Internal.SchemaValidation;
using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Validation context.
    /// </summary>
    internal class ValidationContext
    {
        /// <summary>
        /// Event handler to be called on validation errors rised.
        /// </summary>
        internal event EventHandler<ValidationErrorEventArgs> ValidationErrorEventHandler;

        /// <summary>
        /// Initializes a new instance of the ValidationContext.
        /// Default file format target is FileFormat.Office2007.
        /// </summary>
        internal ValidationContext()
        {
            this.McContext = new MCContext(false);
            this.FileFormat = FileFormatVersions.Office2007;
        }

        /// <summary>
        /// Target file format.
        /// </summary>
        internal FileFormatVersions FileFormat { get; set; }

        //internal MCMode McMode
        //{
        //    get
        //    {
        //        switch (this.FileFormat)
        //        {
        //            case FileFormat.Office2007:
        //                return MCMode.Office2007;

        //            case FileFormat.Office2010:
        //                return MCMode.Office2010;

        //            default:
        //                Debug.Assert(false);
        //                return MCMode.Office2007;
        //        }
        //    }
        //}

        /// <summary>
        /// The target OpenXmlPackage.
        /// </summary>
        internal OpenXmlPackage Package { get; set; }

        /// <summary>
        /// The target OpenXmlPart
        /// </summary>
        internal OpenXmlPart Part { get; set; }

        /// <summary>
        /// The target element.
        /// </summary>
        internal OpenXmlElement Element { get; set; }

        /// <summary>
        /// Used to track MC context.
        /// </summary>
        internal MCContext McContext { get; set; }

        /// <summary>
        /// Collect ExpectedChildren or not.
        /// </summary>
        internal bool CollectExpectedChildren { get; set; }

        /// <summary>
        /// Used by validator to emit errors.
        /// </summary>
        /// <param name="error">The validation error.</param>
        internal void EmitError(ValidationErrorInfo error)
        {
            OnValidationError(new ValidationErrorEventArgs(error));
        }

        /// <summary>
        /// Call event handler to process the error.
        /// </summary>
        /// <param name="errorEventArgs">The event argument which contains the error info.</param>
        protected virtual void OnValidationError(ValidationErrorEventArgs errorEventArgs)
        {
            var handler = this.ValidationErrorEventHandler;
            if (handler != null)
            {
                handler(this, errorEventArgs);
            }
        }

        /// <summary>
        /// Get the first child of this.Element according to the MC Mode.
        /// </summary>
        /// <returns>The first child in the MC mode.</returns>
        internal OpenXmlElement GetFirstChildMc()
        {
            return this.Element.GetFirstChildMc(this.McContext, this.FileFormat);
        }

        /// <summary>
        /// Get the next child of this.Element according to the MC Mode.
        /// </summary>
        /// <param name="child">The child after which the next child going to be retrived.</param>
        /// <returns>The next child after the specified child in the MC mode.</returns>
        internal OpenXmlElement GetNextChildMc(OpenXmlElement child)
        {
            return this.Element.GetNextChildMc(child, this.McContext, this.FileFormat);
        }
    }
}
