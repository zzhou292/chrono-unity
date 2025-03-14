//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChVisualShapeFEA : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChVisualShapeFEA(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChVisualShapeFEA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChVisualShapeFEA() {
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
          chronoPINVOKE.delete_ChVisualShapeFEA(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChVisualShapeFEA() : this(chronoPINVOKE.new_ChVisualShapeFEA(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVisualShapeFEA.DataType GetFEMdataType() {
    ChVisualShapeFEA.DataType ret = (ChVisualShapeFEA.DataType)chronoPINVOKE.ChVisualShapeFEA_GetFEMdataType(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFEMdataType(ChVisualShapeFEA.DataType mdata) {
    chronoPINVOKE.ChVisualShapeFEA_SetFEMdataType(swigCPtr, (int)mdata);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVisualShapeFEA.GlyphType GetFEMglyphType() {
    ChVisualShapeFEA.GlyphType ret = (ChVisualShapeFEA.GlyphType)chronoPINVOKE.ChVisualShapeFEA_GetFEMglyphType(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFEMglyphType(ChVisualShapeFEA.GlyphType mdata) {
    chronoPINVOKE.ChVisualShapeFEA_SetFEMglyphType(swigCPtr, (int)mdata);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetColorscaleMinMax(double min, double max) {
    chronoPINVOKE.ChVisualShapeFEA_SetColorscaleMinMax(swigCPtr, min, max);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSymbolsScale(double mscale) {
    chronoPINVOKE.ChVisualShapeFEA_SetSymbolsScale(swigCPtr, mscale);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetSymbolsScale() {
    double ret = chronoPINVOKE.ChVisualShapeFEA_GetSymbolsScale(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSymbolsThickness(double mthick) {
    chronoPINVOKE.ChVisualShapeFEA_SetSymbolsThickness(swigCPtr, mthick);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetSymbolsThickness() {
    double ret = chronoPINVOKE.ChVisualShapeFEA_GetSymbolsThickness(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetBeamResolution(int mres) {
    chronoPINVOKE.ChVisualShapeFEA_SetBeamResolution(swigCPtr, mres);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetBeamResolution() {
    int ret = chronoPINVOKE.ChVisualShapeFEA_GetBeamResolution(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetBeamResolutionSection(int mres) {
    chronoPINVOKE.ChVisualShapeFEA_SetBeamResolutionSection(swigCPtr, mres);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetBeamResolutionSection() {
    int ret = chronoPINVOKE.ChVisualShapeFEA_GetBeamResolutionSection(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetShellResolution(int mres) {
    chronoPINVOKE.ChVisualShapeFEA_SetShellResolution(swigCPtr, mres);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetShellResolution() {
    int ret = chronoPINVOKE.ChVisualShapeFEA_GetShellResolution(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetShrinkElements(bool mshrink, double mfact) {
    chronoPINVOKE.ChVisualShapeFEA_SetShrinkElements(swigCPtr, mshrink, mfact);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetWireframe(bool mwireframe) {
    chronoPINVOKE.ChVisualShapeFEA_SetWireframe(swigCPtr, mwireframe);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBackfaceCull(bool mbc) {
    chronoPINVOKE.ChVisualShapeFEA_SetBackfaceCull(swigCPtr, mbc);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetZbufferHide(bool mhide) {
    chronoPINVOKE.ChVisualShapeFEA_SetZbufferHide(swigCPtr, mhide);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDefaultMeshColor(ChColor mcolor) {
    chronoPINVOKE.ChVisualShapeFEA_SetDefaultMeshColor(swigCPtr, ChColor.getCPtr(mcolor));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDefaultSymbolsColor(ChColor mcolor) {
    chronoPINVOKE.ChVisualShapeFEA_SetDefaultSymbolsColor(swigCPtr, ChColor.getCPtr(mcolor));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSmoothFaces(bool msmooth) {
    chronoPINVOKE.ChVisualShapeFEA_SetSmoothFaces(swigCPtr, msmooth);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDrawInUndeformedReference(bool mdu) {
    chronoPINVOKE.ChVisualShapeFEA_SetDrawInUndeformedReference(swigCPtr, mdu);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Update(ChPhysicsItem updater, ChFramed frame) {
    chronoPINVOKE.ChVisualShapeFEA_Update(swigCPtr, ChPhysicsItem.getCPtr(updater), ChFramed.getCPtr(frame));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum DataType {
    NONE,
    SURFACE,
    CONTACTSURFACES,
    LOADSURFACES,
    NODE_DISP_NORM,
    NODE_DISP_X,
    NODE_DISP_Y,
    NODE_DISP_Z,
    NODE_SPEED_NORM,
    NODE_SPEED_X,
    NODE_SPEED_Y,
    NODE_SPEED_Z,
    NODE_ACCEL_NORM,
    NODE_ACCEL_X,
    NODE_ACCEL_Y,
    NODE_ACCEL_Z,
    ELEM_STRAIN_VONMISES,
    ELEM_STRESS_VONMISES,
    ELEM_STRAIN_HYDROSTATIC,
    ELEM_STRESS_HYDROSTATIC,
    ELEM_BEAM_MX,
    ELEM_BEAM_MY,
    ELEM_BEAM_MZ,
    ELEM_BEAM_TX,
    ELEM_BEAM_TY,
    ELEM_BEAM_TZ,
    NODE_FIELD_VALUE,
    ANCF_BEAM_AX,
    ANCF_BEAM_BD
  }

  public enum GlyphType {
    NONE,
    NODE_DOT_POS,
    NODE_CSYS,
    NODE_VECT_SPEED,
    NODE_VECT_ACCEL,
    ELEM_TENS_STRAIN,
    ELEM_TENS_STRESS,
    ELEM_VECT_DP
  }

}
