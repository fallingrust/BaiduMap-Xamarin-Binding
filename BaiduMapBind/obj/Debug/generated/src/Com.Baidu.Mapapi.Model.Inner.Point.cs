using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Model.Inner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/inner/Point", DoNotGenerateAcw=true)]
	public partial class Point : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/field[@name='x']"
		[Register ("x")]
		public int X {
			get {
				const string __id = "x.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "x.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/field[@name='y']"
		[Register ("y")]
		public int Y {
			get {
				const string __id = "y.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "y.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/model/inner/Point", typeof (Point));
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

		protected Point (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/constructor[@name='Point' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Point ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/constructor[@name='Point' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Point (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getmPtx;
#pragma warning disable 0169
		static Delegate GetGetmPtxHandler ()
		{
			if (cb_getmPtx == null)
				cb_getmPtx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmPtx);
			return cb_getmPtx;
		}

		static int n_GetmPtx (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.Point __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmPtx ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/method[@name='getmPtx' and count(parameter)=0]"
		[Register ("getmPtx", "()I", "GetGetmPtxHandler")]
		public virtual unsafe int GetmPtx ()
		{
			const string __id = "getmPtx.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getmPty;
#pragma warning disable 0169
		static Delegate GetGetmPtyHandler ()
		{
			if (cb_getmPty == null)
				cb_getmPty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmPty);
			return cb_getmPty;
		}

		static int n_GetmPty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.Point __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmPty ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/method[@name='getmPty' and count(parameter)=0]"
		[Register ("getmPty", "()I", "GetGetmPtyHandler")]
		public virtual unsafe int GetmPty ()
		{
			const string __id = "getmPty.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setmPtx_I;
#pragma warning disable 0169
		static Delegate GetSetmPtx_IHandler ()
		{
			if (cb_setmPtx_I == null)
				cb_setmPtx_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmPtx_I);
			return cb_setmPtx_I;
		}

		static void n_SetmPtx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.Point __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmPtx (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/method[@name='setmPtx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmPtx", "(I)V", "GetSetmPtx_IHandler")]
		public virtual unsafe void SetmPtx (int p0)
		{
			const string __id = "setmPtx.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setmPty_I;
#pragma warning disable 0169
		static Delegate GetSetmPty_IHandler ()
		{
			if (cb_setmPty_I == null)
				cb_setmPty_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmPty_I);
			return cb_setmPty_I;
		}

		static void n_SetmPty_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.Point __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmPty (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='Point']/method[@name='setmPty' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmPty", "(I)V", "GetSetmPty_IHandler")]
		public virtual unsafe void SetmPty (int p0)
		{
			const string __id = "setmPty.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
