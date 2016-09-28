Imports WHLClasses
Imports Linnworks.Orders.ExtendedOrder

Public Class Form1
    Dim FilesGathered As Boolean = False
    Dim DestinationPath As String = ""
    Dim Loader As New GenericDataController
    Dim LoadedFromOrders As Boolean = False
    Dim LoadedFromPast As Boolean = False
    Dim LoadedFromOther As Boolean = False 'Will we ever do this? Maybe. If we decide to get particular past folders...
    Dim LoadedFolderLocation As String = "" 'This will contain that folder's location and load from there. Let's ensure maximum accessibility

    'Dim listOfOrders As Linnworks.Orders.ExtendedOrder 'NOPE. there's 22k files in that past folder. No. Don't hold all that info. Are you NUTS.
    Private Sub GatherItems(FilePath As String)
        GatheredGrid.Rows.Clear() 'We gotta clear this out on running a second time.

        Dim LoadOrderStatus As Boolean = False
        If MsgBox("Would you like to load order states? This will take longer as it has to load EACH file individually to get this information", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            LoadOrderStatus = True
        End If

        MyBase.Enabled = False 'PREVENT BUTTONS BEING PRESSED

        InfoLabel.Text = "Getting file list." 'Let the user know we haven't frozen
        Application.DoEvents()

        'Dim FileList As List(Of String) = My.Computer.FileSystem.GetFiles(FilePath).ToList 'Get the list

        Dim FileList As List(Of String) = My.Computer.FileSystem.GetFiles(FilePath, FileIO.SearchOption.SearchTopLevelOnly, {"*.ordex"}).ToList 'Get the count
        LoadingProgress.Maximum = FileList.Count 'Loading bar - equivelant to the amount of files
        LoadingProgress.Minimum = 0 'Starting at 0

        InfoLabel.Text = FileList.Count.ToString + " found. Loading." 'Let the user know we haven't frozen
        Application.DoEvents()

        Dim DateOfFile As Date
        For Each file In FileList
            DateOfFile = My.Computer.FileSystem.GetFileInfo(file).CreationTime '.ToString("yyyy/MM/dd")

            Dim newRow As New DataGridViewRow 'Make a row
            newRow.CreateCells(GatheredGrid) 'Create cells
            newRow.Cells(0).Value = file.Replace(FilePath, "") 'Add the file name to the first column
            newRow.Cells(1).Value = False 'This will be fuggin awkward but we can do this
            newRow.Cells(2).Value = DateOfFile 'Add the state date to the second column

            If LoadOrderStatus Then
                Try 'Awww shit this is gonna suck... We can't just use the orddef because it just checks orders. Past isn't gonna work like that.
                    Dim theOrdex As Linnworks.Orders.ExtendedOrder = Loader.LoadOrdex(file, False)
                    newRow.Cells(3).Value = theOrdex.Status.ToString 'Add the file state to the second column
                Catch ex As Exception
                    'When we get loading stuff ready, we need to have our reports added to the table somewhere for when things go wrong...
                    'Maybe add the name to a list of failed records, then add them to a fail list table in a different window...
                End Try
            End If

            newRow.Tag = file
            GatheredGrid.Rows.Add(newRow) 'Add the row

            LoadingProgress.Increment(1)
        Next

        LoadingProgress.Value = 0

        'InfoLabel.Text =  'We have our files and values ready. Tell the user what we're loading
        'Application.DoEvents()

        'For Each file As String In fileDictionary.Keys 'For each file in the list
        '    If file.EndsWith(".ordex") Then 'Check they're ordex files


        '        Dim newRow As New DataGridViewRow 'Make a row
        '        newRow.CreateCells(GatheredGrid) 'Create cells
        '        newRow.Cells(0).Value = file.Replace(FilePath, "") 'Add the file name to the first column
        '        newRow.Cells(1).Value = False 'This will be fuggin awkward but we can do this
        '        newRow.Cells(2).Value = fileDictionary.Item(file) 'Add the state date to the second column

        '        Try 'Awww shit this is gonna suck... We can't just use the orddef because it just checks orders. Past isn't gonna work like that.
        '            Dim theOrdex As Linnworks.Orders.ExtendedOrder = Loader.LoadOrdex(file, False)
        '            newRow.Cells(3).Value = theOrdex.Status.ToString 'Add the file state to the second column
        '        Catch ex As Exception
        '            'When we get loading stuff ready, we need to have our reports added to the table somewhere for when things go wrong...
        '            'Maybe add the name to a list of failed records, then add them to a fail list table in a different window...
        '        End Try

        '        newRow.Tag = file


        '        LoadingProgress.Increment(1)

        '        GatheredGrid.Rows.Add(newRow) 'Add the row
        '    End If
        'Next
        'LoadingProgress.Value = 0 'We're done. Stop looking like we're loading.
        Application.DoEvents()

        MyBase.Enabled = True 'LET BUTTONS BE PRESSED

        FilesGathered = True 'We've gathered our files. Let our "move" button know it can run.
    End Sub

    Private Sub GetFromOrdersBtn_Click(sender As Object, e As EventArgs) Handles GetFromOrdersBtn.Click
        GatherItems("T:\AppData\Orders\")
        LoadedFromOrders = True
        LoadedFromPast = False
        LoadedFromOther = False
        InfoLabel.Text = "Files from 'Orders' folder."
    End Sub

    Private Sub GetFromPastBtn_Click(sender As Object, e As EventArgs) Handles GetFromPastBtn.Click
        GatherItems("T:\AppData\Orders\Past\")
        LoadedFromOrders = False
        LoadedFromPast = True
        LoadedFromOther = False
        InfoLabel.Text = "Files from 'Past' folder."
    End Sub

    Private Sub GetFromOtherBtn_Click(sender As Object, e As EventArgs) Handles GetFromOtherBtn.Click
        If PastSubText.Text = "" Then
            MsgBox("Please enter a folder name into the location text box.")
        Else
            Dim locString As String = PastSubText.Text
            If Not locString.EndsWith("\") Then 'Make sure we format this right
                locString += "\"
            End If
            LoadedFolderLocation = "T:\AppData\Orders\Past\" + locString 'Get items from subfolders

            Try
                GatherItems(LoadedFolderLocation)

                LoadedFromOrders = False
                LoadedFromPast = False
                LoadedFromOther = True
                InfoLabel.Text = "Files from 'Past' folder."

            Catch ex As Exception
                MsgBox("Could not find " + LoadedFolderLocation + ". Please make sure the text box has been formatted correctly and that the folder exists.")
            End Try
        End If
    End Sub

    Private Sub SendFilesBtn_Click(sender As Object, e As EventArgs) Handles SendFilesBtn.Click

        Dim checkPrevLocation As Integer = 0 '1 for orders, 2 for past, 3 for dated folder.
        If DestSelected Then
            MsgBox("Temporarilly disabled - changes are being made to file relocation.")

            '///STUFF TO DO IN THE FUTURE///

            'If the destination is a different place from where the items are currently
            '    Get selected stuff from table
            '    Set up loading bar
            '    For each selected item
            '        Move item
            '        Loading bar stuff
            '    Next
            '    Reset loading bar
            'MsgBox("Items moved.")
            'End if

        Else
            MsgBox("Select a destination folder from the drop down menu.")
        End If



        'If DestSelected Then
        '    If LoadedFromOrders Then
        '        'MsgBox("Moving from orders is now no longer possible. Too much will go wrong.")

        '        If DestinationPath = "T:\AppData\Orders\" Then
        '            'Stop wasting time :/
        '            MsgBox("This will send " + fileDictionary.Count.ToString + " orders from the orders folder to the orders folder." + vbNewLine + "No.")

        '        Else
        '            'This isn't gonna be too complex. Just send them to DestinationPath + fileDictionary.Item(<KEY VALUE>).Replace("\", "-") + "\"
        '            If MsgBox("This will send " + fileDictionary.Count.ToString + " orders from the orders folder to folders based on their creation date. Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '                For Each file In fileDictionary
        '                    Dim DestPath As String = DestinationPath + file.Value.Replace("/", "-") + "\" + file.Key.Replace("T:\AppData\Orders\", "") 'This will become T:\AppData\Orders\Past\yyyy-MM-dd\1234567.ordex
        '                    My.Computer.FileSystem.MoveFile(file.Key, DestPath) 'Send T:\AppData\Orders\1234567.ordex to T:\AppData\Orders\Past\yyyy-MM-dd\1234567.ordex
        '                Next
        '            End If
        '        End If
        '    Else 'Loaded from Past
        '        If DestinationPath = "T:\AppData\Orders\" Then

        '            LoadingProgress.Maximum = GatheredGrid.Rows.Count 'Loading bar - equivelant to the amount of files
        '            LoadingProgress.Minimum = 0 'Starting at 0

        '            Dim newFileDictionary As New Dictionary(Of String, String) 'Get our selected rows
        '            For Each row As DataGridViewRow In GatheredGrid.Rows 'For each row
        '                If row.Cells(1).Value = True Then 'Check it's ticked
        '                    Dim newKVP As KeyValuePair(Of String, String) = row.Tag 'Get the tag, a dictionary entry - A key and value
        '                    newFileDictionary.Add(newKVP.Key, newKVP.Value) 'Add it to the new dictionary
        '                End If
        '                LoadingProgress.Increment(1) 'Increase our loading bar
        '            Next
        '            LoadingProgress.Value = 0 'Set loading bar back.

        '            LoadingProgress.Maximum = newFileDictionary.Count 'Loading bar - equivelant to the amount of files... redone

        '            If MsgBox("This will send " + newFileDictionary.Count.ToString + " orders from the past folder to the orders folder. Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '                For Each file In newFileDictionary
        '                    'This is why we needed the new file dictionary. Without it, we'd have issues.
        '                    Dim DestPath As String = DestinationPath + file.Key.Replace("T:\AppData\Orders\Past\", "") 'This will become    T:\AppData\Orders\   +   1234567.ordex
        '                    My.Computer.FileSystem.MoveFile(file.Key, DestPath) 'Send T:\AppData\Orders\Past\1234567.ordex to T:\AppData\Orders\1234567.ordex
        '                    LoadingProgress.Increment(1) 'Increase our loading bar
        '                Next
        '            End If
        '            LoadingProgress.Value = 0 'Set loading bar back.
        '        Else
        '            'If MsgBox("This will send " + fileDictionary.Count.ToString + " orders from the past folder to folders based on their creation date. Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '            '    For Each file In fileDictionary

        '            '        'Move 'file' to 'DestinationPath + file.Value.Replace("\", "-") + "\"'


        '            '    Next
        '            'End If

        '            MsgBox("Not happening. It'll screw up Oversold Order Viewer and Order Downloader which have to see old orders.")
        '        End If

        '    End If

        '    InfoLabel.Text = "Files sent."
        'Else
        '    MsgBox("Select a destination folder from the drop down menu.")
        'End If

    End Sub

    Private Sub SendOldBtn_Click(sender As Object, e As EventArgs) Handles SendOldBtn.Click
        If DestSelected Then

            MyBase.Enabled = False 'PREVENT BUTTONS BEING PRESSED
            LoadingProgress.Maximum = GatheredGrid.Rows.Count 'Loading bar - equivelant to the amount of files
            LoadingProgress.Minimum = 0 'Starting at 0
            LoadingProgress.Value = 0

            If MsgBox("This will send orders in this table from a week ago, regardless of whether selected or not, into the target folder. Are you sure you want to do this?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                InfoLabel.Text = "Moving files. This may take some time." 'Let the user know we haven't frozen
                MyBase.Enabled = False

                Application.DoEvents()

                Dim DateOfFile As Date = Today.AddDays(-7) 'Get a week in the past
                For Each Row As DataGridViewRow In GatheredGrid.Rows
                    If Row.Cells(2).Value < DateOfFile Then 'Check if files are a week old
                        Dim theFile As String = Row.Tag
                        If DestinationPath = "T:\AppData\Orders\" Then
                            Dim DestPath As String = DestinationPath + theFile.Replace("T:\AppData\Orders\", "").Replace("Past\", "")
                            My.Computer.FileSystem.MoveFile(theFile, DestPath)
                        Else 'OOOH, we have to seperate by date :D
                            Dim tagDate As DateTime = Row.Cells(2).Value
                            Dim DestPath As String = DestinationPath + tagDate.ToString("yyyy-MM-dd") + "\" + theFile.Replace("T:\AppData\Orders\", "").Replace("Past\", "") 'This will become T:\AppData\Orders\Past\yyyy-MM-dd\1234567.ordex
                            My.Computer.FileSystem.MoveFile(theFile, DestPath) 'Send T:\AppData\Orders\1234567.ordex to T:\AppData\Orders\Past\yyyy-MM-dd\1234567.ordex
                        End If
                    End If
                    LoadingProgress.Increment(1)
                Next
                LoadingProgress.Value = 0
                InfoLabel.Text = "Files moved."
                GatheredGrid.Rows.Clear()
                MyBase.Enabled = True

                Application.DoEvents()
                MsgBox("Items moved.")
            End If
        Else
            MsgBox("Select a destination folder from the drop down menu.")
        End If
    End Sub

    Private DestSelected As Boolean = False
    Private Sub DestinationCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DestinationCB.SelectedValueChanged
        If DestinationCB.Text = "Date-based folder" Then
            DestinationPath = "T:\AppData\Orders\Past\"
            DestSelected = True
        ElseIf DestinationCB.Text = "Orders folder" Then
            DestinationPath = "T:\AppData\Orders\"
            DestSelected = True
        End If
    End Sub


End Class
