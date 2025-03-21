//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class vector_vector_ChVector3d : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<vector_ChVector3d>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vector_vector_ChVector3d(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(vector_vector_ChVector3d obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~vector_vector_ChVector3d() {
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
          chronoPINVOKE.delete_vector_vector_ChVector3d(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public vector_vector_ChVector3d(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (vector_ChVector3d element in c) {
      this.Add(element);
    }
  }

  public vector_vector_ChVector3d(global::System.Collections.Generic.IEnumerable<vector_ChVector3d> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (vector_ChVector3d element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public vector_ChVector3d this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(vector_ChVector3d[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(vector_ChVector3d[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, vector_ChVector3d[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public vector_ChVector3d[] ToArray() {
    vector_ChVector3d[] array = new vector_ChVector3d[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<vector_ChVector3d> global::System.Collections.Generic.IEnumerable<vector_ChVector3d>.GetEnumerator() {
    return new vector_vector_ChVector3dEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new vector_vector_ChVector3dEnumerator(this);
  }

  public vector_vector_ChVector3dEnumerator GetEnumerator() {
    return new vector_vector_ChVector3dEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class vector_vector_ChVector3dEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<vector_ChVector3d>
  {
    private vector_vector_ChVector3d collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public vector_vector_ChVector3dEnumerator(vector_vector_ChVector3d collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public vector_ChVector3d Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (vector_ChVector3d)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    chronoPINVOKE.vector_vector_ChVector3d_Clear(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(vector_ChVector3d x) {
    chronoPINVOKE.vector_vector_ChVector3d_Add(swigCPtr, vector_ChVector3d.getCPtr(x));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = chronoPINVOKE.vector_vector_ChVector3d_size(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = chronoPINVOKE.vector_vector_ChVector3d_capacity(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    chronoPINVOKE.vector_vector_ChVector3d_reserve(swigCPtr, n);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_vector_ChVector3d() : this(chronoPINVOKE.new_vector_vector_ChVector3d__SWIG_0(), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_vector_ChVector3d(vector_vector_ChVector3d other) : this(chronoPINVOKE.new_vector_vector_ChVector3d__SWIG_1(vector_vector_ChVector3d.getCPtr(other)), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_vector_ChVector3d(int capacity) : this(chronoPINVOKE.new_vector_vector_ChVector3d__SWIG_2(capacity), true) {
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  private vector_ChVector3d getitemcopy(int index) {
    vector_ChVector3d ret = new vector_ChVector3d(chronoPINVOKE.vector_vector_ChVector3d_getitemcopy(swigCPtr, index), true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private vector_ChVector3d getitem(int index) {
    vector_ChVector3d ret = new vector_ChVector3d(chronoPINVOKE.vector_vector_ChVector3d_getitem(swigCPtr, index), false);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, vector_ChVector3d val) {
    chronoPINVOKE.vector_vector_ChVector3d_setitem(swigCPtr, index, vector_ChVector3d.getCPtr(val));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(vector_vector_ChVector3d values) {
    chronoPINVOKE.vector_vector_ChVector3d_AddRange(swigCPtr, vector_vector_ChVector3d.getCPtr(values));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_vector_ChVector3d GetRange(int index, int count) {
    global::System.IntPtr cPtr = chronoPINVOKE.vector_vector_ChVector3d_GetRange(swigCPtr, index, count);
    vector_vector_ChVector3d ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_vector_ChVector3d(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, vector_ChVector3d x) {
    chronoPINVOKE.vector_vector_ChVector3d_Insert(swigCPtr, index, vector_ChVector3d.getCPtr(x));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, vector_vector_ChVector3d values) {
    chronoPINVOKE.vector_vector_ChVector3d_InsertRange(swigCPtr, index, vector_vector_ChVector3d.getCPtr(values));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    chronoPINVOKE.vector_vector_ChVector3d_RemoveAt(swigCPtr, index);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    chronoPINVOKE.vector_vector_ChVector3d_RemoveRange(swigCPtr, index, count);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static vector_vector_ChVector3d Repeat(vector_ChVector3d value, int count) {
    global::System.IntPtr cPtr = chronoPINVOKE.vector_vector_ChVector3d_Repeat(vector_ChVector3d.getCPtr(value), count);
    vector_vector_ChVector3d ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_vector_ChVector3d(cPtr, true);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    chronoPINVOKE.vector_vector_ChVector3d_Reverse__SWIG_0(swigCPtr);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    chronoPINVOKE.vector_vector_ChVector3d_Reverse__SWIG_1(swigCPtr, index, count);
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, vector_vector_ChVector3d values) {
    chronoPINVOKE.vector_vector_ChVector3d_SetRange(swigCPtr, index, vector_vector_ChVector3d.getCPtr(values));
    if (chronoPINVOKE.SWIGPendingException.Pending) throw chronoPINVOKE.SWIGPendingException.Retrieve();
  }

}
