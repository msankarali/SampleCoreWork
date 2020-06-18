using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using PostSharp.Aspects;
using SampleCoreWork.Core.CrossCuttingConcerns.Validation.FluentValidation;

namespace SampleCoreWork.Core.Aspects.Postsharp
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        private Type _validatorType;
        public FluentValidationAspect(Type validator)
        {
            _validatorType = validator;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entityType);

            foreach (var entity in entities)
            {
                ValidatorTool.FluentValidate(validator, entity);
            }
        }
    }
}
