using Godot;
using System;

public partial class receiver : Node2D
{
    SignalManager signalManager;
    int count=0;
    Timer timer;
    Label label;

	public override void _Ready()
	{
        signalManager= GetNode<SignalManager>("/root/SignalManager");
        signalManager.FromMain += ReceiveSignalFromMain;
        label = GetNode<Label>("Label2");

        timer= GetNode<Timer>("Timer");
	}

    public void ReceiveSignalFromMain(){
        GD.Print("signal received from main");
        label.Text = "signal received from main";
        timer.Start();
    }

    public void _on_button_pressed(){
        count++;
        signalManager.EmitSignal(nameof(SignalManager.FromReceiver), count);
    }

    public void _on_timer_timeout(){
        label.Text = "-";
    }
}
