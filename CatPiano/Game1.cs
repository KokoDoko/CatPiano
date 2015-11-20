using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace CatPiano
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager 	_graphics;
		private SpriteBatch 			_spriteBatch;
		private World 					_world;

		public Game1 ()
		{
			_graphics = new GraphicsDeviceManager (this);
			_graphics.PreferredBackBufferWidth = 350;
			_graphics.PreferredBackBufferHeight = 400;
			_graphics.IsFullScreen = false;

			Content.RootDirectory = "Content";	
			IsMouseVisible = true;
		}

		protected override void Initialize ()
		{
			base.Initialize ();
			_world = new World(this);
		}

		protected override void LoadContent ()
		{
			_spriteBatch = new SpriteBatch (GraphicsDevice);
		}

		protected override void Update (GameTime gameTime)
		{
			_world.Update();
		}

		protected override void Draw (GameTime gameTime)
		{
			_graphics.GraphicsDevice.Clear (Color.CornflowerBlue);
			_spriteBatch.Begin();
			_world.Draw(_spriteBatch);
			_spriteBatch.End();
		}
	}
}

