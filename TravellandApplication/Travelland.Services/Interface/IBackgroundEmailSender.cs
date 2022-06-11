using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Travelland.Services.Interface
{
    public interface IBackgroundEmailSender
    {
        Task DoWork();
    }
}
