# DailyJoke.Net
Clean architecture example in .Net Core


## ARM Template Deployment

1. Connect to Azure. In Package Manager Console type:
` Connect-AzAccount

2. If you have multiple subscriptions, choose the subscription you want to use:
` Set-AzContext "{SubscriptionName}"

3. Create a new Resource Group to deploy the resources in to:
` New-AzResourceGroup -Name "{ResourceGroupName}" -Location "North Europe"

4. Deploy the ARM template (note - no spaces allowed in the deployment name):
` New-AzResourceGroupDeployment -Name "{DeploymentName}" -ResourceGroupName "{ResourceGroupName}" -TemplateFile ".\Resources\Azure\{filename}.json" -sqladminusername "{username}" -sqladminpassword "{password}"


SQL Server deployment is particularly slow. If the template includes an SQL server resource, expect the deployment to take several minutes.

Linked templates do not work from the local file system. 
You can either provide a URI value of the linked template that includes either HTTP or HTTPS, or use the relativePath property to deploy a remote linked template at a location relative to the parent template. 
One option is to place both the main template and the linked template in a storage account.

