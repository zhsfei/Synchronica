// automatically generated, do not modify

namespace Synchronica.Schema
{

using FlatBuffers;

public sealed class StepKeyFrameData_Int64 : Table {
  public static StepKeyFrameData_Int64 GetRootAsStepKeyFrameData_Int64(ByteBuffer _bb) { return GetRootAsStepKeyFrameData_Int64(_bb, new StepKeyFrameData_Int64()); }
  public static StepKeyFrameData_Int64 GetRootAsStepKeyFrameData_Int64(ByteBuffer _bb, StepKeyFrameData_Int64 obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public StepKeyFrameData_Int64 __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Time { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long Value { get { int o = __offset(6); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }

  public static Offset<StepKeyFrameData_Int64> CreateStepKeyFrameData_Int64(FlatBufferBuilder builder,
      int time = 0,
      long value = 0) {
    builder.StartObject(2);
    StepKeyFrameData_Int64.AddValue(builder, value);
    StepKeyFrameData_Int64.AddTime(builder, time);
    return StepKeyFrameData_Int64.EndStepKeyFrameData_Int64(builder);
  }

  public static void StartStepKeyFrameData_Int64(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddTime(FlatBufferBuilder builder, int time) { builder.AddInt(0, time, 0); }
  public static void AddValue(FlatBufferBuilder builder, long value) { builder.AddLong(1, value, 0); }
  public static Offset<StepKeyFrameData_Int64> EndStepKeyFrameData_Int64(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<StepKeyFrameData_Int64>(o);
  }
};


}
