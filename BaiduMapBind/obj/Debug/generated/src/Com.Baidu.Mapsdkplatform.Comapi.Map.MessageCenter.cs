using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.map']/class[@name='MessageCenter']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comapi/map/MessageCenter", DoNotGenerateAcw=true)]
	public partial class MessageCenter : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comapi/map/MessageCenter", typeof (MessageCenter));
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

		protected MessageCenter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.map']/class[@name='MessageCenter']/constructor[@name='MessageCenter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageCenter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.map']/class[@name='MessageCenter']/method[@name='registMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler']]"
		[Register ("registMessage", "(ILandroid/os/Handler;)V", "")]
		public static unsafe void RegistMessage (int p0, global::Android.OS.Handler p1)
		{
			const string __id = "registMessage.(ILandroid/os/Handler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.map']/class[@name='MessageCenter']/method[@name='unregistMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Handler']]"
		[Register ("unregistMessage", "(ILandroid/os/Handler;)V", "")]
		public static unsafe void UnregistMessage (int p0, global::Android.OS.Handler p1)
		{
			const string __id = "unregistMessage.(ILandroid/os/Handler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
