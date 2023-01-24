using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
   //IRequest is the return value

    /*public class GetPersonListQueryClass : IRequest<List<PersonModel>>
    {
    }*/
}
