using ProblemPlecakowy;

namespace TestProject
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test1_co_najmniej_jeden_przedmiot_spelnia_warunki()
        {
            // Arrange
            int n = 3;
            int seed = 1;
            int capacity = 6;

            Problem problem = new Problem(n, seed);

            problem.ForceItems(2, 1, 0); 
            problem.ForceItems(13, 3, 1); 
            problem.ForceItems(9, 5, 2); 

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.IsTrue(result.List_ID.Count > 0);
        }

        [TestMethod]
        public void Test2_zaden_przedmiot_nie_spelnia_ograniczenia()
        {
            // Arrange
            int n = 3;
            int seed = 1;
            int capacity = 6;

            Problem problem = new Problem(n, seed);

            problem.ForceItems(20, 41, 0); 
            problem.ForceItems(13, 3, 1); 
            problem.ForceItems(9, 5, 2); 

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(0, result.List_ID.Count);
            Assert.AreEqual(0, result.total_value);
            Assert.AreEqual(0, result.total_weight);
        }

        [TestMethod]
        public void Test3_poprawnosc_wyniku_dla_konkretnej_instancji()
        {
            // Arrange
            int n = 5;
            int seed = 1;
            int capacity = 18;

            Problem problem = new Problem(n, seed);

            problem.ForceItems(9, 4, 0);
            problem.ForceItems(4, 3, 1);
            problem.ForceItems(4, 5, 2);
            problem.ForceItems(1, 5, 3);
            problem.ForceItems(10, 5, 4);

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(4, result.List_ID.Count);
            Assert.AreEqual(18, result.total_value);
            Assert.AreEqual(17, result.total_weight);
        }

        [TestMethod]
        public void Test4_pojemnosc_plecaka_to_0()
        {
            // Arrange
            int n = 5; 
            int seed = 123;
            int capacity = 0; 

            Problem problem = new Problem(n, seed);

            // Act
            Result result = problem.Solve(capacity);

            // Assert
            Assert.AreEqual(0, result.List_ID.Count);
            Assert.AreEqual(0, result.total_value);
            Assert.AreEqual(0, result.total_weight);
        }

        [TestMethod]
        public void Test5_czy_kolejosc_ma_znaczenie()
        {
            int n = 3;
            int seed = 1;
            int capacity = 20;

            Problem problem1 = new Problem(n, seed);
            Problem problem2 = new Problem(n, seed);

            problem1.ForceItems(2, 7, 0);
            problem1.ForceItems(5, 3, 1);
            problem1.ForceItems(9, 5, 2);

            problem2.ForceItems(9, 5, 2);
            problem2.ForceItems(5, 3, 1);
            problem2.ForceItems(2, 7, 0);


            Result result1 = problem1.Solve(capacity);
            Result result2 = problem2.Solve(capacity);

            Assert.AreEqual(result1.List_ID.Count, result2.List_ID.Count);
            Assert.AreEqual(result1.total_value, result2.total_value);
            Assert.AreEqual(result1.total_weight, result2.total_weight);
        }
   
        [TestMethod]
        public void Test6_przedmioty_o_wartosci_0()
        {
            int n = 3;
            int seed = 1;
            int capacity = 6;

            Problem problem = new Problem(n, seed);

            problem.ForceItems(0, 41, 0);
            problem.ForceItems(0, 3, 1);
            problem.ForceItems(0, 5, 2);

            Result result = problem.Solve(capacity);

            Assert.AreEqual(0, result.List_ID.Count);
            Assert.AreEqual(0, result.total_value);
            Assert.AreEqual(0, result.total_weight);
        }

        [TestMethod]
        public void Test7_ujemna_pojemnosc()
        {
            int n = 3;
            int seed = 1;
            int capacity = -6;

            Problem problem = new Problem(n, seed);

            problem.ForceItems(0, 41, 0);
            problem.ForceItems(0, 3, 1);
            problem.ForceItems(0, 5, 2);

            Result result = problem.Solve(capacity);

            Assert.AreEqual(0, result.List_ID.Count);
            Assert.AreEqual(0, result.total_value);
            Assert.AreEqual(0, result.total_weight);
        }

        [TestMethod]
        public void Test8_n_rowny_0()
        {
            int n = 0;
            int seed = 1;
            int capacity = 7;

            Problem problem = new Problem(n, seed);

            Result result = problem.Solve(capacity);

            Assert.AreEqual(0, result.List_ID.Count);
            Assert.AreEqual(0, result.total_value);
            Assert.AreEqual(0, result.total_weight);
        }
    }
    /*[TestMethod]
        public void Test2_jakis_przyklad()
        {
            int n = 3;
            int seed = 1;
            int capacity = 5;

            Problem problem = new Problem(n, seed);

            problem.ForceItems(2, 1, 0);
            problem.ForceItems(3, 1, 1);
            problem.ForceItems(4, 1, 2);

            Result result = problem.Solve(capacity);

            Assert.AreEqual(2, result.List_ID.Count);
            Assert.AreEqual(5, result.total_value);
            Assert.AreEqual(2, result.total_weight);

        }*/

    /* [TestMethod]
       public void Test5_konkretny_przyklad()
       {
           int n = 5;
           int seed = 1;
           int capacity = 18;

           Problem problem = new Problem(n, seed);

           problem.ForceItems(9, 4, 0);
           problem.ForceItems(4, 3, 1);
           problem.ForceItems(4, 5, 2);
           problem.ForceItems(1, 5, 3);
           problem.ForceItems(10, 5, 4);

           Result result = problem.Solve(capacity);

           Assert.AreEqual(4, result.List_ID.Count);
           Assert.AreEqual(18, result.total_value);
           Assert.AreEqual(17, result.total_weight);
       }*/
}