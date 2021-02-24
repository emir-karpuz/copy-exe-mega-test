'!-- MEGA TEST projesi ver:1.2 ------------------

Imports System.IO

Public Class Form1
    Dim exeOldNames As String() = Directory.GetFiles(Application.StartupPath & ".\EXEold", "*.exe")     'Eski exe'lerin yolu
    Dim exeNewName As String() = Directory.GetFiles(Application.StartupPath & ".\EXEnew", "*.exe")      'Yeni exe'nin yolu
    Dim currentProgramName As String = Path.GetFileName(Application.ExecutablePath)                     'Şu anki exe'nin yolu

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load    'Form1 yüklendiğinde
        updateProgram(currentProgramName)    'C:\Users\...\bin\Debug\MEGA-Test01.exe girer
        lblResult.Text += " Successful"
    End Sub

    Private Sub updateProgram(currentProgramName As String)     'Programı günceller
        Try
            Dim exeOldNameNext As String = getVersion() & "_" & currentProgramName      'EXEold'a atılacak dosyaya verilecek isim

            My.Computer.FileSystem.RenameFile(currentProgramName, exeOldNameNext)       'İsim değişikliği yapılır

            If File.Exists(".\EXEold\" & exeOldNameNext) Then                           'Eğer dosya, klasörde var ise
                File.Delete(".\EXEold\" & exeOldNameNext)                               'dosya silinir
            End If

            My.Computer.FileSystem.MoveFile(Application.StartupPath & "\" & exeOldNameNext, ".\EXEold\" & exeOldNameNext)   'Dosyayı EXEold'a taşır
            My.Computer.FileSystem.CopyFile(exeNewName(0), Application.StartupPath & "\" & currentProgramName)              'EXEnew'den yeni dosyayı alır
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hata")
        End Try
    End Sub

    Private Function getVersion() As String             'EXEold klasöründeki sıradaki serialNo'yu döndürür
        Dim splittedExe As String()
        Dim serialNo As Integer = 0

        For Each exe As String In exeOldNames           'EXEold'daki her bir exe için
            txtExeList.Text += trimEXE(exe) & vbCrLf    'Textbox'a isim gönder
            splittedExe = Split(trimEXE(exe), "_")      '"_" Sembolünden itibaren exe yolunu parçalar
            serialNo = splittedExe(0) + 1               'serialNo'ya 1 ekler, son iterasyonda varolan dosyanın 1 fazlası için serialNo'yu verir
        Next                                            'Sıradaki

        Return serialNo                                 'serialNo'yu döndürür
    End Function

    Private Function trimEXE(path) As String            'C:\Users\...\bin\Debug\EXEold\MEGA-Test01.exe yolunu alır sadece "x_MEGA-Test01.exe" döner
        Dim trimmedEXEName As String
        trimmedEXEName = Strings.Right(path, 17)
        Return trimmedEXEName
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click   'Çıkış butonu
        End
    End Sub

End Class
