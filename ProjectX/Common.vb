
Module Common

    Public Sub ShowMessage(str As String)
        If Not str Is Nothing Then
            If str.Equals("") Then
                MsgBox("文字列は(空欄)です！")
            Else
                MsgBox(str)
            End If
        Else
            MsgBox("文字列はNothing です！")
        End If
    End Sub

    Public Function GetCSV(file_path As String) As List(Of String)
        Dim list As New List(Of String)

        ' csv ファイルから読み込み処理
        Using textFile As New FileIO.TextFieldParser(file_path) ' -- デフォルト encoding は UTF8
            ' --- デリミターをタブと定義する
            textFile.TextFieldType = FileIO.FieldType.Delimited
            textFile.SetDelimiters(vbTab)    ' -- カンマ区切りの場合はカッコ内を "," にします
            ' --- 行を文字型配列（currentRow）に読み込み、各列を DataGridView に格納する
            Dim currentRow As String() ' -- 文字型配列
            Dim myRow As Integer = 0
            Dim myCol As Integer = 0
            ' ---▼▼ 行ループ
            While Not textFile.EndOfData
                currentRow = textFile.ReadFields() ' -- １行を文字型配列に格納
                Dim currentColumn As String
                ' ---▼ 列ループ：１行分の列を埋める
                For Each currentColumn In currentRow

                    Dim str As String() = currentColumn.Split(",")
                    For Each item In str
                        list.Add(item)
                    Next
                    myCol += 1
                Next ' --▲ 列ループ
                myCol = 0
                myRow += 1
            End While ' --▲▲ 行ループ
            ' --- 入力ファイルを閉じる
        End Using

        GetCSV = list
    End Function


    Public Function GetFilePath() As String
        'OpenFileDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog()

        'はじめのファイル名を指定する
        'はじめに「ファイル名」で表示される文字列を指定する
        ofd.FileName = ""
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        ofd.InitialDirectory = "C:\"
        '[ファイルの種類]に表示される選択肢を指定する
        '指定しないとすべてのファイルが表示される
        ofd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*"
        '[ファイルの種類]ではじめに選択されるものを指定する
        '2番目の「すべてのファイル」が選択されているようにする
        ofd.FilterIndex = 2
        'タイトルを設定する
        ofd.Title = "開くファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        ofd.RestoreDirectory = True
        '存在しないファイルの名前が指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckFileExists = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckPathExists = True

        'ダイアログを表示する
        If ofd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            Console.WriteLine(ofd.FileName)
            GetFilePath = ofd.FileName
        Else
            GetFilePath = ""
        End If
    End Function
End Module
