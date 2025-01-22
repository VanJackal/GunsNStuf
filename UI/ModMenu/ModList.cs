using Godot;
using System;
using System.Collections.Generic;
using GunsNStuf.Data.Models;
using GunsNStuf.Data;

public partial class ModList : ScrollContainer
{
	[Export] public Container Container;

	[Export] public PackedScene ListItem;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// instantiate children
		foreach (var attachment in Data.GetInstance().Attachments.GetAll())
		{
			ModListItem instance = ListItem.Instantiate<ModListItem>();
			instance.From(attachment);
			Container.AddChild(instance);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
