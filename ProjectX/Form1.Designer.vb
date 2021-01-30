<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Number_CheckBox = New System.Windows.Forms.CheckBox()
        Me.FilePathText = New System.Windows.Forms.TextBox()
        Me.FilePathButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 22)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "占い開始！"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(149, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(308, 22)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "文字コード(Shift-jis)"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(90, 100)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(204, 22)
        Me.TextBox3.TabIndex = 5
        '
        'Number_CheckBox
        '
        Me.Number_CheckBox.AutoSize = True
        Me.Number_CheckBox.Location = New System.Drawing.Point(300, 102)
        Me.Number_CheckBox.Name = "Number_CheckBox"
        Me.Number_CheckBox.Size = New System.Drawing.Size(84, 19)
        Me.Number_CheckBox.TabIndex = 6
        Me.Number_CheckBox.Text = "数値のみ"
        Me.Number_CheckBox.UseVisualStyleBackColor = True
        '
        'FilePathText
        '
        Me.FilePathText.Location = New System.Drawing.Point(90, 138)
        Me.FilePathText.Name = "FilePathText"
        Me.FilePathText.Size = New System.Drawing.Size(204, 22)
        Me.FilePathText.TabIndex = 7
        '
        'FilePathButton
        '
        Me.FilePathButton.Location = New System.Drawing.Point(301, 136)
        Me.FilePathButton.Name = "FilePathButton"
        Me.FilePathButton.Size = New System.Drawing.Size(134, 24)
        Me.FilePathButton.TabIndex = 8
        Me.FilePathButton.Text = "ファイルを開く"
        Me.FilePathButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(582, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FilePathButton)
        Me.Controls.Add(Me.FilePathText)
        Me.Controls.Add(Me.Number_CheckBox)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form"
        Me.Text = "占いフォーム"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Number_CheckBox As CheckBox
    Friend WithEvents FilePathText As TextBox
    Friend WithEvents FilePathButton As Button
    Friend WithEvents Button2 As Button
End Class
