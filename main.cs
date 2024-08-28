using Godot;
using System;

public partial class main : Node2D
{
    SignalManager signalManager;

    Label label;

	public override void _Ready()
	{
        signalManager = GetNode<SignalManager>("/root/SignalManager");
        signalManager.FromReceiver += ReceiveSignalFromReceiver;
        label = GetNode<Label>("Label2");
	}

    public void ReceiveSignalFromReceiver(int count){
        label.Text = count.ToString();
    }
    
    public void _on_button_pressed(){
        signalManager.EmitSignal(nameof(SignalManager.FromMain));
    }
}
