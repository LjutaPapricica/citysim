﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CitySimAndroid.States
{
    public abstract class State
    {
        // xna content manager 
        protected ContentManager _content;

        // graphics device (screen res, display)
        protected GraphicsDevice _graphicsDevice;

        // the game instance this state is a part of
        protected GameInstance _game;

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        public abstract void Update(GameTime gameTime);

        public abstract void PostUpdate(GameTime gameTime);

        // construct state
        public State(GameInstance game, GraphicsDevice graphicsDevice, ContentManager content)
        {
            // set current game instance
            _game = game;

            // set graphics device
            _graphicsDevice = graphicsDevice;

            // set xna content manager
            _content = content;
        }
    }
}