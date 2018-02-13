using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected virtual void On_clicked (object sender, EventArgs e)
	{
		var Msg = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Hello World!");
		if ((ResponseType)Msg.Run () == ResponseType.Ok)
			Msg.Destroy();
	}
}
