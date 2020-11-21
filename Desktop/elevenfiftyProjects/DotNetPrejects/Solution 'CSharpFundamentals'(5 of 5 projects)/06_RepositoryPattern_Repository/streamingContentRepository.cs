using System;
using System.Collections.Generic;
using System.Text;

namespace _06_RepositoryPattern_Repository
{
   public  class streamingContentRepository
    {
        private List<streamingContent> listofcontent = new List<streamingContent>();
        
        //Create
        public void AddContentToList(streamingContent content)
        {
            listofcontent.Add(content);
        }
        //Read
        public List<streamingContent> GetContentList()
        {
            return listofcontent;
        }

        //Update
        public void UpdateExistingContent(string originalTitle, streamingContent newContent)
        {
            // find the content
            streamingContent oldContent = GetContentByTitle(originalTitle);

            // Update the content
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
            }
        }

        //Delate
        public bool RemoveContentFromList(string title)
        {
            streamingContent content = GetContentByTitle(title);
            if(content == null)
            {
                return false;
            }
            int initialCount = listofcontent.Count;
            listofcontent.Remove(content);
            if (initialCount > listofcontent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        private streamingContent GetContentByTitle(string title)
        {
            foreach(streamingContent content in listofcontent)
            {
                if (content.Title == title)
                        {
                    return content;
                }
            }
            return null;
        }

    }
}
