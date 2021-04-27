using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _60_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        private StreamingContentRepository _repo;
        private StreamingContent _content;



        [TestInitialize]

        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("rubber", "type comes to life with the power to make people explode and goes on a murderous ramage through the Californian desert", "R", 5.8, false, GenreType.Drama);

            _repo.AddContentToList(_content);
        }

        //add method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange -- Setting up the playing field
            StreamingContent content = new StreamingContent();
            content.Title = "toy story";
            StreamingContentRepository repository = new StreamingContentRepository();


            // Act --> Get/Run the code we want to test
            repository.AddContentToList(content);
            StreamingContent contentFromDirectory = repository.GetContentByTitle("Toy Story");

            // Assert --> Use the Assert class to verify the expected outcome
            Assert.IsNotNull(contentFromDirectory);
        }

        //Update
        [TestMethod]
        public void UpdateExistingContent_ShowReturnTrue()
        {
            //Arrange
            // TestInitialize
            StreamingContent newContent = new StreamingContent("rubber 2", "type comes to life with the power to make people explode and goes on a murderous ramage through the Californian desert", "R", 10, false, GenreType.RomCom);


            //Act
            bool updateResult = _repo.UpdateExistingContwnt("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);
        }


        [DataTestMethod]
        [DataRow("Rubber", true)]
        [DataRow("Toy Story", false)]
        public void UpdateExisitngContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate)
        {
            //Arrange
            // TestInitialize
            StreamingContent newContent = new StreamingContent("rubber 2", "type comes to life with the power to make people explode and goes on a murderous ramage through the Californian desert", "R", 10, false, GenreType.RomCom);


            //Act
            bool updateResult = _repo.UpdateExistingContwnt(originalTitle, newContent);

            //Assert
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            //Arrange

            //act
            bool deleteResult = _repo.RemoveContentFromList(_content.Title);

            //Assert
            Assert.IsTrue(deleteResult);
        }
    }
}
       

      

