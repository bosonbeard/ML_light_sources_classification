using System;
using System.Linq;
using Accord.Statistics.Models.Regression.Linear;
using Accord.Statistics.Analysis;
using Accord.IO;
using Accord.Math;
using System.Data;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Kernels;
using Accord.Controls;

namespace c_sharp_spectrum_classify_for_habr
{
    class Program
    {
        static void Main(string[] args)
        {

            //for correct symbol of float point
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            //This is a program for demonstrating machine 
            //learning and classifying the spectrum of light sources using .net


            //read data (If you use linux do not forget to correct the path to the files)
            string trainCsvFilePath = @"data\train.csv";
            string testCsvFilePath = @"data\test.csv";
            DataTable trainTable = new CsvReader(trainCsvFilePath, true).ToTable();
            DataTable testTable = new CsvReader(testCsvFilePath, true).ToTable();
 

            // Convert the DataTable to input and output vectors (train and test)
            int[] trainOutputs = trainTable.Columns["label"].ToArray<int>();
                        trainTable.Columns.Remove("label");
            double[][] trainInputs = trainTable.ToJagged<double>();
            int[] testOutputs = testTable.Columns["label"].ToArray<int>();
            testTable.Columns.Remove("label");
            double[][] testInputs = testTable.ToJagged<double>();

            // training  model SVM classifier
            var teacher = new MulticlassSupportVectorLearning<Gaussian>()
            {
                // Configure the learning algorithm to use SMO to train the
                //  underlying SVMs in each of the binary class subproblems.
                Learner = (param) => new SequentialMinimalOptimization<Gaussian>()
                {
                    // Estimate a suitable guess for the Gaussian kernel's parameters.
                    // This estimate can serve as a starting point for a grid search.
                    UseKernelEstimation = true
                }
            };

            // Learn a machine
            var machine = teacher.Learn(trainInputs, trainOutputs);

            // Obtain class predictions for each sample
            int[] predicted = machine.Decide(testInputs);

            // print result
            int i = 0;
            Console.WriteLine("results - (predict ,real labels)");
            foreach (int pred in predicted)
            {

                Console.Write("({0},{1} )", pred, testOutputs[i]);
                i++;
            }

            //calculate the accuracy
            double error = new ZeroOneLoss(testOutputs).Loss(predicted);

            Console.WriteLine("\n accuracy: {0}", 1 - error);

            // consider the decrease in the dimension of features using PCA
            var pca = new PrincipalComponentAnalysis()
            {
                Method = PrincipalComponentMethod.Center,
                Whiten = true
            };

            pca.NumberOfOutputs = 2;
            MultivariateLinearRegression transform = pca.Learn(trainInputs);
            double[][] outputPCA = pca.Transform(trainInputs);

            // print it on the scatter plot
            ScatterplotBox.Show(outputPCA, trainOutputs).Hold();

            Console.ReadLine();
        }
    }
}
