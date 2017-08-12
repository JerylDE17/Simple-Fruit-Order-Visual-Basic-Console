Module Module1

    Sub Main()

        ' I'm creating a simple Point of Sale Machine Calculator using Visual Basic .NET

        Dim userResponse As Boolean = True

        While (userResponse)
            userResponse = MainWindow()
        End While

    End Sub

    Function MainWindow() As Boolean

        Dim itemsForSale() As String = {"apples", "lemons", "oranges"}

        ' The answer to this first question will be stored as a variable string called @item
        ' which will then be referenced during the calculation and the display of the total cost.
        Console.Write("What will you buy? ")
        Dim item As String = Console.ReadLine()
        Dim itemMatchElementArray As String = Array.Exists(itemsForSale,
                                                      Function(element)
                                                          Return element.Equals(item)
                                                      End Function)

        If itemMatchElementArray Then

            ' The answer to the second question will be stored as a variable integer called @quantity
            ' which will then be referenced during the calculation and the display of the total cost.
            Console.Write("How many {0} will you buy? ", item)
            Dim quantity As Integer = Console.ReadLine()

            ' This variable integer is equal to the calculated amount of the function method called @itemCost.
            Dim totalPrice As Integer = itemCost(quantity, item)

            ' This Sub method displays the summary of what was bought, how much per item, and the total amount.
            displayTotalCost(totalPrice, item, quantity)

        Else

            Console.WriteLine("Sorry. We do not have a stock of that item.")

        End If

        ' After executing the block of code above, the console will then ask the user
        ' if they want to buy another item.
        Console.Write("Will you buy again? (Y or N): ")
        Dim answer As String = Console.ReadLine()

        If answer = "Y" Then
            Return True
        ElseIf answer = "N" Then
            Console.WriteLine("Thank you for buying! Come back again!")
            Return False
        Else
            Console.WriteLine("Invalid input. This console will now close.")
            Return False
        End If

    End Function


    Sub displayTotalCost(ByVal totalPrice As Integer, ByVal item As String, ByVal quantity As Integer)

        If item = "apples" Then
            Console.WriteLine("You bought {0} {1} at a price of 3.", quantity, item)
        ElseIf item = "lemons" Then
            Console.WriteLine("You bought {0} {1} at a price of 2.", quantity, item)
        ElseIf item = "oranges" Then
            Console.WriteLine("You bought {0} {1} at a price of 1.", quantity, item)
        Else
            Console.WriteLine("Sorry. We have no {0} being sold.", item)
        End If

        Console.WriteLine("Total Cost: {0}", totalPrice)

    End Sub

    Function itemCost(ByVal quantityItem As Integer, ByVal itemForSale As String) As Integer

        Dim quantity As Integer = quantityItem
        Dim item As String = itemForSale

        Dim costPerItem As Integer

        If item = "apples" Then
            costPerItem = 3
        ElseIf item = "lemons" Then
            costPerItem = 2
        ElseIf item = "oranges" Then
            costPerItem = 1
        Else
            costPerItem = 0
        End If

        Dim cost As Integer = costPerItem * quantity

        Return cost

    End Function

End Module
