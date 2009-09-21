﻿'===============================================================================
' Microsoft patterns & practices Enterprise Library
' Exception Handling Application Block QuickStart
'===============================================================================
' Copyright © Microsoft Corporation.  All rights reserved.
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
' OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
' LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
' FITNESS FOR A PARTICULAR PURPOSE.
'===============================================================================

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4923
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ExceptionHandlingWithLoggingQuickStart.Resources", GetType(Resources).Assembly)
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
        
        '''<summary>
        '''  Looks up a localized string similar to Scenario: Log exception
        '''
        '''1. An exception occurs and is detected in the UI layer.
        '''
        '''2. The UI layer specifies the &quot;Log Only Policy&quot; as the exception handling policy.
        '''
        '''3. The &quot;Log Only Policy&quot; is configured to log the exception and return to the application without recommending a rethrow.
        '''
        '''4. Control is returned to the UI layer.
        '''.
        '''</summary>
        Friend ReadOnly Property LogExceptionText() As String
            Get
                Return ResourceManager.GetString("LogExceptionText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Scenario: Notify the user when an exception occurs
        '''
        '''1. An exception occurs and is detected in the Business layer.
        '''
        '''2. The Business layer specifies the &quot;Notify Policy&quot; as the exception handling policy.
        '''
        '''3. The &quot;Notify Policy&quot; is configured to first log the exception, then replace the exception with a new one, and finally return to the application by recommending a rethrow.
        '''
        '''4. The exception is propagated to and caught by the UI layer.
        '''
        '''5. The UI layer catches the exception and calls the &quot;Global Pol [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property NotifyUserText() As String
            Get
                Return ResourceManager.GetString("NotifyUserText", resourceCulture)
            End Get
        End Property
    End Module
End Namespace