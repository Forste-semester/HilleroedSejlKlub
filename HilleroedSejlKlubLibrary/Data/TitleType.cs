using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Data
{
    public enum TitleType
    {
        [Display(Name = "Board Director")]
        Board_Director,

        [Display(Name = "Board Member")]
        Board_Member,

        Secretary,
        Member
    }
}
