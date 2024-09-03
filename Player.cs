using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Monogame
{
    public class Player : BaseClass
    {


    Player player;

    public Player(Texture2D texture):base(texture, new Vector2(400,240)){
        color = Color.LimeGreen;
    }

    public void Update(){
        KeyboardState kState = Keyboard.GetState();
        int speed = 5;
        if(kState.IsKeyDown(Keys.W)){
            position.Y -= speed;
        }
        if(kState.IsKeyDown(Keys.S)){
            position.Y += speed;
        }
        if(kState.IsKeyDown(Keys.D)){
            position.X += speed;
        }
        if(kState.IsKeyDown(Keys.A)){
            position.X -= speed;
        }
    }
    }
}