package display;

import javax.swing.*;
import java.awt.*;

/**
 * Created by Killer18ys on 02-11-2015.
 */
public class Display {
    public static final int WIDTH = 800;
    public static final int HEIGHT = 600;

    private String name;
    private JFrame frame;
    private Canvas canvas;

    public Display(String name){
        this.name = name;
        init(name);
    }

    private void init(String name){
        this.frame = new JFrame(name);
        this.frame.setVisible(true);
        this.frame.setMinimumSize(new Dimension(WIDTH, HEIGHT));
        this.frame.setPreferredSize(new Dimension(WIDTH, HEIGHT));
        this.frame.setMaximumSize(new Dimension(WIDTH, HEIGHT));
        this.frame.setFocusable(true);
        this.frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);

        this.frame.setResizable(false);
        this.frame.setLocationRelativeTo(null);

        this.canvas = new Canvas();
        this.canvas.setVisible(true);
        this.canvas.setMinimumSize(new Dimension(WIDTH, HEIGHT));
        this.canvas.setPreferredSize(new Dimension(WIDTH, HEIGHT));
        this.canvas.setMaximumSize(new Dimension(WIDTH, HEIGHT));

        this.frame.add(canvas);
        this.frame.pack();
    }


    public Canvas getCanvas() {
        return canvas;
    }
}
