﻿using Domain.DTO_s;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Validations
{
    public class MascotaValidator : AbstractValidator<MascotaDto>
    {
        public MascotaValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().NotNull().WithMessage("El campo Nombre no puede estar vacio");
            RuleFor(x => x.Edad).NotEmpty().NotNull().WithMessage("El campo Edad no puede estar vacio");
            RuleFor(x => x.AnimalId).NotEmpty().NotNull().WithMessage("El campo AnimalId no puede estar vacio");
            RuleFor(x => x.Peso).NotEmpty().GreaterThan(0).WithMessage("El campo Peso no puede estar vacio y tiene que ser mayor a 0");
            RuleFor(x => x.Imagen).NotEmpty().WithMessage("El campo Imagen no puede estar vacio");
        }
    }
}