﻿using FlaUI.Core;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Patterns;
using FlaUI.UIA2.Converters;
using FlaUI.UIA2.Identifiers;
using UIA = System.Windows.Automation;

namespace FlaUI.UIA2.Patterns
{
    public class TableItemPattern : TableItemPatternBase<UIA.TableItemPattern>
    {
        public static readonly PatternId Pattern = PatternId.Register(AutomationType.UIA2, UIA.TableItemPattern.Pattern.Id, "TableItem", AutomationObjectIds.IsTableItemPatternAvailableProperty);
        public static readonly PropertyId ColumnHeaderItemsProperty = PropertyId.Register(AutomationType.UIA2, UIA.TableItemPattern.ColumnHeaderItemsProperty.Id, "ColumnHeaderItems").SetConverter(AutomationElementConverter.NativeArrayToManaged);
        public static readonly PropertyId RowHeaderItemsProperty = PropertyId.Register(AutomationType.UIA2, UIA.TableItemPattern.RowHeaderItemsProperty.Id, "RowHeaderItems").SetConverter(AutomationElementConverter.NativeArrayToManaged);

        public TableItemPattern(BasicAutomationElementBase basicAutomationElement, UIA.TableItemPattern nativePattern) : base(basicAutomationElement, nativePattern)
        {
        }
    }

    public class TableItemPatternProperties : ITableItemPatternProperties
    {
        public PropertyId ColumnHeaderItems => TableItemPattern.ColumnHeaderItemsProperty;
        public PropertyId RowHeaderItems => TableItemPattern.RowHeaderItemsProperty;
    }
}
