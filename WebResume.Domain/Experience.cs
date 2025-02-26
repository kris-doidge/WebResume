using System;
using System.Collections.Generic;

namespace WebResume.Domain;

public class Experience
{
    public string Company { get; set; }
    public List<string> Responsibilities { get; set; }
    public string Title { get; set; }
    public Tuple<string, string> Duration { get; set; }
}