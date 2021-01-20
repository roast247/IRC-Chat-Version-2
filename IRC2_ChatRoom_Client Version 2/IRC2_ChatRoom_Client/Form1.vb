Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim HasConnection As Boolean = False
    Dim IsTrying As Boolean = False
    Dim MainIRCCLient As TcpClient
    Dim TX As StreamWriter
    Dim RX As StreamReader
    Dim ServerPort As Integer = 8383
    Dim ServerStatus As Boolean = False
    Dim ServerTrying As Boolean = False
    Dim Clients As New List(Of TcpClient)
    Dim Server As TcpListener
    Dim Users As New List(Of String)
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private this As Object
    Private offset As Object

    Private Sub startserver_Click(sender As Object, e As EventArgs) Handles startserver.Click
        If ServerStatus = False Then
            Server = New TcpListener(Net.IPAddress.Any, ServerPort)
            Server.Start()
            Threading.ThreadPool.QueueUserWorkItem(AddressOf Client_Handler)
            ServerStatus = True
            startserver.Enabled = False
            Stopserver.Enabled = True
        End If
        serveronoff.Text = ServerStatus.ToString.ToUpper

        MessageBox.Show("Please portforward to Port 8383", "Server Port", MessageBoxButtons.OK)

    End Sub

    Function Client_Handler(ByVal state As Object)
        Dim TempClient As TcpClient
        Dim NickName As String = "Mendax"
        Dim MyIP As String = ""
        Try
            Dim TX As StreamWriter
            Dim RX As StreamReader
            Using Client As TcpClient = Server.AcceptTcpClient
                If ServerTrying = False Then
                    Threading.ThreadPool.QueueUserWorkItem(AddressOf Client_Handler)
                End If
                MyIP = Client.Client.RemoteEndPoint.ToString
                iplist.Items.Add(MyIP)
                If Not Clients.Contains(Client) Then
                    Clients.Add(Client)
                Else Client.Close()
                End If
                TX = New StreamWriter(Client.GetStream)
                RX = New StreamReader(Client.GetStream)
                TempClient = Client
                If Client.Client.Connected = True Then
                    TX.WriteLine("Set your username /setuser <Nickname>")
                    TX.Flush()
                    TX.WriteLine("No spaces in your nickname>>>")
                    TX.Flush()
                    TX.WriteLine("Until you set a Username, it will show your IP as a nickname.")
                    TX.Flush()
                    TX.WriteLine("Check current users /users")
                    TX.Flush()

                    While Client.GetStream.CanRead = True
                        If NickName = "Mendax" Then
                            NickName = MyIP
                        End If
                        Dim RawData As String = RX.ReadLine
                        Dim L As Integer = RawData.Length
                        If RawData.StartsWith("/") Then
                            Try
                                If RawData.ToUpper = "/DISCONNECT" Then
                                    Client.Close()
                                ElseIf RawData.ToUpper = "/USERS" Then
                                    Dim UserCount As Integer = 0
                                    TX.WriteLine("User Total(" + Users.Count.ToString + ")")
                                    TX.Flush()
                                    For Each Username1 As String In Users
                                        UserCount += 1
                                        TX.WriteLine("(" + UserCount.ToString + ")" + Username1)
                                        TX.Flush()
                                    Next
                                ElseIf RawData.Contains(" ") Then
                                    Dim Args As String() = RawData.Split(" ")
                                    If Args(0).ToUpper = "/SETUSER" Then
                                        If Users.Contains(NickName) Then
                                            Users.Remove(NickName)
                                        End If
                                        NickName = Args(1)
                                        Users.Add(NickName)
                                        ''   serverchat.Text += "MyIP: " + MyIP + vbNewLine
                                        '' If ListBox1.Items.Contains(MyIP) Then
                                        ''   Console.Beep()
                                        Try
                                            Dim LBB1 As Boolean = False
                                            Dim LBData1 As String = ""
                                            For Each xdata As String In iplist.Items
                                                '' serverchat.Text += "D: " + xdata + vbNewLine
                                                If xdata.Contains(MyIP) Then
                                                    ''  Console.Beep()
                                                    LBB1 = True
                                                    LBData1 = xdata
                                                    Exit For
                                                End If
                                            Next
                                            If LBB1 = True Then
                                                Try
                                                    ''  Console.Beep()
                                                    iplist.Items.Remove(LBData1)
                                                    LBB1 = False
                                                Catch
                                                End Try
                                            End If
                                        Catch
                                        End Try

                                        ''    End If
                                        iplist.Items.Add(MyIP + " " + NickName)
                                        TX.WriteLine("Your new Username is: " + NickName)
                                        TX.Flush()

                                    End If
                                End If
                            Catch

                            End Try
                        Else
                            SendToAllClients(NickName, RawData, Client.Client.RemoteEndPoint.ToString)
                        End If
                        ConsoleX(NickName, RawData, Client.Client.RemoteEndPoint.ToString)
                    End While
                    If Clients.Contains(TempClient) Then
                        Clients.Remove(TempClient)
                    End If
                    If Users.Contains(NickName) Then
                        Users.Remove(NickName)
                    End If
                    ''  If ListBox1.Items.Contains(MyIP) Then
                    Dim LBB As Boolean = False
                    Dim LBData As String = ""
                    For Each xdata In iplist.Items
                        If xdata.ToString.Contains(MyIP) Then
                            LBB = True
                            LBData = xdata
                            Exit For
                        End If
                    Next
                    If LBB = True Then
                        Try
                            iplist.Items.Remove(LBData)
                        Catch
                        End Try

                    End If
                End If
                ''     End If
            End Using
            If Clients.Contains(TempClient) Then
                Clients.Remove(TempClient)
            End If
            If Users.Contains(NickName) Then
                Users.Remove(NickName)
            End If
            Try
                Dim LBB As Boolean = False
                Dim LBData As String = ""
                For Each xdata In iplist.Items
                    If xdata.ToString.Contains(MyIP) Then
                        LBB = True
                        LBData = xdata
                        Exit For
                    End If
                Next
                If LBB = True Then
                    Try
                        iplist.Items.Remove(LBData)
                    Catch
                    End Try

                End If
            Catch
            End Try
        Catch ex As Exception
            If Clients.Contains(TempClient) Then
                Clients.Remove(TempClient)
            End If
            Try
                TempClient.Close()
            Catch
            End Try
            If Users.Contains(NickName) Then
                Users.Remove(NickName)
            End If
            Try
                Dim LBB As Boolean = False
                Dim LBData As String = ""
                For Each xdata In iplist.Items
                    If xdata.ToString.Contains(MyIP) Then
                        LBB = True
                        LBData = xdata
                        Exit For
                    End If
                Next
                If LBB = True Then
                    Try
                        iplist.Items.Remove(LBData)
                    Catch
                    End Try
                End If
            Catch
            End Try
        End Try
        Return True
    End Function

    Function ConsoleX(ByVal NickName As String, ByVal Data As String, ByVal IP As String)
        Try
            Dim ConData As String = IP + "<" + NickName + ">" + Data + ";"
            serverchat.Text += ConData + vbNewLine
        Catch
        End Try
        Return True
    End Function

    Function SendToAllClients(ByVal NickName As String, ByVal Data As String, ByVal IP As String)
        Try
            For Each Client As TcpClient In Clients
                If Client.Connected = True Then
                    If Client.Client.Connected = True Then
                        Try
                            If Not Client.Client.RemoteEndPoint.ToString = IP Then
                                Dim ToSendData As String = "<" + NickName + "> " + Data
                                Dim TX As New StreamWriter(Client.GetStream)
                                TX.WriteLine(ToSendData)
                                TX.Flush()
                            End If
                        Catch

                        End Try
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
        Return True
    End Function

    Private Sub Stopserver_Click(sender As Object, e As EventArgs) Handles Stopserver.Click
        If ServerStatus = True Then
            ServerTrying = True
            Try
                For Each Client As TcpClient In Clients
                    Client.Close()
                Next
                ServerStatus = False
            Catch
                Try
                    Stopserver.PerformClick()
                Catch
                End Try
            End Try
        End If
        ServerTrying = False
        startserver.Enabled = True
        Stopserver.Enabled = False
        serveronoff.Text = ServerStatus.ToString.ToUpper

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If HasConnection = False Then
            If IsTrying = False Then
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Connect)
            End If
        End If
    End Sub
    Function Connect()
        IsTrying = True
        Try
            MainIRCCLient = New TcpClient
            MainIRCCLient.Connect(TextBoxIP.Text, TextBoxPORT.Text)
            HasConnection = True
            TX = New StreamWriter(MainIRCCLient.GetStream)
            RX = New StreamReader(MainIRCCLient.GetStream)
            Threading.ThreadPool.QueueUserWorkItem(AddressOf Connected)
        Catch ex As Exception
            HasConnection = False
        End Try
        IsTrying = False
        Label2.Text = HasConnection.ToString.ToUpper
        Return True
    End Function
    Function Connected()
        If HasConnection = True Then

            Try
                While MainIRCCLient.Client.Connected = True
                    If RX.BaseStream.CanRead = True Then
                        Dim RawData As String = RX.ReadLine
                        Dim L As Integer = RawData.Length
                        If MainIRCCLient.Client.Connected = False Then
                            Exit While
                        End If
                        ircchat.Text += "<<<" + RawData + vbNewLine
                        If RawData.ToUpper.Contains("@TESTCMD") Then
                            Threading.ThreadPool.QueueUserWorkItem(AddressOf MSGBOX1)
                        End If

                    Else Exit While
                    End If
                End While
                MainIRCCLient.Close()
            Catch ex As Exception
                MainIRCCLient.Close()
            End Try

        End If
        ircchat.Text += ">>>Connection Terminated!" + vbNewLine
        REM Important part
        HasConnection = False
        Try
            ''  Button1.Enabled = True
            Button2.PerformClick()
            '' Button2.Enabled = False
        Catch
        End Try
        Return True
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        '' SHOW EXTERNAL IP 
        Dim req As HttpWebRequest = WebRequest.Create("http://api.ipify.org/")
        Dim res As HttpWebResponse = req.GetResponse()
        Dim str As Stream = res.GetResponseStream()
        Dim sr As StreamReader = New StreamReader(str)
        yourip.Text = "" & sr.ReadToEnd
        '' SHOW EXTERNAL IP

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            MainIRCCLient.Close()
            Label2.Text = HasConnection.ToString.ToUpper
        Catch

        End Try
    End Sub
    Function MSGBOX1()
        MsgBox("TEST!")
        Return True
    End Function
    Private Sub RichTextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Try
                If HasConnection = True Then
                    TX.WriteLine(RichTextBox2.Text)
                    TX.Flush()
                    REM I didn't add the vbnewline but it's important to stop the one line issue.
                    ircchat.Text += ">>><YOU> " + RichTextBox2.Text + vbNewLine
                    RichTextBox2.Clear()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        draggable = False
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp
        draggable = False
    End Sub

    Private Sub GroupBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub GroupBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub GroupBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseUp
        draggable = False
    End Sub

    Private Sub TextBox1_MouseDown(sender As Object, e As MouseEventArgs)
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TextBox1_MouseMove(sender As Object, e As MouseEventArgs)
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub TextBox1_MouseUp(sender As Object, e As MouseEventArgs)
        draggable = False
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label6_MouseMove(sender As Object, e As MouseEventArgs) Handles Label6.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Label6_MouseUp(sender As Object, e As MouseEventArgs) Handles Label6.MouseUp
        draggable = False
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        draggable = False
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        draggable = False
    End Sub

    Private Sub DownR_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DownR.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, MousePosition.Y - Me.Location.Y)
        End If
    End Sub

    Private Sub LeftR_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LeftR.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + (Me.Location.X - MousePosition.X), Me.Size.Height)
            Me.Location = New Point(MousePosition.X, Me.Location.Y)
        End If
    End Sub

    Private Sub RightR_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RightR.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(MousePosition.X - Me.Location.X, Me.Size.Height)
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DownR.Location = New Point(0, Me.Size.Height - 3)
        RightR.Location = New Point(Me.Size.Width - 3, 0)
        UpR.Size = New Size(Me.Size.Width, 3)
        DownR.Size = New Size(Me.Size.Width, 3)
        LeftR.Size = New Size(2, Me.Size.Height)
        RightR.Size = New Size(2, Me.Size.Height)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If WindowState = FormWindowState.Normal Then

            WindowState = FormWindowState.Maximized
        Else

            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub UpR_MouseMove(sender As Object, e As MouseEventArgs) Handles UpR.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (Me.Location.Y - MousePosition.Y))
            Me.Location = New Point(Me.Location.X, MousePosition.Y)
        End If
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label7_MouseMove(sender As Object, e As MouseEventArgs) Handles Label7.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Label7_MouseUp(sender As Object, e As MouseEventArgs) Handles Label7.MouseUp
        draggable = False
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        draggable = False
    End Sub

    Private Sub TimerSystemTime_Tick(sender As Object, e As EventArgs) Handles TimerSystemTime.Tick
        lblSystemTime.Text = TimeString
    End Sub

    Private Sub Hostaserverlabel_MouseDown(sender As Object, e As MouseEventArgs) Handles Hostaserverlabel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Hostaserverlabel_MouseMove(sender As Object, e As MouseEventArgs) Handles Hostaserverlabel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Hostaserverlabel_MouseUp(sender As Object, e As MouseEventArgs) Handles Hostaserverlabel.MouseUp
        draggable = False
    End Sub

    Private Sub time_MouseDown(sender As Object, e As MouseEventArgs) Handles time.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub time_MouseMove(sender As Object, e As MouseEventArgs) Handles time.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub time_MouseUp(sender As Object, e As MouseEventArgs) Handles time.MouseUp
        draggable = False
    End Sub

    Private Sub lblSystemTime_MouseDown(sender As Object, e As MouseEventArgs) Handles lblSystemTime.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub lblSystemTime_MouseMove(sender As Object, e As MouseEventArgs) Handles lblSystemTime.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub lblSystemTime_MouseUp(sender As Object, e As MouseEventArgs) Handles lblSystemTime.MouseUp
        draggable = False
    End Sub

    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label8_MouseMove(sender As Object, e As MouseEventArgs) Handles Label8.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Label8_MouseUp(sender As Object, e As MouseEventArgs) Handles Label8.MouseUp
        draggable = False
    End Sub

    Private Sub yourip_MouseDown(sender As Object, e As MouseEventArgs) Handles yourip.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub yourip_MouseMove(sender As Object, e As MouseEventArgs) Handles yourip.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub yourip_MouseUp(sender As Object, e As MouseEventArgs) Handles yourip.MouseUp
        draggable = False
    End Sub
End Class