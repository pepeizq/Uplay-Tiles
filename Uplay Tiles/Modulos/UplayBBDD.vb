Module UplayBBDD

    Public Function Listado()

        Dim lista As New List(Of UplayBBDDEntrada) From {
            New UplayBBDDEntrada("Anno 1404", "89", "33250", Nothing),
            New UplayBBDDEntrada("Anno 1602", "2990", Nothing, Nothing),
            New UplayBBDDEntrada("Anno 1800", "4553", "916440", Nothing),
            New UplayBBDDEntrada("Anno 2070", "22", "48240", Nothing),
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
            New UplayBBDDEntrada("Blazing Angels: Squadrons of WWII", "266", "15220", Nothing),
            New UplayBBDDEntrada("Blazing Angels 2: Secret Missions of WWII", "267", Nothing, Nothing),
            New UplayBBDDEntrada("Brothers in Arms: Earned in Blood", "271", "19800", Nothing),
            New UplayBBDDEntrada("Brothers in Arms: Hell's Highway", "272", "15390", Nothing),
            New UplayBBDDEntrada("Brothers in Arms: Road to Hill 30", "270", "15190", Nothing),
            New UplayBBDDEntrada("Cold Fear", "233", "15270", Nothing),
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
            New UplayBBDDEntrada("Heroes of Might & Magic V", "87", "15170", Nothing),
            New UplayBBDDEntrada("I am Alive", "93", "214250", Nothing),
            New UplayBBDDEntrada("Might & Magic: Heroes VI", "44", "48220", Nothing),
            New UplayBBDDEntrada("Might & Magic: Heroes VII", "1176", "321960", Nothing),
            New UplayBBDDEntrada("Prince of Persia: The Forgotten Sands", "11", "33320", Nothing),
            New UplayBBDDEntrada("Prince of Persia: The Sands of Time", "111", "13600", Nothing),
            New UplayBBDDEntrada("Prince of Persia: The Two Thrones", "113", "13530", Nothing),
            New UplayBBDDEntrada("Prince of Persia: Warrior Within", "121", "13500", Nothing),
            New UplayBBDDEntrada("Prince of Persia (2008)", "277", "19980", Nothing),
            New UplayBBDDEntrada("Rayman Legends", "410", "242550", Nothing),
            New UplayBBDDEntrada("Rayman Origins", "80", "207490", Nothing),
            New UplayBBDDEntrada("Rocksmith", "268", "205190", Nothing),
            New UplayBBDDEntrada("Shaun White Skateboarding", "20", Nothing, Nothing),
            New UplayBBDDEntrada("Silent Hunter 5: Battle of the Atlantic", "3", "48110", Nothing),
            New UplayBBDDEntrada("South Park: The Fractured But Whole", "3088", "488790", Nothing),
            New UplayBBDDEntrada("South Park: The Stick of Truth", "3584", "213670", Nothing),
            New UplayBBDDEntrada("Steep", "3279", "460920", Nothing),
            New UplayBBDDEntrada("The Adventures of Tintin: The Game", "33", Nothing, Nothing),
            New UplayBBDDEntrada("The Crew", "413", "241560", Nothing),
            New UplayBBDDEntrada("The Crew", "507", "241560", "Russia"),
            New UplayBBDDEntrada("The Settlers - History Edition", "11662", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 2 - History Edition", "11783", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 3 - History Edition", "11784", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 4 - History Edition", "11785", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 5: Heritage of Kings - History Edition", "11786", "965300", Nothing),
            New UplayBBDDEntrada("The Settlers 6: Rise of an Empire - History Edition", "11787", "965310", Nothing),
            New UplayBBDDEntrada("The Settlers 7: Paths to a Kingdom - History Edition", "11788", "965320", Nothing),
            New UplayBBDDEntrada("Tom Clancy's EndWar", "83", "21800", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Advanced Warfighter 2", "114", "13510", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Breakpoint", "11903", Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Future Soldier", "53", "212630", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Wildlands", "1771", "460930", Nothing),
            New UplayBBDDEntrada("Tom Clancy's H.A.W.X. 2", "21", "48180", Nothing),
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
            New UplayBBDDEntrada("Trackmania Turbo", "2070", "375900", Nothing),
            New UplayBBDDEntrada("Trials Evolution Gold Edition", "78", "220160", Nothing),
            New UplayBBDDEntrada("Trials Fusion", "297", "245490", Nothing),
            New UplayBBDDEntrada("Trials Rising", "3601", "641080", Nothing),
            New UplayBBDDEntrada("Watch_Dogs", "274", "243470", Nothing),
            New UplayBBDDEntrada("Watch_Dogs", "543", "243470", "Russia"),
            New UplayBBDDEntrada("Watch_Dogs 2", "2688", "447040", Nothing),
            New UplayBBDDEntrada("World In Conflict", "90", "21760", Nothing),
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
                                          "https://i.imgur.com/6rbY17N.jpg"),
            New UplayBBDDImagenes("20", Nothing,
                                          "https://i.imgur.com/3QwcrrF.png",
                                          "https://i.imgur.com/lhPwbwa.jpg",
                                          Nothing),
            New UplayBBDDImagenes("33", Nothing,
                                          Nothing,
                                          "https://i.imgur.com/gsrnTGB.jpg",
                                          Nothing),
            New UplayBBDDImagenes("267", Nothing,
                                          Nothing,
                                          "https://i.imgur.com/DGONcLK.jpg",
                                          "https://i.imgur.com/str1G1w.png")
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
