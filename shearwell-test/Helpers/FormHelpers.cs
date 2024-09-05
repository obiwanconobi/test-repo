using System.Text.RegularExpressions;

namespace shearwell_test.Helpers
{
    public class FormHelpers
    {
        public bool ValidateTagInput(String input)
        {
            if (Regex.IsMatch(input, @"^UK\d{7} \d{5}$"))
            {
                // formModel.TagValidationMessage = "Tag must be in the format UKXXXXXXX XXXXX";
                return true;
            }
            return false;
        }
    }
}
