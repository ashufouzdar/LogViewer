'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1433
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("LogViewer.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property aboutdialog() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("aboutdialog", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property closeWin() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("closeWin", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property exitApp() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("exitApp", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property log() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("log", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property net() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("net", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property newItem() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("newItem", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property openicon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("openicon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property processing() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("processing", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property remotelog() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("remotelog", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property settingicon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("settingicon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property start() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("start", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property stophand() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("stophand", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 
        '''Copyright © 2008 Ashu Fouzdar. All rights reserved.
        '''
        '''Redistribution and use in source and binary forms, with or without
        '''modification, are permitted provided that the following conditions
        '''are met:
        '''
        '''1. Redistributions of source code must retain the above copyright
        '''   notice, this list of conditions and the following disclaimer.
        '''2. Redistributions in binary form must reproduce the above copyright
        '''   notice, this list of conditions and the following disclaimer in the
        '''   documentation and/or other ma [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property strDisclaimer() As String
            Get
                Return ResourceManager.GetString("strDisclaimer", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
