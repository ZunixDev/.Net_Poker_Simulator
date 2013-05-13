Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Module Declarations
    Public myRnd As New Random 'Used to generate random numbers for cards
    Public custDT As String = (" [" + DateTime.Now + "]: ") 'Used for printing Date & Time in the format of [Datetime]: 
    Public card1_Num As Integer 'The Number of Card 1
    Public card2_Num As Integer 'The Number of Card 2
    Public card3_Num As Integer 'The Number of Card 3
    Public card4_Num As Integer 'The Number of Card 4
    Public card5_Num As Integer 'The Number of Card 5
    Public card1_Suit As Integer 'The Suit of Card 1
    Public card2_Suit As Integer 'The Suit of Card 2
    Public card3_Suit As Integer 'The Suit of Card 3
    Public card4_Suit As Integer 'The Suit of Card 4
    Public card5_Suit As Integer 'The Suit of Card 5
    Public card1 As String 'The complete Card 1 - Declared in Number:Suit Format
    Public card2 As String 'The complete Card 2 - Declared in Number:Suit Format
    Public card3 As String 'The complete Card 3 - Declared in Number:Suit Format
    Public card4 As String 'The complete Card 4 - Declared in Number:Suit Format
    Public card5 As String 'The complete Card 5 - Declared in Number:Suit Format
    Public hasHearts As Integer 'States how many Hearts are in the current hand
    Public hasClubs As Integer 'States how many Clubs are in the current hand
    Public hasSpades As Integer 'States how many Spades are in the current hand
    Public hasDiamonds As Integer 'States how many Diamonds are in the current hand
    Public handValue As String 'Extra, Unused String for declaring hand values
    Public hasTwos As Integer 'States how many Twos are in the current hand
    Public hasThrees As Integer 'States how many Threes are in the current hand
    Public hasFours As Integer 'States how many Fours are in the current hand
    Public hasFives As Integer 'States how many Fives are in the current hand
    Public hasSixes As Integer 'States how many Sixes are in the current hand
    Public hasSevens As Integer 'States how many Sevens are in the current hand
    Public hasEights As Integer 'States how many Eights are in the current hand
    Public hasNines As Integer 'States how many Nines are in the current hand
    Public hasTens As Integer 'States how many Tens are in the current hand
    Public hasJacks As Integer 'States how many Jacks are in the current hand
    Public hasQueens As Integer 'States how many Queens are in the current hand
    Public hasKings As Integer 'States how many Kings are in the current hand
    Public hasAces As Integer 'States how many Aces are in the current hand
    Public hasPair As Boolean = False 'If current hand contains a Pair, this boolean is set to true - Elsewhise, it is false
    Public hasTwoPairs As Boolean = False 'If current hand contains Two Pairs, this boolean is set to true - Elsewhise, it is false
    Public hasThreeOfaKind As Boolean = False 'If current hand contains a Three Of a Kind, this boolean is set to true - Elsewhise, it is false
    Public hasStraight As Boolean = False 'If current hand contains a Straight, this boolean is set to true - Elsewhise, it is false
    Public hasFlush As Boolean = False 'If current hand contains a Flush, this boolean is set to true - Elsewhise, it is false
    Public hasFullHouse As Boolean = False 'If current hand contains a Full house, this boolean is set to true - Elsewhise, it is false
    Public hasFourOfAKind As Boolean = False 'If current hand contains a Four Of a Kind, this boolean is set to true - Elsewhise, it is false
    Public hasStraightFlush As Boolean = False 'If current hand contains a Straight Flush, this boolean is set to true - Elsewhise, it is false
    Public hasRoyalFlush As Boolean = False 'If current hand contains a Royal Flush, this boolean is set to true - Elsewhise, it is false
    Public Cardnums As String() = New String() {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"} 'Array containing the Numbers of a card
    Public Cardsuits As String() = New String() {"Spades", "Clubs", "Hearts", "Diamonds"} 'Array containing the Suits of a card
    Public combNumsString As String 'Used in detecting a Straight & Royal Flush, holds numbers in the format of card1_num$card2_num$card3_num$card4_num$card5num, with $ acting as a delimiter
    Public handNumericValue As Integer 'The Numeric Value of your hand, relying on the hand detection system - using a scale of 0-9
    Public pairNum As String 'Detects what the pair is of the pair you have
    Public pairSecNum As String 'Incase of two pairs, detects what the second pair is of the pairs you have.
    Public stringsList As String() = New String() {"custDT", "card1", "card2", "card3", "card4", "card5", "handValue", "combNumsString", "pairNum", "pairSecNum"} 'Array List of All Integers
    Public integersList As String() = New String() {"card1_Num", "card2_Num", "card3_Num", "card4_Num", "card5_Num", "card1_Suit", "card2_Suit", "card3_Suit", "card4_Suit", "card5_Suit", "hasHearts", "hasClubs", "hasSpades", "hasDiamonds", "hasTwos", "hasThrees", "hasFours", "hasFives", "hasSixes", "hasSevens", "hasEights", "hasNines", "hasTens", "hasJacks", "hasQueens", "hasKings", "hasAces"} 'Array List of All Strings
    Public csl As String = String.Join(", ", stringsList) 'Combined list of all strings, used in the @Strings command
    Public cil As String = String.Join(", ", integersList) 'Combined list of all strings, used in the @Strings command
End Module
