Imports Microsoft.Toolkit.Uwp.UI.Controls
Imports Windows.Storage
Imports Windows.Storage.Pickers
Imports Windows.Storage.Streams

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

        Private Sub CambioImagenIncrustar(bitmap As Object)

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim gridExterior As Grid = pagina.FindName("gridPersonalizacionExterior")

            For Each hijo In gridExterior.Children
                Dim imagen2 As ImageEx = Nothing

                Try
                    imagen2 = hijo
                Catch ex As Exception

                End Try

                If Not imagen2 Is Nothing Then
                    gridExterior.Children.Remove(hijo)
                End If
            Next

            Dim gridInterior As Grid = pagina.FindName("gridPersonalizacionInterior")

            Dim imagen As New ImageEx With {
                .IsCacheEnabled = True,
                .Source = bitmap,
                .Stretch = Stretch.UniformToFill
            }

            Dim cbImagenUbicacion As ComboBox = pagina.FindName("cbPersonalizacionImagenUbicacion")

            If cbImagenUbicacion.SelectedIndex = 0 Then
                gridInterior.Children.Add(imagen)
            ElseIf cbImagenUbicacion.SelectedIndex = 1 Then
                gridInterior.Children.Clear()
                gridExterior.Children.Add(imagen)
            End If

        End Sub

    End Module
End Namespace