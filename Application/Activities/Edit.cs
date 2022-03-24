using AutoMapper;
using Domain;
using Infrastructure;
using MediatR;

namespace Application.Activities
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Activity? Activity { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = request.Activity;

                if (activity != null)
                {
                    _context.Set<Activity>().Update(activity);
                    await _context.SaveChangesAsync();
                }

                return Unit.Value;
            }
        }
    }
}
