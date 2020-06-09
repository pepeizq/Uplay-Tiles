Imports Microsoft.Toolkit.Uwp.Helpers
Imports Microsoft.Toolkit.Uwp.UI.Controls
Imports Newtonsoft.Json
Imports Windows.Storage
Imports Windows.UI.Core
Imports Windows.UI.Xaml.Media.Animation

Module Uplay

    Public anchoColumna As Integer = 306

    Public Async Sub Generar()

        Dim helper As New LocalObjectStorageHelper

        Dim recursos As New Resources.ResourceLoader()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim spProgreso As StackPanel = pagina.FindName("spProgreso")
        spProgreso.Visibility = Visibility.Visible

        Dim pbProgreso As ProgressBar = pagina.FindName("pbProgreso")
        pbProgreso.Value = 0

        Dim tbProgreso As TextBlock = pagina.FindName("tbProgreso")
        tbProgreso.Text = String.Empty

        Dim botonCache As Button = pagina.FindName("botonConfigLimpiarCache")
        botonCache.IsEnabled = False

        Dim gridSeleccionarJuego As Grid = pagina.FindName("gridSeleccionarJuego")
        gridSeleccionarJuego.Visibility = Visibility.Collapsed

        Dim gv As GridView = pagina.FindName("gvTiles")
        gv.Items.Clear()

        Dim listaJuegos As New List(Of Tile)

        If Await helper.FileExistsAsync("juegos") = True Then
            listaJuegos = Await helper.ReadFileAsync(Of List(Of Tile))("juegos")
        End If

        Dim listaBBDD As List(Of UplayBBDDEntrada) = UplayBBDD.Listado

        Dim i As Integer = 0
        For Each juegoBBDD In listaBBDD
            Dim añadir As Boolean = True

            For Each juegoGuardado In listaJuegos
                If juegoGuardado.IDUplay = juegoBBDD.IDUplay Then
                    añadir = False
                End If
            Next

            If añadir = True Then
                If Not juegoBBDD.IDSteam = Nothing Then
                    Dim htmlAPI As String = Await HttpClient(New Uri("https://store.steampowered.com/api/appdetails/?appids=" + juegoBBDD.IDSteam))

                    If Not htmlAPI = Nothing Then
                        Dim temp As String
                        Dim int As Integer

                        int = htmlAPI.IndexOf(":")
                        temp = htmlAPI.Remove(0, int + 1)
                        temp = temp.Remove(temp.Length - 1, 1)

                        Dim api As SteamAPI = JsonConvert.DeserializeObject(Of SteamAPI)(temp)

                        If Not api Is Nothing Then
                            If Not api.Resultado = False Then
                                If Not api.Datos Is Nothing Then
                                    Dim imagenLogo As String = String.Empty

                                    Try
                                        imagenLogo = Await Cache.DescargarImagen("https://steamcdn-a.akamaihd.net/steam/apps/" + juegoBBDD.IDSteam + "/logo.png", juegoBBDD.IDSteam, "logo")
                                    Catch ex As Exception

                                    End Try

                                    Dim imagenAncha As String = String.Empty

                                    Try
                                        imagenAncha = Await Cache.DescargarImagen("https://steamcdn-a.akamaihd.net/steam/apps/" + juegoBBDD.IDSteam + "/header.jpg", juegoBBDD.IDSteam, "ancha")
                                    Catch ex As Exception

                                    End Try

                                    Dim imagenGrande As String = String.Empty

                                    Try
                                        imagenGrande = Await Cache.DescargarImagen("https://steamcdn-a.akamaihd.net/steam/apps/" + juegoBBDD.IDSteam + "/library_600x900.jpg", juegoBBDD.IDSteam, "grande")
                                    Catch ex As Exception

                                    End Try

                                    If imagenGrande = String.Empty Then
                                        Try
                                            imagenGrande = Await Cache.DescargarImagen("https://steamcdn-a.akamaihd.net/steam/apps/" + juegoBBDD.IDSteam + "/capsule_616x353.jpg", juegoBBDD.IDSteam, "grande")
                                        Catch ex As Exception

                                        End Try
                                    End If

                                    Dim juego As New Tile(juegoBBDD.Titulo, juegoBBDD.IDUplay, juegoBBDD.IDSteam, "uplay://launch/" + juegoBBDD.IDUplay + "/0", Nothing, imagenLogo, imagenAncha, imagenGrande, juegoBBDD.Pais)

                                    listaJuegos.Add(juego)
                                End If
                            Else
                                Dim busqueda As UplayBBDDImagenes = UplayBBDD.Imagenes(juegoBBDD.IDUplay)

                                If Not busqueda Is Nothing Then
                                    Dim juego As New Tile(juegoBBDD.Titulo, juegoBBDD.IDUplay, juegoBBDD.IDSteam, "uplay://launch/" + juegoBBDD.IDUplay + "/0", busqueda.ImagenIcono, busqueda.ImagenLogo, busqueda.ImagenAncha, busqueda.ImagenGrande, juegoBBDD.Pais)

                                    listaJuegos.Add(juego)
                                End If
                            End If
                        End If
                    End If
                Else
                    Dim busqueda As UplayBBDDImagenes = UplayBBDD.Imagenes(juegoBBDD.IDUplay)

                    If Not busqueda Is Nothing Then
                        Dim juego As New Tile(juegoBBDD.Titulo, juegoBBDD.IDUplay, juegoBBDD.IDSteam, "uplay://launch/" + juegoBBDD.IDUplay + "/0", busqueda.ImagenIcono, busqueda.ImagenLogo, busqueda.ImagenAncha, busqueda.ImagenGrande, juegoBBDD.Pais)

                        listaJuegos.Add(juego)
                    End If
                End If
            End If

            pbProgreso.Value = CInt((100 / listaBBDD.Count) * i)
            tbProgreso.Text = i.ToString + "/" + listaBBDD.Count.ToString
            i += 1
        Next

        Await helper.SaveFileAsync(Of List(Of Tile))("juegos", listaJuegos)

        spProgreso.Visibility = Visibility.Collapsed

        Dim gridTiles As Grid = pagina.FindName("gridTiles")
        Dim gridAvisoNoJuegos As Grid = pagina.FindName("gridAvisoNoJuegos")

        If Not listaJuegos Is Nothing Then
            If listaJuegos.Count > 0 Then
                gridTiles.Visibility = Visibility.Visible
                gridAvisoNoJuegos.Visibility = Visibility.Collapsed
                gridSeleccionarJuego.Visibility = Visibility.Visible

                listaJuegos.Sort(Function(x, y) x.Titulo.CompareTo(y.Titulo))

                gv.Items.Clear()

                For Each juego In listaJuegos
                    Dim gridImagen As New Grid

                    Dim imagen As New ImageEx With {
                        .Source = juego.ImagenAncha,
                        .IsCacheEnabled = True,
                        .Stretch = Stretch.UniformToFill
                    }

                    gridImagen.Children.Add(imagen)

                    If Not juego.Pais = Nothing Then
                        Dim pais As New ImageEx With {
                            .IsCacheEnabled = True,
                            .Stretch = Stretch.UniformToFill,
                            .Width = 35,
                            .Height = 23,
                            .HorizontalAlignment = HorizontalAlignment.Right,
                            .VerticalAlignment = VerticalAlignment.Bottom
                        }

                        If Not juego.Pais = Nothing Then
                            pais.Source = "Assets/Paises/" + juego.Pais + ".png"
                        End If

                        gridImagen.Children.Add(pais)
                    End If

                    Dim boton As New Button With {
                        .Tag = juego,
                        .Content = gridImagen,
                        .Padding = New Thickness(0, 0, 0, 0)
                    }

                    Dim panel As New DropShadowPanel With {
                        .Margin = New Thickness(5, 5, 5, 5),
                        .ShadowOpacity = 0.9,
                        .BlurRadius = 5
                    }

                    panel.Content = boton

                    Dim tbToolTip As TextBlock = New TextBlock With {
                        .Text = juego.Titulo,
                        .FontSize = 16
                    }

                    ToolTipService.SetToolTip(boton, tbToolTip)
                    ToolTipService.SetPlacement(boton, PlacementMode.Mouse)

                    AddHandler boton.Click, AddressOf BotonTile_Click
                    AddHandler boton.PointerEntered, AddressOf UsuarioEntraBoton
                    AddHandler boton.PointerExited, AddressOf UsuarioSaleBoton

                    If juego.Pais = Nothing Then
                        gv.Items.Add(panel)
                    Else
                        If ApplicationData.Current.LocalSettings.Values("regiones") = True Then
                            If juego.Pais = "Russia" And ApplicationData.Current.LocalSettings.Values("region_rusia") = True Then
                                gv.Items.Add(panel)
                            End If
                        End If
                    End If
                Next
            Else
                gridTiles.Visibility = Visibility.Collapsed
                gridAvisoNoJuegos.Visibility = Visibility.Visible
                gridSeleccionarJuego.Visibility = Visibility.Collapsed
            End If
        Else
            gridTiles.Visibility = Visibility.Collapsed
            gridAvisoNoJuegos.Visibility = Visibility.Visible
            gridSeleccionarJuego.Visibility = Visibility.Collapsed
        End If

        botonCache.IsEnabled = True

    End Sub

    Private Async Sub BotonTile_Click(sender As Object, e As RoutedEventArgs)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim botonJuego As Button = e.OriginalSource
        Dim juego As Tile = botonJuego.Tag

        Dim botonAñadirTile As Button = pagina.FindName("botonAñadirTile")
        botonAñadirTile.Tag = juego

        Dim resultado As New RenderTargetBitmap()
        Await resultado.RenderAsync(botonJuego.Content)

        Dim imagenJuegoSeleccionado As ImageEx = pagina.FindName("imagenJuegoSeleccionado")
        imagenJuegoSeleccionado.Source = resultado

        Dim tbJuegoSeleccionado As TextBlock = pagina.FindName("tbJuegoSeleccionado")
        tbJuegoSeleccionado.Text = juego.Titulo

        Dim gridSeleccionarJuego As Grid = pagina.FindName("gridSeleccionarJuego")
        gridSeleccionarJuego.Visibility = Visibility.Collapsed

        Dim gvTiles As GridView = pagina.FindName("gvTiles")

        If gvTiles.ActualWidth > anchoColumna Then
            ApplicationData.Current.LocalSettings.Values("ancho_grid_tiles") = gvTiles.ActualWidth
        End If

        gvTiles.Width = anchoColumna
        gvTiles.Padding = New Thickness(0, 0, 15, 0)

        Dim gridAñadir As Grid = pagina.FindName("gridAñadirTile")
        gridAñadir.Visibility = Visibility.Visible

        ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("tile", botonJuego)

        Dim animacion As ConnectedAnimation = ConnectedAnimationService.GetForCurrentView().GetAnimation("tile")

        If Not animacion Is Nothing Then
            animacion.TryStart(gridAñadir)
        End If

        Dim tbTitulo As TextBlock = pagina.FindName("tbTitulo")
        tbTitulo.Text = Package.Current.DisplayName + " (" + Package.Current.Id.Version.Major.ToString + "." + Package.Current.Id.Version.Minor.ToString + "." + Package.Current.Id.Version.Build.ToString + "." + Package.Current.Id.Version.Revision.ToString + ") - " + juego.Titulo

        '---------------------------------------------

        Dim imagenPequeña As ImageEx = pagina.FindName("imagenTilePequeña")
        imagenPequeña.Source = Nothing

        Try
            juego.ImagenIcono = Await Cache.DescargarImagen(Await Steam.SacarIcono(juego.IDSteam), juego.IDSteam, "icono")
        Catch ex As Exception

        End Try

        If Not juego.ImagenIcono = Nothing Then
            imagenPequeña.Source = juego.ImagenIcono
            imagenPequeña.Tag = juego.ImagenIcono
        End If

        Dim imagenMediana As ImageEx = pagina.FindName("imagenTileMediana")
        imagenMediana.Source = Nothing

        Dim imagenAncha As ImageEx = pagina.FindName("imagenTileAncha")
        imagenAncha.Source = Nothing

        If Not juego.ImagenAncha = Nothing Then
            If Not juego.ImagenLogo = Nothing Then
                imagenMediana.Source = juego.ImagenLogo
                imagenMediana.Tag = juego.ImagenLogo
            Else
                imagenMediana.Source = juego.ImagenAncha
                imagenMediana.Tag = juego.ImagenAncha
            End If

            imagenAncha.Source = juego.ImagenAncha
            imagenAncha.Tag = juego.ImagenAncha
        End If

        Dim imagenGrande As ImageEx = pagina.FindName("imagenTileGrande")
        imagenGrande.Source = Nothing

        If Not juego.ImagenGrande = Nothing Then
            imagenGrande.Source = juego.ImagenGrande
            imagenGrande.Tag = juego.ImagenGrande
        End If

    End Sub

    Private Sub UsuarioEntraBoton(sender As Object, e As PointerRoutedEventArgs)

        Window.Current.CoreWindow.PointerCursor = New CoreCursor(CoreCursorType.Hand, 1)

    End Sub

    Private Sub UsuarioSaleBoton(sender As Object, e As PointerRoutedEventArgs)

        Window.Current.CoreWindow.PointerCursor = New CoreCursor(CoreCursorType.Arrow, 1)

    End Sub

End Module
