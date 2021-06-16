using System;

namespace TrainingAccessModifier{
  internal class VertexQuadratic{
    internal static float[] vertexPoint;
    internal float h = 0F;
    internal float k = 0F;  
    internal VertexQuadratic(int a, int b, int c){
      h = -b / (2*a);
      k = a*h*h + b*h + c;

      Console.Write(h);
      Console.Write(" ");
      Console.Write(k);

      vertexPoint = new float[]{h, k};
    }
  }
}