# About

Numeric language extensions.

### Int

| Extension  | Description
| :--- | :--- |
| Invert | Flip negative to positive or positive to negative |
| IntToDecimal | Convert int to decimal e.g. 25 will return .25 |
| IsPositive | Determine if value is positive |
| IsNegative | Determine if value is negative |
| ToYesNoFormat | Convert int to Yes/No (not constrained to 0 0r 1) |
| ToYesNo | Formats an int as Yes/No (must be 0 or 1) |
| ToNullableInt | Convert a string to a Nullable int or null |
| PercentDone | Provide percent completed formatted nnn% |

---


### decimal

| Extension  | Description
| :--- | :--- |
| CountDecimalPlaces | count decimals in the fraction part of a number |
| GetParts | Get major and fraction parts of a double |
| Invert | Flip negative to positive or positive to negative |

---


### double

| Extension  | Description
| :--- | :--- |
| PercentOf | Calculates percentage of a number |

---


### String arrays to int arrays

| Extension  | Description
| :--- | :--- |
| AllInt | Determine if all values can represent an int |
| ToIntegerArray | Convert values in array to int array discards non int values in array. |
| GetNonIntegerIndexes | Get all non-integer positions/indices |
| ToIntegerPreserveArray | Convert all values in array to int array where non int values will be set to the default value. |


---


### String arrays to double arrays

| Extension  | Description
| :--- | :--- |
| AllDouble | Determine if all values can represent a double |
| ToDoubleArray | Convert values in array to double array discards non double values in array. |
| GetNonDoubleIndexes | Get all non-double positions/indices |
| ToDoublePreserveArray | Convert all values in array to double array where non double values will be set to the default value. |



---


### String arrays to decimal arrays

| Extension  | Description
| :--- | :--- |
| AllDecimal | Determine if all values can represent a decimal |
| ToDecimalArray | Convert values in array to decimal array discards non decimal values in array. |
| GetNonDecimalIndexes | Get all non-decimal positions/indices |
| ToDecimalPreserveArray | Convert all values in array to decimal array where non decimal values will be set to the default value. |


---


### Int Sequence extensions

| Extension  | Description
| :--- | :--- |
| IsSequenceBroken | Determine if the sequence has missing elements |
| SequenceFindMissing | Get missing elements used with IsSequenceBroken |




![image](assets/Versions.png)


