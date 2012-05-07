/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 0.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

using System;
using System.Runtime.InteropServices;

public class CustomDataTypeClass : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CustomDataTypeClass(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CustomDataTypeClass obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CustomDataTypeClass() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_CustomDataTypeClass(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual int GetId() {
    int ret = C4dApiPINVOKE.CustomDataTypeClass_GetId(swigCPtr);
    return ret;
  }

  public virtual int GetDataID() {
    int ret = C4dApiPINVOKE.CustomDataTypeClass_GetDataID(swigCPtr);
    return ret;
  }

  public virtual int GetValueID() {
    int ret = C4dApiPINVOKE.CustomDataTypeClass_GetValueID(swigCPtr);
    return ret;
  }

  public virtual CustomDataType AllocData() {
    IntPtr cPtr = C4dApiPINVOKE.CustomDataTypeClass_AllocData(swigCPtr);
    CustomDataType ret = (cPtr == IntPtr.Zero) ? null : new CustomDataType(cPtr, false);
    return ret;
  }

  public virtual void FreeData(CustomDataType data) {
    C4dApiPINVOKE.CustomDataTypeClass_FreeData(swigCPtr, CustomDataType.getCPtr(data));
  }

  public virtual bool CopyData(CustomDataType src, CustomDataType dest, AliasTrans aliastrans) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_CopyData(swigCPtr, CustomDataType.getCPtr(src), CustomDataType.getCPtr(dest), AliasTrans.getCPtr(aliastrans));
    return ret;
  }

  public virtual int Compare(CustomDataType d1, CustomDataType d2) {
    int ret = C4dApiPINVOKE.CustomDataTypeClass_Compare(swigCPtr, CustomDataType.getCPtr(d1), CustomDataType.getCPtr(d2));
    return ret;
  }

  public virtual bool WriteData(CustomDataType d, SWIGTYPE_p_HyperFile hf) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_WriteData(swigCPtr, CustomDataType.getCPtr(d), SWIGTYPE_p_HyperFile.getCPtr(hf));
    return ret;
  }

  public virtual bool ReadData(CustomDataType d, SWIGTYPE_p_HyperFile hf, int level) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_ReadData(swigCPtr, CustomDataType.getCPtr(d), SWIGTYPE_p_HyperFile.getCPtr(hf), level);
    return ret;
  }

  public virtual SWIGTYPE_p_CHAR GetResourceSym() {
    IntPtr cPtr = C4dApiPINVOKE.CustomDataTypeClass_GetResourceSym(swigCPtr);
    SWIGTYPE_p_CHAR ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_CHAR(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CustomProperty GetProperties() {
    IntPtr cPtr = C4dApiPINVOKE.CustomDataTypeClass_GetProperties(swigCPtr);
    SWIGTYPE_p_CustomProperty ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_CustomProperty(cPtr, false);
    return ret;
  }

  public virtual void GetDefaultProperties(BaseContainer data) {
    C4dApiPINVOKE.CustomDataTypeClass_GetDefaultProperties(swigCPtr, BaseContainer.getCPtr(data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int GetConversionsFrom(SWIGTYPE_p_p_LONG table) {
    int ret = C4dApiPINVOKE.CustomDataTypeClass_GetConversionsFrom(swigCPtr, SWIGTYPE_p_p_LONG.getCPtr(table));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual GvError ConvertFromGv(int src_type, SWIGTYPE_p_void src, int cpu_id, CustomDataType dst) {
    GvError ret = (GvError)C4dApiPINVOKE.CustomDataTypeClass_ConvertFromGv(swigCPtr, src_type, SWIGTYPE_p_void.getCPtr(src), cpu_id, CustomDataType.getCPtr(dst));
    return ret;
  }

  public virtual int GetConversionsTo(SWIGTYPE_p_p_LONG table) {
    int ret = C4dApiPINVOKE.CustomDataTypeClass_GetConversionsTo(swigCPtr, SWIGTYPE_p_p_LONG.getCPtr(table));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual GvError ConvertToGv(int dst_type, CustomDataType src, SWIGTYPE_p_void dst, int cpu_id) {
    GvError ret = (GvError)C4dApiPINVOKE.CustomDataTypeClass_ConvertToGv(swigCPtr, dst_type, CustomDataType.getCPtr(src), SWIGTYPE_p_void.getCPtr(dst), cpu_id);
    return ret;
  }

  public virtual GvError ConvertToGeData(int dst_type, CustomDataType src, GeData dst) {
    GvError ret = (GvError)C4dApiPINVOKE.CustomDataTypeClass_ConvertToGeData(swigCPtr, dst_type, CustomDataType.getCPtr(src), GeData.getCPtr(dst));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual GvValueFlags GetCalculationFlags() {
    GvValueFlags ret = (GvValueFlags)C4dApiPINVOKE.CustomDataTypeClass_GetCalculationFlags(swigCPtr);
    return ret;
  }

  public virtual GvError Calculate(int calculation, CustomDataType src1, CustomDataType src2, CustomDataType dst, double parm1) {
    GvError ret = (GvError)C4dApiPINVOKE.CustomDataTypeClass_Calculate(swigCPtr, calculation, CustomDataType.getCPtr(src1), CustomDataType.getCPtr(src2), CustomDataType.getCPtr(dst), parm1);
    return ret;
  }

  public virtual SWIGTYPE_p_GV_VALUE_HANDLER GetGvValueHandler() {
    IntPtr cPtr = C4dApiPINVOKE.CustomDataTypeClass_GetGvValueHandler(swigCPtr);
    SWIGTYPE_p_GV_VALUE_HANDLER ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_GV_VALUE_HANDLER(cPtr, false);
    return ret;
  }

  public virtual bool ConvertGeDataToGv(GeData src, SWIGTYPE_p_void dst, int cpu_id) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_ConvertGeDataToGv(swigCPtr, GeData.getCPtr(src), SWIGTYPE_p_void.getCPtr(dst), cpu_id);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool ConvertGvToGeData(SWIGTYPE_p_void src, int cpu_id, GeData dst) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_ConvertGvToGeData(swigCPtr, SWIGTYPE_p_void.getCPtr(src), cpu_id, GeData.getCPtr(dst));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool GetDescription() {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_GetDescription(swigCPtr);
    return ret;
  }

  public virtual bool _GetDescription(CustomDataType data, Description res, SWIGTYPE_p_DESCFLAGS_DESC flags, BaseContainer parentdescription, DescID singledescid) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass__GetDescription(swigCPtr, CustomDataType.getCPtr(data), Description.getCPtr(res), SWIGTYPE_p_DESCFLAGS_DESC.getCPtr(flags), BaseContainer.getCPtr(parentdescription), DescID.getCPtr(singledescid));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool GetParameter(CustomDataType data, DescID id, GeData t_data, SWIGTYPE_p_DESCFLAGS_GET flags) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_GetParameter(swigCPtr, CustomDataType.getCPtr(data), DescID.getCPtr(id), GeData.getCPtr(t_data), SWIGTYPE_p_DESCFLAGS_GET.getCPtr(flags));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool SetDParameter(CustomDataType data, DescID id, GeData t_data, SWIGTYPE_p_DESCFLAGS_SET flags) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_SetDParameter(swigCPtr, CustomDataType.getCPtr(data), DescID.getCPtr(id), GeData.getCPtr(t_data), SWIGTYPE_p_DESCFLAGS_SET.getCPtr(flags));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool GetEnabling(CustomDataType data, DescID id, GeData t_data, SWIGTYPE_p_DESCFLAGS_ENABLE flags, BaseContainer itemdesc) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_GetEnabling(swigCPtr, CustomDataType.getCPtr(data), DescID.getCPtr(id), GeData.getCPtr(t_data), SWIGTYPE_p_DESCFLAGS_ENABLE.getCPtr(flags), BaseContainer.getCPtr(itemdesc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool InterpolateKeys(GeData res, GeData t_data1, GeData t_data2, double mix, int flags) {
    bool ret = C4dApiPINVOKE.CustomDataTypeClass_InterpolateKeys(swigCPtr, GeData.getCPtr(res), GeData.getCPtr(t_data1), GeData.getCPtr(t_data2), mix, flags);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void CheckData(BaseContainer bc, GeData data) {
    C4dApiPINVOKE.CustomDataTypeClass_CheckData(swigCPtr, BaseContainer.getCPtr(bc), GeData.getCPtr(data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}