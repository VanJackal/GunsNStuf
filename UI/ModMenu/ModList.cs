using Godot;
using System;
using System.Collections.Generic;
using GunsNStuf.Data.Models;

public partial class ModList : ScrollContainer
{
	private List<Attachment> _attachments;
	[Export] public Container Container;

	[Export] public PackedScene ListItem;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//todo load this from some kind of static registry
		_attachments = new List<Attachment>
		{
			new("mod1"),
			new("mod2"),
			new("mod3"),
			new("mod4"),
			new("mod5"),
			new("mod6"),
		};
		// instantiate children
		foreach (var attachment in _attachments)
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
