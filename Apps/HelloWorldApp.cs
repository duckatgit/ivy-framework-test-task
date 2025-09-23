

[App(icon: Icons.Shell, title: "Hello World")]
public class HelloWorldApp : ViewBase
{
    public override object? Build()
    {
        return Layout.Center()
               | new Card(
                   Layout.Vertical().Gap(6).Padding(2)
                   | Text.H2("Hello World!")
                   | Text.Block("This is a simple Hello World app.")
                 )
                 .Width(Size.Units(120).Max(500));
    }
}