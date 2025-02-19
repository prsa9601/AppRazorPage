﻿using Eshop.RazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppRazorPage.Infrastructure.RazorUtils;

public class BaseRazorFilter<TFilterParam> : PageModel where TFilterParam : BaseFilterParam
{
    [BindProperty(SupportsGet = true)]
    public TFilterParam FilterParams { get; set; }
}