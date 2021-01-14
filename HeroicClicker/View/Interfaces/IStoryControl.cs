using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.View.Interfaces
{
    interface IStoryControl : IControl
    {
        event Action StartStory;
        event Action ContinueStory;
        
        string SelectedStory { get; set; }

        BindingList<string> Stories { set; }
    }
}
