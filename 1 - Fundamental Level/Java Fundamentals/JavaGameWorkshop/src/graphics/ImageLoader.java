package graphics;

import javax.imageio.ImageIO;
import java.awt.image.BufferedImage;

/**
 * Created by Killer18ys on 02-11-2015.
 */
public class ImageLoader {

    public static BufferedImage loadImage(String path){
        try {
            return ImageIO.read(ImageLoader.class.getResource(path));
        }catch (){

        }
    }
}
