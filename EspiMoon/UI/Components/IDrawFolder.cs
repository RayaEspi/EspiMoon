
using System.Collections.Immutable;

namespace EspiMoon.UI.Components;

public interface IDrawFolder
{
    int TotalPairs { get; }
    int OnlinePairs { get; }
    IImmutableList<DrawUserPair> DrawPairs { get; }
    void Draw();
}
