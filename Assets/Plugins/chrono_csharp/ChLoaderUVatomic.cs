//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoaderUVatomic : ChLoaderUV {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoaderUVatomic(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.ChLoaderUVatomic_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoaderUVatomic obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chronoPINVOKE.delete_ChLoaderUVatomic(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoaderUVatomic(ChLoadableUV mloadable) : this(chronoPINVOKE.new_ChLoaderUVatomic(ChLoadableUV.getCPtr(mloadable)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public override void ComputeQ(ChVectorDynamicd state_x, ChVectorDynamicd state_w) {
    if (SwigDerivedClassHasMethod("ComputeQ", swigMethodTypes0)) chronoPINVOKE.ChLoaderUVatomic_ComputeQSwigExplicitChLoaderUVatomic(swigCPtr, ChVectorDynamicd.getCPtr(state_x), ChVectorDynamicd.getCPtr(state_w)); else chronoPINVOKE.ChLoaderUVatomic_ComputeQ(swigCPtr, ChVectorDynamicd.getCPtr(state_x), ChVectorDynamicd.getCPtr(state_w));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetApplication(double u, double v) {
    chronoPINVOKE.ChLoaderUVatomic_SetApplication(swigCPtr, u, v);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("ComputeQ", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateChLoaderUVatomic_0(SwigDirectorMethodComputeQ);
    if (SwigDerivedClassHasMethod("GetLoadable", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateChLoaderUVatomic_1(SwigDirectorMethodGetLoadable);
    if (SwigDerivedClassHasMethod("IsStiff", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateChLoaderUVatomic_2(SwigDirectorMethodIsStiff);
    if (SwigDerivedClassHasMethod("ComputeF", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateChLoaderUVatomic_3(SwigDirectorMethodComputeF);
    chronoPINVOKE.ChLoaderUVatomic_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ChLoaderUVatomic));
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

  private void SwigDirectorMethodComputeF(double U, double V, global::System.IntPtr F, global::System.IntPtr state_x, global::System.IntPtr state_w) {
    ComputeF(U, V, new ChVectorDynamicd(F, false), (state_x == global::System.IntPtr.Zero) ? null : new ChVectorDynamicd(state_x, false), (state_w == global::System.IntPtr.Zero) ? null : new ChVectorDynamicd(state_w, false));
  }

  public delegate void SwigDelegateChLoaderUVatomic_0(global::System.IntPtr state_x, global::System.IntPtr state_w);
  public delegate global::System.IntPtr SwigDelegateChLoaderUVatomic_1();
  public delegate bool SwigDelegateChLoaderUVatomic_2();
  public delegate void SwigDelegateChLoaderUVatomic_3(double U, double V, global::System.IntPtr F, global::System.IntPtr state_x, global::System.IntPtr state_w);

  private SwigDelegateChLoaderUVatomic_0 swigDelegate0;
  private SwigDelegateChLoaderUVatomic_1 swigDelegate1;
  private SwigDelegateChLoaderUVatomic_2 swigDelegate2;
  private SwigDelegateChLoaderUVatomic_3 swigDelegate3;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(ChVectorDynamicd), typeof(ChVectorDynamicd) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(double), typeof(double), typeof(ChVectorDynamicd), typeof(ChVectorDynamicd), typeof(ChVectorDynamicd) };
}
