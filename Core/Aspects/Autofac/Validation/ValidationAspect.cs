using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception //Aspect
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            // defensice coding
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType; 
        }
        protected override void OnBefore(IInvocation invocation)
        {
            // Alttaki "var validator = (IValidator)Activator.CreateInstance(_validatorType)" productValidator'u
            // bizim icin reflection ile new'liyor yani bir instance olusturuyor.
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            // "var entityType = _validatorType.BaseType.GetGenericArguments()[0];" bu kodda Product tipini almamiza yarar
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
