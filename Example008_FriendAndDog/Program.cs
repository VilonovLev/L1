Console.Clear();
int count = 0,
    firstFriendS = 1, 
    secondFriendS = 2,
    dogS = 5,
    distanse = 10000,
    friend = 2, // Маркер направления движения
    time = 0;

    while(distanse > 5)
    {
        if (firstFriendS == 1)
        {
            time = distanse / (firstFriendS + dogS);
            friend = 1;
        }
        else
        {
            time = distanse / (secondFriendS + dogS);
            friend = 2;
        }
        
        distanse = distanse - (firstFriendS + secondFriendS) * time;
        count++;
    }

    Console.Write("Собака успела пробежать " + count + " раз.");