using MICE.Nintendo.Loaders;
using System.Collections;
using System.Collections.Generic;
using MICE.Nintendo;
using Ninject;
using UnityEngine;

public class NESConsole : MonoBehaviour
{
    private NES nes;
    private IKernel ioc;

    private Renderer renderer;
    private Texture2D texture;

    private long lastFrame = 0;

    public void Awake()
    {
        this.renderer = this.GetComponent<Renderer>();
        this.texture = Instantiate(renderer.material.mainTexture) as Texture2D;
        this.renderer.material.mainTexture = texture;

        this.ioc = new StandardKernel(new NintendoModule());
        this.nes = this.ioc.Get<NES>();

        var cartridge = NESLoader.CreateCartridge(@"C:\Emulators\NES\Games\World\Donkey Kong (JU).nes");
        this.nes.LoadCartridge(cartridge);

        this.nes.PowerOn();
    }

    public void Update()
    {
        this.nes.Step();


        if (this.nes.PPU.FrameNumber != this.lastFrame)
        {
            //var colors = new Color[this.nes.PPU.ScreenData.Length];

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    colors[i] = new Color(this.nes.PPU.ScreenData[i], this.nes.PPU.ScreenData[i], this.nes.PPU.ScreenData[i], 0);
            //}

            //this.texture.SetPixels(colors);

//            this.texture = new Texture2D(128, 120, TextureFormat., mipmap: false);
            this.texture.LoadRawTextureData(this.nes.PPU.ScreenData);
            this.texture.Apply();
        }
    }
}