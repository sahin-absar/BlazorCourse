using Microsoft.AspNetCore.Components;

namespace BlazorCourse.Pages
{
    public class AlertComponent:ComponentBase
    {
        public string alertMessage;
        public string alertType;

        public void ClearAlert()
        {
            alertMessage = null;
            alertType = null;
        }
        public void ShowAlert(string message, string type)
        {
            alertMessage = message;
            alertType = type;
        }
    }
}
