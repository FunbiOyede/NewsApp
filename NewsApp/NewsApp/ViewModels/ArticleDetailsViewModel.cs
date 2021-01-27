using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApp.ViewModels
{
   public class ArticleDetailsViewModel : BaseViewModel
    {

        private Article articleContent;
        public Article ArticleContent
        {
            get { return articleContent; }
            set { articleContent = value; RaisePropertyChanged(nameof(ArticleContent)); }
        }

        public ArticleDetailsViewModel( Article article)
        {
            ArticleContent = article;
        }
    }
}
