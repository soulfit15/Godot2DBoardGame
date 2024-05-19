using Godot;
using System;

public partial class blue3: Sprite2D
{
	AnimationPlayer anim;
	bool isSelected = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var btn = GetNode<Button>("Button");
		btn.Toggled += toggle;
		anim = GetNode<AnimationPlayer>("AnimationPlayer");
	}

	private void toggle(bool toggledOn){
		if (toggledOn)
		{
			anim.Play("anim3");
			isSelected = true;
		} else if (!toggledOn)
		{
			anim.Stop();
			isSelected = false;
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
