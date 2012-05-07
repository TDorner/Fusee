/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 0.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace CppApi {

using System;
using System.Runtime.InteropServices;

class CppApiPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [DllImport("SwigTests.CppApi.dll", EntryPoint="SWIGRegisterExceptionCallbacks_CppApi")]
    public static extern void SWIGRegisterExceptionCallbacks_CppApi(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [DllImport("SwigTests.CppApi.dll", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_CppApi")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_CppApi(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_CppApi(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_CppApi(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [ThreadStatic]
    private static Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(Exception e) {
      if (pendingException != null)
        throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(CppApiPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static Exception Retrieve() {
      Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(CppApiPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [DllImport("SwigTests.CppApi.dll", EntryPoint="SWIGRegisterStringCallback_CppApi")]
    public static extern void SWIGRegisterStringCallback_CppApi(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_CppApi(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static CppApiPINVOKE() {
  }


  public static Parent InstantiateConcreteObject(IntPtr cPtr, bool owner)
  {
    Parent ret = null;
    if (cPtr == IntPtr.Zero) 
	{
      return ret;
    }
    int type = CppApiPINVOKE.Parent_WhatAmI(new HandleRef(null, cPtr));
    switch (type) 
	{
       case 0:
         ret = new Parent(cPtr, owner);
         break;
       case 1:
         ret = new Child(cPtr, owner);
         break;
      // Repeat for every other concrete type.
      default:
        System.Diagnostics.Debug.Assert(false,
        String.Format("Encountered type '{0}' that is not any known concrete class",
            type.ToString()));
        break;
    }
    return ret;
  }


  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_new_Parent")]
  public static extern IntPtr new_Parent();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_delete_Parent")]
  public static extern void delete_Parent(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Parent_WhatAmI")]
  public static extern int Parent_WhatAmI(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Parent_WhatAmISwigExplicitParent")]
  public static extern int Parent_WhatAmISwigExplicitParent(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Parent_I_set")]
  public static extern void Parent_I_set(HandleRef jarg1, int jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Parent_I_get")]
  public static extern int Parent_I_get(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Parent_DoSomething")]
  public static extern int Parent_DoSomething(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Parent_DoSomethingElse")]
  public static extern int Parent_DoSomethingElse(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Parent_DoSomethingElseSwigExplicitParent")]
  public static extern int Parent_DoSomethingElseSwigExplicitParent(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Parent_director_connect")]
  public static extern void Parent_director_connect(HandleRef jarg1, Parent.SwigDelegateParent_0 delegate0, Parent.SwigDelegateParent_1 delegate1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_new_Child")]
  public static extern IntPtr new_Child();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_delete_Child")]
  public static extern void delete_Child(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Child_WhatAmI")]
  public static extern int Child_WhatAmI(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Child_J_set")]
  public static extern void Child_J_set(HandleRef jarg1, int jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Child_J_get")]
  public static extern int Child_J_get(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Child_DoEvenMore")]
  public static extern int Child_DoEvenMore(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Child_DoSomethingElse")]
  public static extern int Child_DoSomethingElse(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Factory_GimmeAParent")]
  public static extern IntPtr Factory_GimmeAParent();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Factory_GimmeAChild")]
  public static extern IntPtr Factory_GimmeAChild();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Factory_GimmeAChildAsAParent")]
  public static extern IntPtr Factory_GimmeAChildAsAParent();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_new_Factory")]
  public static extern IntPtr new_Factory();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_delete_Factory")]
  public static extern void delete_Factory(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_new_VectorConsumer")]
  public static extern IntPtr new_VectorConsumer();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_delete_VectorConsumer")]
  public static extern void delete_VectorConsumer(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerPtr3")]
  public static extern int VectorConsumer_VectorTakerPtr3(HandleRef jarg1, ref Fusee.Math.Core.Vector3D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerPtr3SwigExplicitVectorConsumer")]
  public static extern int VectorConsumer_VectorTakerPtr3SwigExplicitVectorConsumer(HandleRef jarg1, ref Fusee.Math.Core.Vector3D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerRef3")]
  public static extern int VectorConsumer_VectorTakerRef3(HandleRef jarg1, ref Fusee.Math.Core.Vector3D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerRef3SwigExplicitVectorConsumer")]
  public static extern int VectorConsumer_VectorTakerRef3SwigExplicitVectorConsumer(HandleRef jarg1, ref Fusee.Math.Core.Vector3D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerVal3")]
  public static extern int VectorConsumer_VectorTakerVal3(HandleRef jarg1, Fusee.Math.Core.Vector3D /* CVector3_imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerVal3SwigExplicitVectorConsumer")]
  public static extern int VectorConsumer_VectorTakerVal3SwigExplicitVectorConsumer(HandleRef jarg1, Fusee.Math.Core.Vector3D /* CVector3_imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_GimmeSomeVector")]
  public static extern Fusee.Math.Core.Vector3D /* CVector3_imtype_out */ VectorConsumer_GimmeSomeVector(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_GimmeSomeVectorSwigExplicitVectorConsumer")]
  public static extern Fusee.Math.Core.Vector3D /* CVector3_imtype_out */ VectorConsumer_GimmeSomeVectorSwigExplicitVectorConsumer(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VV_set")]
  public static extern void VectorConsumer_VV_set(HandleRef jarg1, Fusee.Math.Core.Vector3D /* CVector3_imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VV_get")]
  public static extern Fusee.Math.Core.Vector3D /* CVector3_imtype_out */ VectorConsumer_VV_get(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerPtr4")]
  public static extern int VectorConsumer_VectorTakerPtr4(HandleRef jarg1, ref Fusee.Math.Core.Vector4D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerPtr4SwigExplicitVectorConsumer")]
  public static extern int VectorConsumer_VectorTakerPtr4SwigExplicitVectorConsumer(HandleRef jarg1, ref Fusee.Math.Core.Vector4D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerRef4")]
  public static extern int VectorConsumer_VectorTakerRef4(HandleRef jarg1, ref Fusee.Math.Core.Vector4D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerRef4SwigExplicitVectorConsumer")]
  public static extern int VectorConsumer_VectorTakerRef4SwigExplicitVectorConsumer(HandleRef jarg1, ref Fusee.Math.Core.Vector4D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerVal4")]
  public static extern int VectorConsumer_VectorTakerVal4(HandleRef jarg1, ref Fusee.Math.Core.Vector4D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_VectorTakerVal4SwigExplicitVectorConsumer")]
  public static extern int VectorConsumer_VectorTakerVal4SwigExplicitVectorConsumer(HandleRef jarg1, ref Fusee.Math.Core.Vector4D /* imtype */ jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumer_director_connect")]
  public static extern void VectorConsumer_director_connect(HandleRef jarg1, VectorConsumer.SwigDelegateVectorConsumer_0 delegate0, VectorConsumer.SwigDelegateVectorConsumer_1 delegate1, VectorConsumer.SwigDelegateVectorConsumer_2 delegate2, VectorConsumer.SwigDelegateVectorConsumer_3 delegate3, VectorConsumer.SwigDelegateVectorConsumer_4 delegate4, VectorConsumer.SwigDelegateVectorConsumer_5 delegate5, VectorConsumer.SwigDelegateVectorConsumer_6 delegate6);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_VectorConsumerCaller_CallVectorConsumer")]
  public static extern void VectorConsumerCaller_CallVectorConsumer(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_new_VectorConsumerCaller")]
  public static extern IntPtr new_VectorConsumerCaller();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_delete_VectorConsumerCaller")]
  public static extern void delete_VectorConsumerCaller(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_AParamType_i_set")]
  public static extern void AParamType_i_set(HandleRef jarg1, int jarg2);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_AParamType_i_get")]
  public static extern int AParamType_i_get(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_new_AParamType")]
  public static extern IntPtr new_AParamType();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_delete_AParamType")]
  public static extern void delete_AParamType(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_RefRefTest_ParameterTaker")]
  public static extern bool RefRefTest_ParameterTaker(IntPtr /* imtype */ jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_new_RefRefTest")]
  public static extern IntPtr new_RefRefTest();

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_delete_RefRefTest")]
  public static extern void delete_RefRefTest(HandleRef jarg1);

  [DllImport("SwigTests.CppApi.dll", EntryPoint="CSharp_Child_SWIGUpcast")]
  public static extern IntPtr Child_SWIGUpcast(IntPtr jarg1);
}

}