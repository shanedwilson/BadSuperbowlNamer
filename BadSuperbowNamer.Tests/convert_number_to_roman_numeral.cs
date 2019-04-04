//using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class convert_number_to_roman_numeral
    {
        [Fact]
        public void converting_number_1()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 3;
            var expectedResult = "III";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_5()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 5;
            var expectedResult = "V";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_9()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 9;
            var expectedResult = "IX";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_12()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 12;
            var expectedResult = "XII";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_16()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 16;
            var expectedResult = "XVI";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_29()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 29;
            var expectedResult = "XXIX";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_44()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 44;
            var expectedResult = "XLIV";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_45()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 45;
            var expectedResult = "XLV";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_68()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 68;
            var expectedResult = "LXVIII";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_83()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 83;
            var expectedResult = "LXXXIII";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_97()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 97;
            var expectedResult = "XCVII";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_99()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 99;
            var expectedResult = "XCIX";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_500()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 500;
            var expectedResult = "D";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_501()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 501;
            var expectedResult = "DI";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_649()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 649;
            var expectedResult = "DCXLIX";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_798()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 798;
            var expectedResult = "DCCXCVIII";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_891()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 891;
            var expectedResult = "DCCCXCI";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_1000()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 1000;
            var expectedResult = "M";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_1004()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 1004;
            var expectedResult = "MIV";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_1006()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 1006;
            var expectedResult = "MVI";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_1023()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 1023;
            var expectedResult = "MXXIII";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_2014()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 2014;
            var expectedResult = "MMXIV";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_3999()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 3999;
            var expectedResult = "MMMCMXCIX";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void converting_number_4000()
        {
            // Arrange -- Context             -- Given
            var convertor = new RomanNumeralConvertor();
            var input = 4000;
            var expectedResult = "MMMM";

            // Act     -- Do the thing        -- When
            var actualResult = convertor.ToRoman(input);

            // Assert  -- Checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
