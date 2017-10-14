///<references path='CardSuit.ts' />
var EasyItSolution4U;
(function (EasyItSolution4U) {
    var PlayingCard = (function () {
        function PlayingCard(cardName, cardValue, imageLocation, cardSuit, cardSound) {
            this.Suit = cardSuit;
            this.CardName = cardName;
            this.CardValue = cardValue;
            this.CardImageLocation = imageLocation;
            this.CardSoundLocation = cardSound;
        }
        return PlayingCard;
    }());
    EasyItSolution4U.PlayingCard = PlayingCard;
})(EasyItSolution4U || (EasyItSolution4U = {}));
//# sourceMappingURL=PlayingCard.js.map