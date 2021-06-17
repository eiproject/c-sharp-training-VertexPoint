using System;

namespace TrainingAccessModifier
{
  class Program
  {
    static void RunVertex(float a, float b, float c){
      VertexQuadratic V1 = new VertexQuadratic(a, b, c);
      float x = VertexQuadratic.vertexPoint[0];
      float y = VertexQuadratic.vertexPoint[1];
      Console.WriteLine("Vertex Point coordinate: " + x.ToString() + " , " + y.ToString());
      }

    static void RunSplitingSentences(string sentence)
    {
      SplittingSentences S1 = new SplittingSentences();
      Console.WriteLine(S1[0]);
    }

    static void Main(string[] args)
    {
      RunVertex(
        a:1.1F, 
        b:0.2F, 
        c:1.5F
        );
      
      RunSplitingSentences(
        sentence:"Learning C# Language From Scratch");
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