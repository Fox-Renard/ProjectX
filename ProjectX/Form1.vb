﻿Public Class Form1

    Private forture_telling_list As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ' csv ファイルから読み込み処理
        Dim textFile As FileIO.TextFieldParser ' -- 入力するファイル
        ' --- 入力ファイルを開く
        textFile = New FileIO.TextFieldParser("..\../csv/forture_telling.csv") ' -- デフォルト encoding は UTF8
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
                    forture_telling_list.Add(item)
                Next
                myCol += 1
            Next ' --▲ 列ループ
            myCol = 0
            myRow += 1
        End While ' --▲▲ 行ループ
        ' --- 入力ファイルを閉じる
        textFile.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text

        ' add method to forture-tekking(占い)
        ' 大吉、中吉、小吉、凶、大凶　の５つをランダムでMsgBox（）で表示

        ' ランダム処理
        Dim bytesData As Byte()

        Dim rnd As Random = New Random(1)

        'Shift JISとして文字列に変換
        bytesData = System.Text.Encoding.GetEncoding(932).GetBytes(str)

        ' 合計を加算
        Dim sum As Integer = 0
        For i As Integer = 0 To bytesData.Count - 1
            sum += bytesData(i)
        Next

        MsgBox(forture_telling_list(sum Mod forture_telling_list.Count))

        ' 文字コード出力
        TextBox2.Text = BitConverter.ToString(bytesData)
    End Sub


End Class
