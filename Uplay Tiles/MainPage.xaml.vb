﻿Public NotInheritable Class MainPage
    Inherits Page

    Private Sub Nv_Loaded(sender As Object, e As RoutedEventArgs)

        Dim recursos As New Resources.ResourceLoader()

        nvPrincipal.MenuItems.Add(Interfaz.NavigationViewItems.Generar(recursos.GetString("Games"), FontAwesome5.EFontAwesomeIcon.Solid_Home))
        nvPrincipal.MenuItems.Add(Interfaz.NavigationViewItems.Generar(recursos.GetString("Config"), FontAwesome5.EFontAwesomeIcon.Solid_Cog))
        nvPrincipal.MenuItems.Add(Interfaz.NavigationViewItems.Generar(recursos.GetString("MissingGames"), FontAwesome5.EFontAwesomeIcon.Solid_Gamepad))
        nvPrincipal.MenuItems.Add(New NavigationViewItemSeparator)

    End Sub

    Private Sub Nv_ItemInvoked(sender As NavigationView, args As NavigationViewItemInvokedEventArgs)

        Dim recursos As New Resources.ResourceLoader()

        Dim item As TextBlock = args.InvokedItem

        If Not item Is Nothing Then
            If item.Text = recursos.GetString("Games") Then
                Interfaz.Pestañas.Visibilidad(gridJuegos, item.Text, item)
            ElseIf item.Text = recursos.GetString("Config") Then
                Interfaz.Pestañas.Visibilidad(gridConfig, item.Text, item)
            ElseIf item.Text = recursos.GetString("MissingGames") Then
                Interfaz.Pestañas.Visibilidad(gridContactarAñadirJuegos, item.Text, item)
            End If
        End If

    End Sub

    Private Sub Page_Loaded(sender As FrameworkElement, args As Object)

        'Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "es-ES"
        'Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US"

        Configuracion.Cache.Cargar()
        Configuracion.LimpiezaArchivos.Cargar()
        Interfaz.Juegos.Cargar()
        Interfaz.AñadirTile.Cargar()
        Interfaz.Busqueda.Cargar()
        Interfaz.JuegosFaltan.Cargar()
        Uplay.Generar()
        MasTiles.Cargar()
        MasCosas.Cargar()

    End Sub

End Class
