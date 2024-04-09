using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Fusee.Math.Core;

namespace MillionThings
{
    internal class Program
    {
        static void Main()
        {
            _ = BenchmarkRunner.Run<BenchThis>();
        }
    }

    public class BenchThis
    {
        const int BENCH_COUNT = 1_000_000;

        [Benchmark]
        public void BenchStruct()
        {
            VertexS[] verts = new VertexS[BENCH_COUNT];

            for (int i = 0; i < verts.Length; i++)
            {
                verts[i].Position.x = i;
            }

            for (int i = 0;i < verts.Length; i++)
            {
                verts[i].Position.y = verts[i].Position.x;
            }
        }

        [Benchmark]
        public void BenchClass()
        {
            VertexC[] vertc = new VertexC[BENCH_COUNT];

            for(int i = 0; i < vertc.Length; i++)
            {
                vertc[i] = new VertexC();
                vertc[i].Position.x = i;
            }

            for (int i = 0; i < vertc.Length; i++)
            {
                vertc[i].Position.y = vertc[i].Position.x;
            }
        }
    }

    public struct VertexS
    {
        public float3 Position;
        public float3 Normal;
        public float3 UVW;
    }

    public class VertexC
    {
        public float3 Position;
        public float3 Normal;
        public float3 UVW;
    }
}
