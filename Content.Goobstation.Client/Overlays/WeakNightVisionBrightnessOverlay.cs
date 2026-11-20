using System.Numerics;
using Robust.Client.Graphics;
using Robust.Shared.Enums;

namespace Content.Goobstation.Client.Overlays;

public sealed class HalfNightVisionBrightnessOverlay : Overlay
{
    public override OverlaySpace Space => OverlaySpace.BeforeLighting;

    protected override void Draw(in OverlayDrawArgs args)
    {
        if (args.DrawingHandle is not DrawingHandleWorld worldHandle)
            return;

        var location = args.WorldAABB.Center;
        var brightnessColor = new Color(0.55f, 0.55f, 0.55f,1f);

        worldHandle.DrawCircle(location,3f, brightnessColor); // make sure circle location is right
    }
}
