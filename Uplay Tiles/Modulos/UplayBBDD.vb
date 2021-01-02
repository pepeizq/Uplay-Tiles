Module UplayBBDD

    'https://github.com/wTonyChen/Uplay-AppID-List/blob/master/UplayAppIDs.json

    Public Function Listado()

        Dim lista As New List(Of UplayBBDDEntrada) From {
            New UplayBBDDEntrada("Anno 1404", "89", "33250", Nothing),
            New UplayBBDDEntrada("Anno 1404 - History Edition", "16232", "1281630", Nothing),
            New UplayBBDDEntrada("Anno 1503 - History Edition", "16234", Nothing, Nothing),
            New UplayBBDDEntrada("Anno 1602", "2990", Nothing, Nothing),
            New UplayBBDDEntrada("Anno 1602 - History Edition", "16236", Nothing, Nothing),
            New UplayBBDDEntrada("Anno 1701 - History Edition", "16238", Nothing, Nothing),
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
            New UplayBBDDEntrada("Assassin's Creed III", "54", "208480", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "103"), New UplayBBDDPaisID("JP", "104"), New UplayBBDDPaisID("CZ", "105")}),
            New UplayBBDDEntrada("Assassin's Creed III Remastered", "5183", "911400", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "5184")}),
            New UplayBBDDEntrada("Assassin's Creed IV Black Flag", "273", "242050", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "441")}),
            New UplayBBDDEntrada("Assassin's Creed Liberation HD", "625", "260210", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "632")}),
            New UplayBBDDEntrada("Assassin's Creed Odyssey", "5059", "812140", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Origins", "3539", "582160", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Revelations", "40", "201870", Nothing),
            New UplayBBDDEntrada("Assassin's Creed Rogue", "895", "311560", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "1186")}),
            New UplayBBDDEntrada("Assassin's Creed Syndicate", "1875", "368500", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "1955")}),
            New UplayBBDDEntrada("Assassin's Creed Unity", "720", "289650", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "944")}),
            New UplayBBDDEntrada("Assassin's Creed Valhalla", "13504", Nothing, Nothing),
            New UplayBBDDEntrada("Atomega", "5060", "619880", Nothing),
            New UplayBBDDEntrada("Beyond Good and Evil", "232", "15130", Nothing),
            New UplayBBDDEntrada("Blazing Angels: Squadrons of WWII", "266", "15220", Nothing),
            New UplayBBDDEntrada("Blazing Angels 2: Secret Missions of WWII", "267", Nothing, Nothing),
            New UplayBBDDEntrada("Brothers in Arms: Earned in Blood", "271", "19800", Nothing),
            New UplayBBDDEntrada("Brothers in Arms: Hell's Highway", "272", "15390", Nothing),
            New UplayBBDDEntrada("Brothers in Arms: Road to Hill 30", "270", "15190", Nothing),
            New UplayBBDDEntrada("Call of Juarez: Bound in Blood", "112", "21980", Nothing),
            New UplayBBDDEntrada("Call of Juarez: Gunslinger", "344", "204450", Nothing),
            New UplayBBDDEntrada("Champions of Anteria", "825", "374520", Nothing),
            New UplayBBDDEntrada("Child of Light", "609", "256290", Nothing),
            New UplayBBDDEntrada("Cloudberry Kingdom", "436", Nothing, Nothing),
            New UplayBBDDEntrada("Cold Fear", "233", "15270", Nothing),
            New UplayBBDDEntrada("CSI: Hard Evidence", "682", "21730", Nothing),
            New UplayBBDDEntrada("Dark Messiah of Might and Magic", "269", "2100", Nothing),
            New UplayBBDDEntrada("Discovery Tour by Assassin’s Creed: Ancient Egypt", "5100", "775430", Nothing),
            New UplayBBDDEntrada("Discovery Tour by Assassin’s Creed: Ancient Greece", "5404", Nothing, Nothing),
            New UplayBBDDEntrada("Driv3r", "249", Nothing, Nothing),
            New UplayBBDDEntrada("Driver Parallel Lines", "252", "21780", Nothing),
            New UplayBBDDEntrada("Driver San Francisco", "13", Nothing, Nothing),
            New UplayBBDDEntrada("Far Cry", "84", "13520", Nothing),
            New UplayBBDDEntrada("Far Cry 2", "85", "19900", Nothing),
            New UplayBBDDEntrada("Far Cry 3", "46", "220240", Nothing),
            New UplayBBDDEntrada("Far Cry 3 Blood Dragon", "205", "233270", Nothing),
            New UplayBBDDEntrada("Far Cry 4", "420", "298110", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "969")}),
            New UplayBBDDEntrada("Far Cry 5", "1803", "552520", Nothing),
            New UplayBBDDEntrada("Far Cry New Dawn", "5210", "939960", Nothing),
            New UplayBBDDEntrada("Far Cry Primal", "2010", "371660", Nothing),
            New UplayBBDDEntrada("Flashback", "422", "245730", Nothing),
            New UplayBBDDEntrada("For Honor", "3458", "304390", Nothing),
            New UplayBBDDEntrada("From Dust", "30", "33460", Nothing),
            New UplayBBDDEntrada("Grow Home", "1108", "323320", Nothing),
            New UplayBBDDEntrada("Grow Up", "3120", "426790", Nothing),
            New UplayBBDDEntrada("Heroes of Might & Magic", "351", Nothing, Nothing),
            New UplayBBDDEntrada("Heroes of Might & Magic 2", "352", Nothing, Nothing),
            New UplayBBDDEntrada("Heroes of Might & Magic 3 Complete Edition", "353", Nothing, Nothing),
            New UplayBBDDEntrada("Heroes of Might & Magic V", "87", "15170", Nothing),
            New UplayBBDDEntrada("Hyper Scape", "11957", Nothing, Nothing),
            New UplayBBDDEntrada("I am Alive", "93", "214250", Nothing),
            New UplayBBDDEntrada("Immortals Fenyx Rising", "5405", Nothing, Nothing),
            New UplayBBDDEntrada("Just Dance 2017", "3130", "446560", Nothing),
            New UplayBBDDEntrada("Mad Riders", "345", "208860", Nothing),
            New UplayBBDDEntrada("Might & Magic: Chess Royale", "5613", Nothing, Nothing),
            New UplayBBDDEntrada("Might & Magic: Heroes VI", "44", "48220", Nothing),
            New UplayBBDDEntrada("Might & Magic: Heroes VII", "1176", "321960", Nothing),
            New UplayBBDDEntrada("Might & Magic IX", "350", Nothing, Nothing),
            New UplayBBDDEntrada("Might & Magic X Legacy", "401", "238750", Nothing),
            New UplayBBDDEntrada("Monopoly Plus", "3774", "562810", Nothing),
            New UplayBBDDEntrada("Ode", "9797", Nothing, Nothing),
            New UplayBBDDEntrada("Petz Catz 2", "691", Nothing, Nothing),
            New UplayBBDDEntrada("Petz Dogz 2", "692", Nothing, Nothing),
            New UplayBBDDEntrada("Petz Horsez 2", "693", "15160", Nothing),
            New UplayBBDDEntrada("Prince of Persia: The Forgotten Sands", "11", "33320", Nothing),
            New UplayBBDDEntrada("Prince of Persia: The Sands of Time", "111", "13600", Nothing),
            New UplayBBDDEntrada("Prince of Persia: The Two Thrones", "113", "13530", Nothing),
            New UplayBBDDEntrada("Prince of Persia: Warrior Within", "121", "13500", Nothing),
            New UplayBBDDEntrada("Prince of Persia (2008)", "277", "19980", Nothing),
            New UplayBBDDEntrada("Rayman 1 Forever", "2968", Nothing, Nothing),
            New UplayBBDDEntrada("Rayman 2 The Great Escape", "361", Nothing, Nothing),
            New UplayBBDDEntrada("Rayman 3 Hoodlum Havoc", "360", Nothing, Nothing),
            New UplayBBDDEntrada("Rayman Legends", "410", "242550", Nothing),
            New UplayBBDDEntrada("Rayman Origins", "80", "207490", Nothing),
            New UplayBBDDEntrada("Rayman Raving Rabbids", "362", "15080", Nothing),
            New UplayBBDDEntrada("Rocksmith", "268", "205190", Nothing),
            New UplayBBDDEntrada("Rocksmith 2014", "301", "221680", Nothing),
            New UplayBBDDEntrada("Shaun White Skateboarding", "20", Nothing, Nothing),
            New UplayBBDDEntrada("ShootMania Storm", "126", "229870", Nothing),
            New UplayBBDDEntrada("Silent Hunter 2", "2988", Nothing, Nothing),
            New UplayBBDDEntrada("Silent Hunter 3", "292", "15210", Nothing),
            New UplayBBDDEntrada("Silent Hunter 4: Wolves of the Pacific", "698", "15200", Nothing),
            New UplayBBDDEntrada("Silent Hunter 5: Battle of the Atlantic", "3", "48110", Nothing),
            New UplayBBDDEntrada("South Park: The Fractured But Whole", "3088", "488790", Nothing),
            New UplayBBDDEntrada("South Park: The Stick of Truth", "3584", "213670", Nothing),
            New UplayBBDDEntrada("Starlink: Battle for Atlas", "5277", "950050", Nothing),
            New UplayBBDDEntrada("Space Junkies", "5056", "647590", Nothing),
            New UplayBBDDEntrada("Steep", "3279", "460920", Nothing),
            New UplayBBDDEntrada("The Adventures of Tintin: The Game", "33", Nothing, Nothing),
            New UplayBBDDEntrada("The Crew", "413", "241560", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "507")}),
            New UplayBBDDEntrada("The Crew 2", "2855", "646910", Nothing),
            New UplayBBDDEntrada("The Expendables 2 Videogame", "346", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers - History Edition", "11662", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 2 - History Edition", "11783", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 3 - History Edition", "11784", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 4 - History Edition", "11785", Nothing, Nothing),
            New UplayBBDDEntrada("The Settlers 5: Heritage of Kings - History Edition", "11786", "965300", Nothing),
            New UplayBBDDEntrada("The Settlers 6: Rise of an Empire - History Edition", "11787", "965310", Nothing),
            New UplayBBDDEntrada("The Settlers 7: Paths to a Kingdom - History Edition", "11788", "965320", Nothing),
            New UplayBBDDEntrada("Tom Clancy's EndWar", "83", "21800", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon", "2297", "15300", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Advanced Warfighter", "94", Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Advanced Warfighter 2", "114", "13510", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Breakpoint", "11903", Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Future Soldier", "53", "212630", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Ghost Recon Wildlands", "1771", "460930", Nothing),
            New UplayBBDDEntrada("Tom Clancy's H.A.W.X. 2", "21", "48180", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six", "2298", Nothing, Nothing),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six 3", "2235", "19830", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six: Lockdown", "358", "15000", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six: Vegas", "88", "13540", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six: Vegas 2", "108", "15120", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Rainbow Six Siege", "635", "359550", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "1842")}),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell", "109", "13560", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Blacklist", "91", "235600", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Chaos Theory", "95", "13570", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Conviction", "2", "33220", Nothing),
            New UplayBBDDEntrada("Tom Clancy's Splinter Cell: Double Agent", "110", "13580", Nothing),
            New UplayBBDDEntrada("Tom Clancy's The Division", "568", "365590", Nothing),
            New UplayBBDDEntrada("Tom Clancy's The Division 2", "4932", Nothing, Nothing),
            New UplayBBDDEntrada("Trackmania", "5595", Nothing, Nothing),
            New UplayBBDDEntrada("Trackmania Turbo", "2070", "375900", Nothing),
            New UplayBBDDEntrada("TrackMania United Forever", "700", "7200", Nothing),
            New UplayBBDDEntrada("TrackMania² Canyon", "127", "228760", Nothing),
            New UplayBBDDEntrada("TrackMania² Stadium", "275", "232910", Nothing),
            New UplayBBDDEntrada("TrackMania² Valley", "429", "243360", Nothing),
            New UplayBBDDEntrada("Transference", "10871", "647570", Nothing),
            New UplayBBDDEntrada("Trials Evolution Gold Edition", "78", "220160", Nothing),
            New UplayBBDDEntrada("Trials Fusion", "297", "245490", Nothing),
            New UplayBBDDEntrada("Trials of the Blood Dragon", "2741", "435480", Nothing),
            New UplayBBDDEntrada("Trials Rising", "3601", "641080", Nothing),
            New UplayBBDDEntrada("UNO", "3352", "470220", Nothing),
            New UplayBBDDEntrada("Valiant Hearts: The Great War", "659", "260230", Nothing),
            New UplayBBDDEntrada("Voodoo Dice", "701", "48150", Nothing),
            New UplayBBDDEntrada("Warlords Battlecry", "3053", Nothing, Nothing),
            New UplayBBDDEntrada("Warlords Battlecry 2", "3054", Nothing, Nothing),
            New UplayBBDDEntrada("Watch_Dogs", "274", "243470", New List(Of UplayBBDDPaisID) From {New UplayBBDDPaisID("RU", "543")}),
            New UplayBBDDEntrada("Watch_Dogs 2", "2688", "447040", Nothing),
            New UplayBBDDEntrada("Watch Dogs Legion", "3353", Nothing, Nothing),
            New UplayBBDDEntrada("World In Conflict", "90", "21760", Nothing),
            New UplayBBDDEntrada("Zeit²", "340", "33390", Nothing),
            New UplayBBDDEntrada("Zombi", "1653", "339230", Nothing)
        }

        Return lista
    End Function

    Public Class UplayBBDDEntrada

        Public Titulo As String
        Public IDUplay As String
        Public IDSteam As String
        Public IDUplayOtrosPaises As List(Of UplayBBDDPaisID)

        Public Sub New(ByVal titulo As String, ByVal idUplay As String, ByVal idSteam As String, ByVal idUplayOtrosPaises As List(Of UplayBBDDPaisID))
            Me.Titulo = titulo
            Me.IDUplay = idUplay
            Me.IDSteam = idSteam
            Me.IDUplayOtrosPaises = idUplayOtrosPaises
        End Sub

    End Class

    Public Class UplayBBDDPaisID

        Public Pais As String
        Public ID As String

        Public Sub New(ByVal pais As String, ByVal id As String)
            Me.Pais = pais
            Me.ID = id
        End Sub

    End Class

End Module
