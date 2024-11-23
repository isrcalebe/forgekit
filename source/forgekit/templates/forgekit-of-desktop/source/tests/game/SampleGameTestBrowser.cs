global using osu.Framework.Allocation;
global using osu.Framework.Bindables;
global using osu.Framework.Graphics;
global using osu.Framework.Graphics.Primitives;
global using osu.Framework.Logging;
global using osu.Framework.Testing;
global using osu.Framework.Utils;
global using osuTK;
using osu.Framework.Graphics.Cursor;
using osu.Framework.Platform;

namespace SampleGame.Game.Tests;

public partial class SampleGameTestBrowser : SampleGameGameBase
{
    protected override void LoadComplete()
    {
        base.LoadComplete();

        AddRange(
        [
            new TestBrowser("SampleGame"),
            new CursorContainer()
        ]);
    }

    public override void SetHost(GameHost host)
    {
        base.SetHost(host);

        host.Window.CursorState |= CursorState.Hidden;
    }
}