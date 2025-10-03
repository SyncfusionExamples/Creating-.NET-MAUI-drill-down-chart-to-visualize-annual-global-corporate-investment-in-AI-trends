# Visualize Global AI Investment with Drilldown Charts from the Toolkit 

This blog will guide you through building an interactive data visualization experience using Syncfusion’s .NET MAUI charting controls. You'll learn how to present global corporate investment in Artificial Intelligence (AI) using drilldown-enabled Doughnut and Column Charts, making complex data more accessible and engaging.

## Understanding Drilldown Charts

Drilldown charts are a powerful way to explore hierarchical or multi-level data interactively. Instead of displaying all data at once, they start with a high-level summary and allow users to "drill down" into more detailed views by clicking on specific chart elements.

## Key Features

**1. Doughnut Chart with Drilldown:**

- Visualizes entity-wise AI investment.
- Supports drilldown interaction: tapping a segment reveals detailed investment categories for the selected entity.
- Includes exploding segments for emphasis and clarity.
- Smart labels ensure readability even with dense data.

**2. Custom Styling:**

- Uses custom brushes to differentiate investment categories visually.
- Legend customization enhances clarity and aligns with the chart’s color scheme.

**3. Column Chart with Drilldown:**

- Displays year-wise investment trends.
- Drilldown reveals sector-specific or regional breakdowns for each year.
- Features smart labels for better data presentation.
- Supports exploding segments to highlight key data points.

## Syncfusion Controls Used

[SfCircularChart](https://help.syncfusion.com/maui/circular-charts/getting-started)

- SfCircularChart with DoughnutSeries
- SelectionChanging event for drill-down interaction
- Smart labels formatting and Custom brushes

[SfCartesianChart](https://help.syncfusion.com/maui/cartesian-charts/getting-started)

- SfCartesianChart with ColumnSeries

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

![AIInvestments_Charts_Blog_Demo](https://github.com/user-attachments/assets/7a47dd95-0c03-4826-aa01-bcb6e741c3d2)

## Troubleshooting

**Path too long exception**

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [Visualize Annual Global Corporate Investment in AI with .NET MAUI Doughnut & Column Charts]().