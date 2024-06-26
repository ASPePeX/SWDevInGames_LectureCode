public class MaterialComponent : ISceneComponent
{
  public string Name { get; set; }

  public string Color { get; set; }

  public MaterialComponent(string color, string name = "MaterialComponent")
  {
    Name = name;
    Color = color;
  }
}