public class SceneNode : ISceneNode
{
  public string Name { get; set; }

  public List<ISceneComponent> SceneComponents;

  public List<ISceneNode> SceneNodes;

  public SceneNode(string name = "SceneNode")
  {
    Name = name;

    SceneComponents = new List<ISceneComponent>();
    SceneNodes = new List<ISceneNode>();
  }
}