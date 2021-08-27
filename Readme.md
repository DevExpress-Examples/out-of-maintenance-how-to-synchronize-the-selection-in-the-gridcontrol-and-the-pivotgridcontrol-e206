<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2065)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q248711/Form1.cs) (VB: [Form1.vb](./VB/Q248711/Form1.vb))
<!-- default file list end -->
# How to synchronize the selection in the GridControl and the PivotGridControl


<p>This example demonstrates how to select data in the PivotGridCotnrol based on the selected cell in the GridControl.</p>


<h3>Description</h3>

<p>The functionality demonstrated in this sample is implemented within the UpdatePivotSelection method. First, you need to obtain the PivotgridField, corresponding to the currently selected GridColumn. If this field is in the data or filter area, clear the selection and exit the function. <br />
 <br />
If this field is in the column or row area, iterate through all columns or rows and use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_GetFieldValuetopic">PivotGridControl.GetFieldValue</a> method to obtain the field value and compare it with the value currently selected in the GridControl.</p><p>Remember all indexes, corresponding to the field values that are equal to the currently selected value, and use them to create the Rectangle, describing the selected area.</p>

<br/>


