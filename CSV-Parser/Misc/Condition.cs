﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Parser {

    public class Condition {

        public Mode ConditionMode;
        public string Value1 = string.Empty;
        public string Value2 = string.Empty;

        public ModeNumeric ConditionMode_Numeric;
        public double Value1_Numeric = Double.NaN;
        public double Value2_Numeric = Double.NaN;

        public ModeDate ConditionMode_Date;
        public DateTime? Value1_Date = null;
        public string Value2_Date = string.Empty;

        public bool IsCustom = false;
        public bool IsNumeric = false;
        public bool IsDate = false;

        public Condition() { }

        public Condition(string value1, string value2, Mode mode) {
            Value1 = value1;
            Value2 = value2;
            ConditionMode = mode;
            IsNumeric = false;
        }

        public Condition(double value1, double value2, ModeNumeric mode) {
            Value1_Numeric = value1;
            Value2_Numeric = value2;
            ConditionMode_Numeric = mode;
            IsNumeric = true;
        }

        public Condition(DateTime value1, string value2, ModeDate mode) {
            Value1_Date = value1;
            Value2_Date = value2;
            ConditionMode_Date = mode;
            IsDate = true;  
        }

        public bool Evaluate() {

            if (IsNumeric) {

                switch (ConditionMode_Numeric) {

                    case ModeNumeric.NOT_EQUAL_TO:
                        return Value1_Numeric != Value2_Numeric;

                    case ModeNumeric.EQUAL_TO:
                        return Value1_Numeric == Value2_Numeric;

                    case ModeNumeric.GREATER_THAN:
                        return Value1_Numeric > Value2_Numeric;

                    case ModeNumeric.LESS_THAN:
                        return Value1_Numeric < Value2_Numeric;

                    case ModeNumeric.GREATER_THAN_EQUAL_TO:
                        return Value1_Numeric >= Value2_Numeric;

                    case ModeNumeric.LESS_THAN_EQUAL_TO:
                        return Value1_Numeric <= Value2_Numeric;

                }

            } else if (IsDate) {

                switch (ConditionMode_Date) {

                    case ModeDate.MONTH_EQUAL_TO:
                        return Value1_Date.Value.Month.ToString() == Value2_Date;

                    case ModeDate.DAY_EQUAL_TO:
                        return Value1_Date.Value.Day.ToString() == Value2_Date;

                    case ModeDate.YEAR_EQUAL_TO:
                        return Value1_Date.Value.Year.ToString() == Value2_Date;

                }

            } else {

                switch (ConditionMode) {

                    case Mode.NOT_EQUAL_TO:
                        return Value1.ToLower() != Value2.ToLower();

                    case Mode.EQUAL_TO:
                        return Value1.ToLower() == Value2.ToLower();

                    case Mode.CONTAINS:
                        return Value1.ToLower().Contains(Value2.ToLower());

                    case Mode.DOES_NOT_CONTAIN:
                        return !Value1.ToLower().Contains(Value2.ToLower());

                }

            }

            return false;

        }

        public string GetDescription() {
            if (IsNumeric) {
                if (IsCustom)
                    return string.Format("[{0}] {1} [\"{2}\"]", Value1, ConditionMode_Numeric.GetString(), Value2);
                else
                    return string.Format("[{0}] {1} [{2}]", Value1, ConditionMode_Numeric.GetString(), Value2);
            } else if (IsDate) {
                if (IsCustom)
                    return string.Format("[{0}] {1} [\"{2}\"]", Value1, ConditionMode_Date.GetString(), Value2);
                else
                    return string.Format("[{0}] {1} [{2}]", Value1, ConditionMode_Date.GetString(), Value2);
            } else {
                if (IsCustom)
                    return string.Format("[{0}] {1} [\"{2}\"]", Value1, ConditionMode.GetString(), Value2);
                else
                    return string.Format("[{0}] {1} [{2}]", Value1, ConditionMode.GetString(), Value2);
            }
        }

    }

    public static class ConditionExtensions {

        public static bool Evaluates(this string[] row, List<Condition> conditions) {

            foreach (Condition condition in conditions) {

                string value1 = row[Data.SelectedColumns[condition.Value1]];
                string value2 = condition.Value2;

                if (!condition.IsCustom)
                    value2 = row[Data.SelectedColumns[condition.Value2]];

                Condition c = null;
                try {
                    if (condition.IsNumeric)
                        c = new Condition(Convert.ToDouble(value1), Convert.ToDouble(value2), condition.ConditionMode_Numeric);
                    else if (condition.IsDate)
                        c = new Condition(DateTime.Parse(value1), value2, condition.ConditionMode_Date);
                    else
                        c = new Condition(value1, value2, condition.ConditionMode);
                } catch (Exception) {
                    return false;
                }

                if (!c.Evaluate())
                    return false;

            }

            return true;

        }

        public static string GetString(this Mode mode) {
            switch (mode) {
                case Mode.NOT_EQUAL_TO:
                    return "is not equal to";
                case Mode.EQUAL_TO:
                    return "is equal to";
                case Mode.CONTAINS:
                    return "contains";
                case Mode.DOES_NOT_CONTAIN:
                    return "does not contain";
            }
            return string.Empty;
        }

        public static string GetString(this ModeNumeric mode) {
            switch (mode) {
                case ModeNumeric.NOT_EQUAL_TO:
                    return "is not equal to";
                case ModeNumeric.EQUAL_TO:
                    return "is equal to";
                case ModeNumeric.GREATER_THAN:
                    return "greater than";
                case ModeNumeric.LESS_THAN:
                    return "less than";
                case ModeNumeric.GREATER_THAN_EQUAL_TO:
                    return "greater than or equal to";
                case ModeNumeric.LESS_THAN_EQUAL_TO:
                    return "less than or equal to";
            }
            return string.Empty;
        }

        public static string GetString(this ModeDate mode) {
            switch (mode) {
                case ModeDate.MONTH_EQUAL_TO:
                    return "month is equal to";
                case ModeDate.DAY_EQUAL_TO:
                    return "day is equal to";
                case ModeDate.YEAR_EQUAL_TO:
                    return "year is equal to";
            }
            return string.Empty;
        }

        public static TEnum GetMaxValue<TEnum>() where TEnum : IComparable, IConvertible, IFormattable {

            Type type = typeof(TEnum);

            if (!type.IsSubclassOf(typeof(Enum)))
                throw new
                    InvalidCastException
                        ("Cannot cast '" + type.FullName + "' to System.Enum.");

            return (TEnum)Enum.ToObject(type, Enum.GetValues(type).Cast<int>().Last());

        }

    }

    public enum Mode {
        NOT_EQUAL_TO, // 0
        EQUAL_TO, // 1
        CONTAINS, // 2
        DOES_NOT_CONTAIN // 3
    }

    public enum ModeNumeric {
        NOT_EQUAL_TO, // 0
        EQUAL_TO, // 1
        GREATER_THAN, // 2
        LESS_THAN, // 3
        GREATER_THAN_EQUAL_TO, // 4
        LESS_THAN_EQUAL_TO // 5
    }

    public enum ModeDate {
        MONTH_EQUAL_TO, // 0
        DAY_EQUAL_TO, // 1
        YEAR_EQUAL_TO // 2
    }

}
