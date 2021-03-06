//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class BaseBitmapLink : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BaseBitmapLink(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BaseBitmapLink obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BaseBitmap Get() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseBitmapLink_Get(swigCPtr);
    BaseBitmap ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseBitmap(cPtr, false);
    return ret;
  }

  public void Set(BaseBitmap bmp) {
    C4dApiPINVOKE.BaseBitmapLink_Set(swigCPtr, BaseBitmap.getCPtr(bmp));
  }

  public static BaseBitmapLink Alloc() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseBitmapLink_Alloc();
    BaseBitmapLink ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseBitmapLink(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_BaseBitmapLink bc) {
    C4dApiPINVOKE.BaseBitmapLink_Free(SWIGTYPE_p_p_BaseBitmapLink.getCPtr(bc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
