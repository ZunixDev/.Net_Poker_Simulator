
Module Functions

#Region "Printing"

    Public Function printMenu()
        Console.WriteLine("")
        fcRed()
        Console.WriteLine("   +-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+ ")
        Console.WriteLine("   +                                                                        + ")
        Console.WriteLine("   +   .Net_Poker - Poker & Cards Engine Developed in VB.Net by ZunixDev    + ")
        Console.WriteLine("   +                                                                        + ")
        Console.WriteLine("   +-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-++-+-+-+-+-+ ")
        fcWhite()
        Console.WriteLine("")
        Console.WriteLine("                    * * * * * * * * * * * * * * * * * * * * *")
        Console.WriteLine("                    *                                       *")
        Console.WriteLine("                    *     1. Generate A Hand                *")
        Console.WriteLine("                    *     2. Show Hand                      *")
        Console.WriteLine("                    *     3. Hand Information               *")
        Console.WriteLine("                    *     4. List All Availible Strings     *")
        Console.WriteLine("                    *     5. List All Availible Integers    *")
        Console.WriteLine("                    *                                       *")
        Console.WriteLine("                    * * * * * * * * * * * * * * * * * * * * *")
        Console.WriteLine("")
        fcYellow()
    End Function
    Public Function printInfo()
        Console.WriteLine("")
        fcRed()
        Console.WriteLine("       Total Number of Hearts: " & hasHearts)
        Console.WriteLine("       Total Number of Clubss: " & hasClubs)
        Console.WriteLine("       Total Number of Spades: " & hasSpades)
        Console.WriteLine("       Total Number of Diamonds: " & hasDiamonds)
        Console.WriteLine("       Total Number of Twos: " & hasTwos)
        Console.WriteLine("       Total Number of Threes: " & hasThrees)
        Console.WriteLine("       Total Number of Fours: " & hasFours)
        Console.WriteLine("       Total Number of Fives: " & hasFives)
        Console.WriteLine("       Total Number of Sixes: " & hasSixes)
        Console.WriteLine("       Total Number of Sevens: " & hasSevens)
        Console.WriteLine("       Total Number of Eights: " & hasEights)
        Console.WriteLine("       Total Number of Nines: " & hasNines)
        Console.WriteLine("       Total Number of Tens: " & hasTens)
        Console.WriteLine("       Total Number of Jacks: " & hasJacks)
        Console.WriteLine("       Total Number of Queens: " & hasQueens)
        Console.WriteLine("       Total Number of Kings: " & hasKings)
        Console.WriteLine("       Total Number of Aces: " & hasAces)
        valueHand()
        printNumeric()
        Console.WriteLine("")
        fcYellow()
    End Function
    Public Function printHand()
        fcRed()
        Console.WriteLine("")
        Console.WriteLine("       Card 1: " & card1)
        Console.WriteLine("       Card 2: " & card2)
        Console.WriteLine("       Card 3: " & card3)
        Console.WriteLine("       Card 4: " & card4)
        Console.WriteLine("       Card 5: " & card5)
        Console.WriteLine("")
        fcYellow()
    End Function
    Public Function printNumeric()
        Console.WriteLine("       The Numric Value of your Hand is: (" & handNumericValue & ")")
    End Function

#End Region

