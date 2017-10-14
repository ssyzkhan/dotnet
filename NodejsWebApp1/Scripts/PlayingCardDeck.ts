///<references path='PlayingCard.ts' />
module EasyItSolution4U {
    export class PlayingCardDeck {
        Cards: PlayingCard[] = null;

        constructor() {
            this.Cards = new Array();
            this.addCard(new EasyItSolution4U.PlayingCard("Ace", "14", "Cards/ace_of_clubs.png", CardSuit.Clubs))

        }
        addCard(Card: PlayingCard) {
            this.Cards.push(Card);
        }
    }

}