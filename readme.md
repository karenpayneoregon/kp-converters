# About

Useful numeric extensions created for teaching C# yet has many extensions that has real world application.

Many extension libraries have various types e.g. string, date, numeric etc which is fine while having specialized libraries falls under what .NET Core is about, included only what you needed.

With that, check out the [following package](https://www.nuget.org/packages/KP.StringLanguageExtensions/) for extension extensions.

This repository has been setup as a template for students to easily fork this repository.

Numeric language extensions.

### Int

| Extension  | Description
| :--- | :--- |
| [Invert](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/IntegerExtensions.cs#L16) | Flip negative to positive or positive to negative |
| [IntToDecimal](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/IntegerExtensions.cs#L41) | Convert int to decimal e.g. 25 will return .25 |
| [IsPositive](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/IntegerExtensions.cs#L24) | Determine if value is positive |
| [IsNegative](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/IntegerExtensions.cs#L32) | Determine if value is negative |
| [ToYesNoFormat](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/IntegerExtensions.cs#L48) | Convert int to Yes/No (not constrained to 0 0r 1) :question: |
| [ToYesNo](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/IntegerExtensions.cs#L56) | Formats an int as Yes/No (must be 0 or 1) :question: |
| [ToNullableInt](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/IntegerExtensions.cs#L95) | Convert a string to a Nullable int or null |
| [PercentDone](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/IntegerExtensions.cs#L72) | Provide percent completed formatted nnn% |


:question: indicates discussion points

---


### decimal

| Extension  | Description
| :--- | :--- |
| [CountDecimalPlaces](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/DecimalExtensions.cs#L28) | count decimals in the fraction part of a number |
| [GetParts](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/DecimalExtensions.cs#L16) | Get major and fraction parts of a double |
| [Invert](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/DecimalExtensions.cs#L54) | Flip negative to positive or positive to negative |

---


### double

| Extension  | Description
| :--- | :--- |
| [PercentOf](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/DoubleExtensions.cs#L17) | Calculates percentage of a number |

---


### String arrays to int arrays

| Extension  | Description
| :--- | :--- |
| [AllInt](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L21) | Determine if all values can represent an int |
| [ToIntegerArray](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L46) | Convert values in array to int array discards non int values in array. |
| [AsIntegerArray](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L38) |  |
| [GetNonIntegerIndexes](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L68) | Get all non-integer positions/indices |
| [ToIntegerPreserveArray](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L83) | Convert all values in array to int array where non int values will be set to the default value. |
| [NoZeros](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L29) | Determine if all values are non-zero |


---


### String arrays to double arrays

| Extension  | Description
| :--- | :--- |
| [AllDouble](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L104) | Determine if all values can represent a double |
| [ToDoubleArray](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L113) | Convert values in array to double array discards non double values in array. |
| [GetNonDoubleIndexes](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L154) | Get all non-double positions/indices |
| [ToDoublePreserveArray](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L136) | Convert all values in array to double array where non double values will be set to the default value. |



---


### String arrays to decimal arrays

| Extension  | Description
| :--- | :--- |
| [AllDecimal](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L174) | Determine if all values can represent a decimal |
| [ToDecimalArray](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L183) | Convert values in array to decimal array discards non decimal values in array. |
| [GetNonDecimalIndexes](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L222) | Get all non-decimal positions/indices |
| [ToDecimalPreserveArray](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/NumericArrays.cs#L205) | Convert all values in array to decimal array where non decimal values will be set to the default value. |


---


### Int Sequence extensions

| Extension  | Description
| :--- | :--- |
| [IsSequenceBroken](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/SequenceExtensions.cs#L34) | Determine if the sequence has missing elements |
| [SequenceFindMissing](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/SequenceExtensions.cs#L23) | Get missing elements used with IsSequenceBroken |

---

### TryParse

[Extensions](https://github.com/karenpayneoregon/kp-converters/blob/master/ConverterLibrary/LanguageExtensions/TryParseExtensions.cs)

</br>


### Microsoft Learn

:beginner: [C# testing in Visual Studio](https://docs.microsoft.com/en-us/learn/modules/visual-studio-test-tools/)

:beginner: [Introduction to software testing concepts](https://docs.microsoft.com/en-us/learn/modules/visual-studio-test-concepts/)


