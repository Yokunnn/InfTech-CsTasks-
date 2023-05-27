using System;
using System.Collections.Generic;
using System.Text;

namespace UtilLibrary
{
    interface Movie
    {
        string Name { get; set; }
        List<string> Show();
        string AddTitri();
    }
}
