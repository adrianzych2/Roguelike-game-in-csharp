using System;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Shaman : Character
    {
        public Shaman()
        {
            Health = 100;
            Damage = 80;
            Shield = 30;
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    
        public override bool FightMode => false;
        public override int DefaultSpriteId => 78;
        public override string DefaultName => "Skeleton";

        protected override void OnDeath()
        {
            Debug.Log("This wasn't suppose to happened");
        }
    }
}
