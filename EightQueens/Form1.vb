Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class Form1

    Private m_cb As New ChessBoard
    Private solutionNumber As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        m_cb.Dock = DockStyle.Fill
        m_cb.GetSolutions()
        Panel1.Controls.Add(m_cb)
        Button1.BringToFront()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        m_cb.Cells = m_cb.Solutions(solutionNumber)
        m_cb.DrawBoard()
        Label1.Text = "Solution #" + Convert.ToString((solutionNumber + 1))

        solutionNumber += 1
        If solutionNumber = m_cb.Solutions.Count Then
            solutionNumber = 0
        End If
    End Sub
End Class
