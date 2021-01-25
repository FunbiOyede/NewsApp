using System;
using System.Collections.Generic;
using System.Text;
using CommonServiceLocator;
namespace NewsApp.ViewModels
{
  public class ViewModelLocator
    {
        public HeadlineViewModel HeadlineViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HeadlineViewModel>();
            }
        }


        public SearchViewModel SearchViewModel 
        
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SearchViewModel>();

            }
        }

    }
}
