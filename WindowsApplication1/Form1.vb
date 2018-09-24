Public Class Form1
    Dim rowcounter As String = 1
    Dim columncounter As String = 3
    Dim time1 As New Stopwatch
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataGridView1.Rows.Add(27)
        'DatagridColor()
    End Sub


    Sub addnewrows()

        If DataGridView1.RowCount = 1 Then
            Exit Sub
        Else
            DataGridView1.Rows.Add(1)
        End If


    End Sub

    Sub TheMouseClick(sender As Object, e As EventArgs) Handles DataGridView1.MouseClick

        If DataGridView1.RowCount = 1 Then
            Exit Sub
        Else
            time1.Start()

            Dim TheRowCount As String = DataGridView1.RowCount

            If rowcounter >= TheRowCount Then
                columncounter = columncounter + 1
                rowcounter = 1
            End If


            Dim TotalTime As TimeSpan = time1.Elapsed.Duration

            DataGridView1.Rows(rowcounter).Cells("Column" & columncounter).Value = TotalTime

            rowcounter = rowcounter + 2
        End If

    End Sub

    Sub Calculate() Handles Button1.Click

        Dim TheRowCount As String = DataGridView1.RowCount
        Dim SumRowCounter As String = 1
        Dim SumColumnCounter As String = 3
        Dim TheCell As String = 4

        Do Until SumColumnCounter = 18

            Do While SumRowCounter <= TheRowCount
                If SumRowCounter < 27 Then
                    Dim FirstSum As TimeSpan = DataGridView1.Rows(SumRowCounter).Cells("Column" & SumColumnCounter).Value
                    Dim SecondSum As TimeSpan = DataGridView1.Rows(SumRowCounter + 2).Cells("Column" & SumColumnCounter).Value
                    Dim TotalSum As TimeSpan = SecondSum - FirstSum

                    DataGridView1.Rows(TheCell).Cells("Column" & SumColumnCounter).Value = TotalSum

                    TheCell = TheCell + 2
                    SumRowCounter = SumRowCounter + 2
                End If

                If SumRowCounter >= 27 Then
                    Dim FirstSum As TimeSpan = DataGridView1.Rows(SumRowCounter - 2).Cells("Column" & SumColumnCounter).Value
                    Dim SecondSum As TimeSpan = DataGridView1.Rows(SumRowCounter).Cells("Column" & SumColumnCounter).Value
                    Dim TotalSum As TimeSpan = SecondSum - FirstSum

                    If TheCell < 27 Then
                        DataGridView1.Rows(TheCell).Cells("Column" & SumColumnCounter).Value = TotalSum
                    End If

                    TheCell = TheCell + 2
                    SumRowCounter = SumRowCounter + 2
                End If


            Loop

            SumColumnCounter = SumColumnCounter + 1
            SumRowCounter = 1
            TheCell = 0
        Loop

    End Sub

    Sub DatagridColor()
        DataGridView1.Rows(0).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(2).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(4).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(6).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(8).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(10).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(12).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(14).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(16).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(18).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(20).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(22).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(24).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(26).DefaultCellStyle.BackColor = Color.LightSkyBlue
        DataGridView1.Rows(28).DefaultCellStyle.BackColor = Color.LightSkyBlue
    End Sub
End Class
