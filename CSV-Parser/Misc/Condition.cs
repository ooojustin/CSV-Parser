using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Parser {

    class Condition {

        public Mode ConditionMode;
        public ModeNumeric ConditionMode_Numeric;

        public string Value1 = string.Empty;
        public string Value2 = string.Empty;

        public double Value1_Numeric = Double.NaN;
        public double Value2_Numeric = Double.NaN;

        public bool IsCustom = false;
        public bool IsNumeric = false;

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
            if (IsNumeric && IsCustom) // + +
                return string.Format("[{0}] {1} [\"{2}\"]", Value1, ConditionMode_Numeric.GetString(), Value2);
            else if (IsNumeric && !IsCustom) // + -
                return string.Format("[{0}] {1} [{2}]", Value1, ConditionMode_Numeric.GetString(), Value2);
            else if (!IsNumeric && IsCustom) // - +
                return string.Format("[{0}] {1} [\"{2}\"]", Value1, ConditionMode.GetString(), Value2);
            else if (!IsNumeric && !IsCustom) // --
                return string.Format("[{0}] {1} [{2}]", Value1, ConditionMode.GetString(), Value2);
            return string.Empty;
        }

    }

    public static class ConditionExtensions {

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

        public static TEnum GetMaxValue<TEnum>() where TEnum : IComparable, IConvertible, IFormattable {

            Type type = typeof(TEnum);

            if (!type.IsSubclassOf(typeof(Enum)))
                throw new
                    InvalidCastException
                        ("Cannot cast '" + type.FullName + "' to System.Enum.");

            return (TEnum)Enum.ToObject(type, Enum.GetValues(type).Cast<int>().Last());

        }

        public static bool IsNumeric(this string value) {
            double test = Double.NaN;
            bool isNumeric = Double.TryParse(value, out test);
            return isNumeric;
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

}
