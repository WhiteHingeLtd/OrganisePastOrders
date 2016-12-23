Imports WHLClasses
Imports Linnworks.Orders.ExtendedOrder

Public Class PastOrderOrganisingForm
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
        LoadingPanel.Visible = True
        Application.DoEvents()

        Dim DateOfFile As Date
        For Each file In FileList
            DateOfFile = My.Computer.FileSystem.GetFileInfo(file).CreationTime '.ToString("yyyy/MM/dd")

            Dim newRow As New DataGridViewRow 'Make a row
            newRow.CreateCells(GatheredGrid) 'Create cells
            newRow.Cells(0).Value = file.Replace(FilePath, "") 'Add the file name to the first column
            newRow.Cells(1).Value = DateOfFile 'Add the state date to the second column

            If LoadOrderStatus Then
                Try 'Awww shit this is gonna suck... We can't just use the orddef because it just checks orders. Past isn't gonna work like that.
                    Dim theOrdex As Linnworks.Orders.ExtendedOrder = Loader.LoadOrdex(file, False)
                    newRow.Cells(2).Value = theOrdex.Status.ToString 'Add the file state to the second column
                Catch ex As Exception
                    'When we get loading stuff ready, we need to have our reports added to the table somewhere for when things go wrong...
                    'Maybe add the name to a list of failed records, then add them to a fail list table in a different window...
                End Try
            End If

            newRow.Tag = file
            GatheredGrid.Rows.Add(newRow) 'Add the row

            LoadingProgress.Increment(1)
            Application.DoEvents()
        Next

        LoadingPanel.Visible = False
        LoadingProgress.Value = 0
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
                PastSubText.Text += "\"
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

    Private Sub SendOldBtn_Click(sender As Object, e As EventArgs) Handles SendOldBtn.Click
        If DestSelected Then
            If DaysOldNum.Text.Length > 0 Then
                If IsNumeric(DaysOldNum.Text) Then
                    Dim daysOld As Integer = DaysOldNum.Text
                    If daysOld < 0 Then
                        MsgBox("No need for a negative indicator. It becomes negative anyway.")
                        daysOld = -daysOld
                        DaysOldNum.Text = daysOld
                    ElseIf daysOld = 0 Then
                        MsgBox("... 0 days, huh... Sure. When I reach into the vast emptiness of nothing at all, I get... your FACE. I will now proceed to stuff your face into the folder you selected.")
                        Threading.Thread.Sleep(1000)
                        MsgBox("...")
                        Threading.Thread.Sleep(500)
                        MsgBox("Ok, that was rude of me. I'll just set the days to 4 instead.")
                        daysOld = 4
                        DaysOldNum.Text = "4"
                        MsgBox("Now stop being a smartarse. ¬_¬")
                        Threading.Thread.Sleep(200)
                    End If
                    MyBase.Enabled = False 'PREVENT BUTTONS BEING PRESSED
                    LoadingProgress.Maximum = GatheredGrid.Rows.Count 'Loading bar - equivelant to the amount of files
                    LoadingProgress.Minimum = 0 'Starting at 0
                    LoadingProgress.Value = 0

                    If MsgBox("This will send orders in this table from " + daysOld.ToString + " days ago into the target folder. Are you sure you want to do this?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        InfoLabel.Text = "Moving files. This may take some time." 'Let the user know we haven't frozen
                        MyBase.Enabled = False
                        LoadingPanel.Visible = True
                        Application.DoEvents()

                        Dim DateOfFile As Date = Today.AddDays(-daysOld) 'Get 4 days in the past
                        For Each Row As DataGridViewRow In GatheredGrid.Rows
                            If Row.Cells(1).Value < DateOfFile Then 'Check if files are 4 days old
                                Dim theFile As String = Row.Tag
                                If DestinationPath = "T:\AppData\Orders\" Then
                                    Dim DestPath As String = DestinationPath + theFile.Replace("T:\AppData\Orders\", "").Replace("Past\", "")
                                    My.Computer.FileSystem.MoveFile(theFile, DestPath)
                                Else 'OOOH, we have to seperate by date :D
                                    Dim tagDate As DateTime = Row.Cells(1).Value
                                    Dim DestPath As String = DestinationPath + tagDate.ToString("yyyy-MM-dd") + "\" + theFile.Replace("T:\AppData\Orders\", "").Replace("Past\", "") 'This will become T:\AppData\Orders\Past\yyyy-MM-dd\1234567.ordex
                                    My.Computer.FileSystem.MoveFile(theFile, DestPath) 'Send T:\AppData\Orders\1234567.ordex to T:\AppData\Orders\Past\yyyy-MM-dd\1234567.ordex
                                End If
                            End If
                            LoadingProgress.Increment(1)
                            Application.DoEvents()
                        Next
                        LoadingProgress.Value = 0
                        LoadingPanel.Visible = False
                        InfoLabel.Text = "Files moved."
                        GatheredGrid.Rows.Clear()
                        Application.DoEvents()
                        If MsgBox("Items moved. Do you want to make the Past Order Dictionary?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            MakeOrdLst()
                        Else
                            MyBase.Enabled = True
                        End If
                    Else
                        MyBase.Enabled = True
                    End If
                Else
                    MsgBox("Set a NUMBER of days to limit to.")
                End If
            Else
                MsgBox("Set a number of days to limit to.")
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

    Private Sub MakeOrdLst()
        Dim currentOrdexList As List(Of String) = My.Computer.FileSystem.GetFiles("T:\AppData\Orders\", FileIO.SearchOption.SearchTopLevelOnly, "*.ordex").ToList
        Dim pastOrdexList As List(Of String) = My.Computer.FileSystem.GetFiles("T:\AppData\Orders\Past\", FileIO.SearchOption.SearchTopLevelOnly, "*.ordex").ToList
        Dim locList As List(Of String) = My.Computer.FileSystem.GetDirectories("T:\AppData\Orders\Past\").ToList
        LoadingProgress.Maximum = locList.Count
        LoadingProgress.Value = 0

        Dim OrderDictionary As New Dictionary(Of String, String)
        LoadingPanel.Visible = True

        'ORDERS FOLDER
        InfoLabel.Text = currentOrdexList.Count.ToString + " files in Orders"
        Application.DoEvents()
        For Each currentOrdex As String In currentOrdexList
            OrderDictionary(currentOrdex.Split("\")(currentOrdex.Split("\").Count - 1).Replace(".ordex", "")) = currentOrdex
        Next

        'PAST FOLDER
        InfoLabel.Text = pastOrdexList.Count.ToString + " files in Past"
        Application.DoEvents()
        For Each pastOrdex As String In pastOrdexList
            OrderDictionary(pastOrdex.Split("\")(pastOrdex.Split("\").Count - 1).Replace(".ordex", "")) = pastOrdex
        Next

        'PAST FOLDERS
        For Each ListedLocation As String In locList
            'Get our files
            Dim fileList As List(Of String) = My.Computer.FileSystem.GetFiles(ListedLocation, FileIO.SearchOption.SearchTopLevelOnly, "*.ordex").ToList
            InfoLabel.Text = fileList.Count.ToString + " files in " + ListedLocation.Replace("T:\AppData\Orders\Past\", "").Replace("\", "")
            Application.DoEvents()

            For Each ListedFile In fileList
                OrderDictionary(ListedFile.Split("\")(ListedFile.Split("\").Count - 1).Replace(".ordex", "")) = ListedFile
            Next
            Try
                LoadingProgress.Value += 1
                Application.DoEvents()
            Catch ex As Exception

            End Try
        Next

        LoadingProgress.Value = 0
        InfoLabel.Text = "Saving POD.ordlst to T:\AppData"
        Application.DoEvents()
        Loader.SaveDataToFile("POD.ordlst", OrderDictionary, "T:\AppData") 'Past Order Dictionary
        MyBase.Enabled = True 'LET BUTTONS BE PRESSED
        InfoLabel.Text = "POD.ordlst saved to T:\AppData"
        LoadingPanel.Visible = False
    End Sub
End Class