#Region "Dealing & Swapping"

    Public Function dealCards()
        Console.WriteLine("")
        resetStats()
        fcGreen()
        Console.WriteLine(custDT + ">> Previous Stats Reset.")
        generateCard1()
        generatecard2()
        generatecard3()
        generatecard4()
        generatecard5()
        Console.WriteLine(custDT + ">> Cards Successfully Generated.")
        C1calcSuits()
        C2calcSuits()
        C3calcSuits()
        C4calcSuits()
        C5calcSuits()
        Console.WriteLine(custDT + ">> Card Suits Successfully Calculated.")
        C1calcNums()
        C2calcNums()
        C3calcNums()
        C4calcNums()
        C5calcNums()
        Console.WriteLine(custDT + ">> Card Numbers Successfully Calculated.")
        checkPairs()
        checkTwoPairs()
        checkThreeOfaKind()
        checkStraight()
        checkFlush()
        checkFullHouse()
        checkFourOfaKind()
        checkStraightFlush()
        checkRoyalFlush()
        Console.WriteLine(custDT + ">> Hand Successfully Valued")
        fcGreen()        Console.WriteLine(custDT + ">> Deck Successfully Generated")
        fcWhite()
        Console.WriteLine("")
        fcYellow()
    End Function
    Public Function swapCard1()
        generateCard1()
        C1calcSuits()
        C1calcNums()
        checkPairs()
        checkTwoPairs()
        checkThreeOfaKind()
        checkStraight()
        checkFlush()
        checkFullHouse()
        checkFourOfaKind()
        checkStraightFlush()
        checkRoyalFlush()
    End Function
    Public Function swapCard2()
        generatecard2()
        C2calcSuits()
        C2calcNums()
        checkPairs()
        checkTwoPairs()
        checkThreeOfaKind()
        checkStraight()
        checkFlush()
        checkFullHouse()
        checkFourOfaKind()
        checkStraightFlush()
        checkRoyalFlush()
    End Function
    Public Function swapCard3()
        generatecard3()
        C3calcSuits()
        C3calcNums()
        checkPairs()
        checkTwoPairs()
        checkThreeOfaKind()
        checkStraight()
        checkFlush()
        checkFullHouse()
        checkFourOfaKind()
        checkStraightFlush()
        checkRoyalFlush()
    End Function
    Public Function swapCard4()
        generatecard4()
        C4calcSuits()
        C4calcNums()
        checkPairs()
        checkTwoPairs()
        checkThreeOfaKind()
        checkStraight()
        checkFlush()
        checkFullHouse()
        checkFourOfaKind()
        checkStraightFlush()
        checkRoyalFlush()
    End Function
    Public Function swapCard5()
        generatecard5()
        C5calcSuits()
        C5calcNums()
        checkPairs()
        checkTwoPairs()
        checkThreeOfaKind()
        checkStraight()
        checkFlush()
        checkFullHouse()
        checkFourOfaKind()
        checkStraightFlush()
        checkRoyalFlush()
    End Function

#End Region

#Region "Listing"

    Public Function listCommands()
        Console.WriteLine("")
        fcGreen()
        Console.WriteLine("                    * * * * * * * * * * * * * * * * * * * * *")
        Console.WriteLine("                    *                                       *")
        Console.WriteLine("                    *     1. Generate A Hand                *")
        Console.WriteLine("                    *     2. Show Hand                      *")
        Console.WriteLine("                    *     3. Hand Information               *")
        Console.WriteLine("                    *     4. List All Availible Strings     *")
        Console.WriteLine("                    *     5. List All Availible Integers    *")
        Console.WriteLine("                    *                                       *")
        Console.WriteLine("                    * * * * * * * * * * * * * * * * * * * * *")
        fcYellow()
        Console.WriteLine("")
    End Function
    Public Function listAllStrings()
        Console.WriteLine("")
        fcGreen()
        Console.WriteLine("Current Strings Are: ")
        fcWhite()
        Console.WriteLine(csl)
        Console.WriteLine("")
        fcYellow()
    End Function
    Public Function listAllIntegers()
        Console.WriteLine("")
        fcGreen()
        Console.WriteLine("Current Integers Are: ")
        fcWhite()
        Console.WriteLine(cil)
        Console.WriteLine("")
        fcYellow()
    End Function

#End Region

