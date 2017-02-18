using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    class BackPropProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin back-propagation demo");
            Console.WriteLine("End back-propagaton demo");
            Console.ReadLine();
        }
        public static void ShowMatrix(double [][] matrix, int numRows, int decimals, bool indices)
        {

        }
        public static void ShowVector(double[] vector, int decimals, int lineLen, bool newLine)
        {

        }
        static double [][] MakeAllData(int numInput, int numHidden, int numOutput, int numRows, int seed)
        {
            return null;
        }
        //static void SplitTrainTest(double[] allData, double trainPct, int seed, out double [][] trainData, out double [][] testData)
        //{
            
        //}
        public class NeuralNetwork
        {
            private int numInput;
            private int numHidden;
            private int numOutput;
            private double[] inputs;
            private double[][] ihweight;
            private double[] hBiases;
            private double[] hOutputs;

            private double[][] hoWeights;
            private double[] oBiases;
            private double[] outputs;

            private Random rnd;

            public NeuralNetwork(int numInput, int numbhidden, int numOutput)
            {

            }
            private static double [][] MakeMatrix(int rows, int cols, double v)
            {
                return null;
            }
            private void IntializedWeights()
            {

            }
            
            public void SetWeights(double[] weights)
            {

            } 
            public double[] GetWeights()
            {
                return null;
            }
            public double[] ComputeOutputs (double[] xValues)
            {
                return null;
            }
            private static double HyperTan(double x)
            {
                return 0;
            }
            private static double[] Softmax(double[] oSums)
            {
                return null;
            }
            public double[] Train(double[][] trainData, int maxEpochs, double learnRate, double momentum)
            {
                return null;
            }
            private void Shuffle(int[] sequence)
            {

            } 
            private double Error(double[][] trainData)
            {
                return 0;
            }
            public double Accuracy(double[][] testData)
            {
                return 0;
            }
            private static int MaxIndex(double[] vector)
            {
                return 0;
            }
        }
    }
}
