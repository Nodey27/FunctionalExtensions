﻿# VisualBasicFunctionalExtensions

**Package ID:** VisualBasicFunctionalExtensions  
**Version:** 0.0.1  
**Owner:** Justi  
**License:** MIT

## Overview

VisualBasicFunctionalExtensions is a functional library for Visual Basic .NET 2.1, drawing inspiration from Rust's functional programming concepts. The library is designed without a focus on performance, making it suitable for various applications.

## Installation

Install via NuGet Package Manager Console:

```bash
dotnet add package VisualBasicFunctionalExtensions --version 0.0.2
```

## Features
* Result and Maybe Monads

## Examples 
Introduction to all the methods and function the library has to offer. 

### Result

#### Try
*[Try](Of T, E)(func As Func(Of T), onError As Func(Of Exception, E)) As Result(Of T, E)*

```vbnet
    Private Const expectedMessage = "Can not sqrt negative integers"

    Public Function CustomSqrt(x As Integer) As Double
        If x < 0 Then
            Throw New Exception(expectedMessage)
        Else
            Return Math.Sqrt(x)
        End If
    End Function

    Public Sub ExampleNoException()
        Dim value = 15
        Dim expected = Result(Of Double, String).Ok(CustomSqrt(value))
        Dim res = Result(Of Double, String).
            Try(
                Function() CustomSqrt(value),
                Function(exception) exception.Message
            )

        Assert.AreEqual(expected, res)
    End Sub

    Public Sub ExampleCatchException()
        Dim value = -1
        Dim expected  = Result(Of Double, String).Err(errorValue:=expectedMessage)
        Dim res = Result(Of Double, String).
            Try(
                Function() CustomSqrt(value),
                Function(exception) exception.Message
            )

        Assert.AreEqual(expected, res)
    End Sub
```

#### And
*[And](Of T, K, E)(res As Result(Of T, E), other As Result(Of K, E)) As Result(Of K, E)*

## Authors
Justin Kasteleijn
Nadia Alrayes

## License
MIT License

## Copyright
(c) Justin Kasteleijn 2024

## Bug Reporting
For bug reports, visit the GitHub repository.