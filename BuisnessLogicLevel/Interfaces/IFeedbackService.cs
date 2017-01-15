using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLogicLevel.Infrastructure;
using Models.Entities;

namespace BuisnessLogicLevel.Interfaces
{
    public interface IFeedbackService
    {
        OperationDetails CreateFeedback(Feedback model);
        OperationDetails DeleteFeedback(Feedback model);
        OperationDetails UpdateFeedback(Feedback model);
        List<Feedback> GetAllFeedbacks();
    }
}
