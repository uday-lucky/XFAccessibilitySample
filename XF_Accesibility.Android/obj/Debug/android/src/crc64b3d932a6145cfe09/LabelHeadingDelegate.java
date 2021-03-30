package crc64b3d932a6145cfe09;


public class LabelHeadingDelegate
	extends android.view.View.AccessibilityDelegate
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInitializeAccessibilityNodeInfo:(Landroid/view/View;Landroid/view/accessibility/AccessibilityNodeInfo;)V:GetOnInitializeAccessibilityNodeInfo_Landroid_view_View_Landroid_view_accessibility_AccessibilityNodeInfo_Handler\n" +
			"";
		mono.android.Runtime.register ("XF_Accesibility.Droid.LabelHeadingDelegate, XF_Accesibility.Android", LabelHeadingDelegate.class, __md_methods);
	}


	public LabelHeadingDelegate ()
	{
		super ();
		if (getClass () == LabelHeadingDelegate.class)
			mono.android.TypeManager.Activate ("XF_Accesibility.Droid.LabelHeadingDelegate, XF_Accesibility.Android", "", this, new java.lang.Object[] {  });
	}


	public void onInitializeAccessibilityNodeInfo (android.view.View p0, android.view.accessibility.AccessibilityNodeInfo p1)
	{
		n_onInitializeAccessibilityNodeInfo (p0, p1);
	}

	private native void n_onInitializeAccessibilityNodeInfo (android.view.View p0, android.view.accessibility.AccessibilityNodeInfo p1);

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
