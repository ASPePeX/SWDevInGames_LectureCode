public class DebugVisitor : IVisitor
{
  public string Name { get; } = "Debug Visitor";

  public void Visit(SceneNode sceneNode)
  {
    Console.WriteLine($"Visiting Node {sceneNode.Name}");

    foreach (var comp in sceneNode.SceneComponents)
    {
      comp.Accept(this);
    }

    foreach (var node in sceneNode.SceneNodes)
    {
      node.Accept(this);
    }
  }

  public void Visit(TransformComponent transformComponent)
  {
    Console.WriteLine($"Positioning from {transformComponent.Name} to {transformComponent.Position}");
  }

  public void Visit(MaterialComponent materialComponent)
  {
    Console.WriteLine($"Painting material {materialComponent.Name} with color {materialComponent.Color}");
  }

  public void Visit(MeshComponent meshComponent)
  {
    Console.WriteLine($"Meshing mesh {meshComponent.Name} with {meshComponent.Vertices} vertices");
  }
}