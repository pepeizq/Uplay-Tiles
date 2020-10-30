Module UplayBBDD

    Public Function Listado()

        Dim lista As New List(Of UplayBBDDEntrada) From {
            New UplayBBDDEntrada("Anno 1404", "89", "33250", Nothing, Nothing),
            New UplayBBDDEntrada("Anno 1602", "2990", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Anno 1800", "4553", "916440", Nothing, Nothing),
            New UplayBBDDEntrada("Anno 2070", "22", "48240", Nothing, Nothing),
            New UplayBBDDEntrada("Anno 2205", "1253", "375910", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed", "82", "15100", Nothing, "https://i.imgur.com/MSgm52E.png"),
            New UplayBBDDEntrada("Assassin's Creed Brotherhood", "26", "48190", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed Chronicles China", "1651", "354380", Nothing, "https://i.imgur.com/EiCQqNj.png"),
            New UplayBBDDEntrada("Assassin's Creed Chronicles India", "1847", "359610", Nothing, "https://i.imgur.com/BpTc5Fv.png"),
            New UplayBBDDEntrada("Assassin's Creed Chronicles Russia", "1848", "359600", Nothing, "https://i.imgur.com/zwN4kWS.png"),
            New UplayBBDDEntrada("Assassin's Creed Freedom Cry", "664", "277590", Nothing, "https://i.imgur.com/IYX85Y4.png"),
            New UplayBBDDEntrada("Assassin's Creed II", "4", "33230", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed III", "54", "208480", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed III", "103", "208480", "Russia", Nothing),
            New UplayBBDDEntrada("Assassin's Creed III Remastered", "5183", "911400", Nothing, "https://i.imgur.com/4KqEfXi.png"),
            New UplayBBDDEntrada("Assassin's Creed IV Black Flag", "273", "242050", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed IV Black Flag", "441", "242050", "Russia", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Liberation HD", "625", "260210", Nothing, "https://i.imgur.com/bJ3zEEE.png"),
            New UplayBBDDEntrada("Assassin's Creed Odyssey", "5059", "812140", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed Origins", "3539", "582160", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed Revelations", "40", "201870", Nothing, "https://i.imgur.com/paAzJfj.png"),
            New UplayBBDDEntrada("Assassin's Creed Rogue", "895", "311560", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed Rogue", "1186", "311560", "Russia", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Syndicate", "1875", "368500", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed Syndicate", "1955", "368500", "Russia", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Unity", "720", "289650", Nothing, Nothing),
            New UplayBBDDEntrada("Assassin's Creed Unity", "944", "289650", "Russia", Nothing),
            New UplayBBDDEntrada("Atomega", "5060", "619880", Nothing, "https://i.imgur.com/74sxKQu.png"),
            New UplayBBDDEntrada("Beyond Good and Evil", "232", "15130", Nothing, "https://i.imgur.com/qUGEkdS.png"),
            New UplayBBDDEntrada("Blazing Angels: Squadrons of WWII", "266", "15220", Nothing, "https://i.imgur.com/4WED8bN.png"),
            New UplayBBDDEntrada("Blazing Angels 2: Secret Missions of WWII", "267", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Brothers in Arms: Earned in Blood", "271", "19800", Nothing, "https://i.imgur.com/LsxaXZc.png"),
            New UplayBBDDEntrada("Brothers in Arms: Hell's Highway", "272", "15390", Nothing, "https://i.imgur.com/wy8jLWp.png"),
            New UplayBBDDEntrada("Brothers in Arms: Road to Hill 30", "270", "15190", Nothing, "https://i.imgur.com/UoYKBZe.png"),
            New UplayBBDDEntrada("Call of Juarez: Bound in Blood", "112", "21980", Nothing, Nothing),
            New UplayBBDDEntrada("Call of Juarez: Gunslinger", "344", "204450", Nothing, Nothing),
            New UplayBBDDEntrada("Child of Light", "609", "256290", Nothing, "https://i.imgur.com/Jthel8R.png"),
            New UplayBBDDEntrada("Cloudberry Kingdom", "436", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Cold Fear", "233", "15270", Nothing, "https://i.imgur.com/y7pFWkH.png"),
            New UplayBBDDEntrada("Driver Parallel Lines", "252", "21780", Nothing, "https://i.imgur.com/rlXaP9E.png"),
            New UplayBBDDEntrada("Driver San Francisco", "13", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Far Cry", "84", "13520", Nothing, "https://i.imgur.com/ne00bC4.png"),
            New UplayBBDDEntrada("Far Cry 2", "85", "19900", Nothing, "https://i.imgur.com/NHE8MU1.png"),
            New UplayBBDDEntrada("Far Cry 3", "46", "220240", Nothing, Nothing),
            New UplayBBDDEntrada("Far Cry 3 Blood Dragon", "205", "233270", Nothing, "https://i.imgur.com/jGNLMVM.png"),
            New UplayBBDDEntrada("Far Cry 4", "420", "298110", Nothing, Nothing),
            New UplayBBDDEntrada("Far Cry 4", "969", "298110", "Russia", Nothing),
            New UplayBBDDEntrada("Far Cry 5", "1803", "552520", Nothing, Nothing),
            New UplayBBDDEntrada("Far Cry New Dawn", "5210", "939960", Nothing, Nothing),
            New UplayBBDDEntrada("Far Cry Primal", "2010", "371660", Nothing, Nothing),
            New UplayBBDDEntrada("Flashback", "422", "245730", Nothing, "https://i.imgur.com/fqexho1.png"),
            New UplayBBDDEntrada("For Honor", "3458", "304390", Nothing, Nothing),
            New UplayBBDDEntrada("From Dust", "30", "33460", Nothing, "https://i.imgur.com/1vCKjpV.png"),
            New UplayBBDDEntrada("Grow Home", "1108", "323320", Nothing, "https://i.imgur.com/BqoGfXk.png"),
            New UplayBBDDEntrada("Grow Up", "3120", "426790", Nothing, "https://i.imgur.com/w9GZcHQ.jpg"),
            New UplayBBDDEntrada("Heroes of Might & Magic V", "87", "15170", Nothing, "https://i.imgur.com/9aFXwiT.png"),
            New UplayBBDDEntrada("Hyper Scape", "11957", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("I am Alive", "93", "214250", Nothing, "https://i.imgur.com/4YmaDPM.png"),
            New UplayBBDDEntrada("Just Dance 2017", "3130", "446560", Nothing, "https://i.imgur.com/p3oYRac.png"),
            New UplayBBDDEntrada("Mad Riders", "345", "208860", Nothing, Nothing),
            New UplayBBDDEntrada("Might & Magic: Heroes VI", "44", "48220", Nothing, "https://i.imgur.com/zqQz8Tf.png"),
            New UplayBBDDEntrada("Might & Magic: Heroes VII", "1176", "321960", Nothing, Nothing),
            New UplayBBDDEntrada("Might & Magic IX", "350", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Might & Magic X Legacy", "401", "238750", Nothing, "https://i.imgur.com/vWxyUz1.png"),
            New UplayBBDDEntrada("Prince of Persia: The Forgotten Sands", "11", "33320", Nothing, "https://i.imgur.com/KafMqz3.png"),
            New UplayBBDDEntrada("Prince of Persia: The Sands of Time", "111", "13600", Nothing, "https://i.imgur.com/vkmNHve.png"),
            New UplayBBDDEntrada("Prince of Persia: The Two Thrones", "113", "13530", Nothing, "https://i.imgur.com/pXokQun.png"),
            New UplayBBDDEntrada("Prince of Persia: Warrior Within", "121", "13500", Nothing, "https://i.imgur.com/Gz3AudR.jpg"),
            New UplayBBDDEntrada("Prince of Persia (2008)", "277", "19980", Nothing, "https://i.imgur.com/tGp5oBL.png"),
            New UplayBBDDEntrada("Rayman 2 The Great Escape", "361", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Rayman 3 Hoodlum Havoc", "360", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Rayman Legends", "410", "242550", Nothing, "https://i.imgur.com/urG5hjE.png"),
            New UplayBBDDEntrada("Rayman Origins", "80", "207490", Nothing, "https://i.imgur.com/gSQ9oeU.png"),
            New UplayBBDDEntrada("Rayman Raving Rabbids", "362", "15080", Nothing, "https://i.imgur.com/zFbXd7G.png"),
            New UplayBBDDEntrada("Rocksmith", "268", "205190", Nothing, "https://i.imgur.com/fOiPStM.png"),
            New UplayBBDDEntrada("Shaun White Skateboarding", "20", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("ShootMania Storm", "126", "229870", Nothing, Nothing),
            New UplayBBDDEntrada("Silent Hunter 5: Battle of the Atlantic", "3", "48110", Nothing, "https://i.imgur.com/cJTqmEs.png"),
            New UplayBBDDEntrada("South Park: The Fractured But Whole", "3088", "488790", Nothing, Nothing),
            New UplayBBDDEntrada("South Park: The Stick of Truth", "3584", "213670", Nothing, Nothing),
            New UplayBBDDEntrada("Space Junkies", "5056", "647590", Nothing, "https://i.imgur.com/RWdMRKd.png"),
            New UplayBBDDEntrada("Steep", "3279", "460920", Nothing, Nothing),
            New UplayBBDDEntrada("The Adventures of Tintin: The Game", "33", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("The Crew", "413", "241560", Nothing, "https://i.imgur.com/Dp2OAa6.jpg"),
            New UplayBBDDEntrada("The Crew", "507", "241560", "Russia", "https://i.imgur.com/Dp2OAa6.jpg"),
            New UplayBBDDEntrada("The Settlers - History Edition", "11662", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 2 - History Edition", "11783", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 3 - History Edition", "11784", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 4 - History Edition", "11785", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 5: Heritage of Kings - History Edition", "11786", "965300", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 6: Rise of an Empire - History Edition", "11787", "965310", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 7: Paths to a Kingdom - History Edition", "11788", "965320", Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's EndWar", "83", "21800", Nothing, "https://i.imgur.com/i72uxQ1.png"),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Advanced Warfighter", "94", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Advanced Warfighter 2", "114", "13510", Nothing, "https://i.imgur.com/913cgi2.png"),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Breakpoint", "11903", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Future Soldier", "53", "212630", Nothing, "https://i.imgur.com/nf8Xirs.png"),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Wildlands", "1771", "460930", Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's H.A.W.X. 2", "21", "48180", Nothing, "https://i.imgur.com/UxhCKOM.png"),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six: Lockdown", "358", "15000", Nothing, "https://i.imgur.com/Nur7DNR.png"),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six: Vegas", "88", "13540", Nothing, "https://i.imgur.com/3FX5Lzq.png"),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six: Vegas 2", "108", "15120", Nothing, "https://i.imgur.com/jz9Daos.png"),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six Siege", "635", "359550", Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell", "109", "13560", Nothing, "https://i.imgur.com/ld5p46S.png"),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Blacklist", "91", "235600", Nothing, "https://i.imgur.com/Nw0GMw0.png"),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Chaos Theory", "95", "13570", Nothing, "https://i.imgur.com/B0U1vFW.png"),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Conviction", "2", "33220", Nothing, "https://i.imgur.com/aC3KyBl.png"),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Double Agent", "110", "13580", Nothing, "https://i.imgur.com/bIOK3xo.png"),
            New UplayBBDDEntrada("Tom Clancy's The Division", "568", "365590", Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's The Division 2", "4932", "881280", Nothing, Nothing),
            New UplayBBDDEntrada("Trackmania", "5595", Nothing, Nothing, Nothing),
            New UplayBBDDEntrada("Trackmania Turbo", "2070", "375900", Nothing, Nothing),
            New UplayBBDDEntrada("TrackMania United Forever", "700", "7200", Nothing, Nothing),
            New UplayBBDDEntrada("TrackMania² Canyon", "127", "228760", Nothing, Nothing),
            New UplayBBDDEntrada("TrackMania² Stadium", "275", "232910", Nothing, Nothing),
            New UplayBBDDEntrada("TrackMania² Valley", "429", "243360", Nothing, Nothing),
            New UplayBBDDEntrada("Trials Evolution Gold Edition", "78", "220160", Nothing, "https://i.imgur.com/HKH4iSR.png"),
            New UplayBBDDEntrada("Trials Fusion", "297", "245490", Nothing, "https://i.imgur.com/6HVlfeX.png"),
            New UplayBBDDEntrada("Trials Rising", "3601", "641080", Nothing, Nothing),
            New UplayBBDDEntrada("Valiant Hearts: The Great War", "659", "260230", Nothing, "https://i.imgur.com/bt1yhsY.png"),
            New UplayBBDDEntrada("Voodoo Dice", "701", "48150", Nothing, "https://i.imgur.com/IXfiHIa.png"),
            New UplayBBDDEntrada("Watch_Dogs", "274", "243470", Nothing, "https://i.imgur.com/JY7QQlh.jpg"),
            New UplayBBDDEntrada("Watch_Dogs", "543", "243470", "Russia", "https://i.imgur.com/JY7QQlh.jpg"),
            New UplayBBDDEntrada("Watch_Dogs 2", "2688", "447040", Nothing, Nothing),
            New UplayBBDDEntrada("World In Conflict", "90", "21760", Nothing, "https://i.imgur.com/GvdaWUl.png"),
            New UplayBBDDEntrada("Zeit²", "340", "33390", Nothing, "https://i.imgur.com/1FbnTGZ.png"),
            New UplayBBDDEntrada("Zombi", "1653", "339230", Nothing, "https://i.imgur.com/v2RyfEO.png")
        }

        Return lista
    End Function

    Public Function Imagenes(id As String)

        Dim lista As New List(Of UplayBBDDImagenes) From {
            New UplayBBDDImagenes("4932", "https://steamcdn-a.akamaihd.net/steamcommunity/public/images/apps/881280/7de6ba91a570187d902d5f1afdca73198a22d592.jpg",
                                          "https://i.imgur.com/1CmXVBp.png",
                                          "https://steamcdn-a.akamaihd.net/steam/apps/881280/header.jpg?t=1528753864",
                                          "https://i.imgur.com/bM53mpb.png"),
            New UplayBBDDImagenes("2990", Nothing,
                                          "https://i.imgur.com/BOkjRPX.jpg",
                                          "https://i.imgur.com/Rr3JVP5.png",
                                          "https://i.imgur.com/ZNMsQTz.png"),
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
                                          "https://i.imgur.com/bZ2BIHI.png"),
            New UplayBBDDImagenes("33", Nothing,
                                          Nothing,
                                          "https://i.imgur.com/gsrnTGB.jpg",
                                          Nothing),
            New UplayBBDDImagenes("267", Nothing,
                                          Nothing,
                                          "https://i.imgur.com/DGONcLK.jpg",
                                          "https://i.imgur.com/str1G1w.png"),
            New UplayBBDDImagenes("11957", Nothing,
                                          "https://i.imgur.com/qO1LGtE.png",
                                          "https://i.imgur.com/JhheFUu.png",
                                          "https://i.imgur.com/6QkTo5h.png"),
            New UplayBBDDImagenes("345", Nothing,
                                          Nothing,
                                          "https://i.imgur.com/mNvHnOP.jpg",
                                          "https://i.imgur.com/0ih6OCF.png"),
            New UplayBBDDImagenes("350", Nothing,
                                          Nothing,
                                          "https://i.imgur.com/cjUW9bn.jpg",
                                          "https://i.imgur.com/30k6K6O.jpg"),
            New UplayBBDDImagenes("360", Nothing,
                                          Nothing,
                                          "https://i.imgur.com/JyUhADv.png",
                                          "https://i.imgur.com/zgWk0rf.png"),
            New UplayBBDDImagenes("361", Nothing,
                                          Nothing,
                                          "https://i.imgur.com/wf3xCLn.jpg",
                                          "https://i.imgur.com/AqqCB1c.png"),
            New UplayBBDDImagenes("436", Nothing,
                                          Nothing,
                                          "https://i.imgur.com/sv4a1sX.jpg",
                                          "https://i.imgur.com/ooOG0Pu.png"),
            New UplayBBDDImagenes("5595", Nothing,
                                          "https://i.imgur.com/RXTJUVK.png",
                                          "https://i.imgur.com/YJY0M1J.png",
                                          "https://i.imgur.com/GkHgTf5.png"),
            New UplayBBDDImagenes("94", Nothing,
                                          "https://i.imgur.com/NVVEyhB.png",
                                          "https://i.imgur.com/j3wrKEw.png",
                                          "https://i.imgur.com/7MlOio6.png")
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
        Public ImagenVertical As String

        Public Sub New(ByVal titulo As String, ByVal idUplay As String, ByVal idSteam As String, ByVal pais As String, ByVal imagenVertical As String)
            Me.Titulo = titulo
            Me.IDUplay = idUplay
            Me.IDSteam = idSteam
            Me.Pais = pais
            Me.ImagenVertical = imagenVertical
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
