using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Map.Basemap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='BaseMapCallback']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/map/basemap/BaseMapCallback", DoNotGenerateAcw=true)]
	public partial class BaseMapCallback : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/map/basemap/BaseMapCallback", typeof (BaseMapCallback));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected BaseMapCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='BaseMapCallback']/constructor[@name='BaseMapCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseMapCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='BaseMapCallback']/method[@name='ReqLayerData' and count(parameter)=4 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("ReqLayerData", "(Landroid/os/Bundle;JILandroid/os/Bundle;)I", "")]
		public static unsafe int ReqLayerData (global::Android.OS.Bundle p0, long p1, int p2, global::Android.OS.Bundle p3)
		{
			const string __id = "ReqLayerData.(Landroid/os/Bundle;JILandroid/os/Bundle;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.map.basemap']/class[@name='BaseMapCallback']/method[@name='removeLayerDataInterface' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("removeLayerDataInterface", "(J)V", "")]
		public static unsafe void RemoveLayerDataInterface (long p0)
		{
			const string __id = "removeLayerDataInterface.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
