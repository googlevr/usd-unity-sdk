//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdSkelSkeleton : UsdGeomBoundable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdSkelSkeleton(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdSkelSkeleton_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelSkeleton obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelSkeleton() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdSkelSkeleton(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdSkelSkeleton(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdSkelSkeleton__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdSkelSkeleton() : this(UsdCsPINVOKE.new_UsdSkelSkeleton__SWIG_1(), true) {
  }

  public UsdSkelSkeleton(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdSkelSkeleton__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdSkelSkeleton_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdSkelSkeleton_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdSkelSkeleton Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdSkelSkeleton ret = new UsdSkelSkeleton(UsdCsPINVOKE.UsdSkelSkeleton_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdSkelSkeleton Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdSkelSkeleton ret = new UsdSkelSkeleton(UsdCsPINVOKE.UsdSkelSkeleton_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetJointsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_GetJointsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateJointsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_CreateJointsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateJointsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_CreateJointsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateJointsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_CreateJointsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetBindTransformsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_GetBindTransformsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateBindTransformsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateBindTransformsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateBindTransformsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetRestTransformsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_GetRestTransformsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateRestTransformsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRestTransformsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRestTransformsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

}

}
