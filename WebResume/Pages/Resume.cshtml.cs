using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebResume.Data;
using WebResume.Domain;

namespace WebResume.Pages;

public class ResumeModel : PageModel
{
    private readonly IExperienceData _experienceData;
    private readonly ITechnologyData _technologyData;

    public ResumeModel(IExperienceData experienceData, ITechnologyData technologyData)
    {
        _experienceData = experienceData;
        _technologyData = technologyData;
    }

    public IEnumerable<Experience> Experiences { get; set; }
    public IEnumerable<Technology> Languages { get; set; }
    public IEnumerable<Technology> OperatingSystems { get; set; }
    public IEnumerable<Technology> Software { get; set; }

    public void OnGet()
    {
        Experiences = _experienceData.GetAll();
        Languages = _technologyData.GetAllLanguages();
        OperatingSystems = _technologyData.GetAllOperatingSystems();
        Software = _technologyData.GetAllSoftware();
    }
}