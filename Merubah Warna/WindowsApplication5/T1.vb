Public Class T1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BackColor = Color.Red

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Red Then
            Me.BackColor = Color.Aqua
        Else
            Me.BackColor = Color.Red
        End If
    End Sub
End Class

