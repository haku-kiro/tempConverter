# tempConverter
Basic temp converter between Celsius and fahrenheit, with Kelvin to be added.
## TempUnitConverter directory
The dir 'TempUnitConverter' contains the logic to convert the temp to/from Celsius <-> fahrenheit.
It is compiled/built into a .dll file that exposes the following methods:

fromCtoF - which returns a double, and takes in a double. You pass it the temp in celsius and it returns fahrenheit.
fromFtoC - which returns a double, and takes in a double. You pass it the temp in fahrenheit and it returns celsius.

Also contains a delegate rule with the following signature:
double Name(double x) - Which means it takes in a double and returns a double. Any method with that sig can use this delegate.

## TestPlatform directory
The dir 'TestPlatform' Contains the logic to test the .dll from the 'TempUnitConverter'. It compiles/builds into a console application
an .exe file.
The logic included here is basically just error checking to ensure that the correct values are entered. As well as the use of the delegate
method.

## Path to important files:
dll - tempConverter/TempUnitConverter/bin/Debug/tempunitconverter.dll
exe - tempConverter/testPlatform/bin/Debug/testplatform.exe
