using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShootAliensInAsteroidBeltGame
{
    class SpriteEntity
    {
        // All animation frames will be on a single sprite sheet, pointed to by this.
        public Texture2D Texture;

        protected List<Rectangle> animationFrames = new List<Rectangle>();

        // Variables for animations
        private int frameWidth = 0;
        private int frameHeight = 0;
        private int curFrame;
        private float frameDisplayTime = 0.1f;
        private float curFrameTime = 0.0f;

        // Variables used for drawing affects
        private Color tintColor = Color.White;
        private float rot = 0.0f;

        // Varibles for collision detection
        public int CollisionCircleRadius = 0;
        public int XPadding = 0;
        public int YPadding = 0;

        protected Vector2 loc = Vector2.Zero;
        protected Vector2 vel = Vector2.Zero;

        public SpriteEntity(
            Vector2 loc,
            Vector2 vel,
            Texture2D texture,
            Rectangle initFrame)
        {
            this.loc = loc;
            this.vel = vel;
            Texture = texture;

            animationFrames.Add(initFrame);
            frameWidth = initFrame.Width;
            frameHeight = initFrame.Height;
        }

        public Vector2 Location
        {
            get { return loc; }
            set { loc = value; }
        }

        public Vector2 Velocity
        {
            get { return vel; }
            set { vel = value; }
        }

        public Color TintColor
        {
            get { return tintColor; }
            set { tintColor = value; }
        }

        public float Rotation
        {
            get { return rot; }
            set { rot = value % MathHelper.TwoPi; }
        }

        public int Frame
        {
            get { return curFrame; }
            set { curFrame = (int)MathHelper.Clamp(value, 0, animationFrames.Count - 1); }
        }

        public float FrameTime
        {
            get { return frameDisplayTime; }
            set { frameDisplayTime = MathHelper.Max(0, value); }
        }

        public Rectangle BlitSource
        {
            get { return animationFrames[curFrame]; }
        }

        public Rectangle BlitDest
        {
            get
            {
                return new Rectangle(
                    (int)loc.X,
                    (int)loc.Y,
                    frameWidth,
                    frameHeight);
            }
        }

        public Vector2 Center
        {
            get { return loc + new Vector2(frameWidth / 2, frameHeight / 2); }
        }
    }
}
