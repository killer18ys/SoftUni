package graphics;

import java.awt.image.BufferedImage;

/**
 * Created by Killer18ys on 02-11-2015.
 */
public class SpriteSheet {
    private BufferedImage image;
    private int cropWidth;
    private int cropHeight;

    public SpriteSheet(BufferedImage image, int width, int height) {
        this.image = image;
        this.cropWidth = width;
        this.cropHeight = height;
    }

    public BufferedImage crop(int x, int y, int width, int height){
        this.image = this.image.getSubimage(x, y, width, height);
    }
}
