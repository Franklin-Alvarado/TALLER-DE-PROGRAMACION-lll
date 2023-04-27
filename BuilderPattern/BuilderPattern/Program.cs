using BuilderPattern;

Console.WriteLine("Pizzas");
BuilderDirector builderDirector = new BuilderDirector();
Console.WriteLine(builderDirector.PizzaBuilder(new PizzaItalianaBuilder()));
Console.WriteLine(builderDirector.PizzaBuilder(new PizzaLightBuilder()));
Console.WriteLine(builderDirector.PizzaBuilder(new PizzaMuzzaBuilder()));
