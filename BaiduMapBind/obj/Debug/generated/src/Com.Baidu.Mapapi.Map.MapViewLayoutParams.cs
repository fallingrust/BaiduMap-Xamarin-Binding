using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapViewLayoutParams", DoNotGenerateAcw=true)]
	public sealed partial class MapViewLayoutParams : global::Android.Views.ViewGroup.LayoutParams {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_BOTTOM']"
		[Register ("ALIGN_BOTTOM")]
		public const int AlignBottom = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_CENTER_HORIZONTAL']"
		[Register ("ALIGN_CENTER_HORIZONTAL")]
		public const int AlignCenterHorizontal = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_CENTER_VERTICAL']"
		[Register ("ALIGN_CENTER_VERTICAL")]
		public const int AlignCenterVertical = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_LEFT']"
		[Register ("ALIGN_LEFT")]
		public const int AlignLeft = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_RIGHT']"
		[Register ("ALIGN_RIGHT")]
		public const int AlignRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams']/field[@name='ALIGN_TOP']"
		[Register ("ALIGN_TOP")]
		public const int AlignTop = (int) 8;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapViewLayoutParams$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapViewLayoutParams$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/constructor[@name='MapViewLayoutParams.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='align' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("align", "(II)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Align (int p0, int p1)
			{
				const string __id = "align.(II)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/mapapi/map/MapViewLayoutParams;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams Build ()
			{
				const string __id = "build.()Lcom/baidu/mapapi/map/MapViewLayoutParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='height' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("height", "(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Height (int p0)
			{
				const string __id = "height.(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='layoutMode' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapViewLayoutParams.ELayoutMode']]"
			[Register ("layoutMode", "(Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder LayoutMode (global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode p0)
			{
				const string __id = "layoutMode.(Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='point' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
			[Register ("point", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Point (global::Android.Graphics.Point p0)
			{
				const string __id = "point.(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Position (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				const string __id = "position.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='width' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("width", "(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder Width (int p0)
			{
				const string __id = "width.(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.Builder']/method[@name='yOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("yOffset", "(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;", "")]
			public unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder YOffset (int p0)
			{
				const string __id = "yOffset.(I)Lcom/baidu/mapapi/map/MapViewLayoutParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode", DoNotGenerateAcw=true)]
		public sealed partial class ELayoutMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']/field[@name='absoluteMode']"
			[Register ("absoluteMode")]
			public static global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode AbsoluteMode {
				get {
					const string __id = "absoluteMode.Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']/field[@name='mapMode']"
			[Register ("mapMode")]
			public static global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode MapMode {
				get {
					const string __id = "mapMode.Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode", typeof (ELayoutMode));
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

			internal ELayoutMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapViewLayoutParams.ELayoutMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/mapapi/map/MapViewLayoutParams$ELayoutMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.MapViewLayoutParams.ELayoutMode));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapViewLayoutParams", typeof (MapViewLayoutParams));
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

		internal MapViewLayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
