<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomDrawHolidayCells/Form1.cs) (VB: [Form1.vb](./VB/CustomDrawHolidayCells/Form1.vb))
<!-- default file list end -->
# How to paint holiday cells with different color


<p><strong>Problem:</strong><br />
How can I change the column color of specific dates? The goal is to mark the holiday with a different color than the weekdays.</p><p><strong>Solution:</strong><br />
You should handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_CustomDrawTimeCelltopic">CustomDrawTimeCell</a> event, which enables time cells to be painted manually. The attached project illustrates how you can accomplish this task.</p>

<br/>


