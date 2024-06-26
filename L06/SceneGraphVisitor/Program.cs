using System.Numerics;

var scene = new SceneNode("Root");

{
  // Nodes definieren
  var sceneNode1 = new SceneNode("Node1");
  var sceneNode2 = new SceneNode("Node2");
  var sceneNode3 = new SceneNode("Node3");

  var sceneNode21 = new SceneNode("Node21");
  var sceneNode22 = new SceneNode("Node22");

  // Nodes verschachteln

  scene.SceneNodes.Add(sceneNode1);
  scene.SceneNodes.Add(sceneNode2);
  scene.SceneNodes.Add(sceneNode3);

  sceneNode2.SceneNodes.Add(sceneNode21);
  sceneNode2.SceneNodes.Add(sceneNode22);

  // Components definieren

  var sceneComp1Trans = new TransformComponent(new Vector2(1, 2));
  var sceneComp1Mat = new MaterialComponent("red");
  var sceneComp1Mesh = new MeshComponent(1238872);

  var sceneComp2Trans = new TransformComponent(new Vector2(23, 32));

  var sceneComp21Mat = new MaterialComponent("white");
  var sceneComp21Mesh = new MeshComponent(93462, "Rocket Mesh White");

  var sceneComp22Mat = new MaterialComponent("green");
  var sceneComp22Mesh1 = new MeshComponent(12859, "Rocket Mesh Green 1");
  var sceneComp22Mesh2 = new MeshComponent(76356, "Rocket Mesh Green 1");

  var sceneComp3Trans = new TransformComponent(new Vector2(3, 7));
  var sceneComp3Mat = new MaterialComponent("blue");
  var sceneComp3Mesh = new MeshComponent(4567);

  // Components verschachteln

  sceneNode1.SceneComponents = new List<ISceneComponent> { sceneComp1Trans, sceneComp1Mat, sceneComp1Mesh };

  sceneNode2.SceneComponents.Add(sceneComp2Trans);

  sceneNode21.SceneComponents = new List<ISceneComponent> { sceneComp21Mat, sceneComp21Mesh };
  sceneNode22.SceneComponents = new List<ISceneComponent> { sceneComp22Mat, sceneComp22Mesh1, sceneComp22Mesh2 };

  sceneNode3.SceneComponents = new List<ISceneComponent> { sceneComp3Trans, sceneComp3Mat, sceneComp3Mesh };
}

Console.WriteLine("Start Visiting");



Console.WriteLine("Done Visiting");