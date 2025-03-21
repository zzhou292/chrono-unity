//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoaderNodeXYZ : ChLoaderUVWatomic {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoaderNodeXYZ(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChLoaderNodeXYZ_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoaderNodeXYZ obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChLoaderNodeXYZ(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoaderNodeXYZ(ChLoadableUVW loadable) : this(chronoPINVOKE.new_ChLoaderNodeXYZ(ChLoadableUVW.getCPtr(loadable)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public override void ComputeF(double U, double V, double W, ChVectorDynamicd F, ChVectorDynamicd state_x, ChVectorDynamicd state_w) {
    if (SwigDerivedClassHasMethod("ComputeF", swigMethodTypes3)) chronoPINVOKE.ChLoaderNodeXYZ_ComputeFSwigExplicitChLoaderNodeXYZ(swigCPtr, U, V, W, ChVectorDynamicd.getCPtr(F), ChVectorDynamicd.getCPtr(state_x), ChVectorDynamicd.getCPtr(state_w)); else chronoPINVOKE.ChLoaderNodeXYZ_ComputeF(swigCPtr, U, V, W, ChVectorDynamicd.getCPtr(F), ChVectorDynamicd.getCPtr(state_x), ChVectorDynamicd.getCPtr(state_w));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetForce(ChVector3d mf) {
    chronoPINVOKE.ChLoaderNodeXYZ_SetForce(swigCPtr, ChVector3d.getCPtr(mf));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVector3d GetForce() {
    ChVector3d ret = new ChVector3d(chronoPINVOKE.ChLoaderNodeXYZ_GetForce(swigCPtr), false);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("ComputeQ", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateChLoaderNodeXYZ_0(SwigDirectorMethodComputeQ);
    if (SwigDerivedClassHasMethod("GetLoadable", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateChLoaderNodeXYZ_1(SwigDirectorMethodGetLoadable);
    if (SwigDerivedClassHasMethod("IsStiff", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateChLoaderNodeXYZ_2(SwigDirectorMethodIsStiff);
    if (SwigDerivedClassHasMethod("ComputeF", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateChLoaderNodeXYZ_3(SwigDirectorMethodComputeF);
    chronoPINVOKE.ChLoaderNodeXYZ_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ChLoaderNodeXYZ));
    return hasDerivedMethod;
  }

  private void SwigDirectorMethodComputeQ(global::System.IntPtr state_x, global::System.IntPtr state_w) {
    ComputeQ((state_x == global::System.IntPtr.Zero) ? null : new ChVectorDynamicd(state_x, false), (state_w == global::System.IntPtr.Zero) ? null : new ChVectorDynamicd(state_w, false));
  }

  private global::System.IntPtr SwigDirectorMethodGetLoadable() {
    return ChLoadable.getCPtr(GetLoadable()).Handle;
  }

  private bool SwigDirectorMethodIsStiff() {
    return IsStiff();
  }

  private void SwigDirectorMethodComputeF(double U, double V, double W, global::System.IntPtr F, global::System.IntPtr state_x, global::System.IntPtr state_w) {
    ComputeF(U, V, W, new ChVectorDynamicd(F, false), (state_x == global::System.IntPtr.Zero) ? null : new ChVectorDynamicd(state_x, false), (state_w == global::System.IntPtr.Zero) ? null : new ChVectorDynamicd(state_w, false));
  }

  public delegate void SwigDelegateChLoaderNodeXYZ_0(global::System.IntPtr state_x, global::System.IntPtr state_w);
  public delegate global::System.IntPtr SwigDelegateChLoaderNodeXYZ_1();
  public delegate bool SwigDelegateChLoaderNodeXYZ_2();
  public delegate void SwigDelegateChLoaderNodeXYZ_3(double U, double V, double W, global::System.IntPtr F, global::System.IntPtr state_x, global::System.IntPtr state_w);

  private SwigDelegateChLoaderNodeXYZ_0 swigDelegate0;
  private SwigDelegateChLoaderNodeXYZ_1 swigDelegate1;
  private SwigDelegateChLoaderNodeXYZ_2 swigDelegate2;
  private SwigDelegateChLoaderNodeXYZ_3 swigDelegate3;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(ChVectorDynamicd), typeof(ChVectorDynamicd) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(double), typeof(double), typeof(double), typeof(ChVectorDynamicd), typeof(ChVectorDynamicd), typeof(ChVectorDynamicd) };
}
