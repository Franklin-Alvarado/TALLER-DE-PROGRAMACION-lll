using TemplateMethod;

 void renderEngine(Component component)
{
    component.Create();
}

TitleComponent title = new TitleComponent();
SubtitleComponent subtitleComponent = new SubtitleComponent();
renderEngine(title);
Console.WriteLine("_________________________");
renderEngine(subtitleComponent);
