Imports Microsoft.Toolkit.Uwp
Imports Microsoft.Toolkit.Uwp.UI.Controls
Imports Windows.UI

Namespace Interfaz
    Module AñadirTile

        Public Sub Cargar()

            Dim recursos As New Resources.ResourceLoader()

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

            Dim botonPersonalizacionTilePequeña As Button = pagina.FindName("botonPersonalizacionTilePequeña")

            AddHandler botonPersonalizacionTilePequeña.Click, AddressOf PersonalizacionTilePequeñaClick
            AddHandler botonPersonalizacionTilePequeña.PointerEntered, AddressOf EfectosHover.Entra_Boton_GridIcono
            AddHandler botonPersonalizacionTilePequeña.PointerExited, AddressOf EfectosHover.Sale_Boton_GridIcono

            Dim botonPersonalizacionTileMediana As Button = pagina.FindName("botonPersonalizacionTileMediana")

            AddHandler botonPersonalizacionTileMediana.Click, AddressOf PersonalizacionTileMedianaClick
            AddHandler botonPersonalizacionTileMediana.PointerEntered, AddressOf EfectosHover.Entra_Boton_GridIcono
            AddHandler botonPersonalizacionTileMediana.PointerExited, AddressOf EfectosHover.Sale_Boton_GridIcono

            Dim botonPersonalizacionTileAncha As Button = pagina.FindName("botonPersonalizacionTileAncha")

            AddHandler botonPersonalizacionTileAncha.Click, AddressOf PersonalizacionTileAnchaClick
            AddHandler botonPersonalizacionTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Boton_GridIcono
            AddHandler botonPersonalizacionTileAncha.PointerExited, AddressOf EfectosHover.Sale_Boton_GridIcono

            Dim iconoPersonalizacionTileAncha As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileAncha")
            Dim gridPersonalizacionTileAncha As Grid = pagina.FindName("gridPersonalizacionTileAncha")
            PestañasPersonalizacion(iconoPersonalizacionTileAncha, botonPersonalizacionTileAncha, gridPersonalizacionTileAncha)

            Dim botonPersonalizacionTileGrande As Button = pagina.FindName("botonPersonalizacionTileGrande")

            AddHandler botonPersonalizacionTileGrande.Click, AddressOf PersonalizacionTileGrandeClick
            AddHandler botonPersonalizacionTileGrande.PointerEntered, AddressOf EfectosHover.Entra_Boton_GridIcono
            AddHandler botonPersonalizacionTileGrande.PointerExited, AddressOf EfectosHover.Sale_Boton_GridIcono

            '----------------------------------------------------------------------

            Dim gridTilePequeña As Grid = pagina.FindName("gridTilePequeña")
            Dim imagenTilePequeña As ImageEx = pagina.FindName("imagenTilePequeña")

            Dim botonCambiarImagenOrdenadorTilePequeña As Button = pagina.FindName("botonCambiarImagenOrdenadorTilePequeña")
            botonCambiarImagenOrdenadorTilePequeña.Tag = imagenTilePequeña

            AddHandler botonCambiarImagenOrdenadorTilePequeña.Click, AddressOf Tiles.Personalizacion.CambioImagenOrdenador
            AddHandler botonCambiarImagenOrdenadorTilePequeña.PointerEntered, AddressOf EfectosHover.Entra_Boton_IconoTexto
            AddHandler botonCambiarImagenOrdenadorTilePequeña.PointerExited, AddressOf EfectosHover.Sale_Boton_IconoTexto

            Dim tbCambiarImagenEnlaceTilePequeña As TextBox = pagina.FindName("tbCambiarImagenEnlaceTilePequeña")
            tbCambiarImagenEnlaceTilePequeña.PlaceholderText = recursos.GetString("ChangeImageLinkInfo")
            tbCambiarImagenEnlaceTilePequeña.Tag = imagenTilePequeña

            AddHandler tbCambiarImagenEnlaceTilePequeña.TextChanged, AddressOf Tiles.Personalizacion.CambioImagenInternet
            AddHandler tbCambiarImagenEnlaceTilePequeña.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler tbCambiarImagenEnlaceTilePequeña.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim cbCambiarImagenAjusteTilePequeña As ComboBox = pagina.FindName("cbCambiarImagenAjusteTilePequeña")
            cbCambiarImagenAjusteTilePequeña.Tag = imagenTilePequeña
            cbCambiarImagenAjusteTilePequeña.Items.Add(recursos.GetString("ImageAdjustmentNone"))
            cbCambiarImagenAjusteTilePequeña.Items.Add(recursos.GetString("ImageAdjustmentFill"))
            cbCambiarImagenAjusteTilePequeña.Items.Add(recursos.GetString("ImageAdjustmentUniform"))
            cbCambiarImagenAjusteTilePequeña.Items.Add(recursos.GetString("ImageAdjustmentUniformFill"))

            AddHandler cbCambiarImagenAjusteTilePequeña.SelectionChanged, AddressOf Tiles.Personalizacion.CambiarImagenEstiramiento
            AddHandler cbCambiarImagenAjusteTilePequeña.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler cbCambiarImagenAjusteTilePequeña.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim sliderCambiarImagenMargenTilePequeña As Slider = pagina.FindName("sliderCambiarImagenMargenTilePequeña")
            sliderCambiarImagenMargenTilePequeña.Tag = imagenTilePequeña

            AddHandler sliderCambiarImagenMargenTilePequeña.ValueChanged, AddressOf Tiles.Personalizacion.CambiarImagenMargen
            AddHandler sliderCambiarImagenMargenTilePequeña.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler sliderCambiarImagenMargenTilePequeña.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim sliderCambiarImagenEsquinasTilePequeña As Slider = pagina.FindName("sliderCambiarImagenEsquinasTilePequeña")
            sliderCambiarImagenEsquinasTilePequeña.Tag = imagenTilePequeña

            AddHandler sliderCambiarImagenEsquinasTilePequeña.ValueChanged, AddressOf Tiles.Personalizacion.CambiarImagenEsquinas
            AddHandler sliderCambiarImagenEsquinasTilePequeña.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler sliderCambiarImagenEsquinasTilePequeña.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim tsImagenTransparenciaTilePequeña As ToggleSwitch = pagina.FindName("tsImagenTransparenciaTilePequeña")
            tsImagenTransparenciaTilePequeña.Tag = gridTilePequeña
            tsImagenTransparenciaTilePequeña.OnContent = recursos.GetString("Yes")
            tsImagenTransparenciaTilePequeña.OffContent = recursos.GetString("No")

            AddHandler tsImagenTransparenciaTilePequeña.Toggled, AddressOf Tiles.Personalizacion.CambiarFondoTransparente
            AddHandler tsImagenTransparenciaTilePequeña.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler tsImagenTransparenciaTilePequeña.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim cpImagenFondoTilePequeña As ColorPicker = pagina.FindName("cpImagenFondoTilePequeña")
            cpImagenFondoTilePequeña.Tag = gridTilePequeña

            AddHandler cpImagenFondoTilePequeña.ColorChanged, AddressOf Tiles.Personalizacion.CambiarFondoColor
            AddHandler cpImagenFondoTilePequeña.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler cpImagenFondoTilePequeña.PointerExited, AddressOf EfectosHover.Sale_Basico

            '----------------------------------------------------------------------

            Dim gridTileMediana As Grid = pagina.FindName("gridTileMediana")
            Dim imagenTileMediana As ImageEx = pagina.FindName("imagenTileMediana")

            Dim botonCambiarImagenOrdenadorTileMediana As Button = pagina.FindName("botonCambiarImagenOrdenadorTileMediana")
            botonCambiarImagenOrdenadorTileMediana.Tag = imagenTileMediana

            AddHandler botonCambiarImagenOrdenadorTileMediana.Click, AddressOf Tiles.Personalizacion.CambioImagenOrdenador
            AddHandler botonCambiarImagenOrdenadorTileMediana.PointerEntered, AddressOf EfectosHover.Entra_Boton_IconoTexto
            AddHandler botonCambiarImagenOrdenadorTileMediana.PointerExited, AddressOf EfectosHover.Sale_Boton_IconoTexto

            Dim tbCambiarImagenEnlaceTileMediana As TextBox = pagina.FindName("tbCambiarImagenEnlaceTileMediana")
            tbCambiarImagenEnlaceTileMediana.PlaceholderText = recursos.GetString("ChangeImageLinkInfo")
            tbCambiarImagenEnlaceTileMediana.Tag = imagenTileMediana

            AddHandler tbCambiarImagenEnlaceTileMediana.TextChanged, AddressOf Tiles.Personalizacion.CambioImagenInternet
            AddHandler tbCambiarImagenEnlaceTileMediana.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler tbCambiarImagenEnlaceTileMediana.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim cbCambiarImagenAjusteTileMediana As ComboBox = pagina.FindName("cbCambiarImagenAjusteTileMediana")
            cbCambiarImagenAjusteTileMediana.Tag = imagenTileMediana
            cbCambiarImagenAjusteTileMediana.Items.Add(recursos.GetString("ImageAdjustmentNone"))
            cbCambiarImagenAjusteTileMediana.Items.Add(recursos.GetString("ImageAdjustmentFill"))
            cbCambiarImagenAjusteTileMediana.Items.Add(recursos.GetString("ImageAdjustmentUniform"))
            cbCambiarImagenAjusteTileMediana.Items.Add(recursos.GetString("ImageAdjustmentUniformFill"))

            AddHandler cbCambiarImagenAjusteTileMediana.SelectionChanged, AddressOf Tiles.Personalizacion.CambiarImagenEstiramiento
            AddHandler cbCambiarImagenAjusteTileMediana.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler cbCambiarImagenAjusteTileMediana.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim sliderCambiarImagenMargenTileMediana As Slider = pagina.FindName("sliderCambiarImagenMargenTileMediana")
            sliderCambiarImagenMargenTileMediana.Tag = imagenTileMediana

            AddHandler sliderCambiarImagenMargenTileMediana.ValueChanged, AddressOf Tiles.Personalizacion.CambiarImagenMargen
            AddHandler sliderCambiarImagenMargenTileMediana.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler sliderCambiarImagenMargenTileMediana.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim sliderCambiarImagenEsquinasTileMediana As Slider = pagina.FindName("sliderCambiarImagenEsquinasTileMediana")
            sliderCambiarImagenEsquinasTileMediana.Tag = imagenTileMediana

            AddHandler sliderCambiarImagenEsquinasTileMediana.ValueChanged, AddressOf Tiles.Personalizacion.CambiarImagenEsquinas
            AddHandler sliderCambiarImagenEsquinasTileMediana.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler sliderCambiarImagenEsquinasTileMediana.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim tsImagenTransparenciaTileMediana As ToggleSwitch = pagina.FindName("tsImagenTransparenciaTileMediana")
            tsImagenTransparenciaTileMediana.Tag = gridTileMediana
            tsImagenTransparenciaTileMediana.OnContent = recursos.GetString("Yes")
            tsImagenTransparenciaTileMediana.OffContent = recursos.GetString("No")

            AddHandler tsImagenTransparenciaTileMediana.Toggled, AddressOf Tiles.Personalizacion.CambiarFondoTransparente
            AddHandler tsImagenTransparenciaTileMediana.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler tsImagenTransparenciaTileMediana.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim cpImagenFondoTileMediana As ColorPicker = pagina.FindName("cpImagenFondoTileMediana")
            cpImagenFondoTileMediana.Tag = gridTileMediana

            AddHandler cpImagenFondoTileMediana.ColorChanged, AddressOf Tiles.Personalizacion.CambiarFondoColor
            AddHandler cpImagenFondoTileMediana.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler cpImagenFondoTileMediana.PointerExited, AddressOf EfectosHover.Sale_Basico

            '----------------------------------------------------------------------

            Dim gridTileAncha As Grid = pagina.FindName("gridTileAncha")
            Dim imagenTileAncha As ImageEx = pagina.FindName("imagenTileAncha")

            Dim botonCambiarImagenOrdenadorTileAncha As Button = pagina.FindName("botonCambiarImagenOrdenadorTileAncha")
            botonCambiarImagenOrdenadorTileAncha.Tag = imagenTileAncha

            AddHandler botonCambiarImagenOrdenadorTileAncha.Click, AddressOf Tiles.Personalizacion.CambioImagenOrdenador
            AddHandler botonCambiarImagenOrdenadorTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Boton_IconoTexto
            AddHandler botonCambiarImagenOrdenadorTileAncha.PointerExited, AddressOf EfectosHover.Sale_Boton_IconoTexto

            Dim tbCambiarImagenEnlaceTileAncha As TextBox = pagina.FindName("tbCambiarImagenEnlaceTileAncha")
            tbCambiarImagenEnlaceTileAncha.PlaceholderText = recursos.GetString("ChangeImageLinkInfo")
            tbCambiarImagenEnlaceTileAncha.Tag = imagenTileAncha

            AddHandler tbCambiarImagenEnlaceTileAncha.TextChanged, AddressOf Tiles.Personalizacion.CambioImagenInternet
            AddHandler tbCambiarImagenEnlaceTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler tbCambiarImagenEnlaceTileAncha.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim cbCambiarImagenAjusteTileAncha As ComboBox = pagina.FindName("cbCambiarImagenAjusteTileAncha")
            cbCambiarImagenAjusteTileAncha.Tag = imagenTileAncha
            cbCambiarImagenAjusteTileAncha.Items.Add(recursos.GetString("ImageAdjustmentNone"))
            cbCambiarImagenAjusteTileAncha.Items.Add(recursos.GetString("ImageAdjustmentFill"))
            cbCambiarImagenAjusteTileAncha.Items.Add(recursos.GetString("ImageAdjustmentUniform"))
            cbCambiarImagenAjusteTileAncha.Items.Add(recursos.GetString("ImageAdjustmentUniformFill"))

            AddHandler cbCambiarImagenAjusteTileAncha.SelectionChanged, AddressOf Tiles.Personalizacion.CambiarImagenEstiramiento
            AddHandler cbCambiarImagenAjusteTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler cbCambiarImagenAjusteTileAncha.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim sliderCambiarImagenMargenTileAncha As Slider = pagina.FindName("sliderCambiarImagenMargenTileAncha")
            sliderCambiarImagenMargenTileAncha.Tag = imagenTileAncha

            AddHandler sliderCambiarImagenMargenTileAncha.ValueChanged, AddressOf Tiles.Personalizacion.CambiarImagenMargen
            AddHandler sliderCambiarImagenMargenTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler sliderCambiarImagenMargenTileAncha.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim sliderCambiarImagenEsquinasTileAncha As Slider = pagina.FindName("sliderCambiarImagenEsquinasTileAncha")
            sliderCambiarImagenEsquinasTileAncha.Tag = imagenTileAncha

            AddHandler sliderCambiarImagenEsquinasTileAncha.ValueChanged, AddressOf Tiles.Personalizacion.CambiarImagenEsquinas
            AddHandler sliderCambiarImagenEsquinasTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler sliderCambiarImagenEsquinasTileAncha.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim tsImagenTituloTileAncha As ToggleSwitch = pagina.FindName("tsImagenTituloTileAncha")
            tsImagenTituloTileAncha.OnContent = recursos.GetString("Yes")
            tsImagenTituloTileAncha.OffContent = recursos.GetString("No")

            AddHandler tsImagenTituloTileAncha.Toggled, AddressOf Tiles.Personalizacion.MostrarTitulo
            AddHandler tsImagenTituloTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler tsImagenTituloTileAncha.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim tsImagenTransparenciaTileAncha As ToggleSwitch = pagina.FindName("tsImagenTransparenciaTileAncha")
            tsImagenTransparenciaTileAncha.Tag = gridTileAncha
            tsImagenTransparenciaTileAncha.OnContent = recursos.GetString("Yes")
            tsImagenTransparenciaTileAncha.OffContent = recursos.GetString("No")

            AddHandler tsImagenTransparenciaTileAncha.Toggled, AddressOf Tiles.Personalizacion.CambiarFondoTransparente
            AddHandler tsImagenTransparenciaTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler tsImagenTransparenciaTileAncha.PointerExited, AddressOf EfectosHover.Sale_Basico

            Dim cpImagenFondoTileAncha As ColorPicker = pagina.FindName("cpImagenFondoTileAncha")
            cpImagenFondoTileAncha.Tag = gridTileAncha

            AddHandler cpImagenFondoTileAncha.ColorChanged, AddressOf Tiles.Personalizacion.CambiarFondoColor
            AddHandler cpImagenFondoTileAncha.PointerEntered, AddressOf EfectosHover.Entra_Basico
            AddHandler cpImagenFondoTileAncha.PointerExited, AddressOf EfectosHover.Sale_Basico

        End Sub

        Public Sub ResetearValores()

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim tbCambiarImagenEnlaceTilePequeña As TextBox = pagina.FindName("tbCambiarImagenEnlaceTilePequeña")
            tbCambiarImagenEnlaceTilePequeña.Text = String.Empty

            Dim cbCambiarImagenAjusteTilePequeña As ComboBox = pagina.FindName("cbCambiarImagenAjusteTilePequeña")
            cbCambiarImagenAjusteTilePequeña.SelectedIndex = 0

            Dim sliderCambiarImagenMargenTilePequeña As Slider = pagina.FindName("sliderCambiarImagenMargenTilePequeña")
            sliderCambiarImagenMargenTilePequeña.Value = 0

            Dim sliderCambiarImagenEsquinasTilePequeña As Slider = pagina.FindName("sliderCambiarImagenEsquinasTilePequeña")
            sliderCambiarImagenEsquinasTilePequeña.Value = 0

            Dim tsImagenTransparenciaTilePequeña As ToggleSwitch = pagina.FindName("tsImagenTransparenciaTilePequeña")
            tsImagenTransparenciaTilePequeña.IsOn = True

            '----------------------------------------------------------------------

            Dim tbCambiarImagenEnlaceTileMediana As TextBox = pagina.FindName("tbCambiarImagenEnlaceTileMediana")
            tbCambiarImagenEnlaceTileMediana.Text = String.Empty

            Dim cbCambiarImagenAjusteTileMediana As ComboBox = pagina.FindName("cbCambiarImagenAjusteTileMediana")
            cbCambiarImagenAjusteTileMediana.SelectedIndex = 2

            Dim sliderCambiarImagenMargenTileMediana As Slider = pagina.FindName("sliderCambiarImagenMargenTileMediana")
            sliderCambiarImagenMargenTileMediana.Value = 0

            Dim sliderCambiarImagenEsquinasTileMediana As Slider = pagina.FindName("sliderCambiarImagenEsquinasTileMediana")
            sliderCambiarImagenEsquinasTileMediana.Value = 0

            Dim tsImagenTransparenciaTileMediana As ToggleSwitch = pagina.FindName("tsImagenTransparenciaTileMediana")
            tsImagenTransparenciaTileMediana.IsOn = True

            '----------------------------------------------------------------------

            Dim tbCambiarImagenEnlaceTileAncha As TextBox = pagina.FindName("tbCambiarImagenEnlaceTileAncha")
            tbCambiarImagenEnlaceTileAncha.Text = String.Empty

            Dim cbCambiarImagenAjusteTileAncha As ComboBox = pagina.FindName("cbCambiarImagenAjusteTileAncha")
            cbCambiarImagenAjusteTileAncha.SelectedIndex = 3

            Dim sliderCambiarImagenMargenTileAncha As Slider = pagina.FindName("sliderCambiarImagenMargenTileAncha")
            sliderCambiarImagenMargenTileAncha.Value = 0

            Dim sliderCambiarImagenEsquinasTileAncha As Slider = pagina.FindName("sliderCambiarImagenEsquinasTileAncha")
            sliderCambiarImagenEsquinasTileAncha.Value = 0

            Dim tsImagenTituloTileAncha As ToggleSwitch = pagina.FindName("tsImagenTituloTileAncha")
            tsImagenTituloTileAncha.IsOn = False

            Dim tsImagenTransparenciaTileAncha As ToggleSwitch = pagina.FindName("tsImagenTransparenciaTileAncha")
            tsImagenTransparenciaTileAncha.IsOn = True

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

            PestañasPersonalizacion(iconoPersonalizacionTilePequeña, botonPersonalizacionTilePequeña, gridPersonalizacionTilePequeña)

        End Sub

        Private Sub PersonalizacionTileMedianaClick(sender As Object, e As RoutedEventArgs)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim iconoPersonalizacionTileMediana As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileMediana")
            Dim botonPersonalizacionTileMediana As Button = pagina.FindName("botonPersonalizacionTileMediana")
            Dim gridPersonalizacionTileMediana As Grid = pagina.FindName("gridPersonalizacionTileMediana")

            PestañasPersonalizacion(iconoPersonalizacionTileMediana, botonPersonalizacionTileMediana, gridPersonalizacionTileMediana)

        End Sub

        Private Sub PersonalizacionTileAnchaClick(sender As Object, e As RoutedEventArgs)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim iconoPersonalizacionTileAncha As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileAncha")
            Dim botonPersonalizacionTileAncha As Button = pagina.FindName("botonPersonalizacionTileAncha")
            Dim gridPersonalizacionTileAncha As Grid = pagina.FindName("gridPersonalizacionTileAncha")

            PestañasPersonalizacion(iconoPersonalizacionTileAncha, botonPersonalizacionTileAncha, gridPersonalizacionTileAncha)

        End Sub

        Private Sub PersonalizacionTileGrandeClick(sender As Object, e As RoutedEventArgs)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim iconoPersonalizacionTileGrande As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileGrande")
            Dim botonPersonalizacionTileGrande As Button = pagina.FindName("botonPersonalizacionTileGrande")
            Dim gridPersonalizacionTileGrande As Grid = pagina.FindName("gridPersonalizacionTileGrande")

            PestañasPersonalizacion(iconoPersonalizacionTileGrande, botonPersonalizacionTileGrande, gridPersonalizacionTileGrande)

        End Sub

        Private Sub PestañasPersonalizacion(icono As FontAwesome5.FontAwesome, boton As Button, grid As Grid)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim iconoPersonalizacionTilePequeña As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTilePequeña")
            iconoPersonalizacionTilePequeña.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown

            Dim botonPersonalizacionTilePequeña As Button = pagina.FindName("botonPersonalizacionTilePequeña")
            botonPersonalizacionTilePequeña.Background = New SolidColorBrush(Colors.Transparent)

            Dim gridPersonalizacionTilePequeña As Grid = pagina.FindName("gridPersonalizacionTilePequeña")
            gridPersonalizacionTilePequeña.Visibility = Visibility.Collapsed

            '----------------------------------------------

            Dim iconoPersonalizacionTileMediana As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileMediana")
            iconoPersonalizacionTileMediana.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown

            Dim botonPersonalizacionTileMediana As Button = pagina.FindName("botonPersonalizacionTileMediana")
            botonPersonalizacionTileMediana.Background = New SolidColorBrush(Colors.Transparent)

            Dim gridPersonalizacionTileMediana As Grid = pagina.FindName("gridPersonalizacionTileMediana")
            gridPersonalizacionTileMediana.Visibility = Visibility.Collapsed

            '----------------------------------------------

            Dim iconoPersonalizacionTileAncha As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileAncha")
            iconoPersonalizacionTileAncha.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown

            Dim botonPersonalizacionTileAncha As Button = pagina.FindName("botonPersonalizacionTileAncha")
            botonPersonalizacionTileAncha.Background = New SolidColorBrush(Colors.Transparent)

            Dim gridPersonalizacionTileAncha As Grid = pagina.FindName("gridPersonalizacionTileAncha")
            gridPersonalizacionTileAncha.Visibility = Visibility.Collapsed

            '----------------------------------------------

            Dim iconoPersonalizacionTileGrande As FontAwesome5.FontAwesome = pagina.FindName("iconoPersonalizacionTileGrande")
            iconoPersonalizacionTileGrande.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown

            Dim botonPersonalizacionTileGrande As Button = pagina.FindName("botonPersonalizacionTileGrande")
            botonPersonalizacionTileGrande.Background = New SolidColorBrush(Colors.Transparent)

            Dim gridPersonalizacionTileGrande As Grid = pagina.FindName("gridPersonalizacionTileGrande")
            gridPersonalizacionTileGrande.Visibility = Visibility.Collapsed

            '----------------------------------------------

            icono.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp

            Dim colorFondo As New SolidColorBrush With {
                .Opacity = 0.8,
                .Color = App.Current.Resources("ColorCuarto")
            }
            boton.Background = colorFondo

            grid.Visibility = Visibility.Visible

        End Sub

    End Module
End Namespace

