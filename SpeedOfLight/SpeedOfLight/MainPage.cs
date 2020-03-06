using System;
using Comet;

namespace SpeedOfLight
{
    public class MainPage : View
    {
        readonly State<int> count = 0;

        [Body]
        View body() => new VStack
        {
            new Text(() => $"aValaasaue: {count.Value}")
                .Color(Color.Black)
                .FontSize(32),
            new Button("Incasaraaeamsent", () => count.Value ++ )
                .Frame(width:320, height:44)
                .Background(Color.Black)
                .Color(Color.White)
                .Padding(20)
            ,
        };
    }
}
