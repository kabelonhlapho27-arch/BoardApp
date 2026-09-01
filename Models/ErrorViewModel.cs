// Group leader name : Kabelo Nhlapho
// Group Student nrs : 219005935;224042163;224037409;220048471;223068452;224136508;224069913
// Assignment nr     : SOD226C Practical Assessment 1 · 2026
// Purpose           : The purpose of this class is to provide error model data 
//                     and request tracking identifiers for error views.

namespace BoardApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId
        {
            //
            //Name             : property string? RequestId
            //Purpose          : Automatic public property to give access to corresponding compiler generated field
            //Re-use           : none
            //Input Parameter  : string? value
            //                   new value for corresponding compiler generated field
            //Output Type      : string?
            //                   value stored in the corresponding compiler generated field
            //
            get; set;
        } // end property

        public bool ShowRequestId
        {
            //
            //Name             : property bool ShowRequestId
            //Purpose          : Read-only property to determine whether RequestId is present and should be displayed
            //Re-use           : none
            //Input Parameter  : none
            //Output Type      : bool
            //                   true if RequestId is not null or empty; otherwise, false
            //
            get
            {
                return !string.IsNullOrEmpty(RequestId);
            } // end get
        } // end property
    } // end class ErrorViewModel
} // end BoardApp.Models
