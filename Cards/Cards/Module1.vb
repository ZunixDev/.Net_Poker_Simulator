Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Timers.Timer
Imports System.Text
Imports System.Threading

Module Module1

    Sub Main()
        Dim line As String
        printMenu()
        Do
            Console.Write("      ")
            line = Console.ReadLine()
            If line = "1" Then dealCards() Else 
            If line = "2" Then printHand()
            If line = "3" Then printInfo()
            If line = "4" Then listAllStrings()
            If line = "5" Then listAllIntegers()
        Loop While line IsNot Nothing
    End Sub

End Module