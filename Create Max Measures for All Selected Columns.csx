// Creates a MAX measure for every currently selected column and hide the column.
foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
    "Max of MAX " + c.Name,                    // Name
        "MAX(" + c.DaxObjectFullName + ")",    // DAX expression
        c.DisplayFolder                        // Display Folder
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = "0.00";

    // Provide some documentation:
    newMeasure.Description = "This measure is the MAX of column " + c.DaxObjectFullName;

    // Hide the base column:
    c.IsHidden = true;
}
