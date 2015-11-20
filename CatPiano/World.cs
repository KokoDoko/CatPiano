using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;

namespace CatPiano
{
	public class World
	{
		private Texture2D 		_pianotex;
		private SoundEffect 	_meow;
		private KeyboardState	_oldstate;

		public World (Game1 game)
		{
			_pianotex = game.Content.Load<Texture2D> ("catpiano");
			_meow = game.Content.Load<SoundEffect>("meow1");
		}

		public void Update(){
			KeyboardState newState = Keyboard.GetState();

			CheckKey(newState, Keys.Z, 0.0f);
			CheckKey(newState, Keys.X, 0.2f);
			CheckKey(newState, Keys.C, 0.4f);
			CheckKey(newState, Keys.V, 0.6f);
			CheckKey(newState, Keys.B, 0.8f);

			_oldstate = newState;
		}

		public void CheckKey(KeyboardState newState, Keys toets, float toonHoogte){
			if(newState.IsKeyDown(toets) && _oldstate.IsKeyUp(toets))
			{
				PlaySound(toonHoogte);
			}
		}

		private void PlaySound(float toonHoogte){
			float volume = 1.0f;
			float pan = 0.0f;
			_meow.Play(volume, toonHoogte, pan);
		}


		public void Draw(SpriteBatch spriteBatch){
			spriteBatch.Draw (_pianotex, new Vector2(0, 0));
		}

	}
}

