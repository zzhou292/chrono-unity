//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class vector_SphereShape : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<SphereShape>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vector_SphereShape(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(vector_SphereShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~vector_SphereShape() {
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
          chrono_vehiclePINVOKE.delete_vector_SphereShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public vector_SphereShape(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (SphereShape element in c) {
      this.Add(element);
    }
  }

  public vector_SphereShape(global::System.Collections.Generic.IEnumerable<SphereShape> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (SphereShape element in c) {
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

  public SphereShape this[int index]  {
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

  public void CopyTo(SphereShape[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(SphereShape[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, SphereShape[] array, int arrayIndex, int count)
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

  public SphereShape[] ToArray() {
    SphereShape[] array = new SphereShape[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<SphereShape> global::System.Collections.Generic.IEnumerable<SphereShape>.GetEnumerator() {
    return new vector_SphereShapeEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new vector_SphereShapeEnumerator(this);
  }

  public vector_SphereShapeEnumerator GetEnumerator() {
    return new vector_SphereShapeEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class vector_SphereShapeEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<SphereShape>
  {
    private vector_SphereShape collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public vector_SphereShapeEnumerator(vector_SphereShape collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public SphereShape Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (SphereShape)currentObject;
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
    chrono_vehiclePINVOKE.vector_SphereShape_Clear(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(SphereShape x) {
    chrono_vehiclePINVOKE.vector_SphereShape_Add(swigCPtr, SphereShape.getCPtr(x));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = chrono_vehiclePINVOKE.vector_SphereShape_size(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = chrono_vehiclePINVOKE.vector_SphereShape_capacity(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    chrono_vehiclePINVOKE.vector_SphereShape_reserve(swigCPtr, n);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_SphereShape() : this(chrono_vehiclePINVOKE.new_vector_SphereShape__SWIG_0(), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_SphereShape(vector_SphereShape other) : this(chrono_vehiclePINVOKE.new_vector_SphereShape__SWIG_1(vector_SphereShape.getCPtr(other)), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_SphereShape(int capacity) : this(chrono_vehiclePINVOKE.new_vector_SphereShape__SWIG_2(capacity), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private SphereShape getitemcopy(int index) {
    SphereShape ret = new SphereShape(chrono_vehiclePINVOKE.vector_SphereShape_getitemcopy(swigCPtr, index), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private SphereShape getitem(int index) {
    SphereShape ret = new SphereShape(chrono_vehiclePINVOKE.vector_SphereShape_getitem(swigCPtr, index), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, SphereShape val) {
    chrono_vehiclePINVOKE.vector_SphereShape_setitem(swigCPtr, index, SphereShape.getCPtr(val));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(vector_SphereShape values) {
    chrono_vehiclePINVOKE.vector_SphereShape_AddRange(swigCPtr, vector_SphereShape.getCPtr(values));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_SphereShape GetRange(int index, int count) {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.vector_SphereShape_GetRange(swigCPtr, index, count);
    vector_SphereShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_SphereShape(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, SphereShape x) {
    chrono_vehiclePINVOKE.vector_SphereShape_Insert(swigCPtr, index, SphereShape.getCPtr(x));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, vector_SphereShape values) {
    chrono_vehiclePINVOKE.vector_SphereShape_InsertRange(swigCPtr, index, vector_SphereShape.getCPtr(values));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    chrono_vehiclePINVOKE.vector_SphereShape_RemoveAt(swigCPtr, index);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    chrono_vehiclePINVOKE.vector_SphereShape_RemoveRange(swigCPtr, index, count);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public static vector_SphereShape Repeat(SphereShape value, int count) {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.vector_SphereShape_Repeat(SphereShape.getCPtr(value), count);
    vector_SphereShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_SphereShape(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    chrono_vehiclePINVOKE.vector_SphereShape_Reverse__SWIG_0(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    chrono_vehiclePINVOKE.vector_SphereShape_Reverse__SWIG_1(swigCPtr, index, count);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, vector_SphereShape values) {
    chrono_vehiclePINVOKE.vector_SphereShape_SetRange(swigCPtr, index, vector_SphereShape.getCPtr(values));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
