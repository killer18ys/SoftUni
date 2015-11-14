package game;

import display.Display;
import graphics.Assets;
import graphics.ImageLoader;
import graphics.SpriteSheet;

import java.awt.*;
import java.awt.image.BufferStrategy;

/**
 * Created by Killer18ys on 02-11-2015.
 */
public class Game implements Runnable {
    private String title;

    private Display display;
    private BufferStrategy bs;
    private Graphics g;

    private SpriteSheet sh;

    private Thread thread;
    private boolean isRunning;

    public Game(String name) {
        this.title = name;
    }

    private void init(){
        Assets.init();

        this.display = new Display(this.title);

        this.sh = new SpriteSheet(Assets.player); // TODO
    }

    private void tick(){
        //TODO
    }

    private void render(){
        this.bs = this.display.getCanvas().getBufferStrategy();
        if (bs == null){
            this.display.getCanvas().createBufferStrategy(2);
            return;
        }
        this.g = this.bs.getDrawGraphics();

        g.clearRect(0, 0, Display.WIDTH, Display.HEIGHT);

        //Start Drawing

        g.drawImage(ImageLoader.loadImage("/textures/bckg.jpg"), 0, 0, null);

        //Stop Drawing
        this.g.dispose();
        this.bs.show();

    }


    @Override
    public void run() {
        this.init();

        int fps = 60;
        double timePerTick = 1000000000.0 /fps;
        double delta = 0;

        long now;
        long lastTime = System.nanoTime();

        while (isRunning){
            now = System.nanoTime();
            delta += (now - lastTime) / timePerTick;

            if (delta >= timePerTick){
                this.tick();
                this.render();
                delta--;
            }

        }
        this.stop();
    }

    public synchronized void  start(){
        this.thread = new Thread(this);
        this.thread.start();
        this.isRunning = true;
    }

    public synchronized void stop(){
        this.isRunning = false;
        try {
            this.thread.join();
        }catch (InterruptedException e){
           e.printStackTrace();
        }
    }
}
