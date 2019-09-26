using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MarkerOptions", DoNotGenerateAcw=true)]
	public sealed partial class MarkerOptions : global::Com.Baidu.Mapapi.Map.OverlayOptions {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MarkerOptions$MarkerAnimateType", DoNotGenerateAcw=true)]
		public sealed partial class MarkerAnimateType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/field[@name='drop']"
			[Register ("drop")]
			public static global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType Drop {
				get {
					const string __id = "drop.Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/field[@name='grow']"
			[Register ("grow")]
			public static global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType Grow {
				get {
					const string __id = "grow.Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/field[@name='jump']"
			[Register ("jump")]
			public static global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType Jump {
				get {
					const string __id = "jump.Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/field[@name='none']"
			[Register ("none")]
			public static global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType None {
				get {
					const string __id = "none.Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MarkerOptions$MarkerAnimateType", typeof (MarkerAnimateType));
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

			internal MarkerAnimateType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions.MarkerAnimateType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MarkerOptions", typeof (MarkerOptions));
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

		internal MarkerOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/constructor[@name='MarkerOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MarkerOptions ()
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

		public unsafe float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				const string __id = "getAlpha.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float AnchorX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getAnchorX' and count(parameter)=0]"
			[Register ("getAnchorX", "()F", "GetGetAnchorXHandler")]
			get {
				const string __id = "getAnchorX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float AnchorY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getAnchorY' and count(parameter)=0]"
			[Register ("getAnchorY", "()F", "GetGetAnchorYHandler")]
			get {
				const string __id = "getAnchorY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType AnimateType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getAnimateType' and count(parameter)=0]"
			[Register ("getAnimateType", "()Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;", "GetGetAnimateTypeHandler")]
			get {
				const string __id = "getAnimateType.()Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getExtraInfo' and count(parameter)=0]"
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

		public unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetIconHandler")]
			get {
				const string __id = "getIcon.()Lcom/baidu/mapapi/map/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> Icons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getIcons' and count(parameter)=0]"
			[Register ("getIcons", "()Ljava/util/ArrayList;", "GetGetIconsHandler")]
			get {
				const string __id = "getIcons.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsDraggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				const string __id = "isDraggable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsFlat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='isFlat' and count(parameter)=0]"
			[Register ("isFlat", "()Z", "GetIsFlatHandler")]
			get {
				const string __id = "isFlat.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsPerspective {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='isPerspective' and count(parameter)=0]"
			[Register ("isPerspective", "()Z", "GetIsPerspectiveHandler")]
			get {
				const string __id = "isPerspective.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='isVisible' and count(parameter)=0]"
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

		public unsafe int Period {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getPeriod' and count(parameter)=0]"
			[Register ("getPeriod", "()I", "GetGetPeriodHandler")]
			get {
				const string __id = "getPeriod.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/baidu/mapapi/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float Rotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getRotate' and count(parameter)=0]"
			[Register ("getRotate", "()F", "GetGetRotateHandler")]
			get {
				const string __id = "getRotate.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='getZIndex' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='alpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alpha", "(F)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeAlpha (float p0)
		{
			const string __id = "alpha.(F)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='anchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("anchor", "(FF)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Anchor (float p0, float p1)
		{
			const string __id = "anchor.(FF)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='animateType' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MarkerOptions.MarkerAnimateType']]"
		[Register ("animateType", "(Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeAnimateType (global::Com.Baidu.Mapapi.Map.MarkerOptions.MarkerAnimateType p0)
		{
			const string __id = "animateType.(Lcom/baidu/mapapi/map/MarkerOptions$MarkerAnimateType;)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='clickable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("clickable", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Clickable (bool p0)
		{
			const string __id = "clickable.(Z)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='draggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("draggable", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Draggable (bool p0)
		{
			const string __id = "draggable.(Z)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='extraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extraInfo", "(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeExtraInfo (global::Android.OS.Bundle p0)
		{
			const string __id = "extraInfo.(Landroid/os/Bundle;)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='fixedScreenPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("fixedScreenPosition", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions FixedScreenPosition (global::Android.Graphics.Point p0)
		{
			const string __id = "fixedScreenPosition.(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='flat' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("flat", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Flat (bool p0)
		{
			const string __id = "flat.(Z)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='icon' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
		[Register ("icon", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeIcon (global::Com.Baidu.Mapapi.Map.BitmapDescriptor p0)
		{
			const string __id = "icon.(Lcom/baidu/mapapi/map/BitmapDescriptor;)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='icons' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.baidu.mapapi.map.BitmapDescriptor&gt;']]"
		[Register ("icons", "(Ljava/util/ArrayList;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeIcons (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> p0)
		{
			const string __id = "icons.(Ljava/util/ArrayList;)Lcom/baidu/mapapi/map/MarkerOptions;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='infoWindow' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.InfoWindow']]"
		[Register ("infoWindow", "(Lcom/baidu/mapapi/map/InfoWindow;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InfoWindow (global::Com.Baidu.Mapapi.Map.InfoWindow p0)
		{
			const string __id = "infoWindow.(Lcom/baidu/mapapi/map/InfoWindow;)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='period' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("period", "(I)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokePeriod (int p0)
		{
			const string __id = "period.(I)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='perspective' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("perspective", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Perspective (bool p0)
		{
			const string __id = "perspective.(Z)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("position", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokePosition (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "position.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotate", "(F)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeRotate (float p0)
		{
			const string __id = "rotate.(F)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='scaleX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleX", "(F)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions ScaleX (float p0)
		{
			const string __id = "scaleX.(F)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='scaleY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("scaleY", "(F)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions ScaleY (float p0)
		{
			const string __id = "scaleY.(F)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='title' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("title", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeTitle (string p0)
		{
			const string __id = "title.(Ljava/lang/String;)Lcom/baidu/mapapi/map/MarkerOptions;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions Visible (bool p0)
		{
			const string __id = "visible.(Z)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='yOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("yOffset", "(I)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions YOffset (int p0)
		{
			const string __id = "yOffset.(I)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MarkerOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("zIndex", "(I)Lcom/baidu/mapapi/map/MarkerOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.MarkerOptions InvokeZIndex (int p0)
		{
			const string __id = "zIndex.(I)Lcom/baidu/mapapi/map/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
