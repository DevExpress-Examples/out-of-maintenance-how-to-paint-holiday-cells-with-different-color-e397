<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E397)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomDrawHolidayCells/Form1.cs) (VB: [Form1.vb](./VB/CustomDrawHolidayCells/Form1.vb))
<!-- default file list end -->
# How to paint holiday cells with different color


<p><strong>Problem:</strong><br />
How can I change the column color of specific dates? The goal is to mark the holiday with a different color than the weekdays.</p><p><strong>Solution:</strong><br />
You should handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_CustomDrawTimeCelltopic">CustomDrawTimeCell</a> event, which enables time cells to be painted manually. The attached project illustrates how you can accomplish this task.</p>

<br/>


