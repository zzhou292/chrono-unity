//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class VelocityColorCallback : ColorCallback {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VelocityColorCallback(global::System.IntPtr cPtr, bool cMemoryOwn) : base(chronoPINVOKE.VelocityColorCallback_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VelocityColorCallback obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          chronoPINVOKE.delete_VelocityColorCallback(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public VelocityColorCallback(double vmin, double vmax, VelocityColorCallback.Component component) : this(chronoPINVOKE.new_VelocityColorCallback__SWIG_0(vmin, vmax, (int)component), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public VelocityColorCallback(double vmin, double vmax) : this(chronoPINVOKE.new_VelocityColorCallback__SWIG_1(vmin, vmax), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public VelocityColorCallback(ChColor base_color, double vmin, double vmax, VelocityColorCallback.Component component) : this(chronoPINVOKE.new_VelocityColorCallback__SWIG_2(ChColor.getCPtr(base_color), vmin, vmax, (int)component), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public VelocityColorCallback(ChColor base_color, double vmin, double vmax) : this(chronoPINVOKE.new_VelocityColorCallback__SWIG_3(ChColor.getCPtr(base_color), vmin, vmax), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChColor get(uint n, ChParticleCloud cloud) {
    ChColor ret = new ChColor(chronoPINVOKE.VelocityColorCallback_get(swigCPtr, n, ChParticleCloud.getCPtr(cloud)), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum Component {
    X,
    Y,
    Z,
    NORM
  }

}
