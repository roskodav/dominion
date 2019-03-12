﻿namespace GameCore.Cards.Base
{
    public class Moneylender : Card
    {
        static Moneylender moneylender = null;
        private Moneylender() : base
        (
            id: 17,
            name: "Moneylender",
            price: 4,
            addActions: 0,
            addBuys: 0,
            addCoins: 0,
            drawCards: 0,
            isVictory: false,
            isTreasure: false,
            isAction: true,
            isReaction: false,
            isAttack: false
        )
        { }

        public static Moneylender Get() => moneylender ?? new Moneylender();

        protected override void SpecialPlayEffect(Player player)
        {
            var copper = player.ps.Hand.Find(c => c.Id == 1);
            if (copper == null)
                return;
            player.Trash(copper);
            player.ps.Coins += 3;
        }
    }
}
