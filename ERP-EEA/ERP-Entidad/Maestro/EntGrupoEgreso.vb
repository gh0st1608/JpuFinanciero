﻿Public Class EntGrupoEgreso
    Private VarIdGrupoEgreso As Integer
    Private VarTipoEgreso As String
    Private VarDescripcion As String
    Private VarUsuarioCreacionId As Integer
    Private VarUsuarioModificacionId As Integer
    Private VarIdEstadoActivo As Byte
    Private VarEstadoActivo As String


    Public Property IdGrupoEgreso As Integer
        Get
            Return VarIdGrupoEgreso
        End Get
        Set(value As Integer)
            VarIdGrupoEgreso = value
        End Set
    End Property

    Public Property TipoEgreso As String
        Get
            Return VarTipoEgreso
        End Get
        Set(ByVal value As String)
            VarTipoEgreso = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return VarDescripcion
        End Get
        Set(ByVal value As String)
            VarDescripcion = value
        End Set
    End Property

    Public Property UsuarioCreacionId As Integer
        Get
            Return VarUsuarioCreacionId
        End Get
        Set(ByVal value As Integer)
            VarUsuarioCreacionId = value
        End Set
    End Property

    Public Property UsuarioModificacionId As Integer
        Get
            Return VarUsuarioModificacionId
        End Get
        Set(ByVal value As Integer)
            VarUsuarioModificacionId = value
        End Set
    End Property

    Public Property IdEstadoActivo As Byte
        Get
            Return VarIdEstadoActivo
        End Get
        Set(ByVal value As Byte)
            VarIdEstadoActivo = value
        End Set
    End Property

    Public Property EstadoActivo As String
        Get
            Return VarEstadoActivo
        End Get
        Set(ByVal value As String)
            VarEstadoActivo = value
        End Set
    End Property

End Class
