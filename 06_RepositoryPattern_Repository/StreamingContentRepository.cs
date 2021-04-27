using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        //Create
        //This method adds a SC to our List<StreamingContent>. It takes in an SC as a parameter. We build out all the properties of that object in the UI, then call this method to add it to a list
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        //Read
        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }

        //Update
        public bool UpdateExistingContwnt(string originalTitle, StreamingContent newContent)
        {
            // fing the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            
            //Update the content
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if (content == null)
            {
                return false;
            }

            int intialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if(intialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;
        }

    }
}
