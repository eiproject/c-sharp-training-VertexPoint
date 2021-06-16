using System;

namespace TrainingAccessModifier
{
  class Program
  {
    static void Main(string[] args)
    {
      VertexQuadratic V1 = new VertexQuadratic(1, 0, 25);
      Console.WriteLine(V1.vertexPoint);
    }
  }
}

// namespace Vertex{
//   class runVertex{
//     static void  countVertexPoint(){
//       VertexQuadratic V1 = new VertexQuadratic(1, 1, 1);
//     }
    
    
//   }
// }