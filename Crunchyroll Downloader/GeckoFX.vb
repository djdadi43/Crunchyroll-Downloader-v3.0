﻿Imports Gecko.Events
Imports Gecko
Imports System.IO
Imports Gecko.Cache
Imports System.ComponentModel
Imports System.Threading
Public Class GeckoFX
    Public keks As String = Nothing
    Public c As Boolean = True
    Dim t As Thread
    Private Sub GeckoWebBrowser1_DocumentCompleted(sender As Object, e As EventArgs) Handles WebBrowser1.DocumentCompleted
        'My.Computer.Clipboard.SetText(WebBrowser1.Document.Body.InnerHtml)
        'Try
        '    Dim ads_add As String = My.Resources.ads_preroll
        '    For Each c As String In WebBrowser1.Document.Body.InnerHtml
        '        If c = My.Resources.ads_midroll Then
        '            ads_add = ads_add + My.Resources.ads_preroll
        '        End If
        '    Next
        '    WebBrowser1.Document.Body.InnerHtml = WebBrowser1.Document.Body.InnerHtml.Replace(My.Resources.ads_preroll, ads_add)
        'Catch ex As Exception
        'End Try
        'My.Computer.Clipboard.SetText(WebBrowser1.Document.Body.InnerHtml)
        If Main.LoginOnly = "US_UnBlock" Then
            Main.LoginOnly = "US_UnBlocck_Wait2nd"
            'Main.LoginOnly = "US_UnBlock_Wait"
            'My.Computer.Clipboard.SetText(WebBrowser1.Url.ToString + vbNewLine + "before" + vbNewLine + vbNewLine + WebBrowser1.Document.Cookie)
            'einstellungen.RichTextBox1.Text = WebBrowser1.Url.ToString + vbNewLine + "before" + vbNewLine + vbNewLine + WebBrowser1.Document.Cookie
            'WebBrowser1.Document.Cookie = ""
            'WebBrowser1.Navigate("javascript:document.cookie = 'session_id=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;';")
            'WebBrowser1.Navigate("javascript:$$")
            'WebBrowser1.ExecuteCommand("alert(document.cookie);")
            'WebBrowser1.Document.Body.InnerHtml = WebBrowser1.Document.Body.InnerHtml + "<script>alert(document.cookie);</script>"
            'einstellungen.RichTextBox1.Text = einstellungen.RichTextBox1.Text + vbNewLine + WebBrowser1.Url.ToString + vbNewLine + "after" + vbNewLine + vbNewLine + WebBrowser1.Document.Cookie
            'My.Computer.Clipboard.SetText(before + vbNewLine + WebBrowser1.Url.ToString + vbNewLine + "after" + vbNewLine + vbNewLine + WebBrowser1.Document.Cookie)
            Try
                'Dim cookieName As String = "session_id"
                'Dim cookieValue As String = keks
                'WebBrowser1.Document.Cookie = String.Format("{0}={1}; {2}", cookieName, cookieValue, WebBrowser1.Document.Cookie)
                'Dim cookieName2 As String = "sess_id"
                'WebBrowser1.Document.Cookie = String.Format("{0}={1}; {2}", cookieName2, cookieValue, WebBrowser1.Document.Cookie)
                'Dim cookieFillName As String = "c_locale"
                'Dim cookieFillValue As String = "enUS"
                'WebBrowser1.Document.Cookie = String.Format("{0}={1}; {2}", cookieFillName, cookieFillValue, WebBrowser1.Document.Cookie)
                WebBrowser1.Navigate("javascript:document.cookie =" + Chr(34) + "session_id=" + keks + "; expires=Thu, 05 Jan 2021 00:00:00 UTC; path=/;" + Chr(34) + ";")
                Main.Pause(2)
                WebBrowser1.Navigate("javascript:document.cookie = " + Chr(34) + "sess_id=" + keks + "; expires=Thu, 05 Jan 2021 00:00:00 UTC; path=/;" + Chr(34) + ";")
                Main.Pause(2)
                WebBrowser1.Navigate("javascript:document.cookie = " + Chr(34) + "c_locale=enUS; expires=Thu, 05 Jan 2021 00:00:00 UTC; path=/;" + Chr(34) + ";")
                Main.Pause(2)
                'WebBrowser1.Navigate("javascript:alert(document.cookie);")
                'Main.Pause(2)
                WebBrowser1.Navigate("https://www.crunchyroll.com/")
                Main.LoginOnly = "US_UnBlock_Check"
                'WebBrowser1.Navigate("https://www.crunchyroll.com/")
            Catch ex As Exception
            End Try
        ElseIf Main.LoginOnly = "US_UnBlock_Wait" Then
            Main.LoginOnly = "US_UnBlocck_Wait2nd"
            Main.Pause(2)
            Main.LoginOnly = "US_UnBlock_Check"
            WebBrowser1.Navigate("https://www.crunchyroll.com/")
        ElseIf Main.LoginOnly = "US_UnBlock_Check" Then
            Main.LoginOnly = "false"
            If CBool(InStr(WebBrowser1.Document.Body.OuterHtml, "Your detected location is United States of America.")) Then
                'MsgBox(keks + vbNewLine + WebBrowser1.Document.Cookie)
                MsgBox("unlock successful", MsgBoxStyle.Information)
                Me.Close()
                'MsgBox(WebBrowser1.Document.Cookie)
            Else

                'MsgBox(WebBrowser1.Document.Cookie)
                'MsgBox(keks + vbNewLine + WebBrowser1.Document.Cookie)
                MsgBox("unlock failes", MsgBoxStyle.Exclamation)
                Me.Close()
            End If
        Else


            If CBool(InStr(WebBrowser1.Url.ToString, "crunchyroll.com")) Then

                If Main.b = False Then
                    Try
                        If WebBrowser1.Url.ToString = "https://www.crunchyroll.com/" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/en-gb" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/es" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/es-es" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/pt-br" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/pt-pt" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/fr" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/de" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/ar" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/it" Then
                            Main.b = True
                        ElseIf WebBrowser1.Url.ToString = "https://www.crunchyroll.com/ru" Then
                            Main.b = True
                        ElseIf CBool(InStr(WebBrowser1.Document.Body.OuterHtml, "hardsub_lang")) Then
                            Main.WebbrowserURL = WebBrowser1.Url.ToString
                            Main.WebbrowserText = WebBrowser1.Document.Body.OuterHtml
                            Main.WebbrowserTitle = WebBrowser1.DocumentTitle
                            Main.b = True
                            t = New Thread(AddressOf Main.GrappURL)
                            t.Priority = ThreadPriority.Normal
                            t.IsBackground = True
                            t.Start()

                        ElseIf CBool(InStr(WebBrowser1.Document.Body.OuterHtml, "season-dropdown content-menu block")) Then
                            Main.b = True
                            'MsgBox("1")
                            If CBool(InStr(WebBrowser1.Document.Body.OuterHtml, Chr(34) + "premium_status" + Chr(34) + ":" + Chr(34) + "premium" + Chr(34))) Then
                                Main.WebbrowserURL = WebBrowser1.Url.ToString
                                Main.WebbrowserText = WebBrowser1.Document.Body.OuterHtml
                                Main.WebbrowserTitle = WebBrowser1.DocumentTitle
                                Main.SeasonDropdownGrapp()
                            Else 'If CBool(InStr(WebBrowser1.Document.Body.OuterHtml, Chr(34) + "premium_status" + Chr(34) + ":" + Chr(34) + "free_trial" + Chr(34))) Then
                                Main.WebbrowserURL = WebBrowser1.Url.ToString
                                Main.WebbrowserText = WebBrowser1.Document.Body.OuterHtml
                                Main.WebbrowserTitle = WebBrowser1.DocumentTitle
                                Main.SeasonDropdownGrapp()
                                ' ElseIf CBool(InStr(WebBrowser1.Document.Body.OuterHtml, Chr(34) + "premium_status" + Chr(34) + ":" + Chr(34) + "free_trial" + Chr(34))) Then
                                'Main.SeasonDropdownGrapp()
                                'Else
                                'MsgBox(Main.CR_Premium_Failed, MsgBoxStyle.Information)
                                '    Anime_Add.groupBox1.Visible = True
                                '    Anime_Add.groupBox2.Visible = False
                                '    Anime_Add.GroupBox3.Visible = False
                                '    Anime_Add.pictureBox4.Image = My.Resources.main_button_download_default
                            End If
                        ElseIf CBool(InStr(WebBrowser1.Document.Body.OuterHtml, "wrapper container-shadow hover-classes")) Then
                            Main.b = True
                            'MsgBox("1")
                            If CBool(InStr(WebBrowser1.Document.Body.OuterHtml, Chr(34) + "premium_status" + Chr(34) + ":" + Chr(34) + "premium" + Chr(34))) Then
                                Main.WebbrowserURL = WebBrowser1.Url.ToString
                                Main.WebbrowserText = WebBrowser1.Document.Body.OuterHtml
                                Main.WebbrowserTitle = WebBrowser1.DocumentTitle
                                Main.MassGrapp()
                            Else 'If CBool(InStr(WebBrowser1.Document.Body.OuterHtml, Chr(34) + "premium_status" + Chr(34) + ":" + Chr(34) + "free_trial" + Chr(34))) Then
                                Main.WebbrowserURL = WebBrowser1.Url.ToString
                                Main.WebbrowserText = WebBrowser1.Document.Body.OuterHtml
                                Main.WebbrowserTitle = WebBrowser1.DocumentTitle
                                Main.MassGrapp()
                                'ElseIf CBool(InStr(WebBrowser1.Document.Body.OuterHtml, Chr(34) + "premium_status" + Chr(34) + ":" + Chr(34) + "free_trial" + Chr(34))) Then
                                'Main.MassGrapp()
                                'Else
                                '    'MsgBox(Main.CR_Premium_Failed, MsgBoxStyle.Information)
                                '    Anime_Add.groupBox1.Visible = True
                                '    Anime_Add.groupBox2.Visible = False
                                '    Anime_Add.GroupBox3.Visible = False
                                '    Anime_Add.pictureBox4.Image = My.Resources.main_button_download_default

                            End If
                        Else
                            MsgBox(Main.No_Stream, MsgBoxStyle.OkOnly)
                        End If
                    Catch ex As Exception
                        Main.LabelUpdate = "Status: idle"
                    End Try
                ElseIf c = False Then
                    If CBool(InStr(WebBrowser1.Document.Body.OuterHtml, "hardsub_lang")) Then
                        c = True
                        Main.WebbrowserURL = WebBrowser1.Url.ToString
                        Main.WebbrowserText = WebBrowser1.Document.Body.OuterHtml
                        Main.WebbrowserTitle = WebBrowser1.DocumentTitle
                        SoftSub.DownloadSubs()
                        Me.Close()
                    End If
                End If
                If Main.UserBowser = False Then
                    Main.WebbrowserURL = WebBrowser1.Url.ToString
                    Main.WebbrowserText = WebBrowser1.Document.Body.OuterHtml
                    Main.WebbrowserTitle = WebBrowser1.DocumentTitle
                    Me.Close()
                End If
            Else
                If Main.UserBowser = False Then
                    'My.Computer.Clipboard.SetText(WebBrowser1.Document.Body.OuterHtml)
                    'If InStr(WebBrowser1.DocumentTitle, " - Watch on VRV") Then
                    Main.WebbrowserURL = WebBrowser1.Url.ToString
                    Main.WebbrowserTitle = WebBrowser1.DocumentTitle
                    WebBrowser1.Navigate("view-source:" + Main.WebbrowserURL)
                    Main.Pause(3)
                    If CBool(InStr(WebBrowser1.Document.Body.OuterHtml, ".m3u8")) Then
                        'MsgBox("test3")
                        Main.WebbrowserText = WebBrowser1.Document.Body.OuterHtml
                        Main.b = True
                        t = New Thread(AddressOf Main.Grapp_non_CR)
                        t.Priority = ThreadPriority.Normal
                        t.IsBackground = True
                        t.Start()
                    End If
                    'End If
                End If
            End If
            If Main.UserBowser = False Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub GeckoFX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If WebBrowser1.Url.ToString = "about:blank" Then
            If Main.LoginOnly = "US_UnBlock" Then
                WebBrowser1.Navigate("https://www.crunchyroll.com/login")
            Else
                'WebBrowser1.Navigate("https://duckduckgo.com/") '")
                WebBrowser1.Navigate(Main.Startseite)
            End If
            'WebBrowser1.Navigate("about:preferences")
            'WebBrowser1.Navigate("about:addons")

            'WebBrowser1.Navigate("https://www.crunchyroll.com/de/rwby/episode-45-world-of-remnant-1-dust-658499")
            'WebBrowser1.Navigate("https://www.crunchyroll.com/de/rwby")
        End If
        Me.Icon = My.Resources.icon
        'MsgBox(WebBrowser1.Url.ToString)
        Main.UserBowser = True
    End Sub

    Private Sub GeckoFX_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main.UserBowser = False
    End Sub


End Class