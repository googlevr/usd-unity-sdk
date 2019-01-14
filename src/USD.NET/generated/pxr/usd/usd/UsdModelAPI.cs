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

public class UsdModelAPI : UsdAPISchemaBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdModelAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdModelAPI_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdModelAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdModelAPI() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdModelAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdModelAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdModelAPI__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdModelAPI() : this(UsdCsPINVOKE.new_UsdModelAPI__SWIG_1(), true) {
  }

  public UsdModelAPI(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdModelAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdModelAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdModelAPI_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdModelAPI Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdModelAPI ret = new UsdModelAPI(UsdCsPINVOKE.UsdModelAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetKind(TfToken kind) {
    bool ret = UsdCsPINVOKE.UsdModelAPI_GetKind(swigCPtr, TfToken.getCPtr(kind));
    return ret;
  }

  public bool SetKind(TfToken kind) {
    bool ret = UsdCsPINVOKE.UsdModelAPI_SetKind(swigCPtr, TfToken.getCPtr(kind));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsKind(TfToken baseKind, UsdModelAPI.KindValidation validation) {
    bool ret = UsdCsPINVOKE.UsdModelAPI_IsKind__SWIG_0(swigCPtr, TfToken.getCPtr(baseKind), (int)validation);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsKind(TfToken baseKind) {
    bool ret = UsdCsPINVOKE.UsdModelAPI_IsKind__SWIG_1(swigCPtr, TfToken.getCPtr(baseKind));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsModel() {
    bool ret = UsdCsPINVOKE.UsdModelAPI_IsModel(swigCPtr);
    return ret;
  }

  public bool IsGroup() {
    bool ret = UsdCsPINVOKE.UsdModelAPI_IsGroup(swigCPtr);
    return ret;
  }

  public bool GetAssetIdentifier(SdfAssetPath identifier) {
    bool ret = UsdCsPINVOKE.UsdModelAPI_GetAssetIdentifier(swigCPtr, SdfAssetPath.getCPtr(identifier));
    return ret;
  }

  public void SetAssetIdentifier(SdfAssetPath identifier) {
    UsdCsPINVOKE.UsdModelAPI_SetAssetIdentifier(swigCPtr, SdfAssetPath.getCPtr(identifier));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetAssetName(SWIGTYPE_p_std__string assetName) {
    bool ret = UsdCsPINVOKE.UsdModelAPI_GetAssetName(swigCPtr, SWIGTYPE_p_std__string.getCPtr(assetName));
    return ret;
  }

  public void SetAssetName(string assetName) {
    UsdCsPINVOKE.UsdModelAPI_SetAssetName(swigCPtr, assetName);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetAssetVersion(SWIGTYPE_p_std__string version) {
    bool ret = UsdCsPINVOKE.UsdModelAPI_GetAssetVersion(swigCPtr, SWIGTYPE_p_std__string.getCPtr(version));
    return ret;
  }

  public void SetAssetVersion(string version) {
    UsdCsPINVOKE.UsdModelAPI_SetAssetVersion(swigCPtr, version);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetPayloadAssetDependencies(SdfAssetPathArray assetDeps) {
    bool ret = UsdCsPINVOKE.UsdModelAPI_GetPayloadAssetDependencies(swigCPtr, SdfAssetPathArray.getCPtr(assetDeps));
    return ret;
  }

  public void SetPayloadAssetDependencies(SdfAssetPathArray assetDeps) {
    UsdCsPINVOKE.UsdModelAPI_SetPayloadAssetDependencies(swigCPtr, SdfAssetPathArray.getCPtr(assetDeps));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetAssetInfo(VtDictionary info) {
    bool ret = UsdCsPINVOKE.UsdModelAPI_GetAssetInfo(swigCPtr, VtDictionary.getCPtr(info));
    return ret;
  }

  public void SetAssetInfo(VtDictionary info) {
    UsdCsPINVOKE.UsdModelAPI_SetAssetInfo(swigCPtr, VtDictionary.getCPtr(info));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum KindValidation {
    KindValidationNone,
    KindValidationModelHierarchy
  }

}

}
