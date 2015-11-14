package graphics;

import java.awt.image.BufferedImage;

/**
 * Created by Killer18ys on 02-11-2015.
 */
public class Assets {
    public static BufferedImage background;
    public static BufferedImage player;


    public void init(){
        background = ImageLoader.loadImage("/textures/bckg.jpg");
        player = ImageLoader.loadImage("/textures/player.jpg");
    }
}
