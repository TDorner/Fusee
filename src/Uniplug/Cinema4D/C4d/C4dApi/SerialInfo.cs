/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class SerialInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SerialInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SerialInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SerialInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_SerialInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string /* constString&_cstype */ nr {
    set {
      C4dApiPINVOKE.SerialInfo_nr_set(swigCPtr, value);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = C4dApiPINVOKE.SerialInfo_nr_get(swigCPtr);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string /* constString&_cstype */ name {
    set {
      C4dApiPINVOKE.SerialInfo_name_set(swigCPtr, value);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = C4dApiPINVOKE.SerialInfo_name_get(swigCPtr);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string /* constString&_cstype */ organization {
    set {
      C4dApiPINVOKE.SerialInfo_organization_set(swigCPtr, value);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = C4dApiPINVOKE.SerialInfo_organization_get(swigCPtr);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string /* constString&_cstype */ street {
    set {
      C4dApiPINVOKE.SerialInfo_street_set(swigCPtr, value);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = C4dApiPINVOKE.SerialInfo_street_get(swigCPtr);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string /* constString&_cstype */ city {
    set {
      C4dApiPINVOKE.SerialInfo_city_set(swigCPtr, value);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = C4dApiPINVOKE.SerialInfo_city_get(swigCPtr);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string /* constString&_cstype */ country {
    set {
      C4dApiPINVOKE.SerialInfo_country_set(swigCPtr, value);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = C4dApiPINVOKE.SerialInfo_country_get(swigCPtr);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SerialInfo() : this(C4dApiPINVOKE.new_SerialInfo(), true) {
  }

}

}