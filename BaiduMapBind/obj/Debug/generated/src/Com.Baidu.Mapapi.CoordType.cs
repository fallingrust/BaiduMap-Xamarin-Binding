using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='CoordType']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/CoordType", DoNotGenerateAcw=true)]
	public sealed partial class CoordType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='CoordType']/field[@name='BD09LL']"
		[Register ("BD09LL")]
		public static global::Com.Baidu.Mapapi.CoordType Bd09ll {
			get {
				const string __id = "BD09LL.Lcom/baidu/mapapi/CoordType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.CoordType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='CoordType']/field[@name='GCJ02']"
		[Register ("GCJ02")]
		public static global::Com.Baidu.Mapapi.CoordType Gcj02 {
			get {
				const string __id = "GCJ02.Lcom/baidu/mapapi/CoordType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.CoordType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/CoordType", typeof (CoordType));
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

		internal CoordType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='CoordType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/CoordType;", "")]
		public static unsafe global::Com.Baidu.Mapapi.CoordType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/CoordType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.CoordType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='CoordType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/CoordType;", "")]
		public static unsafe global::Com.Baidu.Mapapi.CoordType[] Values ()
		{
			const string __id = "values.()[Lcom/baidu/mapapi/CoordType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Baidu.Mapapi.CoordType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.CoordType));
			} finally {
			}
		}

	}
}