#Region "Generating & Calculating"

    Public Function generateCard1()
        card1_Num = myRnd.Next(0, 12) 'both as integers
        card1_Suit = myRnd.Next(0, 3) 'both as integers
        card1 = Cardnums(card1_Num) & ":" & Cardsuits(card1_Suit)
        checkDuplicates()
    End Function
    Public Function generatecard2()
        card2_Num = myRnd.Next(0, 12) 'both as integers
        card2_Suit = myRnd.Next(0, 3) 'both as integers
        card2 = Cardnums(card2_Num) & ":" & Cardsuits(card2_Suit)
        checkDuplicates()
    End Function
    Public Function generatecard3()
        card3_Num = myRnd.Next(0, 12) 'both as integers
        card3_Suit = myRnd.Next(0, 3) 'both as integers
        card3 = Cardnums(card3_Num) & ":" & Cardsuits(card3_Suit)
        checkDuplicates()
    End Function
    Public Function generatecard4()
        card4_Num = myRnd.Next(0, 12) 'both as integers
        card4_Suit = myRnd.Next(0, 3) 'both as integers
        card4 = Cardnums(card4_Num) & ":" & Cardsuits(card4_Suit)
        checkDuplicates()
    End Function
    Public Function generatecard5()
        card5_Num = myRnd.Next(0, 12) 'both as integers
        card5_Suit = myRnd.Next(0, 3) 'both as integers
        card5 = Cardnums(card5_Num) & ":" & Cardsuits(card5_Suit)
        checkDuplicates()
    End Function
    Public Function C1calcSuits()
        If card1_Suit = 0 Then hasSpades = hasSpades + 1
        If card1_Suit = 1 Then hasClubs = hasClubs + 1
        If card1_Suit = 2 Then hasHearts = hasHearts + 1
        If card1_Suit = 3 Then hasDiamonds = hasDiamonds + 1
    End Function
    Public Function C2calcSuits()
        If card2_Suit = 0 Then hasSpades = hasSpades + 1
        If card2_Suit = 1 Then hasClubs = hasClubs + 1
        If card2_Suit = 2 Then hasHearts = hasHearts + 1
        If card2_Suit = 3 Then hasDiamonds = hasDiamonds + 1
    End Function
    Public Function C3calcSuits()
        If card3_Suit = 0 Then hasSpades = hasSpades + 1
        If card3_Suit = 1 Then hasClubs = hasClubs + 1
        If card3_Suit = 2 Then hasHearts = hasHearts + 1
        If card3_Suit = 3 Then hasDiamonds = hasDiamonds + 1
    End Function
    Public Function C4calcSuits()
        If card4_Suit = 0 Then hasSpades = hasSpades + 1
        If card4_Suit = 1 Then hasClubs = hasClubs + 1
        If card4_Suit = 2 Then hasHearts = hasHearts + 1
        If card4_Suit = 3 Then hasDiamonds = hasDiamonds + 1
    End Function
    Public Function C5calcSuits()
        If card5_Suit = 0 Then hasSpades = hasSpades + 1
        If card5_Suit = 1 Then hasClubs = hasClubs + 1
        If card5_Suit = 2 Then hasHearts = hasHearts + 1
        If card5_Suit = 3 Then hasDiamonds = hasDiamonds + 1
    End Function
    Public Function C1calcNums()
        If card1_Num = 0 Then hasTwos = hasTwos + 1
        If card1_Num = 1 Then hasThrees = hasThrees + 1
        If card1_Num = 2 Then hasFours = hasFours + 1
        If card1_Num = 3 Then hasFives = hasFives + 1
        If card1_Num = 4 Then hasSixes = hasSixes + 1
        If card1_Num = 5 Then hasSevens = hasSevens + 1
        If card1_Num = 6 Then hasEights = hasEights + 1
        If card1_Num = 7 Then hasNines = hasNines + 1
        If card1_Num = 8 Then hasTens = hasTens + 1
        If card1_Num = 9 Then hasJacks = hasJacks + 1
        If card1_Num = 10 Then hasQueens = hasQueens + 1
        If card1_Num = 11 Then hasKings = hasKings + 1
        If card1_Num = 12 Then hasAces = hasAces + 1
    End Function
    Public Function C2calcNums()
        If card2_Num = 0 Then hasTwos = hasTwos + 1
        If card2_Num = 1 Then hasThrees = hasThrees + 1
        If card2_Num = 2 Then hasFours = hasFours + 1
        If card2_Num = 3 Then hasFives = hasFives + 1
        If card2_Num = 4 Then hasSixes = hasSixes + 1
        If card2_Num = 5 Then hasSevens = hasSevens + 1
        If card2_Num = 6 Then hasEights = hasEights + 1
        If card2_Num = 7 Then hasNines = hasNines + 1
        If card2_Num = 8 Then hasTens = hasTens + 1
        If card2_Num = 9 Then hasJacks = hasJacks + 1
        If card2_Num = 10 Then hasQueens = hasQueens + 1
        If card2_Num = 11 Then hasKings = hasKings + 1
        If card2_Num = 12 Then hasAces = hasAces + 1
    End Function
    Public Function C3calcNums()
        If card3_Num = 0 Then hasTwos = hasTwos + 1
        If card3_Num = 1 Then hasThrees = hasThrees + 1
        If card3_Num = 2 Then hasFours = hasFours + 1
        If card3_Num = 3 Then hasFives = hasFives + 1
        If card3_Num = 4 Then hasSixes = hasSixes + 1
        If card3_Num = 5 Then hasSevens = hasSevens + 1
        If card3_Num = 6 Then hasEights = hasEights + 1
        If card3_Num = 7 Then hasNines = hasNines + 1
        If card3_Num = 8 Then hasTens = hasTens + 1
        If card3_Num = 9 Then hasJacks = hasJacks + 1
        If card3_Num = 10 Then hasQueens = hasQueens + 1
        If card3_Num = 11 Then hasKings = hasKings + 1
        If card3_Num = 12 Then hasAces = hasAces + 1
    End Function
    Public Function C4calcNums()
        If card4_Num = 0 Then hasTwos = hasTwos + 1
        If card4_Num = 1 Then hasThrees = hasThrees + 1
        If card4_Num = 2 Then hasFours = hasFours + 1
        If card4_Num = 3 Then hasFives = hasFives + 1
        If card4_Num = 4 Then hasSixes = hasSixes + 1
        If card4_Num = 5 Then hasSevens = hasSevens + 1
        If card4_Num = 6 Then hasEights = hasEights + 1
        If card4_Num = 7 Then hasNines = hasNines + 1
        If card4_Num = 8 Then hasTens = hasTens + 1
        If card4_Num = 9 Then hasJacks = hasJacks + 1
        If card4_Num = 10 Then hasQueens = hasQueens + 1
        If card4_Num = 11 Then hasKings = hasKings + 1
        If card4_Num = 12 Then hasAces = hasAces + 1
    End Function
    Public Function C5calcNums()
        If card5_Num = 0 Then hasTwos = hasTwos + 1
        If card5_Num = 1 Then hasThrees = hasThrees + 1
        If card5_Num = 2 Then hasFours = hasFours + 1
        If card5_Num = 3 Then hasFives = hasFives + 1
        If card5_Num = 4 Then hasSixes = hasSixes + 1
        If card5_Num = 5 Then hasSevens = hasSevens + 1
        If card5_Num = 6 Then hasEights = hasEights + 1
        If card5_Num = 7 Then hasNines = hasNines + 1
        If card5_Num = 8 Then hasTens = hasTens + 1
        If card5_Num = 9 Then hasJacks = hasJacks + 1
        If card5_Num = 10 Then hasQueens = hasQueens + 1
        If card5_Num = 11 Then hasKings = hasKings + 1
        If card5_Num = 12 Then hasAces = hasAces + 1
    End Function
    Public Function checkDuplicates()
        If card1 = card2 Then generateCard1()
        If card1 = card3 Then generateCard1()
        If card1 = card4 Then generateCard1()
        If card1 = card5 Then generateCard1()
        If card2 = card3 Then generatecard2()
        If card2 = card4 Then generatecard2()
        If card2 = card5 Then generatecard2()
        If card3 = card4 Then generatecard3()
        If card3 = card5 Then generatecard3()
        If card4 = card5 Then generatecard4()
    End Function
    Public Function resetStats()
        handNumericValue = 0
        handValue = 0
        hasHearts = 0
        hasClubs = 0
        hasSpades = 0
        hasDiamonds = 0
        hasTwos = 0
        hasThrees = 0
        hasFours = 0
        hasFives = 0
        hasSixes = 0
        hasSevens = 0
        hasEights = 0
        hasNines = 0
        hasTens = 0
        hasJacks = 0
        hasQueens = 0
        hasKings = 0
        hasAces = 0
        hasPair = False
        hasTwoPairs = False
        hasThreeOfaKind = False
        hasStraight = False
        hasFlush = False
        hasFullHouse = False
        hasFourOfAKind = False
        hasStraightFlush = False
        hasRoyalFlush = False
    End Function

