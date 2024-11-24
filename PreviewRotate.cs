using Godot;
using System;

public partial class PreviewRotate : Node3D
{
	[Export] public int RotationFactor { get; set; } = 200;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//Rotate(new Vector3(0.5f,0.5f,0).Normalized(), (float)delta);
	}

	private void DoRotate(Vector2 move) {
		float mag = move.Length();
		Vector3 axis = Vector3.Back.Cross(new Vector3(move.X, -move.Y, 0)).Normalized();
		GlobalRotate(axis,mag/RotationFactor);
	}
    public override void _Input(InputEvent @event)
    { //todo add click and drag
		if (@event is InputEventMouseMotion eventMouseMotion) {
			Vector2 deltaMouse = eventMouseMotion.Relative;
			DoRotate(deltaMouse);
		}
    }
}
