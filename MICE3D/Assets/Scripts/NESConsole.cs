using MICE.Nintendo;
using MICE.Nintendo.Loaders;
using Ninject;
using System.Threading;
using UnityEngine;

public class NESConsole : MonoBehaviour
{
    private NES nes;
    private IKernel ioc;

    private Renderer rend;
    private Texture2D texture;
    private PaletteHandler palette;

    private long lastFrame = 0;
    private Thread nesThread;

    public void Awake()
    {
        this.palette = new PaletteHandler();
        this.rend = this.GetComponent<Renderer>();
        this.texture = new Texture2D(256, 240, TextureFormat.ARGB32, mipmap: false);

        this.rend.material.mainTexture = texture;

        this.ioc = new StandardKernel(new NintendoModule());
        this.nes = this.ioc.Get<NES>();

        var cartridge = NESLoader.CreateCartridge(@"C:\emulators\nes\games\Super Mario Bros.nes");
        this.nes.LoadCartridge(cartridge);

        this.nes.PowerOn();

        this.nesThread = new Thread(NESStep);
        this.nesThread.Start();
    }

    private void NESStep()
    {
        while (true)
        {
            this.nes.Step();
        }
    }

    private byte[] screen = new byte[0x0000f000];
    public void Update()
    {
        this.transform.Rotate(Vector3.up);

        if (this.lastFrame != this.nes.CurrentFrame)
        {
            this.nes.PPU.ScreenData.CopyTo(screen, 0);

            var colors = new Color32[screen.Length];

            for (int i = 0; i < screen.Length; i++)
            {
                colors[i] = this.palette.Colors[screen[i]];
            }

            this.texture.SetPixels32(colors);

            this.texture.Apply();

            this.lastFrame = this.nes.CurrentFrame;
            Debug.Log($"Frame: {this.lastFrame}");
        }
    }
}