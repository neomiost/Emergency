using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency.ViewModels
{
   
    public class MainVM:BaseVM
    {
        private AnalysisVM analysisVM;
        public AnalysisVM AnalysisVM
        {
            get
            {
                return analysisVM;
            }
            set
            {
                analysisVM = value;
                OnPropertyRaised("AnalysisVM");
            }
        }
        private CollectDetailsVM collectDetailsVM;
        public CollectDetailsVM CollectDetailsVM
        {
            get
            {
                return collectDetailsVM;
            }
            set
            {
                collectDetailsVM = value;
                OnPropertyRaised("CollectDetailsVM");
            }
        }
        private IdentificationVM identificationVM;
        public IdentificationVM IdentificationVM
        {
            get
            {
                return identificationVM;
            }
            set
            {
                identificationVM = value;
                OnPropertyRaised("IdentificationVM");
            }
        }
        private UpdateResultsVM udateResultsVM;
        public UpdateResultsVM UpdateResultsVM
        {
            get
            {
                return udateResultsVM;
            }
            set
            {
                udateResultsVM = value;
                OnPropertyRaised("UpdateResultsVM");
            }
        }
        private ViewDetailsVM viewDetailsVM;
        public ViewDetailsVM ViewDetailsVM
        {
            get
            {
                return viewDetailsVM;
            }
            set
            {
                viewDetailsVM = value;
                OnPropertyRaised("ViewDetailsVM");
            }
        }
        public MainVM()
        {
            AnalysisVM = new ViewModels.AnalysisVM();
            CollectDetailsVM = new ViewModels.CollectDetailsVM();
            IdentificationVM = new IdentificationVM();
            UpdateResultsVM = new UpdateResultsVM();
            ViewDetailsVM = new ViewDetailsVM();

        }
    }
}
