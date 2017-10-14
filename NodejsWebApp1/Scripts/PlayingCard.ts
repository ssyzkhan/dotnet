///<references path='CardSuit.ts' />
module EasyItSolution4U {
    export class PlayingCard {
        CardName: string;
        CardValue: string;
        CardImageLocation: string;
        CardSoundLocation: string;
        Suit: CardSuit;

        constructor(cardName: string, cardValue: string, imageLocation: string, cardSuit: CardSuit,cardSound?: string ) {
            this.Suit = cardSuit;
            this.CardName = cardName;
            this.CardValue = cardValue;
            this.CardImageLocation = imageLocation;
            this.CardSoundLocation = cardSound;

        }

    }
}

