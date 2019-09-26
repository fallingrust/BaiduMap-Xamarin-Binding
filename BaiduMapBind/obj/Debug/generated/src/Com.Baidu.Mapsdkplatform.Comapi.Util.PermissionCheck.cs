using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comapi.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='PermissionCheck']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comapi/util/PermissionCheck", DoNotGenerateAcw=true)]
	public partial class PermissionCheck : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='PermissionCheck']/field[@name='a']"
		[Register ("a")]
		public static int A {
			get {
				const string __id = "a.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "a.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='PermissionCheck']/field[@name='b']"
		[Register ("b")]
		public static int B {
			get {
				const string __id = "b.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "b.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='PermissionCheck']/field[@name='c']"
		[Register ("c")]
		public static int C {
			get {
				const string __id = "c.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "c.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comapi/util/PermissionCheck", typeof (PermissionCheck));
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

		protected PermissionCheck (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='PermissionCheck']/constructor[@name='PermissionCheck' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PermissionCheck ()
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

		public static unsafe int PermissionResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='PermissionCheck']/method[@name='getPermissionResult' and count(parameter)=0]"
			[Register ("getPermissionResult", "()I", "GetGetPermissionResultHandler")]
			get {
				const string __id = "getPermissionResult.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='PermissionCheck']/method[@name='destory' and count(parameter)=0]"
		[Register ("destory", "()V", "")]
		public static unsafe void Destory ()
		{
			const string __id = "destory.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='PermissionCheck']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='PermissionCheck']/method[@name='permissionCheck' and count(parameter)=0]"
		[Register ("permissionCheck", "()I", "")]
		public static unsafe int InvokePermissionCheck ()
		{
			const string __id = "permissionCheck.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
