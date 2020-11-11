﻿Imports Microsoft.Toolkit.Uwp.Helpers
Imports Windows.ApplicationModel.Core
Imports Windows.Services.Store
Imports Windows.Storage
Imports Windows.System
Imports Windows.UI
Imports Windows.UI.Core

Public NotInheritable Class MainPage
    Inherits Page

    Private Sub Nv_Loaded(sender As Object, e As RoutedEventArgs)

        Dim recursos As New Resources.ResourceLoader()

        nvPrincipal.MenuItems.Add(NavigationViewItems.Generar(recursos.GetString("Tiles"), FontAwesome5.EFontAwesomeIcon.Solid_Home, 0))
        nvPrincipal.MenuItems.Add(NavigationViewItems.Generar(recursos.GetString("Config"), FontAwesome5.EFontAwesomeIcon.Solid_Cog, 1))
        nvPrincipal.MenuItems.Add(NavigationViewItems.Generar(recursos.GetString("MissingGames"), FontAwesome5.EFontAwesomeIcon.Solid_Gamepad, 2))
        nvPrincipal.MenuItems.Add(New NavigationViewItemSeparator)
        nvPrincipal.MenuItems.Add(MasCosas.Generar("https://github.com/pepeizq/Uplay-Tiles", "https://poeditor.com/join/project/93E4lCQLWI", "https://www.youtube.com/watch?v=bE-DRINSfAs"))

    End Sub

    Private Sub Nv_ItemInvoked(sender As NavigationView, args As NavigationViewItemInvokedEventArgs)

        Dim recursos As New Resources.ResourceLoader()

        Dim item As TextBlock = args.InvokedItem

        If Not item Is Nothing Then
            If item.Text = recursos.GetString("Tiles") Then
                GridVisibilidad(gridTiles, item.Text)

                If spProgreso.Visibility = Visibility.Visible Then
                    gridSeleccionarJuego.Visibility = Visibility.Collapsed
                End If

                If gvTiles.Items.Count > 0 Then
                    gridSeleccionarJuego.Visibility = Visibility.Visible
                End If

                If Not ApplicationData.Current.LocalSettings.Values("ancho_grid_tiles") = 0 Then
                    gvTiles.Width = ApplicationData.Current.LocalSettings.Values("ancho_grid_tiles")
                    gvTiles.Padding = New Thickness(5, 0, 5, 0)
                End If

            ElseIf item.Text = recursos.GetString("Config") Then
                GridVisibilidad(gridConfig, item.Text)
            ElseIf item.Text = recursos.GetString("MissingGames") Then
                GridVisibilidad(gridContactarAñadirJuegos, item.Text)
            ElseIf item.Text = recursos.GetString("MoreThings") Then
                FlyoutBase.ShowAttachedFlyout(nvPrincipal.MenuItems.Item(nvPrincipal.MenuItems.Count - 1))
            End If
        End If

    End Sub

    Private Sub Page_Loaded(sender As FrameworkElement, args As Object)

        'Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "es-ES"
        'Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US"

        tbTitulo.Text = Package.Current.DisplayName

        Dim coreBarra As CoreApplicationViewTitleBar = CoreApplication.GetCurrentView.TitleBar
        coreBarra.ExtendViewIntoTitleBar = True

        Dim barra As ApplicationViewTitleBar = ApplicationView.GetForCurrentView().TitleBar
        barra.ButtonBackgroundColor = Colors.Transparent
        barra.ButtonForegroundColor = Colors.White
        barra.ButtonInactiveBackgroundColor = Colors.Transparent
        barra.ButtonInactiveForegroundColor = Colors.White

        Cache.Cargar()
        Configuracion.Iniciar()
        Uplay.Generar()

        '--------------------------------------------------------

        Dim transpariencia As New UISettings
        TransparienciaEfectosFinal(transpariencia.AdvancedEffectsEnabled)
        AddHandler transpariencia.AdvancedEffectsEnabledChanged, AddressOf TransparienciaEfectosCambia

    End Sub

    Private Sub TransparienciaEfectosCambia(sender As UISettings, e As Object)

        TransparienciaEfectosFinal(sender.AdvancedEffectsEnabled)

    End Sub

    Private Async Sub TransparienciaEfectosFinal(estado As Boolean)

        Await Dispatcher.RunAsync(CoreDispatcherPriority.High, Sub()
                                                                   If estado = True Then
                                                                       gridPersonalizarTiles.Background = App.Current.Resources("GridAcrilico")
                                                                       gridConfig.Background = App.Current.Resources("GridAcrilico")
                                                                       gridConfigCache.Background = App.Current.Resources("GridTituloBackground")
                                                                       gridContactarAñadirJuegos.Background = App.Current.Resources("GridAcrilico")
                                                                   Else
                                                                       gridPersonalizarTiles.Background = New SolidColorBrush(Colors.LightGray)
                                                                       gridConfig.Background = New SolidColorBrush(Colors.LightGray)
                                                                       gridConfigCache.Background = New SolidColorBrush(App.Current.Resources("ColorPrimario"))
                                                                       gridContactarAñadirJuegos.Background = New SolidColorBrush(Colors.LightGray)
                                                                   End If
                                                               End Sub)

    End Sub

    Private Sub GridVisibilidad(grid As Grid, tag As String)

        Dim recursos As New Resources.ResourceLoader()

        tbTitulo.Text = Package.Current.DisplayName + " (" + Package.Current.Id.Version.Major.ToString + "." + Package.Current.Id.Version.Minor.ToString + "." + Package.Current.Id.Version.Build.ToString + "." + Package.Current.Id.Version.Revision.ToString + ") - " + tag

        gridAñadirTile.Visibility = Visibility.Collapsed
        gridPersonalizarTiles.Visibility = Visibility.Collapsed
        gridConfig.Visibility = Visibility.Collapsed
        gridContactarAñadirJuegos.Visibility = Visibility.Collapsed

        If tag = recursos.GetString("Tiles") Then
            If gvTiles.Items.Count > 0 Then
                spBuscador.Visibility = Visibility.Visible
            Else
                spBuscador.Visibility = Visibility.Collapsed
            End If
        Else
            spBuscador.Visibility = Visibility.Collapsed
        End If

        grid.Visibility = Visibility.Visible

    End Sub

    Private Async Sub TbBuscador_TextChanged(sender As Object, e As TextChangedEventArgs) Handles tbBuscador.TextChanged

        Dim helper As New LocalObjectStorageHelper

        Dim listaJuegos As New List(Of Tile)

        If Await helper.FileExistsAsync("juegos") = True Then
            listaJuegos = Await helper.ReadFileAsync(Of List(Of Tile))("juegos")
        End If

        If Not listaJuegos Is Nothing Then
            gvTiles.Items.Clear()

            listaJuegos.Sort(Function(x, y) x.Titulo.CompareTo(y.Titulo))

            If tbBuscador.Text.Trim.Length > 0 Then
                For Each juego In listaJuegos
                    Dim busqueda As String = tbBuscador.Text.Trim

                    If LimpiarBusqueda(juego.Titulo).ToString.Contains(LimpiarBusqueda(busqueda)) Then
                        BotonEstilo(juego, gvTiles)
                    End If
                Next
            Else
                For Each juego In listaJuegos
                    BotonEstilo(juego, gvTiles)
                Next
            End If
        End If

    End Sub

    Private Function LimpiarBusqueda(texto As String)

        Dim listaCaracteres As New List(Of String) From {"Early Access", " ", "•", ">", "<", "¿", "?", "!", "¡", ":",
            ".", "_", "–", "-", ";", ",", "™", "®", "'", "’", "´", "`", "(", ")", "/", "\", "|", "&", "#", "=", ChrW(34),
            "@", "^", "[", "]", "ª", "«"}

        For Each item In listaCaracteres
            texto = texto.Replace(item, Nothing)
        Next

        texto = texto.ToLower
        texto = texto.Trim

        Return texto
    End Function

    Private Async Sub BotonContactarAñadirJuegos_Click(sender As Object, e As RoutedEventArgs) Handles botonContactarAñadirJuegos.Click

        Await Launcher.LaunchUriAsync(New Uri("https://pepeizqapps.com/contact/"))

    End Sub

    Private Sub UsuarioEntraBoton(sender As Object, e As PointerRoutedEventArgs)

        Window.Current.CoreWindow.PointerCursor = New CoreCursor(CoreCursorType.Hand, 1)

    End Sub

    Private Sub UsuarioSaleBoton(sender As Object, e As PointerRoutedEventArgs)

        Window.Current.CoreWindow.PointerCursor = New CoreCursor(CoreCursorType.Arrow, 1)

    End Sub

    'TILES-----------------------------------------------------------------------------

    Private Sub BotonAñadirTile_Click(sender As Object, e As RoutedEventArgs) Handles botonAñadirTile.Click

        Dim tile As Tile = botonAñadirTile.Tag
        Tiles.Añadir.Generar(tile)

    End Sub

    Private Sub BotonCerrarTiles_Click(sender As Object, e As RoutedEventArgs) Handles botonCerrarTiles.Click

        gridAñadirTile.Visibility = Visibility.Collapsed
        spBuscador.Visibility = Visibility.Visible

        If ApplicationData.Current.LocalSettings.Values("ancho_grid_tiles") > 0 Then
            If Uplay.anchoColumna < ApplicationData.Current.LocalSettings.Values("ancho_grid_tiles") Then
                gvTiles.Width = ApplicationData.Current.LocalSettings.Values("ancho_grid_tiles")
                gvTiles.Padding = New Thickness(5, 0, 5, 0)
            End If
        End If

        tbTitulo.Text = Package.Current.DisplayName + " (" + Package.Current.Id.Version.Major.ToString + "." + Package.Current.Id.Version.Minor.ToString + "." + Package.Current.Id.Version.Build.ToString + "." + Package.Current.Id.Version.Revision.ToString + ")"

    End Sub

    Private Sub BotonTilePequeña_Click(sender As Object, e As RoutedEventArgs) Handles botonTilePequeña.Click

        Tiles.Personalizacion.Cargar(gridTilePequeña, 0, imagenTilePequeña.Source)
        ResetearPersonalizacion(0)

    End Sub

    Private Sub BotonTileMediana_Click(sender As Object, e As RoutedEventArgs) Handles botonTileMediana.Click

        Tiles.Personalizacion.Cargar(gridTileMediana, 1, imagenTileMediana.Source)
        ResetearPersonalizacion(1)

    End Sub

    Private Sub BotonTileAncha_Click(sender As Object, e As RoutedEventArgs) Handles botonTileAncha.Click

        Tiles.Personalizacion.Cargar(gridTileAncha, 2, imagenTileAncha.Source)
        ResetearPersonalizacion(2)

    End Sub

    Private Sub BotonTileGrande_Click(sender As Object, e As RoutedEventArgs) Handles botonTileGrande.Click

        Tiles.Personalizacion.Cargar(gridTileGrande, 3, imagenTileGrande.Source)
        ResetearPersonalizacion(3)

    End Sub

    'PERSONALIZACION--------------------------------------------------------------------

    Private Sub ResetearPersonalizacion(tipo As Integer)

        tbPersonalizacionCambiarImagenInternet.Text = String.Empty

        cbPersonalizacionImagenUbicacion.SelectedIndex = 0

        sliderPersonalizacionImagenMargen.Value = 0

        If tipo = 0 Or tipo = 1 Then
            gridPersonalizacionImagenTitulo.Visibility = Visibility.Collapsed
        Else
            cbPersonalizacionImagenTitulo.IsChecked = False
            cbPersonalizacionImagenTitulo.Tag = tipo
            gridPersonalizacionImagenTitulo.Visibility = Visibility.Visible

            If tipo = 2 Then
                ApplicationData.Current.LocalSettings.Values("tile_ancha_titulo") = False
            ElseIf tipo = 3 Then
                ApplicationData.Current.LocalSettings.Values("tile_grande_titulo") = False
            End If
        End If

        colorPickerPersonalizacionFondo.Color = Microsoft.Toolkit.Uwp.Helpers.ColorHelper.ToColor(Microsoft.Toolkit.Uwp.Helpers.ColorHelper.ToHex(App.Current.Resources("ColorTerciario")))
        gridPersonalizacionExterior.Background = New SolidColorBrush(colorPickerPersonalizacionFondo.Color)

    End Sub

    'CONFIG-----------------------------------------------------------------------------

    Private Async Sub BotonComprarApp_Click(sender As Object, e As RoutedEventArgs) Handles botonComprarApp.Click

        Dim usuarios As IReadOnlyList(Of User) = Await User.FindAllAsync

        If Not usuarios Is Nothing Then
            If usuarios.Count > 0 Then
                Dim usuario As User = usuarios(0)

                Dim contexto As StoreContext = StoreContext.GetForUser(usuario)
                Await contexto.RequestPurchaseAsync("9NF9PH08FRSJ")
            End If
        End If

    End Sub

End Class