#End Region

#Region "Value Hand"

    Public Function checkPairs()
        If hasTwos = 2 Then
            hasPair = True
            pairNum = "Twos"
        End If
        If hasThrees = 2 Then
            hasPair = True
            pairNum = "Threes"
        End If
        If hasFours = 2 Then
            hasPair = True
            pairNum = "Fours"
        End If
        If hasFives = 2 Then
            hasPair = True
            pairNum = "Fives"
        End If
        If hasSixes = 2 Then
            hasPair = True
            pairNum = "Sixes"
        End If
        If hasSevens = 2 Then
            hasPair = True
            pairNum = "Sevens"
        End If
        If hasEights = 2 Then
            hasPair = True
            pairNum = "Eights"
        End If
        If hasNines = 2 Then
            hasPair = True
            pairNum = "Nines"
        End If
        If hasTens = 2 Then
            hasPair = True
            pairNum = "Tens"
        End If
        If hasJacks = 2 Then
            hasPair = True
            pairNum = "Jacks"
        End If
        If hasQueens = 2 Then
            hasPair = True
            pairNum = "Queens"
        End If
        If hasKings = 2 Then
            hasPair = True
            pairNum = "Kings"
        End If
        If hasAces = 2 Then
            hasPair = True
            pairNum = "Aces"
        End If
    End Function
    Public Function checkTwoPairs()

        If hasTwos = 2 Then 'Base Pair
            pairNum = "Twos"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasThrees = 2 Then 'Base Pair
            pairNum = "Threes"
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasFours = 2 Then 'Base Pair
            pairNum = "Fours"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasFives = 2 Then 'Base Pair
            pairNum = "Fives"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasSixes = 2 Then 'Base Pair
            pairNum = "Sixes"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasSevens = 2 Then 'Base Pair
            pairNum = "Sevens"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasEights = 2 Then 'Base Pair
            pairNum = "Eights"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasNines = 2 Then 'Base Pair
            pairNum = "Nines"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasTens = 2 Then 'Base Pair
            pairNum = "Tens"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasJacks = 2 Then 'Base Pair
            pairNum = "Jacks"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasQueens = 2 Then 'Base Pair
            pairNum = "Queens"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasKings = 2 Then 'Base Pair
            pairNum = "Kings"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
            If hasAces = 2 Then
                hasTwoPairs = True
                pairSecNum = "Aces"
            End If
        End If

        If hasAces = 2 Then 'Base Pair
            pairNum = "Aces"
            If hasThrees = 2 Then
                hasTwoPairs = True
                pairSecNum = "Threes"
            End If
            If hasFours = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fours"
            End If
            If hasFives = 2 Then
                hasTwoPairs = True
                pairSecNum = "Fives"
            End If
            If hasSixes = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sixes"
            End If
            If hasSevens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Sevens"
            End If
            If hasEights = 2 Then
                hasTwoPairs = True
                pairSecNum = "Eights"
            End If
            If hasNines = 2 Then
                hasTwoPairs = True
                pairSecNum = "Nines"
            End If
            If hasTens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Ten"
            End If
            If hasJacks = 2 Then
                hasTwoPairs = True
                pairSecNum = "Jacks"
            End If
            If hasQueens = 2 Then
                hasTwoPairs = True
                pairSecNum = "Queens"
            End If
            If hasKings = 2 Then
                hasTwoPairs = True
                pairSecNum = "Kings"
            End If
            If hasTwos = 2 Then
                hasTwoPairs = True
                pairSecNum = "Twos"
            End If
        End If


        'If hasAces = 2 Then
        '    pairNum = "Aces"
        '    If hasThrees = 2 Then hasTwoPairs = True & pairSecNum = "Threes"
        '    If hasFours = 2 Then hasTwoPairs = True & pairSecNum = "Fours"
        '    If hasFives = 2 Then hasTwoPairs = True & pairSecNum = "Fives"
        '    If hasSixes = 2 Then hasTwoPairs = True & pairSecNum = "Sixes"
        '    If hasSevens = 2 Then hasTwoPairs = True & pairSecNum = "Sevens"
        '    If hasEights = 2 Then hasTwoPairs = True & pairSecNum = "Eights"
        '    If hasNines = 2 Then hasTwoPairs = True & pairSecNum = "Nines"
        '    If hasTens = 2 Then hasTwoPairs = True & pairSecNum = "Ten"
        '    If hasJacks = 2 Then hasTwoPairs = True & pairSecNum = "Jacks"
        '    If hasQueens = 2 Then hasTwoPairs = True & pairSecNum = "Queens"
        '    If hasKings = 2 Then hasTwoPairs = True & pairSecNum = "Kings"
        '    If hasTwos = 2 Then hasTwoPairs = True & pairSecNum = "Twos"
        'End If
    End Function
    Public Function checkThreeOfaKind()
        If hasTwos = 3 Then
            hasThreeOfaKind = True
            pairNum = "Two"
        End If
        If hasThrees = 3 Then
            hasThreeOfaKind = True
            pairNum = "Threes"
        End If
        If hasFours = 3 Then
            hasThreeOfaKind = True
            pairNum = "Fours"
        End If
        If hasFives = 3 Then
            hasThreeOfaKind = True
            pairNum = "Fives"
        End If
        If hasSixes = 3 Then
            hasThreeOfaKind = True
            pairNum = "Sixes"
        End If
        If hasSevens = 3 Then
            hasThreeOfaKind = True
            pairNum = "Sevens"
        End If
        If hasEights = 3 Then
            hasThreeOfaKind = True
            pairNum = "Eights"
        End If
        If hasNines = 3 Then
            hasThreeOfaKind = True
            pairNum = "Nines"
        End If
        If hasTens = 3 Then
            hasThreeOfaKind = True
            pairNum = "Tens"
        End If
        If hasJacks = 3 Then
            hasThreeOfaKind = True
            pairNum = "Jacks"
        End If
        If hasQueens = 3 Then
            hasThreeOfaKind = True
            pairNum = "Queens"
        End If
        If hasKings = 3 Then
            hasThreeOfaKind = True
            pairNum = "Kings"
        End If
        If hasAces = 3 Then
            hasThreeOfaKind = True
            pairNum = "Aces"
        End If
    End Function
    Public Function checkStraight()
        combNumsString = Cardnums(card1_Num) + "$" + Cardnums(card2_Num) + "$" + Cardnums(card3_Num) + "$" + Cardnums(card4_Num) + "$" + Cardnums(card5_Num) + "$"
        If combNumsString.Contains("Two$") Then
            If combNumsString.Contains("Three$") Then
                If combNumsString.Contains("Four$") Then
                    If combNumsString.Contains("Five$") Then
                        If combNumsString.Contains("Six$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
        If combNumsString.Contains("Three$") Then
            If combNumsString.Contains("Four$") Then
                If combNumsString.Contains("Five$") Then
                    If combNumsString.Contains("Six$") Then
                        If combNumsString.Contains("Seven$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
        If combNumsString.Contains("Four$") Then
            If combNumsString.Contains("Five$") Then
                If combNumsString.Contains("Six$") Then
                    If combNumsString.Contains("Seven$") Then
                        If combNumsString.Contains("Eight$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
        If combNumsString.Contains("Five$") Then
            If combNumsString.Contains("Six$") Then
                If combNumsString.Contains("Seven$") Then
                    If combNumsString.Contains("Eight$") Then
                        If combNumsString.Contains("Nine$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
        If combNumsString.Contains("Six$") Then
            If combNumsString.Contains("Seven$") Then
                If combNumsString.Contains("Eight$") Then
                    If combNumsString.Contains("Nine$") Then
                        If combNumsString.Contains("Ten$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
        If combNumsString.Contains("Seven$") Then
            If combNumsString.Contains("Eight") Then
                If combNumsString.Contains("Nine$") Then
                    If combNumsString.Contains("Ten$") Then
                        If combNumsString.Contains("Jack$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
        If combNumsString.Contains("Eight$") Then
            If combNumsString.Contains("Nine$") Then
                If combNumsString.Contains("Ten$") Then
                    If combNumsString.Contains("Jack$") Then
                        If combNumsString.Contains("Queen$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
        If combNumsString.Contains("Nine$") Then
            If combNumsString.Contains("Ten$") Then
                If combNumsString.Contains("Jack$") Then
                    If combNumsString.Contains("Queen$") Then
                        If combNumsString.Contains("King$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
        If combNumsString.Contains("Ten$") Then
            If combNumsString.Contains("Jack$") Then
                If combNumsString.Contains("Queen$") Then
                    If combNumsString.Contains("King$") Then
                        If combNumsString.Contains("Ace$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
        If combNumsString.Contains("Ace$") Then
            If combNumsString.Contains("Two$") Then
                If combNumsString.Contains("Three$") Then
                    If combNumsString.Contains("Four$") Then
                        If combNumsString.Contains("Five$") Then
                            hasStraight = True
                        End If
                    End If
                End If
            End If
        End If
    End Function
    Public Function checkFlush()
        If hasHearts = 5 Then
            hasFlush = True
        End If
        If hasClubs = 5 Then
            hasFlush = True
        End If
        If hasDiamonds = 5 Then
            hasFlush = True
        End If
        If hasSpades = 5 Then
            hasFlush = True
        End If

    End Function
    Public Function checkFullHouse()
        'If hasTwos = 2 Then hasFullHouse = True
        'If hasThrees = 2 Then hasFullHouse = True
        'If hasFours = 2 Then hasFullHouse = True
        'If hasFives = 2 Then hasFullHouse = True
        'If hasSixes = 2 Then hasFullHouse = True
        'If hasSevens = 2 Then hasFullHouse = True
        'If hasEights = 2 Then hasFullHouse = True
        'If hasNines = 2 Then hasFullHouse = True
        'If hasTens = 2 Then hasFullHouse = True
        'If hasJacks = 2 Then hasFullHouse = True
        'If hasQueens = 2 Then hasFullHouse = True
        'If hasKings = 2 Then hasFullHouse = True
        'If hasAces = 2 Then hasFullHouse = True
        'End If
        If hasTwos = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasThrees = 3 Then
            If hasTwos = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasFours = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasFives = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasSixes = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasSevens = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasEights = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasNines = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasTens = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasJacks = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasQueens = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasKings = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
            If hasAces = 2 Then hasFullHouse = True
        End If
        If hasAces = 3 Then
            If hasThrees = 2 Then hasFullHouse = True
            If hasFours = 2 Then hasFullHouse = True
            If hasFives = 2 Then hasFullHouse = True
            If hasSixes = 2 Then hasFullHouse = True
            If hasSevens = 2 Then hasFullHouse = True
            If hasEights = 2 Then hasFullHouse = True
            If hasNines = 2 Then hasFullHouse = True
            If hasTens = 2 Then hasFullHouse = True
            If hasJacks = 2 Then hasFullHouse = True
            If hasQueens = 2 Then hasFullHouse = True
            If hasKings = 2 Then hasFullHouse = True
            If hasTwos = 2 Then hasFullHouse = True
        End If

    End Function
    Public Function checkFourOfaKind()
        If hasTwos = 4 Then
            hasFourOfAKind = True
        End If
        If hasThrees = 4 Then
            hasFourOfAKind = True
        End If
        If hasFours = 4 Then
            hasFourOfAKind = True
        End If
        If hasFives = 4 Then
            hasFourOfAKind = True
        End If
        If hasSixes = 4 Then
            hasFourOfAKind = True
        End If
        If hasSevens = 4 Then
            hasFourOfAKind = True
        End If
        If hasEights = 4 Then
            hasFourOfAKind = True
        End If
        If hasNines = 4 Then
            hasFourOfAKind = True
        End If
        If hasTens = 4 Then
            hasFourOfAKind = True
        End If
        If hasJacks = 4 Then
            hasFourOfAKind = True
        End If
        If hasQueens = 4 Then
            hasFourOfAKind = True
        End If
        If hasKings = 4 Then
            hasFourOfAKind = True
        End If
    End Function
    Public Function checkStraightFlush()
        If hasFlush = True Then
            If hasStraight = True Then
                hasStraightFlush = True
            End If
        End If
        If hasStraight = True Then
            If hasFlush = True Then
                hasStraightFlush = True
            End If
        End If
    End Function
    Public Function checkRoyalFlush()
        If hasFlush = True Then
            combNumsString = Cardnums(card1_Num) + "$" + Cardnums(card2_Num) + "$" + Cardnums(card3_Num) + "$" + Cardnums(card4_Num) + "$" + Cardnums(card5_Num) + "$"
            If combNumsString.Contains("Ten$") Then
                If combNumsString.Contains("Jack$") Then
                    If combNumsString.Contains("Queen$") Then
                        If combNumsString.Contains("King$") Then
                            If combNumsString.Contains("Ace$") Then
                                hasRoyalFlush = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Function
    Public Function valueHand()
        If hasRoyalFlush = True Then
            handNumericValue = 9
            Console.WriteLine("       The Value of your Hand is: Royal Flush")
        ElseIf hasStraightFlush = True Then
            handNumericValue = 8
            Console.WriteLine("       The Value of your Hand is: Straight Flush")
        ElseIf hasFourOfAKind = True Then
            handNumericValue = 7
            Console.WriteLine("       The Value of your Hand is: Four of a Kind")
        ElseIf hasFullHouse = True Then
            handNumericValue = 6
            Console.WriteLine("       The Value of your Hand is: Full House")
        ElseIf hasFlush = True Then
            handNumericValue = 5
            Console.WriteLine("       The Value of your Hand is: Flush")
        ElseIf hasStraight = True Then
            handNumericValue = 4
            Console.WriteLine("       The Value of your Hand is: Straight")
        ElseIf hasThreeOfaKind = True Then
            handNumericValue = 3
            Console.WriteLine("       The Value of your Hand is: Three Of a Kind (" & pairNum & ") ")
        ElseIf hasTwoPairs = True Then
            handNumericValue = 2
            Console.WriteLine("       The Value of your Hand is: Two Pairs (" & pairNum & " & " & pairSecNum & ")")
        ElseIf hasPair = True Then
            handNumericValue = 1
            Console.WriteLine("       The Value of your Hand is: Pair (" & pairNum & ") ")
        Else
            handNumericValue = 0
            Dim fndLg As Integer() = New Integer() {card1_Num, card2_Num, card3_Num, card4_Num, card5_Num}
            Console.WriteLine("       The Value of your Hand is: High Card (" + Cardnums(fndLg.Max) + ")")
        End If
    End Function

#End Region

#Region "Font Functions"

    Public Function fcBlac()
        Console.ForegroundColor = ConsoleColor.Black
    End Function
    Public Function fcBlue()
        Console.ForegroundColor = ConsoleColor.Blue
    End Function
    Public Function fcCyan()
        Console.ForegroundColor = ConsoleColor.Cyan
    End Function
    Public Function fcGray()
        Console.ForegroundColor = ConsoleColor.Gray
    End Function
    Public Function fcGreen()
        Console.ForegroundColor = ConsoleColor.Green
    End Function
    Public Function fcMagenta()
        Console.ForegroundColor = ConsoleColor.Magenta
    End Function
    Public Function fcRed()
        Console.ForegroundColor = ConsoleColor.Red
    End Function
    Public Function fcWhite()
        Console.ForegroundColor = ConsoleColor.White
    End Function
    Public Function fcYellow()
        Console.ForegroundColor = ConsoleColor.Yellow
    End Function
    Public Function fcDarkBlue()
        Console.ForegroundColor = ConsoleColor.DarkBlue
    End Function
    Public Function fcDarkCyan()
        Console.ForegroundColor = ConsoleColor.DarkCyan
    End Function
    Public Function fcDarkGray()
        Console.ForegroundColor = ConsoleColor.DarkGray
    End Function
    Public Function fcDarkGreen()
        Console.ForegroundColor = ConsoleColor.DarkGreen
    End Function
    Public Function fcDarkMagenta()
        Console.ForegroundColor = ConsoleColor.DarkMagenta
    End Function
    Public Function fcDarkRed()
        Console.ForegroundColor = ConsoleColor.DarkRed
    End Function
    Public Function fcDarkYellow()
        Console.ForegroundColor = ConsoleColor.DarkYellow
    End Function

#End Region

End Module
