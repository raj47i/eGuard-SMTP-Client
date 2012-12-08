Imports System.Net.Mail

Public Class Main
    Dim mailmsg As System.Net.Mail.MailMessage
    '    Dim client As System.Net.Mail.SmtpClient
    Dim mailattach As System.Net.Mail.Attachment



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim mailto As New MailAddress(txtTo.Text)
            Dim mailFrom As New MailAddress(txtFrom.Text)
            ' Dim copy As New MailAddress(txtCC.Text)


            mailmsg = New MailMessage(mailFrom, mailto)

            '  mailmsg.CC.Add(copy)

            mailmsg.Subject = txtSubject.Text
            mailmsg.Body = rtBody.Text
            'mailmsg.Attachments.Add(mailattach)
            'Dim client As New SmtpClient("oracleserver")
            Dim client As New SmtpClient("localhost")
            MsgBox(client.Host & "," & client.Port)
            client.Send(mailmsg)
            MsgBox("Mail send successfully")
        Catch ex As Exception
            MsgBox("Unexpected Error : " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        txtAttachement.Text = OpenFileDialog1.FileName
        mailattach = New Attachment(txtAttachement.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Forms.AbouteGUARD.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Help.ShowHelp(sender, My.Application.Info.DirectoryPath & "/Manual.CHM", HelpNavigator.TableOfContents)
    End Sub
End Class
