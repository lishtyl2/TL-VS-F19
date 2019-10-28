Public Class Form1
    'example of lists

    Sub MakeANewList()

        Dim myNewList As New List(Of String)
        myNewList.Add("Hello")
        myNewList.Add("Goodbye")
        Console.WriteLine(myNewList(0))        Console.WriteLine(myNewList(1))
    End Sub


    Sub iterateList()
        Dim otherList As New List(Of String)
        otherList.Add("Jim")
        otherList.Add("Bob")
        otherList.Add("Emily")
        otherList.Add("Beth")
        otherList.Add("Joe")
        otherList.Add("Emily")

        'otherList.IndexOf("Emily")
        'Console.WriteLine(otherList.IndexOf("Emily"))

        'iterate through a list
        For Each Item As String In otherList
            'Console.WriteLine(Item.IndexOf("b"))
            Console.WriteLine(Item & " " & "is in index : " & otherList.IndexOf(Item))
        Next
        removeIndexItem(3, otherList)
        addIndexItem(3, "Sue", otherList)
        'Console.WriteLine(otherList.Count)
        For i = 0 To otherList.Count - 1
            Console.WriteLine(otherList(i) & " " & "is in list index : " & Str(i))
        Next


        'Console.WriteLine(otherList(0))
    End Sub

    Sub removeIndexItem(ByVal index As Integer, ByRef targetList As List(Of String))

        targetList.RemoveAt(index)


    End Sub

    Sub addIndexItem(ByVal index As Integer, ByVal value As String, ByRef targetList As List(Of String))

        targetList.Insert(index, value)


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MakeANewList()
        iterateList()

    End Sub
End Class
