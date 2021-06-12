Public Class Formulario
    Dim nombre, apellido, fecha, Aficiones, Sex, Gym, Box, Spinning As String


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        
        If nombre = "" Or apellido = "" Or fecha = "" Or Aficiones = "" Or Sex = "" Or cbx1.Checked = False And cbx2.Checked = False And cbx3.Checked = False Or rdbtn1.Checked = False And rdbtn2.Checked = False Then
            MessageBox.Show(" ¡Complete todos los datos! ")

        Else
            MessageBox.Show("Nombre: " & nombre & Environment.NewLine &
                                       "Apellido: " & apellido & Environment.NewLine &
                                       "Fecha: " & fecha & Environment.NewLine &
                                       "Sexo: " & Sex & Environment.NewLine &
                                       "AfIciones: " & Aficiones)

        End If


    End Sub

    Private Sub rdbtn1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn1.CheckedChanged
        Sex = " Femenino "


    End Sub

    Private Sub rdbtn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtn2.CheckedChanged
        Sex = " Masculino "

    End Sub

    Private Sub cbx1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx1.CheckedChanged

        Gym = " Gym "
        Aficiones = Gym
        
        If cbx1.Checked And cbx2.Checked And cbx3.Checked Then
            Aficiones = Gym & " , " & Box & " y " & Spinning
        End If
        If cbx1.Checked And cbx2.Checked And cbx3.Checked = False Then
            Aficiones = Gym & " y " & Box
        End If
        If cbx1.Checked And cbx2.Checked = False And cbx3.Checked Then
            Aficiones = Gym & " y " & Spinning
        End If
        If cbx1.Checked = False And cbx2.Checked And cbx3.Checked Then
            Aficiones = Box & " y " & Spinning
        End If
        If cbx1.Checked = False And cbx2.Checked = False And cbx3.Checked Then
            Aficiones = Spinning
        End If
        If cbx1.Checked And cbx2.Checked = False And cbx3.Checked = False Then
            Aficiones = Gym
        End If
    End Sub

    Private Sub cbx2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx2.CheckedChanged

        Box = " Box "
        Aficiones = Box
        
        If cbx1.Checked And cbx2.Checked And cbx3.Checked Then
            Aficiones = Gym & " , " & Box & " y " & Spinning
        End If
        If cbx1.Checked And cbx2.Checked And cbx3.Checked = False Then
            Aficiones = Gym & " y " & Box
        End If
        If cbx1.Checked And cbx2.Checked = False And cbx3.Checked Then
            Aficiones = Gym & " y " & Spinning
        End If
        If cbx1.Checked = False And cbx2.Checked And cbx3.Checked Then
            Aficiones = Box & " y " & Spinning
        End If
        If cbx1.Checked = False And cbx2.Checked And cbx3.Checked = False Then
            Aficiones = Box
        End If

    End Sub

    Private Sub cbx3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx3.CheckedChanged
        Spinning = " Spinning "
        Aficiones = Spinning

        If cbx1.Checked And cbx2.Checked And cbx3.Checked Then
            Aficiones = Gym & " , " & Box & " y " & Spinning
        End If
        If cbx1.Checked And cbx2.Checked And cbx3.Checked = False Then
            Aficiones = Gym & " y " & Box
        End If
        If cbx1.Checked And cbx2.Checked = False And cbx3.Checked Then
            Aficiones = Gym & " y " & Spinning
        End If
        If cbx1.Checked = False And cbx2.Checked And cbx3.Checked Then
            Aficiones = Box & " y " & Spinning
        End If

        If cbx1.Checked = False And cbx2.Checked = False And cbx3.Checked Then
            Aficiones = Spinning
        End If
    End Sub

    Private Sub Datetime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datetime.ValueChanged
        fecha = Datetime.Value.Date
    End Sub

    Private Sub txtN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN.TextChanged
        nombre = txtN.Text
        

    End Sub

    Private Sub txtApe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApe.TextChanged
        apellido = txtApe.Text
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtN.Text = ""
        txtApe.Text = ""
        Datetime.Text = ""
        cbx1.Checked = False
        cbx2.Checked = False
        cbx3.Checked = False
        rdbtn1.Checked = False
        rdbtn2.Checked = False


    End Sub
End Class
