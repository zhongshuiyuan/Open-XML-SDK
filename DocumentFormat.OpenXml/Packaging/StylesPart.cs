﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
    /// </summary>
    public abstract partial class StylesPart : OpenXmlPart
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DocumentFormat.OpenXml.Wordprocessing.Styles _rootEle;

        /// <summary>
        /// Only for OpenXmlPart derived classes.
        /// </summary>
        internal override OpenXmlPartRootElement _rootElement
        {
            get
            {
                return _rootEle;
            }

            set
            {
                _rootEle = value as DocumentFormat.OpenXml.Wordprocessing.Styles;
            }
        }

        /// <summary>
        /// Gets the root element of this part. The DOM tree will be loaded on demand.
        /// </summary>
        internal override OpenXmlPartRootElement PartRootElement
        {
            get
            {
                return this.Styles;
            }
        }

        /// <summary>
        /// Gets/Sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Wordprocessing.Styles Styles
        {
            get
            {
                if (_rootEle == null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Wordprocessing.Styles>();
                }
                return _rootEle;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                SetDomTree(value);
            }
        }
    }
}
