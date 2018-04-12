using System.Collections.Generic;
using UnityEngine;

public class PaletteHandler
{
    public PaletteHandler()
    {
        this.Colors = new Dictionary<byte, Color32>
        {
            { 0x0, new Color32(84, 84, 84, 255) },
            { 0x1, new Color32(0, 30, 116, 255) },
            { 0x2, new Color32(8, 16, 144, 255) },
            { 0x3, new Color32(48, 0, 136, 255) },
            { 0x4, new Color32(68, 0, 100, 255) },
            { 0x5, new Color32(92, 0, 48, 255) },
            { 0x6, new Color32(84, 4, 0, 255) },
            { 0x7, new Color32(60, 24, 0, 255) },
            { 0x8, new Color32(32, 42, 0, 255) },
            { 0x9, new Color32(8, 58, 0, 255) },
            { 0xa, new Color32(0, 64, 0, 255) },
            { 0xb, new Color32(0, 60, 0, 255) },
            { 0xc, new Color32(0, 50, 60, 255) },
            { 0xd, new Color32(0, 0, 0, 255) },
            { 0xe, new Color32(0, 0, 0, 255) },
            { 0xf, new Color32(0, 0, 0, 255) },
            { 0x10, new Color32(152, 150, 152, 255) },
            { 0x11, new Color32(8, 76, 196, 255) },
            { 0x12, new Color32(48, 50, 236, 255) },
            { 0x13, new Color32(92, 30, 228, 255) },
            { 0x14, new Color32(136, 20, 176, 255) },
            { 0x15, new Color32(160, 20, 100, 255) },
            { 0x16, new Color32(152, 34, 32, 255) },
            { 0x17, new Color32(120, 60, 0, 255) },
            { 0x18, new Color32(84, 90, 0, 255) },
            { 0x19, new Color32(40, 114, 0, 255) },
            { 0x1a, new Color32(8, 124, 0, 255) },
            { 0x1b, new Color32(0, 118, 40, 255) },
            { 0x1c, new Color32(0, 102, 120, 255) },
            { 0x1d, new Color32(0, 0, 0, 255) },
            { 0x1e, new Color32(0, 0, 0, 255) },
            { 0x1f, new Color32(0, 0, 0, 255) },
            { 0x20, new Color32(236, 238, 236, 255) },
            { 0x21, new Color32(76, 154, 236, 255) },
            { 0x22, new Color32(120, 124, 236, 255) },
            { 0x23, new Color32(176, 98, 236, 255) },
            { 0x24, new Color32(228, 84, 236, 255) },
            { 0x25, new Color32(236, 88, 180, 255) },
            { 0x26, new Color32(236, 106, 100, 255) },
            { 0x27, new Color32(212, 136, 32, 255) },
            { 0x28, new Color32(160, 170, 0, 255) },
            { 0x29, new Color32(116, 196, 0, 255) },
            { 0x2a, new Color32(76, 208, 32, 255) },
            { 0x2b, new Color32(56, 204, 108, 255) },
            { 0x2c, new Color32(56, 180, 204, 255) },
            { 0x2d, new Color32(60, 60, 60, 255) },
            { 0x2e, new Color32(0, 0, 0, 255) },
            { 0x2f, new Color32(0, 0, 0, 255) },
            { 0x30, new Color32(236, 238, 236, 255) },
            { 0x31, new Color32(168, 204, 236, 255) },
            { 0x32, new Color32(188, 188, 236, 255) },
            { 0x33, new Color32(212, 178, 236, 255) },
            { 0x34, new Color32(236, 174, 236, 255) },
            { 0x35, new Color32(236, 174, 212, 255) },
            { 0x36, new Color32(236, 180, 176, 255) },
            { 0x37, new Color32(228, 196, 144, 255) },
            { 0x38, new Color32(204, 210, 120, 255) },
            { 0x39, new Color32(180, 222, 120, 255) },
            { 0x3a, new Color32(168, 226, 144, 255) },
            { 0x3b, new Color32(152, 226, 180, 255) },
            { 0x3c, new Color32(160, 214, 228, 255) },
            { 0x3d, new Color32(160, 162, 160, 255) },
            { 0x3e, new Color32(0, 0, 0, 255) },
            { 0x3f, new Color32(0, 0, 0, 255) }
        };
    }

    public Dictionary<byte, Color32> Colors { get; private set; }
}