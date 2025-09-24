# Visualize Annual Global Corporate Investment in AI with .NET MAUI Doughnut & Column Charts

This sample demonstrates how to visualize global corporate investment in Artificial Intelligence using Syncfusion’s .NET MAUI charting controls. It features an interactive Doughnut Chart for entity-wise investment breakdown and a Column Chart for year-wise investment trends.

## Key Features

**1. Interactive Doughnut Chart:**

This chart provides a high-level overview of total AI investments categorized by entity type—such as Mergers & Acquisitions (M&A), Private Investment, Public Offering, and Minority Stake. Each segment is clickable, allowing users to interact with the data and explore specific categories in more detail. The chart also uses smart labels and exploding segments to make the data easier to read and visually engaging.

**2. Column Chart:**

Once a user taps a segment in the Doughnut Chart, they’re taken to a Column Chart that shows year-wise investment trends (from 2013 to 2023) for the selected entity type. This helps users analyze how investment patterns have evolved over time, making it ideal for spotting growth trends or shifts in funding priorities.

**3. Drill-Down Navigation:**

This feature enhances interactivity by allowing users to tap on a segment of the Doughnut Chart and instantly navigate to a detailed Column Chart view. It helps users explore specific investment categories in depth, making the data exploration seamless and intuitive.

**4. Custom Styling:**

Both charts use a consistent set of brushes (colors and styles) to maintain visual harmony. This ensures that the same entity type is represented with the same color across charts, improving recognition and reducing cognitive load for users.

**5. Smart Labels & Exploding Segments:**

Smart labels automatically adjust to avoid overlap and improve readability, especially in dense data views. Exploding segments (slightly separated slices) in the Doughnut Chart highlight selected or important data points, drawing attention to key insights.

## Syncfusion Controls Used

[SfCircularChart](https://help.syncfusion.com/maui/circular-charts/getting-started)

SfCircularChart with DoughnutSeries
SelectionChanging event for drill-down interaction

[SfCartesianChart](https://help.syncfusion.com/maui/cartesian-charts/getting-started)

SfCartesianChart with ColumnSeries
Custom brushes and smart label formatting

## Use Cases

**1. Financial Dashboards:** 
- This visualization is ideal for financial analysts and decision-makers who need to monitor AI investment patterns across different entity types and years. 
- By presenting both high-level and detailed views, it supports strategic planning and helps identify growth areas or shifts in funding priorities.

**2. Tech Research:** 
- Researchers studying corporate trends in AI funding can use these charts to analyze how investment behaviors have evolved over time. 
- The breakdown by entity type and year-wise trends provides valuable insights into which sectors and investment forms are driving innovation.

**3. Data Journalism:** 
- Data journalists can leverage the interactive visuals to tell compelling stories about the rise of AI investments. 
- The drill-down capability and smart formatting make it easier to highlight key trends, making complex data accessible and engaging for a broader audience

**4. Policy Analysis:** 
- Policy analysts can use this visualization to compare investment priorities across sectors and time periods. 
- It helps identify funding gaps, assess the impact of policy decisions, and guide future strategies for AI development and regulation.

## Output

![AIInvestments_Charts_Blog_Demo]()

## Troubleshooting

**Path too long exception**

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [Visualize Annual Global Corporate Investment in AI with .NET MAUI Doughnut & Column Charts]().