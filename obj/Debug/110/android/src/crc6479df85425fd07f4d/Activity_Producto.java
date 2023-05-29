package crc6479df85425fd07f4d;


public class Activity_Producto
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ClasePractica01.Activity_Producto, ClasePractica01", Activity_Producto.class, __md_methods);
	}


	public Activity_Producto ()
	{
		super ();
		if (getClass () == Activity_Producto.class)
			mono.android.TypeManager.Activate ("ClasePractica01.Activity_Producto, ClasePractica01", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
