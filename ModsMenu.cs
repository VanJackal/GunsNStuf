using Godot;
using System;

public partial class ModsMenu : Tree
{
	[Export] public Tree Tree;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		TreeItem root = Tree.CreateItem();
		root.SetText(0,"Root");
		//Tree.HideRoot = true;
		TreeItem child1 = Tree.CreateItem(root);
		TreeItem child2 = Tree.CreateItem(root);
		TreeItem subchild1 = Tree.CreateItem(child1);
		subchild1.SetText(0, "Subchild1");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
