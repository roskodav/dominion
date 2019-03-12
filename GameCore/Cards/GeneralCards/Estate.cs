﻿namespace GameCore.Cards.GeneralCards
{
    public class Estate : Card
    {
        static Estate estate = null;
        private Estate() : base
        (
            id: 4,
            name: "Estate",
            price: 2,
            addBuys: 0,
            victoryPoints: 1, 
            coins: 0,
            isVictory: true,
            isTreasure: false
        )
        { }

        public static Estate Get() => estate ?? new Estate();
    }
}