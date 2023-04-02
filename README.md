# Roman-Calculator(Console apllication)
Take on the role of the Roman Emperor's Minister for Innovation and develop a calculator for him to subtract and add Roman numbers.

# Task
[Zadanie.pdf](https://github.com/Doris5/Roman-Calculator/files/11132618/Zadanie.pdf)

# Technology
* IDE: Microsoft Visual Studio
* Clean C#

# Execution time
3h

# Table of Roman numbers on which I relied

![roman numbers](https://user-images.githubusercontent.com/35083021/229363053-d2e74fb9-87d2-48de-84be-15605af10473.png)

# RULES:

Rule 1: When certain numerals are repeated, the number represented by them is their sum. For example, II = 1 + 1 = 2, or XX = 10 + 10 = 20, or, XXX = 10 + 10 + 10 = 30.

Rule 2: It is to be noted that no Roman numerals can come together more than 3 times.For example, we cannot write 40 as XXXX

Rule 3: The letters V, L, and D are not repeated.

Rule 4: Only I, X, and C can be used as subtractive numerals.There can be 6 combinations when we subtract.These are IV = 5 - 1 = 4; IX = 10 - 1 = 9; XL = 50 - 10 = 40; XC = 100 - 10 = 90; CD = 500 - 100 = 400; and CM = 1000 - 100 = 900

Rule 5: When a Roman numeral is placed after another Roman numeral of greater value, the result is the sum of the numerals.For example, VIII = 5 + 1 + 1 + 1 = 8, or, XV = 10 + 5 = 15,

Rule 6: When a Roman numeral is placed before another Roman numeral of greater value, the result is the difference between the numerals.For example, IV = 5 - 1 = 4, or, XL = 50 - 10 = 40, or XC = 100 - 10 = 90

Rule 7: When a Roman numeral of a smaller value is placed between two numerals of greater value, it is subtracted from the numeral on its right.For example, XIV = 10 + (5 - 1) = 14, or, XIX = 10 + (10 - 1) = 19

Rule 8: To multiply a number by a factor of 1000 a bar is placed over it.

Rule 9: Roman numerals do not follow any place value system.

Rule 10: There is no Roman numeral for zero(0).

How it word?

The program first prompts the user to enter two Roman numerals separated by a space, and then asks the user to specify whether they want to add or subtract the two numbers.

The program then converts the Roman numerals to decimal values using the ConvertRomanToDecimalNumber method,
performs the requested operation, and then converts the result back to a Roman numeral using the ConvertToRomanNumeral method.
