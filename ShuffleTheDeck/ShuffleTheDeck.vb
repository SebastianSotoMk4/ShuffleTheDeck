
'Sebastian Soto
'RCET0265
'Fall 2021
'Shuffle The Deck
'https://github.com/SebastianSotoMk4/ShuffleTheDeck.git
Option Strict On
Option Explicit On
Option Compare Text
Module ShuffleTheDeck
    Sub Main()
        Dim cardReturn As String
        Dim aNumber As String
        Dim shuffleCheck As String
        Dim cardDeck(51) As String
        Dim cardCheck(51) As String
        Dim value As Integer
        Dim shuffle As Boolean
        Dim quit As Boolean

        cardDeck(0) = "Club, ace"
        cardDeck(1) = "Club, 2"
        cardDeck(2) = "Club, 3"
        cardDeck(3) = "Club, 4"
        cardDeck(4) = "Club, 5"
        cardDeck(5) = "Club, 6"
        cardDeck(6) = "Club, 7"
        cardDeck(7) = "Club, 8"
        cardDeck(8) = "Club, 9"
        cardDeck(9) = "Club, 10"
        cardDeck(10) = "Club, Jack"
        cardDeck(11) = "Club, Queen"
        cardDeck(12) = "Club, king"
        cardDeck(13) = "Hearts, Ace"
        cardDeck(14) = "Hearts, 2"
        cardDeck(15) = "Hearts, 3"
        cardDeck(16) = "Hearts, 4"
        cardDeck(17) = "Hearts, 5"
        cardDeck(18) = "Hearts, 6"
        cardDeck(19) = "Hearts, 7"
        cardDeck(20) = "Hearts, 8"
        cardDeck(21) = "Hearts, 9"
        cardDeck(22) = "Hearts, 10"
        cardDeck(23) = "Hearts, Jack"
        cardDeck(24) = "Hearts, Queen"
        cardDeck(25) = "Hearts, king"
        cardDeck(26) = "Spades, Ace"
        cardDeck(27) = "Spades, 2"
        cardDeck(28) = "Spades, 3"
        cardDeck(29) = "Spades, 4"
        cardDeck(30) = "Spades, 5"
        cardDeck(31) = "Spades, 6"
        cardDeck(32) = "Spades, 7"
        cardDeck(33) = "Spades, 8"
        cardDeck(34) = "Spades, 9"
        cardDeck(35) = "Spades, 10"
        cardDeck(36) = "Spades, Jack"
        cardDeck(37) = "Spades, Queen"
        cardDeck(38) = "Spades, king"
        cardDeck(39) = "Diamond, Ace"
        cardDeck(40) = "Diamond, 2"
        cardDeck(41) = "Diamond, 3"
        cardDeck(42) = "Diamond, 4"
        cardDeck(43) = "Diamond, 5"
        cardDeck(44) = "Diamond, 6"
        cardDeck(45) = "Diamond, 7"
        cardDeck(46) = "Diamond, 8"
        cardDeck(47) = "Diamond, 9"
        cardDeck(48) = "Diamond, 10"
        cardDeck(49) = "Diamond, Jack"
        cardDeck(50) = "Diamond, Queen"
        cardDeck(51) = "Diamond, king"
        Do
            Console.WriteLine("Press enter to begin dealing cards")
            Console.ReadLine()
            shuffle = False
            For i = 1 To 52
                Do
                    value = DealACard(52)
                    aNumber = cardCheck(value)
                Loop Until aNumber = Nothing

                cardReturn = cardDeck(value)
                cardCheck(value) = cardDeck(value)
                Console.WriteLine(cardReturn)
                'Console.ReadLine()
            Next
            Console.WriteLine("Type S to shuffle or Q to quit")
            Do
                shuffleCheck = Console.ReadLine()
                Select Case shuffleCheck
                    Case = "S"
                        For i = LBound(cardCheck) To UBound(cardCheck)
                            cardCheck(i) = Nothing
                            shuffle = True
                        Next
                    Case = "Q"
                        quit = True
                        shuffle = True
                    Case <> "S"
                        Console.WriteLine("Enter S or Q")
                End Select
            Loop Until shuffle = True
        Loop Until quit = True
    End Sub

    Function DealACard(max As Integer) As Integer
        Dim rndNum As Double
        Dim NumRnd As Integer
        Randomize(Now.Millisecond)
        rndNum = System.Math.Floor(CDbl(Rnd() * (max)))
        NumRnd = CInt(rndNum)
        Return NumRnd
    End Function
End Module
'https://elearn.isu.edu/moodle/mod/assign/view.php?id=2180761