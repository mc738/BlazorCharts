using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorCharts
{
    public class Pipeline
    {
        public List<PipelineItem> Items { get; set; }


        public int NewLeads => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.NewLead).Count();
        public int Qualified => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.Qualified).Count();
        public int QuotesSent => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.QuoteSent).Count();
        public int InProgress => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.InProgress).Count();
        public int Won => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.Won).Count();


        public decimal NewLeadsValue => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.NewLead).Sum(x => x.Value);
        public decimal QualifiedValue => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.Qualified).Sum(x => x.Value);
        public decimal QuotesSentValue => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.QuoteSent).Sum(x => x.Value);
        public decimal InProgressValue => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.InProgress).Sum(x => x.Value);
        public decimal WonValue => Items.Where(x => x.PipelineItemStatus == PipelineItemStatus.InProgress).Sum(x => x.Value);


        public int QualifiedStage => Items.Where(x => (int)x.PipelineItemStatus > 1).Count();
        public int QuoteSentStage => Items.Where(x => (int)x.PipelineItemStatus > 2).Count();
        public int InProgressStage => Items.Where(x => (int)x.PipelineItemStatus > 3).Count();
        public int WonStage => Items.Where(x => (int)x.PipelineItemStatus > 4).Count();

        //decimal qualifedPercent = ((decimal)Pipeline.QualifiedStage / Pipeline.Total) * 100;
        //decimal quoteSentPercent = ((decimal)Pipeline.QuoteSentStage / Pipeline.Total) * 100;
        //decimal inProgressPrecent = ((decimal)Pipeline.InProgressStage / Pipeline.Total) * 100;
        //decimal wonPercent = ((decimal)Pipeline.WonStage / Pipeline.Total) * 100;


        public decimal NewLeadsStagePercent => 100;
        public decimal QualifiedStagePercent => ((decimal)QualifiedStage / Total) * 100;
        public decimal QuoteSentStagePercent => ((decimal)QuoteSentStage / Total) * 100;
        public decimal InProgressStagrPercent => ((decimal)InProgressStage / Total) * 100;
        public decimal WonStagePercent => ((decimal)WonStage / Total) * 100;

        public decimal NewLeadsStageValuePercent => 100;
        public decimal QualifiedStageValuePercent => (QualifiedStageValue / TotalValue) * 100;
        public decimal QuoteSentStageValuePercent => (QuoteSentStageValue / TotalValue) * 100;
        public decimal InProgressStageValuePercent => (InProgressStageValue / TotalValue) * 100;
        public decimal WonStageValuePercent => (WonStageValue / TotalValue) * 100;



        public decimal QualifiedStageValue => Items.Where(x => (int)x.PipelineItemStatus > 1).Sum(x => x.Value);
        public decimal QuoteSentStageValue => Items.Where(x => (int)x.PipelineItemStatus > 2).Sum(x => x.Value);
        public decimal InProgressStageValue => Items.Where(x => (int)x.PipelineItemStatus > 3).Sum(x => x.Value);
        public decimal WonStageValue => Items.Where(x => (int)x.PipelineItemStatus > 4).Sum(x => x.Value);





        public int Total => Items.Count();
        public decimal TotalValue => Items.Sum(x => x.Value);

        public Pipeline()
        {
            Items = new List<PipelineItem>();
        }
    }
}
