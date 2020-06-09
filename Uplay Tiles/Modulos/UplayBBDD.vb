Module UplayBBDD

    'https://github.com/Haoose/UPLAY_GAME_ID

    Public Function Listado()

        Dim lista As New List(Of UplayBBDDEntrada) From {
            New UplayBBDDEntrada("Anno 1404", "89", "33250", Nothing),
            New UplayBBDDEntrada("Anno 1602", "2990", Nothing, Nothing),
            New UplayBBDDEntrada("Anno 2070", "22", "48240", Nothing),
            New UplayBBDDEntrada("Anno 1800", "4553", "916440", Nothing),
            New UplayBBDDEntrada("Anno 2205", "1253", "375910", Nothing),
            New UplayBBDDEntrada("Assassin's Creed", "82", "15100", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Brotherhood", "26", "48190", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Chronicles China", "1651", "354380", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Chronicles India", "1847", "359610", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Chronicles Russia", "1848", "359600", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Freedom Cry", "664", "277590", Nothing),
            New UplayBBDDEntrada("Assassin's Creed II", "4", "33230", Nothing),
            New UplayBBDDEntrada("Assassin's Creed III", "54", "208480", Nothing),
            New UplayBBDDEntrada("Assassin's Creed III", "103", "208480", "Russia"),
            New UplayBBDDEntrada("Assassin's Creed III Remastered", "5183", "911400", Nothing),
            New UplayBBDDEntrada("Assassin's Creed IV Black Flag", "273", "242050", Nothing),
            New UplayBBDDEntrada("Assassin's Creed IV Black Flag", "441", "242050", "Russia"),
            New UplayBBDDEntrada("Assassin's Creed Liberation HD", "625", "260210", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Odyssey", "5059", "812140", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Origins", "3539", "582160", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Revelations", "40", "201870", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Rogue", "895", "311560", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Rogue", "1186", "311560", "Russia"),
            New UplayBBDDEntrada("Assassin's Creed Syndicate", "1875", "368500", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Syndicate", "1955", "368500", "Russia"),
            New UplayBBDDEntrada("Assassin's Creed Unity", "720", "289650", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Unity", "944", "289650", "Russia"),
            New UplayBBDDEntrada("Beyond Good and Evil", "232", "15130", Nothing),
            New UplayBBDDEntrada("Driver San Francisco", "13", Nothing, Nothing),
            New UplayBBDDEntrada("Far Cry", "84", "13520", Nothing),
            New UplayBBDDEntrada("Far Cry 2", "85", "19900", Nothing),
            New UplayBBDDEntrada("Far Cry 3", "46", "220240", Nothing),
            New UplayBBDDEntrada("Far Cry 3 Blood Dragon", "205", "233270", Nothing),
            New UplayBBDDEntrada("Far Cry 4", "420", "298110", Nothing),
            New UplayBBDDEntrada("Far Cry 4", "969", "298110", "Russia"),
            New UplayBBDDEntrada("Far Cry 5", "1803", "552520", Nothing),
            New UplayBBDDEntrada("Far Cry New Dawn", "5210", "939960", Nothing),
            New UplayBBDDEntrada("Far Cry Primal", "2010", "371660", Nothing),
            New UplayBBDDEntrada("For Honor", "3458", "304390", Nothing),
            New UplayBBDDEntrada("From Dust", "30", "33460", Nothing),
            New UplayBBDDEntrada("Prince of Persia: The Forgotten Sands", "11", "33320", Nothing),
            New UplayBBDDEntrada("Prince of Persia: The Sands of Time", "111", "13600", Nothing),
            New UplayBBDDEntrada("Prince of Persia: The Two Thrones", "113", "13530", Nothing),
            New UplayBBDDEntrada("Prince of Persia: Warrior Within", "121", "13500", Nothing),
            New UplayBBDDEntrada("Prince of Persia (2008)", "277", "19980", Nothing),
            New UplayBBDDEntrada("Rayman Legends", "410", "242550", Nothing),
            New UplayBBDDEntrada("Rayman Origins", "80", "207490", Nothing),
            New UplayBBDDEntrada("Steep", "3279", "460920", Nothing),
            New UplayBBDDEntrada("The Crew", "413", "241560", Nothing),
            New UplayBBDDEntrada("The Crew", "507", "241560", "Russia"),
            New UplayBBDDEntrada("The Settlers", "11662", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 2", "11783", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 3", "11784", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 4", "11785", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 5: Heritage of Kings", "11786", "965300", Nothing),
            New UplayBBDDEntrada("The Settlers 6: Rise of an Empire", "11787", "965310", Nothing),
            New UplayBBDDEntrada("The Settlers 7: Paths to a Kingdom", "8", "965320", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Breakpoint", "11903", Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Wildlands", "1771", "460930", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six: Vegas", "88", "13540", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six: Vegas 2", "108", "15120", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six Siege", "635", "359550", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell", "109", "13560", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Blacklist", "91", "235600", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Chaos Theory", "95", "13570", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Conviction", "2", "33220", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Double Agent", "110", "13580", Nothing),
            New UplayBBDDEntrada("Tom Clancy's The Division", "568", "365590", Nothing),
            New UplayBBDDEntrada("Tom Clancy's The Division 2", "4932", "881280", Nothing),
            New UplayBBDDEntrada("Watch_Dogs", "274", "243470", Nothing),
            New UplayBBDDEntrada("Watch_Dogs", "543", "243470", "Russia"),
            New UplayBBDDEntrada("Watch_Dogs 2", "2688", "447040", Nothing),
            New UplayBBDDEntrada("Zeit²", "340", "33390", Nothing)
        }

        Return lista
    End Function

    Public Function Imagenes(id As String)

        Dim lista As New List(Of UplayBBDDImagenes) From {
            New UplayBBDDImagenes("4932", "https://steamcdn-a.akamaihd.net/steamcommunity/public/images/apps/881280/7de6ba91a570187d902d5f1afdca73198a22d592.jpg",
                                          "https://i.imgur.com/1CmXVBp.png",
                                          "https://steamcdn-a.akamaihd.net/steam/apps/881280/header.jpg?t=1528753864",
                                          "https://i.imgur.com/sdeWy9u.png"),
            New UplayBBDDImagenes("2990", Nothing,
                                          "https://i.imgur.com/BOkjRPX.jpg",
                                          "https://i.imgur.com/Rr3JVP5.png",
                                          "https://i.imgur.com/vh0pV8S.jpg"),
            New UplayBBDDImagenes("11903", Nothing,
                                          "https://i.imgur.com/B48jFZ2.png",
                                          "https://i.imgur.com/5Bhs1wT.png",
                                          "https://i.imgur.com/qQVJeDN.png"),
            New UplayBBDDImagenes("11662", Nothing,
                                          "https://i.imgur.com/WtsWvLZ.png",
                                          "https://i.imgur.com/7j4sX1T.png",
                                          "https://i.imgur.com/JTzR4jc.png"),
            New UplayBBDDImagenes("11783", Nothing,
                                           Nothing,
                                          "https://i.imgur.com/ZnIRWlI.jpg",
                                          "https://i.imgur.com/eY77VGC.jpg"),
            New UplayBBDDImagenes("11784", Nothing,
                                           Nothing,
                                          "https://i.imgur.com/md9RK3A.jpg",
                                          "https://i.imgur.com/bBK7T9V.png"),
            New UplayBBDDImagenes("11785", Nothing,
                                           Nothing,
                                          "https://i.imgur.com/vV3GetE.jpg",
                                          "https://i.imgur.com/5NBoqtV.png"),
            New UplayBBDDImagenes("13", Nothing,
                                          "https://i.imgur.com/F8THwzY.png",
                                          "https://i.imgur.com/kWkgQrl.png",
                                          "https://i.imgur.com/6rbY17N.jpg")
        }

        For Each juego In lista
            If id = juego.ID Then
                Return juego
            End If
        Next

        Return Nothing
    End Function

    Public Class UplayBBDDEntrada

        Public Titulo As String
        Public IDUplay As String
        Public IDSteam As String
        Public Pais As String

        Public Sub New(ByVal titulo As String, ByVal idUplay As String, ByVal idSteam As String, ByVal pais As String)
            Me.Titulo = titulo
            Me.IDUplay = idUplay
            Me.IDSteam = idSteam
            Me.Pais = pais
        End Sub

    End Class

    Public Class UplayBBDDImagenes

        Public ID As String
        Public ImagenIcono As String
        Public ImagenLogo As String
        Public ImagenAncha As String
        Public ImagenGrande As String

        Public Sub New(ByVal id As String, ByVal imagenIcono As String, ByVal imagenLogo As String, ByVal imagenAncha As String, ByVal imagenGrande As String)
            Me.ID = id
            Me.ImagenIcono = imagenIcono
            Me.ImagenLogo = imagenLogo
            Me.ImagenAncha = imagenAncha
            Me.ImagenGrande = imagenGrande
        End Sub

    End Class

End Module
