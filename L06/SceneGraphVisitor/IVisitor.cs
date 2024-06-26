public interface IVisitor
{
  public string Name { get; }

  public void Visit(SceneNode sceneNode);

  public void Visit(TransformComponent transformComponent);
  public void Visit(MaterialComponent materialComponent);
  public void Visit(MeshComponent meshComponent);
}