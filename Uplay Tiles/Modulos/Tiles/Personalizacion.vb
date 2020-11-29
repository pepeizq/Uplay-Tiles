Imports Microsoft.Toolkit.Uwp
Imports Microsoft.Toolkit.Uwp.UI.Controls
Imports Windows.Storage
Imports Windows.Storage.Pickers
Imports Windows.Storage.Streams
Imports Windows.UI

Namespace Tiles
    Module Personalizacion

        Public Async Sub CambioImagenOrdenador(sender As Object, e As RoutedEventArgs)

            Dim boton As Button = sender
            boton.IsEnabled = False

            Dim imagen As ImageEx = boton.Tag

            Dim ficheroPicker As New FileOpenPicker
            ficheroPicker.FileTypeFilter.Add(".png")
            ficheroPicker.FileTypeFilter.Add(".jpg")
            ficheroPicker.FileTypeFilter.Add(".jpeg")
            ficheroPicker.ViewMode = PickerViewMode.List

            Dim ficheroImagen As StorageFile = Await ficheroPicker.PickSingleFileAsync

            Dim bitmap As New BitmapImage

            Try
                Dim stream As FileRandomAccessStream = Await ficheroImagen.OpenAsync(FileAccessMode.Read)
                bitmap.SetSource(stream)
                imagen.Source = bitmap
            Catch ex As Exception

            End Try

            boton.IsEnabled = True

        End Sub

        Public Sub CambioImagenInternet(sender As Object, e As TextChangedEventArgs)

            Dim tb As TextBox = sender
            tb.IsEnabled = False

            Dim imagen As ImageEx = tb.Tag

            If tb.Text.Trim.Length > 0 Then
                If tb.Text.Trim.Contains("http://") Or tb.Text.Trim.Contains("https://") Then
                    Try
                        imagen.Source = tb.Text.Trim
                    Catch ex As Exception

                    End Try
                End If
            End If

            tb.IsEnabled = True

        End Sub

        Public Sub CambiarImagenEstiramiento(sender As Object, e As SelectionChangedEventArgs)

            Dim cb As ComboBox = sender
            cb.IsEnabled = False

            Dim imagen As ImageEx = cb.Tag

            If cb.SelectedIndex = 0 Then
                imagen.Stretch = Stretch.None
            ElseIf cb.SelectedIndex = 1 Then
                imagen.Stretch = Stretch.Fill
            ElseIf cb.SelectedIndex = 2 Then
                imagen.Stretch = Stretch.Uniform
            ElseIf cb.SelectedIndex = 3 Then
                imagen.Stretch = Stretch.UniformToFill
            End If

            cb.IsEnabled = True

        End Sub

        Public Sub CambiarImagenMargen(ByVal sender As Object, ByVal e As RoutedEventArgs)

            Dim slider As Slider = sender
            slider.IsEnabled = False

            Dim imagen As ImageEx = slider.Tag
            imagen.Margin = New Thickness(slider.Value)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            If imagen.Name = "imagenTilePequeña" Then
                Dim tb As TextBlock = pagina.FindName("tbCambiarImagenMargenTilePequeña")
                tb.Text = slider.Value.ToString + "px"
            ElseIf imagen.Name = "imagenTileMediana" Then
                Dim tb As TextBlock = pagina.FindName("tbCambiarImagenMargenTileMediana")
                tb.Text = slider.Value.ToString + "px"
            ElseIf imagen.Name = "imagenTileAncha" Then
                Dim tb As TextBlock = pagina.FindName("tbCambiarImagenMargenTileAncha")
                tb.Text = slider.Value.ToString + "px"
            ElseIf imagen.Name = "imagenTileGrande" Then
                Dim tb As TextBlock = pagina.FindName("tbCambiarImagenMargenTileGrande")
                tb.Text = slider.Value.ToString + "px"
            End If

            slider.IsEnabled = True

        End Sub

        Public Sub CambiarImagenEsquinas(ByVal sender As Object, ByVal e As RoutedEventArgs)

            Dim slider As Slider = sender
            slider.IsEnabled = False

            Dim imagen As ImageEx = slider.Tag
            imagen.CornerRadius = New CornerRadius(slider.Value)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            If imagen.Name = "imagenTilePequeña" Then
                Dim tb As TextBlock = pagina.FindName("tbCambiarImagenEsquinasTilePequeña")
                tb.Text = slider.Value.ToString + "px"
            ElseIf imagen.Name = "imagenTileMediana" Then
                Dim tb As TextBlock = pagina.FindName("tbCambiarImagenEsquinasTileMediana")
                tb.Text = slider.Value.ToString + "px"
            ElseIf imagen.Name = "imagenTileAncha" Then
                Dim tb As TextBlock = pagina.FindName("tbCambiarImagenEsquinasTileAncha")
                tb.Text = slider.Value.ToString + "px"
            ElseIf imagen.Name = "imagenTileGrande" Then
                Dim tb As TextBlock = pagina.FindName("tbCambiarImagenEsquinasTileGrande")
                tb.Text = slider.Value.ToString + "px"
            End If

            slider.IsEnabled = True

        End Sub

        Public Sub CambiarFondoTransparente(ByVal sender As Object, ByVal e As RoutedEventArgs)

            Dim ts As ToggleSwitch = sender
            ts.IsEnabled = False

            Dim grid As Grid = ts.Tag

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            If ts.IsOn Then
                grid.Background = New SolidColorBrush(Colors.Transparent)

                If grid.Name = "gridTilePequeña" Then
                    Dim sp As StackPanel = pagina.FindName("spImagenFondoTilePequeña")
                    sp.Visibility = Visibility.Collapsed
                ElseIf grid.Name = "gridTileMediana" Then
                    Dim sp As StackPanel = pagina.FindName("spImagenFondoTileMediana")
                    sp.Visibility = Visibility.Collapsed
                ElseIf grid.Name = "gridTileAncha" Then
                    Dim sp As StackPanel = pagina.FindName("spImagenFondoTileAncha")
                    sp.Visibility = Visibility.Collapsed
                ElseIf grid.Name = "gridTileGrande" Then
                    Dim sp As StackPanel = pagina.FindName("spImagenFondoTileGrande")
                    sp.Visibility = Visibility.Collapsed
                End If
            Else
                grid.Background = New SolidColorBrush(App.Current.Resources("ColorTerciario"))

                If grid.Name = "gridTilePequeña" Then
                    Dim sp As StackPanel = pagina.FindName("spImagenFondoTilePequeña")
                    sp.Visibility = Visibility.Visible

                    Dim cp As ColorPicker = pagina.FindName("cpImagenFondoTilePequeña")
                    cp.Color = Helpers.ColorHelper.ToColor(Helpers.ColorHelper.ToHex(App.Current.Resources("ColorTerciario")))
                ElseIf grid.Name = "gridTileMediana" Then
                    Dim sp As StackPanel = pagina.FindName("spImagenFondoTileMediana")
                    sp.Visibility = Visibility.Visible

                    Dim cp As ColorPicker = pagina.FindName("cpImagenFondoTileMediana")
                    cp.Color = Helpers.ColorHelper.ToColor(Helpers.ColorHelper.ToHex(App.Current.Resources("ColorTerciario")))
                ElseIf grid.Name = "gridTileAncha" Then
                    Dim sp As StackPanel = pagina.FindName("spImagenFondoTileAncha")
                    sp.Visibility = Visibility.Visible

                    Dim cp As ColorPicker = pagina.FindName("cpImagenFondoTileAncha")
                    cp.Color = Helpers.ColorHelper.ToColor(Helpers.ColorHelper.ToHex(App.Current.Resources("ColorTerciario")))
                ElseIf grid.Name = "gridTileGrande" Then
                    Dim sp As StackPanel = pagina.FindName("spImagenFondoTileGrande")
                    sp.Visibility = Visibility.Visible

                    Dim cp As ColorPicker = pagina.FindName("cpImagenFondoTileGrande")
                    cp.Color = Helpers.ColorHelper.ToColor(Helpers.ColorHelper.ToHex(App.Current.Resources("ColorTerciario")))
                End If
            End If

            ts.IsEnabled = True

        End Sub

        Public Sub CambiarFondoColor(ByVal sender As Object, ByVal e As ColorChangedEventArgs)

            Dim cp As ColorPicker = sender
            cp.IsEnabled = False

            Dim grid As Grid = cp.Tag
            grid.Background = New SolidColorBrush(cp.Color)

            cp.IsEnabled = True

        End Sub

        Public Sub MostrarTitulo(ByVal sender As Object, ByVal e As RoutedEventArgs)

            Dim ts As ToggleSwitch = sender

            If ts.IsOn = True Then
                ApplicationData.Current.LocalSettings.Values("tile_ancha_titulo") = True
            Else
                ApplicationData.Current.LocalSettings.Values("tile_ancha_titulo") = False
            End If

        End Sub

    End Module
End Namespace