///<references path='PlayingCard.ts' />
var EasyItSolution4U;
(function (EasyItSolution4U) {
    var PlayingCardDeck = (function () {
        function PlayingCardDeck() {
            this.Cards = null;
            this.Cards = new Array();
            this.addCard(new EasyItSolution4U.PlayingCard("Ace", "14", "Cards/ace_of_clubs.png", EasyItSolution4U.CardSuit.Clubs));
        }
        PlayingCardDeck.prototype.addCard = function (Card) {
            this.Cards.push(Card);
        };
        return PlayingCardDeck;
    }());
    EasyItSolution4U.PlayingCardDeck = PlayingCardDeck;
})(EasyItSolution4U || (EasyItSolution4U = {}));
//# sourceMappingURL=PlayingCardDeck.js.map