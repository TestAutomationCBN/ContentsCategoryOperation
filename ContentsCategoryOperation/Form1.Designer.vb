<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContentsGategoryOperation
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefButton1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RefButton3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.XMLPath = New System.Windows.Forms.TextBox()
        Me.RefButton2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(31, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(439, 19)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1. 基となるコンテンツカテゴリ設計書を選択してください。"
        '
        'RefButton1
        '
        Me.RefButton1.Location = New System.Drawing.Point(491, 52)
        Me.RefButton1.Name = "RefButton1"
        Me.RefButton1.Size = New System.Drawing.Size(100, 23)
        Me.RefButton1.TabIndex = 2
        Me.RefButton1.Text = "参照"
        Me.RefButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2. 行う処理を下記より選択してください。"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(31, 166)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(246, 16)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "エクスポートXMLと比較を実施(テストの実施)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(31, 145)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(119, 16)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "テスト仕様書の作成"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.RadioButton1.Location = New System.Drawing.Point(31, 123)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(127, 16)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "インポート用XML作成"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "3. 生成ファイルの出力先を選択してください。"
        '
        'RefButton3
        '
        Me.RefButton3.Location = New System.Drawing.Point(491, 228)
        Me.RefButton3.Name = "RefButton3"
        Me.RefButton3.Size = New System.Drawing.Size(100, 23)
        Me.RefButton3.TabIndex = 9
        Me.RefButton3.Text = "参照"
        Me.RefButton3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(31, 230)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(439, 19)
        Me.TextBox2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "エクスポートXML"
        '
        'XMLPath
        '
        Me.XMLPath.Location = New System.Drawing.Point(370, 165)
        Me.XMLPath.Name = "XMLPath"
        Me.XMLPath.Size = New System.Drawing.Size(100, 19)
        Me.XMLPath.TabIndex = 11
        '
        'RefButton2
        '
        Me.RefButton2.Location = New System.Drawing.Point(491, 163)
        Me.RefButton2.Name = "RefButton2"
        Me.RefButton2.Size = New System.Drawing.Size(100, 23)
        Me.RefButton2.TabIndex = 12
        Me.RefButton2.Text = "参照"
        Me.RefButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 21)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "処理の実行"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(336, 276)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(134, 21)
        Me.ClearButton.TabIndex = 14
        Me.ClearButton.Text = "キャンセル"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ContentsGategoryOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 309)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RefButton2)
        Me.Controls.Add(Me.XMLPath)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RefButton3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RefButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ContentsGategoryOperation"
        Me.Text = "コンテンツカテゴリ系操作メニュー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents RefButton1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents RefButton3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents XMLPath As TextBox
    Friend WithEvents RefButton2 As Button
    Protected Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ClearButton As Button
End Class
