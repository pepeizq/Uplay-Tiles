Imports Windows.Storage

Namespace Interfaz
    Module AñadirTile

        Public Sub Cargar()

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim svPersonalizacion As ScrollViewer = pagina.FindName("svPersonalizacion")

            AddHandler svPersonalizacion.ViewChanging, AddressOf PersonalizacionScroll

            Dim botonCerrarTiles As Button = pagina.FindName("botonCerrarTiles")

            AddHandler botonCerrarTiles.Click, AddressOf CerrarClick
            AddHandler botonCerrarTiles.PointerEntered, AddressOf EfectosHover.Entra_Boton_Icono
            AddHandler botonCerrarTiles.PointerExited, AddressOf EfectosHover.Sale_Boton_Icono

            Dim botonSubirTiles As Button = pagina.FindName("botonSubirTiles")

            AddHandler botonSubirTiles.Click, AddressOf SubirClick
            AddHandler botonSubirTiles.PointerEntered, AddressOf EfectosHover.Entra_Boton_Icono
            AddHandler botonSubirTiles.PointerExited, AddressOf EfectosHover.Sale_Boton_Icono

            Dim botonAñadirTile As Button = pagina.FindName("botonAñadirTile")

            AddHandler botonAñadirTile.Click, AddressOf AñadirTileClick
            AddHandler botonAñadirTile.PointerEntered, AddressOf EfectosHover.Entra_Boton_IconoTexto
            AddHandler botonAñadirTile.PointerExited, AddressOf EfectosHover.Sale_Boton_IconoTexto

            Dim botonComprarApp As Button = pagina.FindName("botonComprarApp")

            AddHandler botonComprarApp.Click, AddressOf ComprarAppClick
            AddHandler botonComprarApp.PointerEntered, AddressOf EfectosHover.Entra_Boton_Texto
            AddHandler botonComprarApp.PointerExited, AddressOf EfectosHover.Sale_Boton_Texto

            '----------------------------------------------------------------------

            Dim iconoPersonalizacionTilePequeña As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTilePequeña")
            Dim botonPersonalizacionTilePequeña As Button = pagina.FindName("botonPersonalizacionTilePequeña")

            AddHandler botonPersonalizacionTilePequeña.Click, AddressOf PersonalizacionTilePequeñaClick
            AddHandler botonPersonalizacionTilePequeña.PointerEntered, AddressOf EfectosHover.Entra_Boton_IconoTexto_Grid
            AddHandler botonPersonalizacionTilePequeña.PointerExited, AddressOf EfectosHover.Sale_Boton_IconoTexto_Grid

            Dim gridPersonalizacionTilePequeña As Grid = pagina.FindName("gridPersonalizacionTilePequeña")

            If ApplicationData.Current.LocalSettings.Values("PersonalizacionTilePequeña") = Nothing Then
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTilePequeña") = 0
                gridPersonalizacionTilePequeña.Visibility = Visibility.Collapsed
                iconoPersonalizacionTilePequeña.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
            Else
                If ApplicationData.Current.LocalSettings.Values("PersonalizacionTilePequeña") = 1 Then
                    gridPersonalizacionTilePequeña.Visibility = Visibility.Visible
                    iconoPersonalizacionTilePequeña.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
                Else
                    gridPersonalizacionTilePequeña.Visibility = Visibility.Collapsed
                    iconoPersonalizacionTilePequeña.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
                End If
            End If

            Dim iconoPersonalizacionTileMediana As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileMediana")
            Dim botonPersonalizacionTileMediana As Button = pagina.FindName("botonPersonalizacionTileMediana")

            AddHandler botonPersonalizacionTileMediana.Click, AddressOf PersonalizacionTileMedianaClick
            AddHandler botonPersonalizacionTileMediana.PointerEntered, AddressOf EfectosHover.Entra_Boton_IconoTexto_Grid
            AddHandler botonPersonalizacionTileMediana.PointerExited, AddressOf EfectosHover.Sale_Boton_IconoTexto_Grid

            Dim gridPersonalizacionTileMediana As Grid = pagina.FindName("gridPersonalizacionTileMediana")

            If ApplicationData.Current.LocalSettings.Values("PersonalizacionTileMediana") = Nothing Then
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTileMediana") = 0
                gridPersonalizacionTileMediana.Visibility = Visibility.Collapsed
                iconoPersonalizacionTileMediana.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
            Else
                If ApplicationData.Current.LocalSettings.Values("PersonalizacionTileMediana") = 1 Then
                    gridPersonalizacionTileMediana.Visibility = Visibility.Visible
                    iconoPersonalizacionTileMediana.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
                Else
                    gridPersonalizacionTileMediana.Visibility = Visibility.Collapsed
                    iconoPersonalizacionTileMediana.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
                End If
            End If

            Dim iconoPersonalizacionTileAncha As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileAncha")
            Dim botonPersonalizacionTileAncha As Button = pagina.FindName("botonPersonalizacionTileAncha")

            AddHandler botonPersonalizacionTileAncha.Click, AddressOf PersonalizacionTileAnchaClick
            AddHandler botonPersonalizacionTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Boton_IconoTexto_Grid
            AddHandler botonPersonalizacionTileAncha.PointerExited, AddressOf EfectosHover.Sale_Boton_IconoTexto_Grid

            Dim gridPersonalizacionTileAncha As Grid = pagina.FindName("gridPersonalizacionTileAncha")

            If ApplicationData.Current.LocalSettings.Values("PersonalizacionTileAncha") = Nothing Then
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTileAncha") = 1
                gridPersonalizacionTileAncha.Visibility = Visibility.Visible
                iconoPersonalizacionTileAncha.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
            Else
                If ApplicationData.Current.LocalSettings.Values("PersonalizacionTileAncha") = 1 Then
                    gridPersonalizacionTileAncha.Visibility = Visibility.Visible
                    iconoPersonalizacionTileAncha.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
                Else
                    gridPersonalizacionTileAncha.Visibility = Visibility.Collapsed
                    iconoPersonalizacionTileAncha.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
                End If
            End If

            Dim iconoPersonalizacionTileGrande As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileGrande")
            Dim botonPersonalizacionTileGrande As Button = pagina.FindName("botonPersonalizacionTileGrande")

            AddHandler botonPersonalizacionTileGrande.Click, AddressOf PersonalizacionTileGrandeClick
            AddHandler botonPersonalizacionTileGrande.PointerEntered, AddressOf EfectosHover.Entra_Boton_IconoTexto_Grid
            AddHandler botonPersonalizacionTileGrande.PointerExited, AddressOf EfectosHover.Sale_Boton_IconoTexto_Grid

            Dim gridPersonalizacionTileGrande As Grid = pagina.FindName("gridPersonalizacionTileGrande")

            If ApplicationData.Current.LocalSettings.Values("PersonalizacionTileGrande") = Nothing Then
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTileGrande") = 0
                gridPersonalizacionTileGrande.Visibility = Visibility.Collapsed
                iconoPersonalizacionTileGrande.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
            Else
                If ApplicationData.Current.LocalSettings.Values("PersonalizacionTileGrande") = 1 Then
                    gridPersonalizacionTileGrande.Visibility = Visibility.Visible
                    iconoPersonalizacionTileGrande.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
                Else
                    gridPersonalizacionTileGrande.Visibility = Visibility.Collapsed
                    iconoPersonalizacionTileGrande.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
                End If
            End If

        End Sub

        Private Sub PersonalizacionScroll(sender As Object, e As ScrollViewerViewChangingEventArgs)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim botonSubir As Button = pagina.FindName("botonSubirTiles")

            Dim sv As ScrollViewer = sender

            If sv.VerticalOffset > 50 Then
                botonSubir.Visibility = Visibility.Visible
            Else
                botonSubir.Visibility = Visibility.Collapsed
            End If

        End Sub

        Private Sub CerrarClick(sender As Object, e As RoutedEventArgs)

            Dim recursos As New Resources.ResourceLoader()

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim gridJuegos As Grid = pagina.FindName("gridJuegos")
            Pestañas.Visibilidad_Pestañas(gridJuegos, recursos.GetString("Games"))

        End Sub

        Private Sub SubirClick(sender As Object, e As RoutedEventArgs)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim svPersonalizacion As ScrollViewer = pagina.FindName("svPersonalizacion")
            svPersonalizacion.ChangeView(Nothing, 0, Nothing)

            Dim botonSubir As Button = sender
            botonSubir.Visibility = Visibility.Collapsed

        End Sub

        Private Sub AñadirTileClick(sender As Object, e As RoutedEventArgs)

            Dim boton As Button = sender
            Dim tile As Tile = boton.Tag
            Tiles.Añadir.Generar(tile)

        End Sub

        Private Sub PersonalizacionTilePequeñaClick(sender As Object, e As RoutedEventArgs)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim iconoPersonalizacionTilePequeña As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTilePequeña")
            Dim botonPersonalizacionTilePequeña As Button = pagina.FindName("botonPersonalizacionTilePequeña")
            Dim gridPersonalizacionTilePequeña As Grid = pagina.FindName("gridPersonalizacionTilePequeña")

            If gridPersonalizacionTilePequeña.Visibility = Visibility.Visible Then
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTilePequeña") = 0
                gridPersonalizacionTilePequeña.Visibility = Visibility.Collapsed
                iconoPersonalizacionTilePequeña.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
            Else
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTilePequeña") = 1
                gridPersonalizacionTilePequeña.Visibility = Visibility.Visible
                iconoPersonalizacionTilePequeña.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
            End If

        End Sub

        Private Sub PersonalizacionTileMedianaClick(sender As Object, e As RoutedEventArgs)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim iconoPersonalizacionTileMediana As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileMediana")
            Dim botonPersonalizacionTileMediana As Button = pagina.FindName("botonPersonalizacionTileMediana")
            Dim gridPersonalizacionTileMediana As Grid = pagina.FindName("gridPersonalizacionTileMediana")

            If gridPersonalizacionTileMediana.Visibility = Visibility.Visible Then
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTileMediana") = 0
                gridPersonalizacionTileMediana.Visibility = Visibility.Collapsed
                iconoPersonalizacionTileMediana.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
            Else
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTileMediana") = 1
                gridPersonalizacionTileMediana.Visibility = Visibility.Visible
                iconoPersonalizacionTileMediana.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
            End If

        End Sub

        Private Sub PersonalizacionTileAnchaClick(sender As Object, e As RoutedEventArgs)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim iconoPersonalizacionTileAncha As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileAncha")
            Dim botonPersonalizacionTileAncha As Button = pagina.FindName("botonPersonalizacionTileAncha")
            Dim gridPersonalizacionTileAncha As Grid = pagina.FindName("gridPersonalizacionTileAncha")

            If gridPersonalizacionTileAncha.Visibility = Visibility.Visible Then
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTileAncha") = 0
                gridPersonalizacionTileAncha.Visibility = Visibility.Collapsed
                iconoPersonalizacionTileAncha.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
            Else
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTileAncha") = 1
                gridPersonalizacionTileAncha.Visibility = Visibility.Visible
                iconoPersonalizacionTileAncha.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
            End If

        End Sub

        Private Sub PersonalizacionTileGrandeClick(sender As Object, e As RoutedEventArgs)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim iconoPersonalizacionTileGrande As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileGrande")
            Dim botonPersonalizacionTileGrande As Button = pagina.FindName("botonPersonalizacionTileGrande")
            Dim gridPersonalizacionTileGrande As Grid = pagina.FindName("gridPersonalizacionTileGrande")

            If gridPersonalizacionTileGrande.Visibility = Visibility.Visible Then
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTileGrande") = 0
                gridPersonalizacionTileGrande.Visibility = Visibility.Collapsed
                iconoPersonalizacionTileGrande.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
            Else
                ApplicationData.Current.LocalSettings.Values("PersonalizacionTileGrande") = 1
                gridPersonalizacionTileGrande.Visibility = Visibility.Visible
                iconoPersonalizacionTileGrande.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
            End If

        End Sub

    End Module
End Namespace

