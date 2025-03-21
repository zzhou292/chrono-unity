//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChVector3f : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChVector3f(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChVector3f obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChVector3f() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          chronoPINVOKE.delete_ChVector3f(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChVector3f() : this(chronoPINVOKE.new_ChVector3f__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVector3f(float x, float y, float z) : this(chronoPINVOKE.new_ChVector3f__SWIG_1(x, y, z), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVector3f(float a) : this(chronoPINVOKE.new_ChVector3f__SWIG_2(a), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVector3f(ChVector3f other) : this(chronoPINVOKE.new_ChVector3f__SWIG_3(ChVector3f.getCPtr(other)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_float data() {
    global::System.IntPtr cPtr = chronoPINVOKE.ChVector3f_data__SWIG_0(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set(float x, float y, float z) {
    chronoPINVOKE.ChVector3f_Set__SWIG_0(swigCPtr, x, y, z);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(ChVector3f v) {
    chronoPINVOKE.ChVector3f_Set__SWIG_1(swigCPtr, ChVector3f.getCPtr(v));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(float s) {
    chronoPINVOKE.ChVector3f_Set__SWIG_2(swigCPtr, s);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetNull() {
    chronoPINVOKE.ChVector3f_SetNull(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsNull() {
    bool ret = chronoPINVOKE.ChVector3f_IsNull(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(ChVector3f other) {
    bool ret = chronoPINVOKE.ChVector3f_Equals__SWIG_0(swigCPtr, ChVector3f.getCPtr(other));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(ChVector3f other, float tol) {
    bool ret = chronoPINVOKE.ChVector3f_Equals__SWIG_1(swigCPtr, ChVector3f.getCPtr(other), tol);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Length() {
    float ret = chronoPINVOKE.ChVector3f_Length(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Length2() {
    float ret = chronoPINVOKE.ChVector3f_Length2(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float LengthInf() {
    float ret = chronoPINVOKE.ChVector3f_LengthInf(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(ChVector3f A, ChVector3f B) {
    chronoPINVOKE.ChVector3f_Add(swigCPtr, ChVector3f.getCPtr(A), ChVector3f.getCPtr(B));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Sub(ChVector3f A, ChVector3f B) {
    chronoPINVOKE.ChVector3f_Sub(swigCPtr, ChVector3f.getCPtr(A), ChVector3f.getCPtr(B));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Mul(ChVector3f A, float s) {
    chronoPINVOKE.ChVector3f_Mul(swigCPtr, ChVector3f.getCPtr(A), s);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Scale(float s) {
    chronoPINVOKE.ChVector3f_Scale(swigCPtr, s);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Cross(ChVector3f A, ChVector3f B) {
    chronoPINVOKE.ChVector3f_Cross__SWIG_0(swigCPtr, ChVector3f.getCPtr(A), ChVector3f.getCPtr(B));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVector3f Cross(ChVector3f other) {
    ChVector3f ret = new ChVector3f(chronoPINVOKE.ChVector3f_Cross__SWIG_1(swigCPtr, ChVector3f.getCPtr(other)), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Dot(ChVector3f B) {
    float ret = chronoPINVOKE.ChVector3f_Dot(swigCPtr, ChVector3f.getCPtr(B));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Normalize() {
    bool ret = chronoPINVOKE.ChVector3f_Normalize(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3f GetNormalized() {
    ChVector3f ret = new ChVector3f(chronoPINVOKE.ChVector3f_GetNormalized(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLength(float s) {
    chronoPINVOKE.ChVector3f_SetLength(swigCPtr, s);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetDirectionAxesAsX(ChVector3f Vx, ChVector3f Vy, ChVector3f Vz, ChVector3f y_sugg) {
    chronoPINVOKE.ChVector3f_GetDirectionAxesAsX__SWIG_0(swigCPtr, ChVector3f.getCPtr(Vx), ChVector3f.getCPtr(Vy), ChVector3f.getCPtr(Vz), ChVector3f.getCPtr(y_sugg));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetDirectionAxesAsX(ChVector3f Vx, ChVector3f Vy, ChVector3f Vz) {
    chronoPINVOKE.ChVector3f_GetDirectionAxesAsX__SWIG_1(swigCPtr, ChVector3f.getCPtr(Vx), ChVector3f.getCPtr(Vy), ChVector3f.getCPtr(Vz));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetDirectionAxesAsY(ChVector3f Vx, ChVector3f Vy, ChVector3f Vz, ChVector3f z_sugg) {
    chronoPINVOKE.ChVector3f_GetDirectionAxesAsY__SWIG_0(swigCPtr, ChVector3f.getCPtr(Vx), ChVector3f.getCPtr(Vy), ChVector3f.getCPtr(Vz), ChVector3f.getCPtr(z_sugg));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetDirectionAxesAsY(ChVector3f Vx, ChVector3f Vy, ChVector3f Vz) {
    chronoPINVOKE.ChVector3f_GetDirectionAxesAsY__SWIG_1(swigCPtr, ChVector3f.getCPtr(Vx), ChVector3f.getCPtr(Vy), ChVector3f.getCPtr(Vz));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetDirectionAxesAsZ(ChVector3f Vx, ChVector3f Vy, ChVector3f Vz, ChVector3f x_sugg) {
    chronoPINVOKE.ChVector3f_GetDirectionAxesAsZ__SWIG_0(swigCPtr, ChVector3f.getCPtr(Vx), ChVector3f.getCPtr(Vy), ChVector3f.getCPtr(Vz), ChVector3f.getCPtr(x_sugg));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetDirectionAxesAsZ(ChVector3f Vx, ChVector3f Vy, ChVector3f Vz) {
    chronoPINVOKE.ChVector3f_GetDirectionAxesAsZ__SWIG_1(swigCPtr, ChVector3f.getCPtr(Vx), ChVector3f.getCPtr(Vy), ChVector3f.getCPtr(Vz));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetMaxComponent() {
    int ret = chronoPINVOKE.ChVector3f_GetMaxComponent(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVector3f GetOrthogonalVector() {
    ChVector3f ret = new ChVector3f(chronoPINVOKE.ChVector3f_GetOrthogonalVector(swigCPtr), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive_out) {
    chronoPINVOKE.ChVector3f_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive_out));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive_in) {
    chronoPINVOKE.ChVector3f_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive_in));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public float x {
    set {
      chronoPINVOKE.ChVector3f_x_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChVector3f_x_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float y {
    set {
      chronoPINVOKE.ChVector3f_y_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChVector3f_y_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float z {
    set {
      chronoPINVOKE.ChVector3f_z_set(swigCPtr, value);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = chronoPINVOKE.ChVector3f_z_get(swigCPtr);
      if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
