using BLL;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class SuggestService
    {
        private SuggestRepository _suggestRepository;

        public SuggestService()
        {
            _suggestRepository = new SuggestRepository();
        }
        public Suggest publish(string title,string body,int authorId)
        {
            Suggest suggest = new Suggest
            {
                //Author = new UserRepository().GetById(authorId),
                Body = body,
                Title = title,
            };

            suggest.Publish();
            return _suggestRepository.Save(suggest);
        }
    }
}
