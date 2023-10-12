using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocablazorizer.Data;

namespace Vocablazorizer.Services
{
    public class VocabularyService
    {
        private List<Vocabulary> VocabularyList;

        public VocabularyService() 
        {
            VocabularyList = LoadVocabulariesFromFile();
        }

        public List<Vocabulary> GetVocabularies()
        {
            List<Vocabulary> vocabularies = new();



            return vocabularies;
        }

        public void AddNewVocabularies(Vocabulary vocabulary)
        {
            VocabularyList.Add(vocabulary);
            SaveVocabulariesFromFile();
        }

        public void DeleteVocabulary(Vocabulary vocabulary)
        {
            VocabularyList.Remove(vocabulary);
            SaveVocabulariesFromFile();
        }

        // maybe use databinding instead?
        public void UpdateVocabulary(Vocabulary vocabulary,string word,string wordToTranslate)
        {
            Vocabulary vocabularyToUpdate = VocabularyList.Where(voc => voc.Id == vocabulary.Id).FirstOrDefault();
            vocabularyToUpdate.Word = word;
            vocabularyToUpdate.WordTranslated = wordToTranslate;
        }

        internal void SaveVocabulariesFromFile()
        {

        }

        internal List<Vocabulary> LoadVocabulariesFromFile()
        {
            List<Vocabulary> vocabularies = new();



            return vocabularies;
        }
    }
}
