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
        Dim cardDeck(51, 1) As String
        Dim shuffleCheck As String
        Dim hasBeenDelt As String
        Dim shuffle As Boolean
        Dim quit As Boolean
        Dim cardValue As Integer

        cardDeck(0, 0) = "Club, ace"
        cardDeck(1, 0) = "Club, 2"
        cardDeck(2, 0) = "Club, 3"
        cardDeck(3, 0) = "Club, 4"
        cardDeck(4, 0) = "Club, 5"
        cardDeck(5, 0) = "Club, 6"
        cardDeck(6, 0) = "Club, 7"
        cardDeck(7, 0) = "Club, 8"
        cardDeck(8, 0) = "Club, 9"
        cardDeck(9, 0) = "Club, 10"
        cardDeck(10, 0) = "Club, Jack"
        cardDeck(11, 0) = "Club, Queen"
        cardDeck(12, 0) = "Club, king"
        cardDeck(13, 0) = "Hearts, Ace"
        cardDeck(14, 0) = "Hearts, 2"
        cardDeck(15, 0) = "Hearts, 3"
        cardDeck(16, 0) = "Hearts, 4"
        cardDeck(17, 0) = "Hearts, 5"
        cardDeck(18, 0) = "Hearts, 6"
        cardDeck(19, 0) = "Hearts, 7"
        cardDeck(20, 0) = "Hearts, 8"
        cardDeck(21, 0) = "Hearts, 9"
        cardDeck(22, 0) = "Hearts, 10"
        cardDeck(23, 0) = "Hearts, Jack"
        cardDeck(24, 0) = "Hearts, Queen"
        cardDeck(25, 0) = "Hearts, king"
        cardDeck(26, 0) = "Spades, Ace"
        cardDeck(27, 0) = "Spades, 2"
        cardDeck(28, 0) = "Spades, 3"
        cardDeck(29, 0) = "Spades, 4"
        cardDeck(30, 0) = "Spades, 5"
        cardDeck(31, 0) = "Spades, 6"
        cardDeck(32, 0) = "Spades, 7"
        cardDeck(33, 0) = "Spades, 8"
        cardDeck(34, 0) = "Spades, 9"
        cardDeck(35, 0) = "Spades, 10"
        cardDeck(36, 0) = "Spades, Jack"
        cardDeck(37, 0) = "Spades, Queen"
        cardDeck(38, 0) = "Spades, king"
        cardDeck(39, 0) = "Diamond, Ace"
        cardDeck(40, 0) = "Diamond, 2"
        cardDeck(41, 0) = "Diamond, 3"
        cardDeck(42, 0) = "Diamond, 4"
        cardDeck(43, 0) = "Diamond, 5"
        cardDeck(44, 0) = "Diamond, 6"
        cardDeck(45, 0) = "Diamond, 7"
        cardDeck(46, 0) = "Diamond, 8"
        cardDeck(47, 0) = "Diamond, 9"
        cardDeck(48, 0) = "Diamond, 10"
        cardDeck(49, 0) = "Diamond, Jack"
        cardDeck(50, 0) = "Diamond, Queen"
        cardDeck(51, 0) = "Diamond, king"
        Do
            Console.WriteLine("Press enter to begin dealing cards")
            Console.ReadLine()
            shuffle = False
            For i = 1 To 52
                'This loop will run until a card that has not been delt before has been selected. 
                Do
                    cardValue = DealACard(52)
                    hasBeenDelt = cardDeck(cardValue, 1)
                    'The array defaults to Nothing, So nothing is checked for.
                Loop Until hasBeenDelt = Nothing
                'The second column is assigned the first columns card value,
                'This ensures that card can not be delt again
                cardDeck(cardValue, 1) = cardDeck(cardValue, 0)
                Console.WriteLine(cardDeck(cardValue, 0))

                'Remove the Readline one next line to deal all cards.
                Console.ReadLine()
            Next
            Console.WriteLine("Type S to shuffle or Q to quit")
            Do
                shuffleCheck = Console.ReadLine()
                Select Case shuffleCheck
                    Case = "S"
                        'If the user wants to shuffle the deck the For loop will 
                        'run through the second colume and clear the value.                      
                        For i = 0 To 51
                            cardDeck(i, 1) = Nothing
                            shuffle = True
                        Next
                    Case = "Q"
                        quit = True
                        shuffle = True
                    Case <> "S"
                        Console.WriteLine("Enter S or Q")
                End Select
                'The shuffle Boolean is set true when valuable user input is entered
                'ending the loop
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