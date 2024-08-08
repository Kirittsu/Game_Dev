using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Dev.Interfaces;
using Game_Dev.Managers;
using Game_Dev.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Dev.Characters
{
    public abstract class Character : BaseObject
    {
        public IMovement Movement { get; set; }
        public int Weight { get; set; }

        public virtual void Update(GameTime gameTime)
        {
            MovementManager.Move(this, gameTime);
            this.CurrentFrame.Hitbox.Flip(this);
        }

        public abstract bool Interaction(BaseObject gameObject);

        public bool InteractWith(BaseObject gameObject)
        {
            bool interact = Interaction(gameObject);

            if (interact)
            {
                return true;
            }

            return interact;
        }
    }
}
