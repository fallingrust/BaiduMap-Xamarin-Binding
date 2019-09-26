using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkvi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VMsg']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkvi/VMsg", DoNotGenerateAcw=true)]
	public partial class VMsg : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkvi/VMsg", typeof (VMsg));
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

		protected VMsg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VMsg']/constructor[@name='VMsg' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VMsg ()
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

		public static unsafe global::Com.Baidu.Mapsdkvi.VMsg Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VMsg']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/mapsdkvi/VMsg;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/baidu/mapsdkvi/VMsg;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkvi.VMsg> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VMsg']/method[@name='InitClass' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("InitClass", "(Ljava/lang/Object;)V", "")]
		public static unsafe void InitClass (global::Java.Lang.Object p0)
		{
			const string __id = "InitClass.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VMsg']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public static unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkvi']/class[@name='VMsg']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "")]
		public static unsafe void Init ()
		{
			const string __id = "init.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
