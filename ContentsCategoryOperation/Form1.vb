Public Class ContentsGategoryOperation
    Private Sub RefButton1_Click(sender As Object, e As EventArgs) Handles RefButton1.Click
        Dim fcd As New OpenFileDialog()
        fcd.InitialDirectory = "C:\"
        fcd.Title = "使用するコンテンツカテゴリ設計書を選択してください"

        If fcd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            TextBox1.Text = fcd.FileName
        End If

    End Sub

    Private Sub RefButton2_Click(sender As Object, e As EventArgs) Handles RefButton2.Click
        Dim fcd As New OpenFileDialog()
        fcd.InitialDirectory = "C:\"
        fcd.Title = "使用するコンテンツカテゴリ設計書を選択してください"

        If fcd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            XMLPath.Text = fcd.FileName
        End If

    End Sub

    Private Sub RefButton3_Click(sender As Object, e As EventArgs) Handles RefButton3.Click
        Dim fcd As New OpenFileDialog()
        fcd.InitialDirectory = "C:\"
        fcd.Title = "使用するコンテンツカテゴリ設計書を選択してください"

        If fcd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            TextBox2.Text = fcd.FileName
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Me.Close()
    End Sub
End Class
