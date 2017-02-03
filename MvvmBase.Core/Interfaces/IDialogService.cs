using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmBase.Core.Interfaces
{
    public interface IDialogService
    {
        void Alert(string message, string title, string okbtnText);
    }
}
