﻿
Imports System.Runtime.CompilerServices
Imports Microsoft.AspNetCore.Mvc.ModelBinding

Public Interface IVazorView

    Property ViewBag As <Dynamic> Object
    ' Property ModelState As ModelStateDictionary

    Property Name As String

    Property Path As String
    Function Vazor() As XElement

    ReadOnly Property Content As XElement
End Interface
