using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineDottedLineType']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/PolylineDottedLineType", DoNotGenerateAcw=true)]
	public sealed partial class PolylineDottedLineType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineDottedLineType']/field[@name='DOTTED_LINE_CIRCLE']"
		[Register ("DOTTED_LINE_CIRCLE")]
		public static global::Com.Baidu.Mapapi.Map.PolylineDottedLineType DottedLineCircle {
			get {
				const string __id = "DOTTED_LINE_CIRCLE.Lcom/baidu/mapapi/map/PolylineDottedLineType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineDottedLineType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineDottedLineType']/field[@name='DOTTED_LINE_SQUARE']"
		[Register ("DOTTED_LINE_SQUARE")]
		public static global::Com.Baidu.Mapapi.Map.PolylineDottedLineType DottedLineSquare {
			get {
				const string __id = "DOTTED_LINE_SQUARE.Lcom/baidu/mapapi/map/PolylineDottedLineType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineDottedLineType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/PolylineDottedLineType", typeof (PolylineDottedLineType));
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

		internal PolylineDottedLineType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineDottedLineType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/PolylineDottedLineType;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.PolylineDottedLineType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/map/PolylineDottedLineType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineDottedLineType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineDottedLineType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/map/PolylineDottedLineType;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.PolylineDottedLineType[] Values ()
		{
			const string __id = "values.()[Lcom/baidu/mapapi/map/PolylineDottedLineType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Baidu.Mapapi.Map.PolylineDottedLineType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.PolylineDottedLineType));
			} finally {
			}
		}

	}
}
