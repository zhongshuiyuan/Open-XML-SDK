﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// <auto-generated>
// This source code was generated by SdbBuilder.
// Please do NOT change the code manually.
// </auto-generated>

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    internal static class O15UnionHelper
    {
        internal static OpenXmlSimpleType[] CreatePossibleMembers(UnionValueRestriction unionValueRestriction)
        {
            OpenXmlSimpleType[] simpleValues = new OpenXmlSimpleType[unionValueRestriction.UnionTypes.Length];

            switch (unionValueRestriction.UnionId)
            {
                // ST_AnimationDgmBuildType
                case 25:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Drawing.AnimationBuildValues>();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Drawing.AnimationDiagramOnlyBuildValues>();
                    break;

                // ST_AnimationChartBuildType
                case 27:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Drawing.AnimationBuildValues>();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Drawing.AnimationChartOnlyBuildValues>();
                    break;

                // ST_AdjCoordinate
                case 45:
                    simpleValues[0] = new Int64Value();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_AdjAngle
                case 46:
                    simpleValues[0] = new Int32Value();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_LayoutShapeType
                case 145:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues>();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.OutputShapeValues>();
                    break;

                // ST_ParameterVal
                case 183:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HorizontalAlignmentValues>();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.VerticalAlignmentValues>();
                    simpleValues[2] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildDirectionValues>();
                    simpleValues[3] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildAlignmentValues>();
                    simpleValues[4] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.SecondaryChildAlignmentValues>();
                    simpleValues[5] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.LinearDirectionValues>();
                    simpleValues[6] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.SecondaryLinearDirectionValues>();
                    simpleValues[7] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.StartingElementValues>();
                    simpleValues[8] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BendPointValues>();
                    simpleValues[9] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectorRoutingValues>();
                    simpleValues[10] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ArrowheadStyleValues>();
                    simpleValues[11] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectorDimensionValues>();
                    simpleValues[12] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.RotationPathValues>();
                    simpleValues[13] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.CenterShapeMappingValues>();
                    simpleValues[14] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.NodeHorizontalAlignmentValues>();
                    simpleValues[15] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.NodeVerticalAlignmentValues>();
                    simpleValues[16] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FallbackDimensionValues>();
                    simpleValues[17] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextDirectionValues>();
                    simpleValues[18] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PyramidAccentPositionValues>();
                    simpleValues[19] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PyramidAccentTextMarginValues>();
                    simpleValues[20] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextBlockDirectionValues>();
                    simpleValues[21] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextAnchorHorizontalValues>();
                    simpleValues[22] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextAnchorVerticalValues>();
                    simpleValues[23] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextAlignmentValues>();
                    simpleValues[24] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AutoTextRotationValues>();
                    simpleValues[25] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.GrowDirectionValues>();
                    simpleValues[26] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FlowDirectionValues>();
                    simpleValues[27] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ContinueDirectionValues>();
                    simpleValues[28] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BreakpointValues>();
                    simpleValues[29] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.OffsetValues>();
                    simpleValues[30] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyAlignmentValues>();
                    simpleValues[31] = new Int32Value();
                    simpleValues[32] = new DoubleValue();
                    simpleValues[33] = new BooleanValue();
                    simpleValues[34] = new StringValue();
                    simpleValues[35] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectorPointValues>();
                    break;

                // ST_ModelId
                case 184:
                    simpleValues[0] = new Int32Value();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_FunctionValue
                case 207:
                    simpleValues[0] = new Int32Value();
                    simpleValues[1] = new BooleanValue();
                    simpleValues[2] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues>();
                    simpleValues[3] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues>();
                    simpleValues[4] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues>();
                    simpleValues[5] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues>();
                    simpleValues[6] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues>();
                    break;

                // ST_FunctionArgument
                case 209:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.VariableValues>();
                    break;

                // ST_NonZeroDecimalNumber
                case 368:
                    simpleValues[0] = new Int32Value();
                    simpleValues[1] = new Int32Value();
                    break;

                // ST_MarkupId
                case 375:
                    simpleValues[0] = new Int32Value();
                    simpleValues[1] = new Int32Value();
                    break;

                // ST_HexColor
                case 404:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Wordprocessing.AutomaticColorValues>();
                    simpleValues[1] = new HexBinaryValue();
                    break;

                // ST_DecimalNumberOrPercent
                case 507:
                    simpleValues[0] = new StringValue();
                    simpleValues[1] = new Int32Value();
                    break;

                // ST_SignedHpsMeasure_O14
                case 525:
                    simpleValues[0] = new IntegerValue();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_HpsMeasure_O14
                case 528:
                    simpleValues[0] = new UInt32Value();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_SignedTwipsMeasure_O14
                case 531:
                    simpleValues[0] = new IntegerValue();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_TwipsMeasure_O14
                case 534:
                    simpleValues[0] = new UInt32Value();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_TransitionEightDirectionType
                case 544:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues>();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Presentation.TransitionCornerDirectionValues>();
                    break;

                // ST_TLTimeAnimateValueTime
                case 561:
                    simpleValues[0] = new Int32Value();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>();
                    break;

                // ST_TLTime_O12
                case 603:
                    simpleValues[0] = new UInt32Value();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>();
                    break;

                // ST_TLTime_O14
                case 604:
                    simpleValues[0] = new StringValue();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>();
                    break;

                // ST_PublishDate
                case 689:
                    simpleValues[0] = new DateTimeValue();
                    simpleValues[1] = new DateTimeValue();
                    simpleValues[2] = new StringValue();
                    break;

                // ST_ChannelDataPoint
                case 697:
                    simpleValues[0] = new DecimalValue();
                    simpleValues[1] = new BooleanValue();
                    break;

                // ST_ChannelPropertyName
                case 701:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardChannelPropertyNameValues>();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_BrushPropertyName
                case 704:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardBrushPropertyNameValues>();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_ChannelName
                case 707:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardChannelNameValues>();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_Units
                case 719:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>();
                    simpleValues[2] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>();
                    simpleValues[3] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>();
                    simpleValues[4] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>();
                    simpleValues[5] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>();
                    simpleValues[6] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>();
                    simpleValues[7] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>();
                    simpleValues[8] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>();
                    simpleValues[9] = new EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>();
                    simpleValues[10] = new StringValue();
                    break;

                // ST_BrushPropertyValue
                case 732:
                    simpleValues[0] = new DecimalValue();
                    simpleValues[1] = new BooleanValue();
                    simpleValues[2] = new EnumValue<DocumentFormat.OpenXml.InkML.PenTipShapeValues>();
                    simpleValues[3] = new EnumValue<DocumentFormat.OpenXml.InkML.RasterOperationValues>();
                    simpleValues[4] = new StringValue();
                    break;

                // ST_Ref
                case 746:
                    simpleValues[0] = new StringValue();
                    simpleValues[1] = new UInt32Value();
                    break;

                // ST_CtxNodeType
                case 747:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Office2010.Ink.KnownContextNodeTypeValues>();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_SemanticType
                case 750:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Office2010.Ink.KnownSemanticTypeValues>();
                    simpleValues[1] = new UInt32Value();
                    break;

                // ST_PointsOrInt
                case 753:
                    simpleValues[0] = new ListValue<StringValue>();
                    simpleValues[1] = new Int32Value();
                    break;

                // ST_TransitionCornerAndCenterDirectionType
                case 766:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Presentation.TransitionCornerDirectionValues>();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionCenterDirectionTypeValues>();
                    break;

                // ST_ColorStyleMethod
                case 835:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleMethodEnum>();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_StyleReferenceModifier
                case 837:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReferenceModifierEnum>();
                    simpleValues[1] = new StringValue();
                    break;

                // ST_StyleColorVal
                case 840:
                    simpleValues[0] = new UInt32Value();
                    simpleValues[1] = new EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColorEnum>();
                    simpleValues[2] = new StringValue();
                    break;

                // ST_StyleEntryModifier
                case 842:
                    simpleValues[0] = new EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleEntryModifierEnum>();
                    simpleValues[1] = new StringValue();
                    break;

                default:
                    Debug.Assert(false);
                    break;
            }

            Debug.Assert(simpleValues.Length > 0);

            return simpleValues;
        }

        internal static OpenXmlSimpleType CreateTargetValueObject(RedirectedRestriction redirectedRestriction)
        {
            OpenXmlSimpleType simpleValue = null;

            switch (redirectedRestriction.AttributeId)
            {
                // property name: Width
                case 2593:
                    simpleValue = new StringValue();
                    break;

                // property name: Percent
                case 2851:
                    simpleValue = new StringValue();
                    break;

                // property name: FontSize
                case 2928:
                    simpleValue = new StringValue();
                    break;

                // property name: ShapeId
                case 3075:
                    simpleValue = new UInt32Value();
                    break;

                // property name: ShapeId
                case 3084:
                    simpleValue = new UInt32Value();
                    break;

                // property name: ShapeId
                case 3088:
                    simpleValue = new UInt32Value();
                    break;

                // property name: ShapeId
                case 3093:
                    simpleValue = new UInt32Value();
                    break;

                // property name: AdvanceAfterTime
                case 3154:
                    simpleValue = new StringValue();
                    break;

                // property name: ShapeId
                case 3157:
                    simpleValue = new UInt32Value();
                    break;

                default:
                    Debug.Assert(false);
                    break;
            }

            return simpleValue;
        }
    }
}
