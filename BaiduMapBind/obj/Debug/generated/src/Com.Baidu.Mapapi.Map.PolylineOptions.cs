using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/PolylineOptions", DoNotGenerateAcw=true)]
	public sealed partial class PolylineOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/PolylineOptions", typeof (PolylineOptions));
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

		internal PolylineOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/constructor[@name='PolylineOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PolylineOptions ()
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

		public unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor CustomTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getCustomTexture' and count(parameter)=0]"
			[Register ("getCustomTexture", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetCustomTextureHandler")]
			get {
				const string __id = "getCustomTexture.()Lcom/baidu/mapapi/map/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> CustomTextureList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getCustomTextureList' and count(parameter)=0]"
			[Register ("getCustomTextureList", "()Ljava/util/List;", "GetGetCustomTextureListHandler")]
			get {
				const string __id = "getCustomTextureList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getExtraInfo' and count(parameter)=0]"
			[Register ("getExtraInfo", "()Landroid/os/Bundle;", "GetGetExtraInfoHandler")]
			get {
				const string __id = "getExtraInfo.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsDottedLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='isDottedLine' and count(parameter)=0]"
			[Register ("isDottedLine", "()Z", "GetIsDottedLineHandler")]
			get {
				const string __id = "isDottedLine.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsFocus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='isFocus' and count(parameter)=0]"
			[Register ("isFocus", "()Z", "GetIsFocusHandler")]
			get {
				const string __id = "isFocus.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				const string __id = "getPoints.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> TextureIndexs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getTextureIndexs' and count(parameter)=0]"
			[Register ("getTextureIndexs", "()Ljava/util/List;", "GetGetTextureIndexsHandler")]
			get {
				const string __id = "getTextureIndexs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()I", "GetGetZIndexHandler")]
			get {
				const string __id = "getZIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='clickable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("clickable", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions Clickable (bool p0)
		{
			const string __id = "clickable.(Z)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("color", "(I)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeColor (int p0)
		{
			const string __id = "color.(I)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='colorsValues' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("colorsValues", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions ColorsValues (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
		{
			const string __id = "colorsValues.(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='customTexture' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
		[Register ("customTexture", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeCustomTexture (global::Com.Baidu.Mapapi.Map.BitmapDescriptor p0)
		{
			const string __id = "customTexture.(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='customTextureList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.map.BitmapDescriptor&gt;']]"
		[Register ("customTextureList", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeCustomTextureList (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> p0)
		{
			const string __id = "customTextureList.(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='dottedLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("dottedLine", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions DottedLine (bool p0)
		{
			const string __id = "dottedLine.(Z)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='dottedLineType' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.PolylineDottedLineType']]"
		[Register ("dottedLineType", "(Lcom/baidu/mapapi/map/PolylineDottedLineType;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions DottedLineType (global::Com.Baidu.Mapapi.Map.PolylineDottedLineType p0)
		{
			const string __id = "dottedLineType.(Lcom/baidu/mapapi/map/PolylineDottedLineType;)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='extraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeExtraInfo (global::Android.OS.Bundle p0)
		{
			const string __id = "extraInfo.(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='focus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("focus", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions Focus (bool p0)
		{
			const string __id = "focus.(Z)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='keepScale' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("keepScale", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions KeepScale (bool p0)
		{
			const string __id = "keepScale.(Z)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='points' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;']]"
		[Register ("points", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokePoints (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> p0)
		{
			const string __id = "points.(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='textureIndex' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("textureIndex", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions TextureIndex (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
		{
			const string __id = "textureIndex.(Ljava/util/List;)Lcom/baidu/mapapi/map/PolylineOptions;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions Visible (bool p0)
		{
			const string __id = "visible.(Z)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='width' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("width", "(I)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeWidth (int p0)
		{
			const string __id = "width.(I)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolylineOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("zIndex", "(I)Lcom/baidu/mapapi/map/PolylineOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.PolylineOptions InvokeZIndex (int p0)
		{
			const string __id = "zIndex.(I)Lcom/baidu/mapapi/map/PolylineOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolylineOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
