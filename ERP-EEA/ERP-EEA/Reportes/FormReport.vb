﻿Imports Microsoft.Reporting.WinForms
Public Class FormReport

    Private VarObjParamList As List(Of ReportParameter)
    Private VarLinksReport As Boolean
    Private VarImageReport As Boolean
    Private VarDsReport As DataSet
    Private VarPathReport As String

    Public Property ObjParamList As List(Of ReportParameter)
        Get
            Return VarObjParamList
        End Get
        Set(value As List(Of ReportParameter))
            VarObjParamList = value
        End Set
    End Property

    Public Property LinksReport As Boolean
        Get
            Return VarLinksReport
        End Get
        Set(ByVal value As Boolean)
            VarLinksReport = value
        End Set
    End Property

    Public Property ImageReport As Boolean
        Get
            Return VarImageReport
        End Get
        Set(ByVal value As Boolean)
            VarImageReport = value
        End Set
    End Property

    Public Property DsReport As DataSet
        Get
            Return VarDsReport
        End Get
        Set(ByVal value As DataSet)
            VarDsReport = value
        End Set
    End Property

    Public Property PathReport As String
        Get
            Return VarPathReport
        End Get
        Set(ByVal value As String)
            VarPathReport = value
        End Set
    End Property
    Private Sub fnLoadReport()

        ReportViewer.Reset()
        ReportViewer.LocalReport.DataSources.Clear()
        ReportViewer.LocalReport.ReportPath = PathReport

        Dim objSource As ReportDataSource

        For Each dt In DsReport.Tables
            objSource = New ReportDataSource()
            objSource.Name = dt.TableName
            objSource.Value = dt
            ReportViewer.LocalReport.DataSources.Add(objSource)
        Next

        For Each param In ObjParamList
            ReportViewer.LocalReport.SetParameters(param)
        Next

        ReportViewer.LocalReport.EnableExternalImages = ImageReport
        ReportViewer.LocalReport.EnableHyperlinks = LinksReport
        ReportViewer.LocalReport.Refresh()
        ReportViewer.RefreshReport()

    End Sub
    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fnLoadReport()
        Me.ReportViewer.RefreshReport()
    End Sub

End Class