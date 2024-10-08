﻿using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;

namespace Game_Dev.Characters
{
    public abstract class Character : BaseObject
    {
        public IMovement Movement { get; set; }

        public virtual void Update(GameTime gameTime)
        {
            MovementManager.Move(this, gameTime);
            this.CurrentFrame.Hitbox.Flip(this);
        }
    }
}