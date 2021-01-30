Public Class Form

    Private forture_telling_list As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forture_telling_list = GetCSV("..\../csv/forture_telling.csv")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text

        ' ランダム処理
        Dim bytesData As Byte()

        'Shift JISとして文字列に変換
        bytesData = System.Text.Encoding.GetEncoding(932).GetBytes(str)

        ' 合計を加算
        Dim sum As Integer = 0
        For i As Integer = 0 To bytesData.Count - 1
            sum += bytesData(i)
        Next

        ShowMessage(forture_telling_list(sum Mod forture_telling_list.Count))
        'MsgBox(forture_telling_list(sum Mod forture_telling_list.Count))

        ' 文字コード出力
        TextBox2.Text = BitConverter.ToString(bytesData)
    End Sub



    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress

        If Number_CheckBox.Checked Then
            ' 数値、BackSpaceのみ入力可能、それ以外は空欄に変更
            If Not (IsNumeric(e.KeyChar) Or e.KeyChar = vbBack) Then
                e.KeyChar = ""
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Number_CheckBox.CheckedChanged
        ' テキストボックスの文字を削除
        TextBox3.Text = ""
    End Sub

    Private Sub FilePathButton_Click(sender As Object, e As EventArgs) Handles FilePathButton.Click
        FilePathText.Text = GetFilePath()
    End Sub
End Class
