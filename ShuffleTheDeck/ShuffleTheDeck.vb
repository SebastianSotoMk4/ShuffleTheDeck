﻿'Sebastian Soto
'RCET0265
'Fall 2021
'Shuffle The Deck
'https://github.com/SebastianSotoMk4/ShuffleTheDeck.git
Option Strict On
Option Explicit On
Module ShuffleTheDeck

    Sub Main()

        For i = 1 To 52
            DeckOfCards()
            Console.ReadLine()
        Next

        Console.ReadLine()
    End Sub

    Sub DeckOfCards()
        Dim cardDeck(3, 13) As String

        cardDeck(0, 0) = "Club, Ace"
        cardDeck(0, 1) = "Club, 2"
        cardDeck(0, 2) = "Club, 3"
        cardDeck(0, 3) = "Club, 4"
        cardDeck(0, 4) = "Club, 5"
        cardDeck(0, 5) = "Club, 6"
        cardDeck(0, 6) = "Club, 7"
        cardDeck(0, 7) = "Club, 8"
        cardDeck(0, 8) = "Club, 9"
        cardDeck(0, 9) = "Club, 10"
        cardDeck(0, 10) = "Club, Jack"
        cardDeck(0, 11) = "Club, Queen"
        cardDeck(0, 12) = "Club, king"

        cardDeck(1, 0) = "Hearts, Ace"
        cardDeck(1, 1) = "Hearts, 2"
        cardDeck(1, 2) = "Hearts, 3"
        cardDeck(1, 3) = "Hearts, 4"
        cardDeck(1, 4) = "Hearts, 5"
        cardDeck(1, 5) = "Hearts, 6"
        cardDeck(1, 6) = "Hearts, 7"
        cardDeck(1, 7) = "Hearts, 8"
        cardDeck(1, 8) = "Hearts, 9"
        cardDeck(1, 9) = "Hearts, 10"
        cardDeck(1, 10) = "Hearts, Jack"
        cardDeck(1, 11) = "Hearts, Queen"
        cardDeck(1, 12) = "Hearts, king"

        cardDeck(2, 0) = "Spades, Ace"
        cardDeck(2, 1) = "Spades, 2"
        cardDeck(2, 2) = "Spades, 3"
        cardDeck(2, 3) = "Spades, 4"
        cardDeck(2, 4) = "Spades, 5"
        cardDeck(2, 5) = "Spades, 6"
        cardDeck(2, 6) = "Spades, 7"
        cardDeck(2, 7) = "Spades, 8"
        cardDeck(2, 8) = "Spades, 9"
        cardDeck(2, 9) = "Spades, 10"
        cardDeck(2, 10) = "Spades, Jack"
        cardDeck(2, 11) = "Spades, Queen"
        cardDeck(2, 12) = "Spades, king"

        cardDeck(3, 0) = "Diamond, Ace"
        cardDeck(3, 1) = "Diamond, 2"
        cardDeck(3, 2) = "Diamond, 3"
        cardDeck(3, 3) = "Diamond, 4"
        cardDeck(3, 4) = "Diamond, 5"
        cardDeck(3, 5) = "Diamond, 6"
        cardDeck(3, 6) = "Diamond, 7"
        cardDeck(3, 7) = "Diamond, 8"
        cardDeck(3, 8) = "Diamond, 9"
        cardDeck(3, 9) = "Diamond, 10"
        cardDeck(3, 10) = "Diamond, Jack"
        cardDeck(3, 11) = "Diamond, Queen"
        cardDeck(3, 12) = "Diamond, king"


        Console.WriteLine(cardDeck(DealASuit(4), DealACard(12)))




    End Sub

    Function DealACard(max As Integer) As Integer
        Dim rndNum As Double
        Dim NumRnd As Integer
        Randomize(Now.Millisecond)
        rndNum = System.Math.Floor(CDbl(Rnd() * (max)))
        NumRnd = CInt(rndNum)
        Return NumRnd
    End Function

    Function DealASuit(max As Integer) As Integer
        Dim rndNum As Double
        Dim NumRnd As Integer
        Randomize(Now.Millisecond)
        rndNum = System.Math.Floor(CDbl(Rnd() * (max)))
        NumRnd = CInt(rndNum)
        Return NumRnd
    End Function

    Sub TestRandom()
        Dim randomNumbers(6) As Integer

        For i = 0 To 10000

            randomNumbers(DealACard(6)) += 1
        Next

        For i = LBound(randomNumbers) To UBound(randomNumbers)
            Console.Write(CStr(i).PadLeft(7))
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(80, "-"))


        For i = LBound(randomNumbers) To UBound(randomNumbers)
            Console.Write(CStr(randomNumbers(i)).PadLeft(7))
        Next
    End Sub
    Function CardDeck() As Integer

    End Function
End Module
'https://elearn.isu.edu/moodle/mod/assign/view.php?id=2180761