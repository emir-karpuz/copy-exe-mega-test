
'--- MEGA TEST projesi ver:1.2 ------------------

Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        prgGuncelle(Path.GetFileName(Application.ExecutablePath))    'MEGA-Test01.exe
        TextBox1.Text = "----- İŞLEM BAŞARILI --------"
    End Sub

    Sub prgGuncelle(strPrgAdi)
        Dim strOldFileName As String() = Directory.GetFiles(Application.StartupPath & "\EXEold", "*.exe")
        Dim strNewFileName As String() = Directory.GetFiles(Application.StartupPath & "\EXEnew", "*.exe")

        For Each exe As String In strOldFileName
            Dim inc As Integer = 0
            If File.Exists(exe) Then   '00 ve 01 var, 02 atandı
                inc += 1
                strPrgAdi &= inc
                Exit For
            End If
        Next

        My.Computer.FileSystem.RenameFile(strPrgAdi, strOldFileName(0))
        My.Computer.FileSystem.MoveFile(Application.StartupPath & "\" + strOldFileName(0), "\EXEold\" & strOldFileName(0), overwrite:=True)
        My.Computer.FileSystem.CopyFile(strNewFileName(0), Application.StartupPath & "\" & strPrgAdi, overwrite:=True)

    End Sub

    Private Function vrsnAl(path As String) As String
        Dim versiyon As String
        versiyon = Strings.Right(path, 6)
        versiyon = Strings.Left(versiyon, 2)
        Return versiyon
    End Function

    Private Function exeAdiKirp(path) As String
        Dim exeAdi As String
        exeAdi = Strings.Right(path, 15)
        Return exeAdi
    End Function

    Private Sub btnCikis_Click(sender As System.Object, e As System.EventArgs) Handles btnCikis.Click
        End
    End Sub

End Class
