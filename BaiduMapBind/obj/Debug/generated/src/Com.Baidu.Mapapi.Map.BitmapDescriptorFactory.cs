using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/BitmapDescriptorFactory", DoNotGenerateAcw=true)]
	public partial class BitmapDescriptorFactory : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/BitmapDescriptorFactory", typeof (BitmapDescriptorFactory));
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

		protected BitmapDescriptorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/constructor[@name='BitmapDescriptorFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapDescriptorFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromAsset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAsset", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromAsset (string p0)
		{
			const string __id = "fromAsset.(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromAssetWithDpi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAssetWithDpi", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromAssetWithDpi (string p0)
		{
			const string __id = "fromAssetWithDpi.(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromBitmap (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "fromBitmap.(Landroid/graphics/Bitmap;)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromFile", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromFile (string p0)
		{
			const string __id = "fromFile.(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromFileWithDpi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("fromFileWithDpi", "(Ljava/lang/String;I)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromFileWithDpi (string p0, int p1)
		{
			const string __id = "fromFileWithDpi.(Ljava/lang/String;I)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromPath", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromPath (string p0)
		{
			const string __id = "fromPath.(Ljava/lang/String;)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromPathWithDpi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("fromPathWithDpi", "(Ljava/lang/String;I)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromPathWithDpi (string p0, int p1)
		{
			const string __id = "fromPathWithDpi.(Ljava/lang/String;I)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromResource", "(I)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromResource (int p0)
		{
			const string __id = "fromResource.(I)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromResourceWithDpi' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("fromResourceWithDpi", "(II)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromResourceWithDpi (int p0, int p1)
		{
			const string __id = "fromResourceWithDpi.(II)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("fromView", "(Landroid/view/View;)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromView (global::Android.Views.View p0)
		{
			const string __id = "fromView.(Landroid/view/View;)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BitmapDescriptorFactory']/method[@name='fromViewWithDpi' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("fromViewWithDpi", "(Landroid/view/View;I)Lcom/baidu/mapapi/map/BitmapDescriptor;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor FromViewWithDpi (global::Android.Views.View p0, int p1)
		{
			const string __id = "fromViewWithDpi.(Landroid/view/View;I)Lcom/baidu/mapapi/map/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
