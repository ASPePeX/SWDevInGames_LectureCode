public class MeshComponent : ISceneComponent
{
  public string Name { get; set; }

  public int Vertices { get; set; }

  public MeshComponent(int vertices, string name = "MeshComponent")
  {
    Name = name;
    Vertices = vertices;
  }

  public void Accept(IVisitor visitor)
  {
    visitor.Visit(this);
  }
}