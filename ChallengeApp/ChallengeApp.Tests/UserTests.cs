namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult()
        {
            //arrage
            var user = new User("Pawe³", "8271411");
            user.AddScore(5);
            user.AddScore(5);
            user.AddScore(10);
            user.AddScore(-12);
            
            //act 
            var result = user.Result;

            //assert
            Assert.AreEqual(8, result);
        }

    }
}