using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='OpenLogUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/OpenLogUtil", DoNotGenerateAcw=true)]
	public partial class OpenLogUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/OpenLogUtil", typeof (OpenLogUtil));
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

		protected OpenLogUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='OpenLogUtil']/constructor[@name='OpenLogUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenLogUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='OpenLogUtil']/method[@name='setModuleLogEnable' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.ModuleName'] and parameter[2][@type='boolean']]"
		[Register ("setModuleLogEnable", "(Lcom/baidu/mapapi/ModuleName;Z)V", "")]
		public static unsafe void SetModuleLogEnable (global::Com.Baidu.Mapapi.ModuleName p0, bool p1)
		{
			const string __id = "setModuleLogEnable.(Lcom/baidu/mapapi/ModuleName;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
