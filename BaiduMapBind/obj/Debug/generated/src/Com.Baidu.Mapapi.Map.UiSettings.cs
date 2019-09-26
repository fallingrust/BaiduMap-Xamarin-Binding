using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/UiSettings", DoNotGenerateAcw=true)]
	public sealed partial class UiSettings : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/UiSettings", typeof (UiSettings));
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

		internal UiSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool CompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isCompassEnabled' and count(parameter)=0]"
			[Register ("isCompassEnabled", "()Z", "GetIsCompassEnabledHandler")]
			get {
				const string __id = "isCompassEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setCompassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCompassEnabled", "(Z)V", "GetSetCompassEnabled_ZHandler")]
			set {
				const string __id = "setCompassEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool OverlookingGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isOverlookingGesturesEnabled' and count(parameter)=0]"
			[Register ("isOverlookingGesturesEnabled", "()Z", "GetIsOverlookingGesturesEnabledHandler")]
			get {
				const string __id = "isOverlookingGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setOverlookingGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOverlookingGesturesEnabled", "(Z)V", "GetSetOverlookingGesturesEnabled_ZHandler")]
			set {
				const string __id = "setOverlookingGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool RotateGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isRotateGesturesEnabled' and count(parameter)=0]"
			[Register ("isRotateGesturesEnabled", "()Z", "GetIsRotateGesturesEnabledHandler")]
			get {
				const string __id = "isRotateGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setRotateGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRotateGesturesEnabled", "(Z)V", "GetSetRotateGesturesEnabled_ZHandler")]
			set {
				const string __id = "setRotateGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("isScrollGesturesEnabled", "()Z", "GetIsScrollGesturesEnabledHandler")]
			get {
				const string __id = "isScrollGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScrollGesturesEnabled", "(Z)V", "GetSetScrollGesturesEnabled_ZHandler")]
			set {
				const string __id = "setScrollGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='isZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("isZoomGesturesEnabled", "()Z", "GetIsZoomGesturesEnabledHandler")]
			get {
				const string __id = "isZoomGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomGesturesEnabled", "(Z)V", "GetSetZoomGesturesEnabled_ZHandler")]
			set {
				const string __id = "setZoomGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setAllGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllGesturesEnabled", "(Z)V", "")]
		public unsafe void SetAllGesturesEnabled (bool p0)
		{
			const string __id = "setAllGesturesEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UiSettings']/method[@name='setEnlargeCenterWithDoubleClickEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnlargeCenterWithDoubleClickEnable", "(Z)V", "")]
		public unsafe void SetEnlargeCenterWithDoubleClickEnable (bool p0)
		{
			const string __id = "setEnlargeCenterWithDoubleClickEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
