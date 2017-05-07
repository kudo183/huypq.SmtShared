using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huypq.SmtShared.Test
{
    public partial class TestDataDto
    {
        partial void RaiseDependentPropertyChanged(string basePropertyName)
        {
            if (basePropertyName == nameof(Data))
            {
                OnPropertyChanged(nameof(DisplayText));
            }
        }

        public string DisplayText
        {
            get { return Data; }
        }
    }
}
