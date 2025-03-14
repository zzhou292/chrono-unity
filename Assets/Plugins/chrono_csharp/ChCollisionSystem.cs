//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChCollisionSystem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChCollisionSystem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChCollisionSystem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChCollisionSystem() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          chronoPINVOKE.delete_ChCollisionSystem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public bool IsInitialized() {
    bool ret = chronoPINVOKE.ChCollisionSystem_IsInitialized(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Initialize() {
    chronoPINVOKE.ChCollisionSystem_Initialize(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void BindAll() {
    chronoPINVOKE.ChCollisionSystem_BindAll(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void BindItem(ChPhysicsItem item) {
    chronoPINVOKE.ChCollisionSystem_BindItem(swigCPtr, ChPhysicsItem.getCPtr(item));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UnbindItem(ChPhysicsItem item) {
    chronoPINVOKE.ChCollisionSystem_UnbindItem(swigCPtr, ChPhysicsItem.getCPtr(item));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Clear() {
    chronoPINVOKE.ChCollisionSystem_Clear(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Add(ChCollisionModel model) {
    chronoPINVOKE.ChCollisionSystem_Add(swigCPtr, ChCollisionModel.getCPtr(model));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Remove(ChCollisionModel model) {
    chronoPINVOKE.ChCollisionSystem_Remove(swigCPtr, ChCollisionModel.getCPtr(model));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void PreProcess() {
    chronoPINVOKE.ChCollisionSystem_PreProcess(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Run() {
    chronoPINVOKE.ChCollisionSystem_Run(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void PostProcess() {
    chronoPINVOKE.ChCollisionSystem_PostProcess(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual ChAABB GetBoundingBox() {
    ChAABB ret = new ChAABB(chronoPINVOKE.ChCollisionSystem_GetBoundingBox(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTimerCollisionBroad() {
    double ret = chronoPINVOKE.ChCollisionSystem_GetTimerCollisionBroad(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTimerCollisionNarrow() {
    double ret = chronoPINVOKE.ChCollisionSystem_GetTimerCollisionNarrow(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ResetTimers() {
    chronoPINVOKE.ChCollisionSystem_ResetTimers(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetNumThreads(int nthreads) {
    chronoPINVOKE.ChCollisionSystem_SetNumThreads(swigCPtr, nthreads);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ReportContacts(ChContactContainer mcontactcontainer) {
    chronoPINVOKE.ChCollisionSystem_ReportContacts(swigCPtr, ChContactContainer.getCPtr(mcontactcontainer));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ReportProximities(ChProximityContainer mproximitycontainer) {
    chronoPINVOKE.ChCollisionSystem_ReportProximities(swigCPtr, ChProximityContainer.getCPtr(mproximitycontainer));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RegisterBroadphaseCallback(BroadphaseCallback callback) {
    chronoPINVOKE.ChCollisionSystem_RegisterBroadphaseCallback(swigCPtr, BroadphaseCallback.getCPtr(callback));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RegisterNarrowphaseCallback(NarrowphaseCallback callback) {
    chronoPINVOKE.ChCollisionSystem_RegisterNarrowphaseCallback(swigCPtr, NarrowphaseCallback.getCPtr(callback));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool RayHit(ChVector3d from, ChVector3d to, ChRayhitResult result) {
    bool ret = chronoPINVOKE.ChCollisionSystem_RayHit__SWIG_0(swigCPtr, ChVector3d.getCPtr(from), ChVector3d.getCPtr(to), ChRayhitResult.getCPtr(result));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool RayHit(ChVector3d from, ChVector3d to, ChCollisionModel model, ChRayhitResult result) {
    bool ret = chronoPINVOKE.ChCollisionSystem_RayHit__SWIG_1(swigCPtr, ChVector3d.getCPtr(from), ChVector3d.getCPtr(to), ChCollisionModel.getCPtr(model), ChRayhitResult.getCPtr(result));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void RegisterVisualizationCallback(VisualizationCallback callback) {
    chronoPINVOKE.ChCollisionSystem_RegisterVisualizationCallback(swigCPtr, VisualizationCallback.getCPtr(callback));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Visualize(int flags) {
    chronoPINVOKE.ChCollisionSystem_Visualize(swigCPtr, flags);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChCollisionSystem_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChCollisionSystem_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSystem(ChSystem sys) {
    chronoPINVOKE.ChCollisionSystem_SetSystem(swigCPtr, ChSystem.getCPtr(sys));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum Type {
    BULLET,
    MULTICORE
  }

  public enum VisualizationModes {
    VIS_None = 0,
    VIS_Shapes = 1 << 0,
    VIS_Aabb = 1 << 1,
    VIS_Contacts = 1 << 2,
    VIS_MAX_MODES
  }

}
