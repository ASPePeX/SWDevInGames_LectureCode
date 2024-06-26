using System.Numerics;

public class TransformComponent : ISceneComponent
{
  public string Name { get; set; }

  public Vector2 Position { get; set; }

  public TransformComponent(Vector2 position, string name = "TransformComponent")
  {
    Name = name;
    Position = position;
  }

  public void Accept(IVisitor visitor)
  {
    visitor.Visit(this);
  }
}