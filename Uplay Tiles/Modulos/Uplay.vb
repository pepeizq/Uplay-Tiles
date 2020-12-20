Imports Microsoft.Toolkit.Uwp.Helpers
Imports Microsoft.Toolkit.Uwp.UI.Controls
Imports Newtonsoft.Json
Imports Windows.UI

Module Uplay

    Public anchoColumna As Integer = 180
    Dim dominioImagenes As String = "https://cdn.cloudflare.steamstatic.com"

    Public Async Sub Generar()

        Dim helper As New LocalObjectStorageHelper

        Dim recursos As New Resources.ResourceLoader()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim gridProgreso As Grid = pagina.FindName("gridProgreso")
        Interfaz.Pestañas.Visibilidad_Pestañas(gridProgreso, Nothing)

        Dim pbProgreso As ProgressBar = pagina.FindName("pbProgreso")
        pbProgreso.Value = 0

        Dim tbProgreso As TextBlock = pagina.FindName("tbProgreso")
        tbProgreso.Text = String.Empty

        Cache.Estado(False)

        Dim gv As AdaptiveGridView = pagina.FindName("gvTiles")
        gv.DesiredWidth = anchoColumna
        gv.Items.Clear()

        Dim listaJuegos As New List(Of Tile)

        If Await helper.FileExistsAsync("juegos") = True Then
            listaJuegos = Await helper.ReadFileAsync(Of List(Of Tile))("juegos")
        End If

        If listaJuegos Is Nothing Then
            listaJuegos = New List(Of Tile)
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
                                        imagenLogo = Await Cache.DescargarImagen(dominioImagenes + "/steam/apps/" + juegoBBDD.IDSteam + "/logo.png", juegoBBDD.IDSteam, "logo")
                                    Catch ex As Exception

                                    End Try

                                    Dim imagenAncha As String = String.Empty

                                    Try
                                        imagenAncha = Await Cache.DescargarImagen(dominioImagenes + "/steam/apps/" + juegoBBDD.IDSteam + "/header.jpg", juegoBBDD.IDSteam, "ancha")
                                    Catch ex As Exception

                                    End Try

                                    Dim imagenGrande As String = Await Cache.DescargarImagen(Nothing, juegoBBDD.IDUplay, "grande")

                                    If imagenGrande = Nothing Then
                                        Try
                                            imagenGrande = Await Cache.DescargarImagen(dominioImagenes + "/steam/apps/" + juegoBBDD.IDSteam + "/library_600x900.jpg", juegoBBDD.IDSteam, "grande")
                                        Catch ex As Exception

                                        End Try

                                        If imagenGrande = String.Empty Then
                                            Try
                                                imagenGrande = Await Cache.DescargarImagen(dominioImagenes + "/steam/apps/" + juegoBBDD.IDSteam + "/capsule_616x353.jpg", juegoBBDD.IDSteam, "grande")
                                            Catch ex As Exception

                                            End Try
                                        End If
                                    End If

                                    Dim enlace As String = "uplay://launch/" + juegoBBDD.IDUplay + "/0"
                                    Dim pais As New Windows.Globalization.GeographicRegion

                                    If Not juegoBBDD.IDUplayOtrosPaises Is Nothing Then
                                        If juegoBBDD.IDUplayOtrosPaises.Count > 0 Then
                                            For Each paisID In juegoBBDD.IDUplayOtrosPaises
                                                If pais.CodeTwoLetter.ToUpper = paisID.Pais.ToUpper Then
                                                    enlace = "uplay://launch/" + paisID.ID + "/0"
                                                End If
                                            Next
                                        End If
                                    End If

                                    Dim juego As New Tile(juegoBBDD.Titulo, juegoBBDD.IDUplay, juegoBBDD.IDSteam, enlace, Nothing, imagenLogo, imagenAncha, imagenGrande)
                                    listaJuegos.Add(juego)
                                End If
                            End If
                        End If
                    End If
                Else
                    Dim imagenIcono As String = Await Cache.DescargarImagen(Nothing, juegoBBDD.IDUplay, "icono")
                    Dim imagenLogo As String = Await Cache.DescargarImagen(Nothing, juegoBBDD.IDUplay, "logo")
                    Dim imagenAncha As String = Await Cache.DescargarImagen(Nothing, juegoBBDD.IDUplay, "ancha")
                    Dim imagenGrande As String = Await Cache.DescargarImagen(Nothing, juegoBBDD.IDUplay, "grande")

                    Dim enlace As String = "uplay://launch/" + juegoBBDD.IDUplay + "/0"
                    Dim pais As New Windows.Globalization.GeographicRegion

                    If Not juegoBBDD.IDUplayOtrosPaises Is Nothing Then
                        If juegoBBDD.IDUplayOtrosPaises.Count > 0 Then
                            For Each paisID In juegoBBDD.IDUplayOtrosPaises
                                If pais.CodeTwoLetter.ToUpper = paisID.Pais.ToUpper Then
                                    enlace = "uplay://launch/" + paisID.ID + "/0"
                                End If
                            Next
                        End If
                    End If

                    Dim juego As New Tile(juegoBBDD.Titulo, juegoBBDD.IDUplay, Nothing, enlace, imagenIcono, imagenLogo, imagenAncha, imagenGrande)
                    listaJuegos.Add(juego)
                End If
            End If

            pbProgreso.Value = CInt((100 / listaBBDD.Count) * i)
            tbProgreso.Text = i.ToString + "/" + listaBBDD.Count.ToString
            i += 1
        Next

        Try
            Await helper.SaveFileAsync(Of List(Of Tile))("juegos", listaJuegos)
        Catch ex As Exception

        End Try

        Dim gridJuegos As Grid = pagina.FindName("gridJuegos")
        Interfaz.Pestañas.Visibilidad_Pestañas(gridJuegos, recursos.GetString("Games"))

        If Not listaJuegos Is Nothing Then
            If listaJuegos.Count > 0 Then
                listaJuegos.Sort(Function(x, y) x.Titulo.CompareTo(y.Titulo))

                gv.Items.Clear()

                For Each juego In listaJuegos
                    BotonEstilo(juego, gv)
                Next
            End If
        End If

        Cache.Estado(True)

    End Sub

    Public Sub BotonEstilo(juego As Tile, gv As GridView)

        Dim panel As New DropShadowPanel With {
            .Margin = New Thickness(10, 10, 10, 10),
            .ShadowOpacity = 0.9,
            .BlurRadius = 10,
            .MaxWidth = anchoColumna + 20,
            .HorizontalAlignment = HorizontalAlignment.Center,
            .VerticalAlignment = VerticalAlignment.Center
        }

        Dim boton As New Button

        Dim imagen As New ImageEx With {
            .Source = juego.ImagenGrande,
            .IsCacheEnabled = True,
            .Stretch = Stretch.UniformToFill,
            .Padding = New Thickness(0, 0, 0, 0),
            .HorizontalAlignment = HorizontalAlignment.Center,
            .VerticalAlignment = VerticalAlignment.Center,
            .EnableLazyLoading = True
        }

        If imagen.Source = Nothing Then
            imagen.Source = juego.ImagenAncha
        End If

        boton.Tag = juego
        boton.Content = imagen
        boton.Padding = New Thickness(0, 0, 0, 0)
        boton.Background = New SolidColorBrush(Colors.Transparent)

        panel.Content = boton

        Dim tbToolTip As TextBlock = New TextBlock With {
            .Text = juego.Titulo,
            .FontSize = 16,
            .TextWrapping = TextWrapping.Wrap
        }

        ToolTipService.SetToolTip(boton, tbToolTip)
        ToolTipService.SetPlacement(boton, PlacementMode.Mouse)

        AddHandler boton.Click, AddressOf BotonTile_Click
        AddHandler boton.PointerEntered, AddressOf Interfaz.Entra_Boton_Imagen
        AddHandler boton.PointerExited, AddressOf Interfaz.Sale_Boton_Imagen

        gv.Items.Add(panel)

    End Sub

    Private Async Sub BotonTile_Click(sender As Object, e As RoutedEventArgs)

        Trial.Detectar()
        Interfaz.AñadirTile.ResetearValores()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim botonJuego As Button = e.OriginalSource
        Dim juego As Tile = botonJuego.Tag

        Dim gridAñadirTile As Grid = pagina.FindName("gridAñadirTile")
        Interfaz.Pestañas.Visibilidad_Pestañas(gridAñadirTile, juego.Titulo)

        Dim botonAñadirTile As Button = pagina.FindName("botonAñadirTile")
        botonAñadirTile.Tag = juego

        Dim imagenJuegoSeleccionado As ImageEx = pagina.FindName("imagenJuegoSeleccionado")
        imagenJuegoSeleccionado.Source = juego.ImagenAncha

        Dim tbJuegoSeleccionado As TextBlock = pagina.FindName("tbJuegoSeleccionado")
        tbJuegoSeleccionado.Text = juego.Titulo

        '---------------------------------------------

        Dim imagenPequeña As ImageEx = pagina.FindName("imagenTilePequeña")
        imagenPequeña.Source = Nothing

        Dim imagenMediana As ImageEx = pagina.FindName("imagenTileMediana")
        imagenMediana.Source = Nothing

        Dim imagenAncha As ImageEx = pagina.FindName("imagenTileAncha")
        imagenAncha.Source = Nothing

        Dim imagenGrande As ImageEx = pagina.FindName("imagenTileGrande")
        imagenGrande.Source = Nothing

        If juego.ImagenIcono = Nothing Then
            If Not juego.IDSteam = Nothing Then
                Try
                    juego.ImagenIcono = Await Cache.DescargarImagen(Await Steam.SacarIcono(juego.IDSteam), juego.IDSteam, "icono")
                Catch ex As Exception

                End Try
            End If
        End If

        If Not juego.ImagenIcono = Nothing Then
            imagenPequeña.Source = juego.ImagenIcono
            imagenPequeña.Tag = juego.ImagenIcono
        End If

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

        If Not juego.ImagenGrande = Nothing Then
            imagenGrande.Source = juego.ImagenGrande
            imagenGrande.Tag = juego.ImagenGrande
        End If

    End Sub

End Module
