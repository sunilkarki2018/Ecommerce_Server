﻿using AutoMapper;
using Ecommerce.Business.src.Abstractions;
using Ecommerce.Business.src.DTOs;
using Ecommerce.Core.src.Abstractions;
using Ecommerce.Core.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.src.Services
{
    public class ReviewService : BaseService<Review, ReviewReadDTO, ReviewCreateDTO, ReviewUpdateDTO>, IReviewService
    {
        protected readonly IReviewRepo _repo;
        public ReviewService(IReviewRepo repo, IMapper mapper) : base(repo, mapper)
        {
        }
    }
}
