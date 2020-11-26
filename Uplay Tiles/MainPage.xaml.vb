Imports Microsoft.Toolkit.Uwp.Helpers
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

        nvPrincipal.MenuItems.Add(Interfaz.NavigationViewItems.Generar(recursos.GetString("Games"), FontAwesome5.EFontAwesomeIcon.Solid_Home))
        nvPrincipal.MenuItems.Add(Interfaz.NavigationViewItems.Generar(recursos.GetString("Config"), FontAwesome5.EFontAwesomeIcon.Solid_Cog))
        nvPrincipal.MenuItems.Add(Interfaz.NavigationViewItems.Generar(recursos.GetString("MissingGames"), FontAwesome5.EFontAwesomeIcon.Solid_Gamepad))
        nvPrincipal.MenuItems.Add(New NavigationViewItemSeparator)
        'nvPrincipal.MenuItems.Add(MasCosas.Generar("https://github.com/pepeizq/Uplay-Tiles", "https://poeditor.com/join/project/93E4lCQLWI", "https://www.youtube.com/watch?v=bE-DRINSfAs"))

    End Sub

    Private Sub Nv_ItemInvoked(sender As NavigationView, args As NavigationViewItemInvokedEventArgs)

        Dim recursos As New Resources.ResourceLoader()

        Dim item As TextBlock = args.InvokedItem

        If Not item Is Nothing Then
            If item.Text = recursos.GetString("Games") Then
                Interfaz.Pestañas.Visibilidad_Pestañas(gridJuegos, item.Text)
            ElseIf item.Text = recursos.GetString("Config") Then
                Interfaz.Pestañas.Visibilidad_Pestañas(gridConfig, item.Text)
            ElseIf item.Text = recursos.GetString("MissingGames") Then
                Interfaz.Pestañas.Visibilidad_Pestañas(gridContactarAñadirJuegos, item.Text)
            ElseIf item.Text = recursos.GetString("MoreThings") Then
                Interfaz.Pestañas.Visibilidad_Pestañas(gridMasCosas, item.Text)
            End If
        End If

    End Sub

    Private Sub Page_Loaded(sender As FrameworkElement, args As Object)

        'Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "es-ES"
        'Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US"

        Cache.Cargar()
        Configuracion.Cargar()
        Interfaz.AñadirTile.Cargar()
        Uplay.Generar()

        Dim recursos As New Resources.ResourceLoader()
        Interfaz.Pestañas.Visibilidad_Pestañas(gridJuegos, recursos.GetString("Games"))

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

End Class
