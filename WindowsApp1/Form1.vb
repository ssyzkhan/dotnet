Public Class Form1
    'members...
    Private _customers As New CustomerCollection()
    Public ReadOnly Property SelectedCustomer() As Customer
        Get
            'do we have a selection?
            If lstCustomers.SelectedIndex <> -1 Then
                'return the selected customer...
                'Return lstCustomers.Items(lstCustomers.SelectedIndex)
                Return _customers(lstCustomers.SelectedIndex)
            End If
        End Get
    End Property
    'enum
    Public Enum DayAction As Integer
        Asleep = 0
        GettingReadyForWork = 1
        TravelingToWork = 2
        AtWork = 3
        AtLunch = 4
        TravelingFromWork = 5
        RelaxingWithFriends = 6
        GettingReadyForBed = 7
    End Enum
    'members...
    Public CurrentState As DayAction

    'CreateCustomer-create a new customer...
    Public Function CreateCustomer(ByVal firstName As String, ByVal lastName As String, ByVal email As String) As Customer
        'create the new customer...
        Dim newCustomer As Customer
        newCustomer.FirstName = firstName
        newCustomer.LastName = lastName
        newCustomer.Email = email

        'add it to the list...
        _customers.Add(newCustomer)

        'add it to the view...
        lstCustomers.Items.Add(newCustomer)

        'return the customer...
        Return newCustomer

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'clear the list...
        _customers.Clear()
        _customers.EmailHashtable.Clear()
        lstCustomers.Items.Clear()
        'create a new customer...
        CreateCustomer("Amir", "Alibadi", "amir@pretendcompany.com")
        CreateCustomer("Gretchen", "Aliabadi", "gretchen@pretendcompany.com")
        CreateCustomer("Ben", "Aliabadi", "ben@pretendcompany.com")

    End Sub
    'DisplayCustomer - show the customer
    Public Sub DisplayCustomer(ByVal customer As Customer)
        'update the fields...
        txtFirstName.Text = customer.FirstName
        txtLastName.Text = customer.LastName
        txtEmail.Text = customer.Email
        txtName.Text = customer.FirstName & customer.LastName

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'what customer do we want to selete?
        If SelectedCustomer.IsEmpty = False Then
            'ask the user...
            If MessageBox.Show("Are you sure you want to delete " & SelectedCustomer.Name & "?", "Structure Demo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'store the customer that we want to delete...
                Dim deleteCustomer As Customer = SelectedCustomer
                'remove it from the arraylist...
                _customers.Remove(deleteCustomer)
                lstCustomers.Items.Remove(deleteCustomer)
            End If
        Else
            MessageBox.Show("You must select a customer.",
                            "Structure Demo")

        End If
    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        DisplayCustomer(SelectedCustomer)
    End Sub

    Private Sub btnLookupEmail_Click(sender As Object, e As EventArgs) Handles btnLookupEmail.Click
        'what E-Mail address do we want to find?
        Dim findEmail As String = txtEmail.Text

        'lookup and display the customer by email...
        Dim foundCustomer As Customer
        foundCustomer = _customers(findEmail)
        If foundCustomer.IsEmpty = False Then
            'show the customer's name...
            MessageBox.Show("The name is:" & foundCustomer.Name,
                            "Structure Demo")
        Else
            'display an error...
            MessageBox.Show("There is no customer with the E-Mail address" &
                            findEmail & ".", "Structure Demo")

        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'define an array to hold friends in...
        Dim friends(4) As String
        'store the name of each friend...
        friends(0) = "Darren"
        friends(1) = "Edward"
        friends(2) = "Alex"
        friends(3) = "Charlotte"
        friends(4) = "Len"

        Dim MoreFriends() As String = {"a", "b", "c"}
        ReDim Preserve MoreFriends(6)
        MoreFriends(3) = "e"
        MoreFriends(4) = "f"
        MoreFriends(5) = "g"
        MoreFriends(6) = "h"
        AddFriendsToList(friends)
        AddFriendsToList(MoreFriends)
    End Sub
    Private Sub AddFriendsToList(ByVal friends() As String)
        'sort it...
        Array.Sort(friends)
        'how big is the array?

        Dim upperBound As Integer = friends.Length

        'create a randomizer...
        Dim random As New Random()

        'count tem items...
        Dim n As Integer
        For n = 1 To 10
            'which index?
            Dim index As Integer = random.Next(upperBound)
            lstFriends.Items.Add(index & ": " & friends(index))
        Next
        Dim friendName As String
        For Each friendName In friends
            lstFriends.Items.Add(friendName)
        Next
    End Sub
    'Hour property...
    Public Property Hour() As Integer
        Get
            Return trkHour.Value
        End Get
        Set(value As Integer)
            'set the hour...
            trkHour.Value = value

            'determin the state...
            Dim hour As Integer = value
            If hour >= 6 And hour < 7 Then
                CurrentState = DayAction.GettingReadyForWork
            ElseIf hour >= 7 And hour < 8 Then
                CurrentState = DayAction.TravelingToWork
            ElseIf hour >= 8 And hour < 13 Then
                CurrentState = DayAction.AtWork
            ElseIf hour >= 13 And hour < 14 Then
                CurrentState = DayAction.AtLunch
            ElseIf hour >= 14 And hour < 17 Then
                CurrentState = DayAction.AtWork
            ElseIf hour >= 17 And hour < 18 Then
                CurrentState = DayAction.TravelingFromWork
            ElseIf hour >= 18 And hour < 22 Then
                CurrentState = DayAction.RelaxingWithFriends
            ElseIf hour >= 22 And hour < 23 Then
                CurrentState = DayAction.GettingReadyForBed
            Else
                CurrentState = DayAction.Asleep

            End If

            'set the text...
            Dim statusText As String
            statusText = $"At{value}:00, Len is {CurrentState}"
            txtState.Text = statusText
        End Set
    End Property
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set the hour to the current hour...
        Me.Hour = Date.Now.Hour

    End Sub

    Private Sub trkHour_Scroll(sender As Object, e As EventArgs) Handles trkHour.Scroll
        Me.Hour = trkHour.Value
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub
End Class
