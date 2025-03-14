//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class SCMTerrain : ChTerrain {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal SCMTerrain(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chrono_vehiclePINVOKE.SCMTerrain_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SCMTerrain obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          chrono_vehiclePINVOKE.delete_SCMTerrain(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public SCMTerrain(ChSystem system, bool visualization_mesh) : this(chrono_vehiclePINVOKE.new_SCMTerrain__SWIG_0(ChSystem.getCPtr(system), visualization_mesh), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public SCMTerrain(ChSystem system) : this(chrono_vehiclePINVOKE.new_SCMTerrain__SWIG_1(ChSystem.getCPtr(system)), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPlane(ChCoordsysd plane) {
    chrono_vehiclePINVOKE.SCMTerrain_SetPlane(swigCPtr, ChCoordsysd.getCPtr(plane));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChCoordsysd GetPlane() {
    ChCoordsysd ret = new ChCoordsysd(chrono_vehiclePINVOKE.SCMTerrain_GetPlane(swigCPtr), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSoilParameters(double Bekker_Kphi, double Bekker_Kc, double Bekker_n, double Mohr_cohesion, double Mohr_friction, double Janosi_shear, double elastic_K, double damping_R) {
    chrono_vehiclePINVOKE.SCMTerrain_SetSoilParameters(swigCPtr, Bekker_Kphi, Bekker_Kc, Bekker_n, Mohr_cohesion, Mohr_friction, Janosi_shear, elastic_K, damping_R);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void EnableBulldozing(bool mb) {
    chrono_vehiclePINVOKE.SCMTerrain_EnableBulldozing(swigCPtr, mb);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBulldozingParameters(double erosion_angle, double flow_factor, int erosion_iterations, int erosion_propagations) {
    chrono_vehiclePINVOKE.SCMTerrain_SetBulldozingParameters__SWIG_0(swigCPtr, erosion_angle, flow_factor, erosion_iterations, erosion_propagations);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBulldozingParameters(double erosion_angle, double flow_factor, int erosion_iterations) {
    chrono_vehiclePINVOKE.SCMTerrain_SetBulldozingParameters__SWIG_1(swigCPtr, erosion_angle, flow_factor, erosion_iterations);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBulldozingParameters(double erosion_angle, double flow_factor) {
    chrono_vehiclePINVOKE.SCMTerrain_SetBulldozingParameters__SWIG_2(swigCPtr, erosion_angle, flow_factor);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBulldozingParameters(double erosion_angle) {
    chrono_vehiclePINVOKE.SCMTerrain_SetBulldozingParameters__SWIG_3(swigCPtr, erosion_angle);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTestHeight(double offset) {
    chrono_vehiclePINVOKE.SCMTerrain_SetTestHeight(swigCPtr, offset);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetTestHeight() {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetTestHeight(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPlotType(SCMTerrain.DataPlotType plot_type, double min_val, double max_val) {
    chrono_vehiclePINVOKE.SCMTerrain_SetPlotType(swigCPtr, (int)plot_type, min_val, max_val);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetColor(ChColor color) {
    chrono_vehiclePINVOKE.SCMTerrain_SetColor(swigCPtr, ChColor.getCPtr(color));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTexture(string tex_file, float scale_x, float scale_y) {
    chrono_vehiclePINVOKE.SCMTerrain_SetTexture__SWIG_0(swigCPtr, tex_file, scale_x, scale_y);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTexture(string tex_file, float scale_x) {
    chrono_vehiclePINVOKE.SCMTerrain_SetTexture__SWIG_1(swigCPtr, tex_file, scale_x);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTexture(string tex_file) {
    chrono_vehiclePINVOKE.SCMTerrain_SetTexture__SWIG_2(swigCPtr, tex_file);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBoundary(ChAABB aabb) {
    chrono_vehiclePINVOKE.SCMTerrain_SetBoundary(swigCPtr, ChAABB.getCPtr(aabb));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddMovingPatch(ChBody body, ChVector3d OOBB_center, ChVector3d OOBB_dims) {
    chrono_vehiclePINVOKE.SCMTerrain_AddMovingPatch(swigCPtr, ChBody.getCPtr(body), ChVector3d.getCPtr(OOBB_center), ChVector3d.getCPtr(OOBB_dims));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RegisterSoilParametersCallback(SoilParametersCallback cb) {
    chrono_vehiclePINVOKE.SCMTerrain_RegisterSoilParametersCallback(swigCPtr, SoilParametersCallback.getCPtr(cb));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetInitHeight(ChVector3d loc) {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetInitHeight(swigCPtr, ChVector3d.getCPtr(loc));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3d GetInitNormal(ChVector3d loc) {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.SCMTerrain_GetInitNormal(swigCPtr, ChVector3d.getCPtr(loc)), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetHeight(ChVector3d loc) {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetHeight(swigCPtr, ChVector3d.getCPtr(loc));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVector3d GetNormal(ChVector3d loc) {
    ChVector3d ret = new ChVector3d(chrono_vehiclePINVOKE.SCMTerrain_GetNormal(swigCPtr, ChVector3d.getCPtr(loc)), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float GetCoefficientFriction(ChVector3d loc) {
    float ret = chrono_vehiclePINVOKE.SCMTerrain_GetCoefficientFriction(swigCPtr, ChVector3d.getCPtr(loc));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NodeInfo GetNodeInfo(ChVector3d loc) {
    NodeInfo ret = new NodeInfo(chrono_vehiclePINVOKE.SCMTerrain_GetNodeInfo(swigCPtr, ChVector3d.getCPtr(loc)), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVisualShapeTriangleMesh GetMesh() {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.SCMTerrain_GetMesh(swigCPtr);
    ChVisualShapeTriangleMesh ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChVisualShapeTriangleMesh(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMeshWireframe(bool val) {
    chrono_vehiclePINVOKE.SCMTerrain_SetMeshWireframe(swigCPtr, val);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteMesh(string filename) {
    chrono_vehiclePINVOKE.SCMTerrain_WriteMesh(swigCPtr, filename);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCosimulationMode(bool val) {
    chrono_vehiclePINVOKE.SCMTerrain_SetCosimulationMode(swigCPtr, val);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(double sizeX, double sizeY, double delta) {
    chrono_vehiclePINVOKE.SCMTerrain_Initialize__SWIG_0(swigCPtr, sizeX, sizeY, delta);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(string heightmap_file, double sizeX, double sizeY, double hMin, double hMax, double delta) {
    chrono_vehiclePINVOKE.SCMTerrain_Initialize__SWIG_1(swigCPtr, heightmap_file, sizeX, sizeY, hMin, hMax, delta);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(string mesh_file, double delta) {
    chrono_vehiclePINVOKE.SCMTerrain_Initialize__SWIG_2(swigCPtr, mesh_file, delta);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChTriangleMeshConnected trimesh, double delta) {
    chrono_vehiclePINVOKE.SCMTerrain_Initialize__SWIG_3(swigCPtr, ChTriangleMeshConnected.getCPtr(trimesh), delta);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChSCMModifiedNodes GetModifiedNodes(bool all_nodes) {
    ChSCMModifiedNodes ret = new ChSCMModifiedNodes(chrono_vehiclePINVOKE.SCMTerrain_GetModifiedNodes__SWIG_0(swigCPtr, all_nodes), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChSCMModifiedNodes GetModifiedNodes() {
    ChSCMModifiedNodes ret = new ChSCMModifiedNodes(chrono_vehiclePINVOKE.SCMTerrain_GetModifiedNodes__SWIG_1(swigCPtr), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetModifiedNodes(ChSCMModifiedNodes nodes) {
    chrono_vehiclePINVOKE.SCMTerrain_SetModifiedNodes(swigCPtr, ChSCMModifiedNodes.getCPtr(nodes));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetContactForceBody(ChBody body, ChVector3d force, ChVector3d torque) {
    bool ret = chrono_vehiclePINVOKE.SCMTerrain_GetContactForceBody(swigCPtr, ChBody.getCPtr(body), ChVector3d.getCPtr(force), ChVector3d.getCPtr(torque));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetContactForceNode(SWIGTYPE_p_std__shared_ptrT_chrono__fea__ChNodeFEAxyz_t node, ChVector3d force) {
    bool ret = chrono_vehiclePINVOKE.SCMTerrain_GetContactForceNode(swigCPtr, SWIGTYPE_p_std__shared_ptrT_chrono__fea__ChNodeFEAxyz_t.getCPtr(node), ChVector3d.getCPtr(force));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumRayCasts() {
    int ret = chrono_vehiclePINVOKE.SCMTerrain_GetNumRayCasts(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumRayHits() {
    int ret = chrono_vehiclePINVOKE.SCMTerrain_GetNumRayHits(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumContactPatches() {
    int ret = chrono_vehiclePINVOKE.SCMTerrain_GetNumContactPatches(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumErosionNodes() {
    int ret = chrono_vehiclePINVOKE.SCMTerrain_GetNumErosionNodes(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimerMovingPatches() {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetTimerMovingPatches(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimerRayTesting() {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetTimerRayTesting(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimerRayCasting() {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetTimerRayCasting(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimerContactPatches() {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetTimerContactPatches(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimerContactForces() {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetTimerContactForces(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimerBulldozing() {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetTimerBulldozing(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimerVisUpdate() {
    double ret = chrono_vehiclePINVOKE.SCMTerrain_GetTimerVisUpdate(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void PrintStepStatistics(SWIGTYPE_p_std__ostream os) {
    chrono_vehiclePINVOKE.SCMTerrain_PrintStepStatistics(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public SCMLoader GetSCMLoader() {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.SCMTerrain_GetSCMLoader(swigCPtr);
    SCMLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new SCMLoader(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetBaseMeshLevel(double level) {
    chrono_vehiclePINVOKE.SCMTerrain_SetBaseMeshLevel(swigCPtr, level);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum DataPlotType {
    PLOT_NONE,
    PLOT_LEVEL,
    PLOT_LEVEL_INITIAL,
    PLOT_SINKAGE,
    PLOT_SINKAGE_ELASTIC,
    PLOT_SINKAGE_PLASTIC,
    PLOT_STEP_PLASTIC_FLOW,
    PLOT_PRESSURE,
    PLOT_PRESSURE_YELD,
    PLOT_SHEAR,
    PLOT_K_JANOSI,
    PLOT_IS_TOUCHED,
    PLOT_ISLAND_ID,
    PLOT_MASSREMAINDER
  }

}
