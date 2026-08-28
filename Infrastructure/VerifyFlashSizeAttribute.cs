using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BoardApp.Infrastructure
{
    public class VerifyFlashSizeAttribute: Attribute,IModelValidator
    {
        public bool IsRequired => true;

        public string ErrorMessage { get; set; } = "Valid flash sizes in KB are: 16, 32, 64, 128, 256, 512, 1024, 2048, 4096";

        //valid flash sizes in KB
        private readonly List<int> validFlashSizes = new List<int>()
        {
            16,32,64,128,256,512,1024,2048,4096
        };

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            int?value = context.Model as int?;

            //Fail if null or not in the allowed set
            if(value ==null || !validFlashSizes.Contains(value.Value))
            {
                return new List<ModelValidationResult>
                {
                    new ModelValidationResult("",ErrorMessage)
                };
            }

            //pass if valid 
            return Enumerable.Empty<ModelValidationResult>();
        }
    }
}
