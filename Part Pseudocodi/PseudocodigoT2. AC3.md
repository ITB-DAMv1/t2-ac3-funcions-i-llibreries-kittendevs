# Pseudocodi
         program Super4BestGame
        
        
        function Main()
        
        
        const
                string MsgErrorDades= “Les dades han sigut introduïdes incorrectament”;
                string MsgUserAvatar=”Tria el avatar!Has d'introduir un nombre entre 1 i 4.”;
                string MsgUserName=”Tria un nom, sense números, que com a mínim tingui 2 lletres i com màxim 25.”;
                string MsgMaldat=”Tria el teu nivell de maldat! Has d'introduir un nombre entre 1000 i 50000.”;
        char[] VocalesArray= [‘A’.’E’,’I’,’O’,’U’];
        string MaldatInvalid=”El nivel de maldat no està entre 1000 i 50000”;
        
        
        endconst
        
        
        var
        string userName;
        string[] userNameArray;
        int userAvatar = 0;
        int userMaldat=0;
        bool flag=false;
        int polsMagica=0;
        int numVocales = 0;
        endvar
        
        
        
        
                AvatarSelector(string userAvatar by ref, string MsgUserAvatar by ref);
                NameSelector(string MsgUserName by ref, string userName, string MsgErrorDades by ref);
                MaldatSelector(string MsgMaldat by ref, int userMaldat by ref);
                
                GameCore();
        
        
        endfunction
        
        
        function AvatarSelector()
        
        
        WriteLine(MsgUserAvatar);
        
        
        while !(userAvatar >= 1 && userAvatar <= 4)
                userAvatar = ConsoleRead();
        endwhile
        
        
        endfunction
        
        
        
        
        function NameSelector()
        
        
        WriteLIne(MsgUserName);
        
        
        do
        userName=Console.ReadLine;
        if(!(userName.Length>=2 && userName.Length<=25))
                Console.WriteLine(MsgErrorDades);
        while(userName.Length>=2 && userName.Length<=25)
        userName = ToCharArray(userNameArray)
        
        
        endfunction
        
        
        function MaldatSelector()
                
        ConsoleWriteLine(MsgMaldat);
        userMaldat = int.Parse.(Console.ReadLine());
        
        
        while ((userMaldat >50000)&&(userMaldat<1000)) do
        ConsoleWriteLine(MaldatInvalid);
        userMaldat = int.Parse.(Console.ReadLine());
                
        endfunction
        
        
        
        
        
        
        function GameCore()
        
        
        for (int i = 0; i < userNameArray.Length; i++)
                for (int n = 0; n < VocalesArray.Length; n++)
                        if (userNameArray[i] == VocalesArray[n])
                                numVocales = numVocales + 1;
                        endif
                endfor
        endfor
        
        
        if numVocales >= 2
                flag = true;
        endif
        
        
        if(flag)
        polsMagica=userMaldat/4;
        
        
        else
        polsMagica=((userMaldat*5)/100)/4
        
        
        endfunction
        
        
        
        
        
        
        endprogram
