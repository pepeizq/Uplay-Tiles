Imports Windows.Storage

Module Configuracion

    Public Sub Iniciar()

        If ApplicationData.Current.LocalSettings.Values("regiones") Is Nothing Then
            CargarRegiones(False)
        Else
            CargarRegiones(ApplicationData.Current.LocalSettings.Values("regiones"))
        End If

        If ApplicationData.Current.LocalSettings.Values("region_rusia") Is Nothing Then
            CargarRegionesRusia(False)
        Else
            CargarRegionesRusia(ApplicationData.Current.LocalSettings.Values("region_rusia"))
        End If

        '-------------------------------------

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim tbTitulo As TextBlock = pagina.FindName("tbTitulo")
        tbTitulo.Text = Package.Current.DisplayName + " (" + Package.Current.Id.Version.Major.ToString + "." + Package.Current.Id.Version.Minor.ToString + "." + Package.Current.Id.Version.Build.ToString + "." + Package.Current.Id.Version.Revision.ToString + ")"

    End Sub

    Public Sub CargarRegiones(estado As Boolean)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim cbRegiones As CheckBox = pagina.FindName("cbConfigRegiones")
        cbRegiones.IsChecked = estado

        Dim gvRegiones As GridView = pagina.FindName("gvRegiones")

        If estado = True Then
            gvRegiones.Visibility = Visibility.Visible
        Else
            gvRegiones.Visibility = Visibility.Collapsed
        End If

        ApplicationData.Current.LocalSettings.Values("regiones") = estado

    End Sub

    Public Sub CargarRegionesRusia(estado As Boolean)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim cb As CheckBox = pagina.FindName("cbConfigRegionRusia")
        cb.IsChecked = estado

        ApplicationData.Current.LocalSettings.Values("region_rusia") = estado

    End Sub

End Module
