using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Custom_Report_Debugger
{
    class HierarchyChecker
    {
        public static List<string> HierarchyManagement(List<string> mergefieldsToTest)
        {
            var report_Group = new List<string>();
            var report_Group_Array = ConfigurationManager.AppSettings.Get("Report").Split(',');
            foreach (var field in report_Group_Array)
            {
                report_Group.Add(field.Trim().Replace("\n", ""));
            }

            var managedAssetSummary_Group = new List<string>();
            var managedAssetSummary_Group_Array = ConfigurationManager.AppSettings.Get("ManagedAssetSummary").Split(',');
            foreach (var field in managedAssetSummary_Group_Array)
            {
                managedAssetSummary_Group.Add(field.Trim().Replace("\n", ""));
            }

            var managedAssetSummary_Plans_Group = new List<string>();
            var managedAssetSummary_Plans_Group_Array = ConfigurationManager.AppSettings.Get("ManagedAssetSummary_Plans").Split(',');
            foreach (var field in managedAssetSummary_Plans_Group_Array)
            {
                managedAssetSummary_Plans_Group.Add(field.Trim().Replace("\n", ""));
            }

            var managedAssetSummary_AllPlans_Group = new List<string>();
            var managedAssetSummary_AllPlans_Group_Array = ConfigurationManager.AppSettings.Get("ManagedAssetSummary_AllPlans").Split(',');
            foreach (var field in managedAssetSummary_AllPlans_Group_Array)
            {
                managedAssetSummary_AllPlans_Group.Add(field.Trim().Replace("\n", ""));
            }

            var managedAssetSummary_SubPlans_Group = new List<string>();
            var managedAssetSummary_SubPlans_Group_Array = ConfigurationManager.AppSettings.Get("ManagedAssetSummary_SubPlans").Split(',');
            foreach (var field in managedAssetSummary_SubPlans_Group_Array)
            {
                managedAssetSummary_SubPlans_Group.Add(field.Trim().Replace("\n", ""));
            }

            var managedAssetSummary_CostsAndChargesSummary_Group = new List<string>();
            var managedAssetSummary_CostsAndChargesSummary_Group_Array = ConfigurationManager.AppSettings.Get("ManagedAssetSummary_CostsAndChargesSummary").Split(',');
            foreach (var field in managedAssetSummary_CostsAndChargesSummary_Group_Array)
            {
                managedAssetSummary_CostsAndChargesSummary_Group.Add(field.Trim().Replace("\n", ""));
            }

            var managedAssetSummary_CostsAndCharges_Group = new List<string>();
            var managedAssetSummary_CostsAndCharges_Group_Array = ConfigurationManager.AppSettings.Get("ManagedAssetSummary_CostsAndCharges").Split(',');
            foreach (var field in managedAssetSummary_CostsAndCharges_Group_Array)
            {
                managedAssetSummary_CostsAndCharges_Group.Add(field.Trim().Replace("\n", ""));
            }

            //foreach (var field in report_Group)
                //Console.WriteLine(field);


            int indexOfLastOpenGroup;
            string currentGroup;
            var activeGroups = new List<string>();
            var failedMergefields_Hierarchy = new List<string>();
            

            foreach (var field in mergefieldsToTest)
            {
                if (field.Contains("BeginGroup"))
                {
                    var splitBegin = field.Split(':');
                    activeGroups.Add(splitBegin[1]);
                }
                else if (field.Contains("EndGroup"))
                {
                    var splitEnd = field.Split(':');
                    activeGroups.Remove(splitEnd[1]);
                }
                else
                {
                    foreach (var group in activeGroups)
                    {                        
                        var neatGroup = group.Replace("}","");
                        Console.Write(neatGroup + " --> ");
                    }


                    indexOfLastOpenGroup = activeGroups.Count - 1;
                    currentGroup = activeGroups[indexOfLastOpenGroup];
                    currentGroup = "{MERGEFIELD BeginGroup:" + currentGroup;
                    
                    //REPORT
                    if (currentGroup == "{MERGEFIELD BeginGroup:Report}")
                    {
                        if (!report_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                            
                    }
                    //MANAGED ASSET SUMMARY
                    else if (currentGroup == "{MERGEFIELD BeginGroup:ManagedAssetSummary}")
                    {
                        if (!managedAssetSummary_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Plans}" && activeGroups.Contains("ManagedAssetSummary}"))
                    {
                        if (!managedAssetSummary_Plans_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:CostsAndChargesSummary}" && activeGroups.Contains("ManagedAssetSummary}"))
                    {
                        if (!managedAssetSummary_CostsAndChargesSummary_Group.Contains(field))
                        {
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:CostsAndCharges}" && activeGroups.Contains("ManagedAssetSummary}"))
                    {
                        if (!managedAssetSummary_CostsAndCharges_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:SubPlans}" && activeGroups.Contains("ManagedAssetSummary}"))
                    {
                        if (!managedAssetSummary_SubPlans_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:AllPlans}" && activeGroups.Contains("ManagedAssetSummary}"))
                    {
                        if (!managedAssetSummary_AllPlans_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }

                    //INVESTMENTS
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Investments}")
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:PlansWithFunds}" && activeGroups.Contains("Investments}"))
                    {                     

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithoutPortfolio}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Funds}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:LookThrough}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Assets}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithPortfolio}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Portfolios}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:SubPlansWithFunds}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:CostsAndChargesSummary}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:CostsAndCharges}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:AssetClasses}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Summarised}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Detailed}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Regions}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:SubPlansWithoutFunds}" && activeGroups.Contains("Investments}"))
                    {

                    }  
                    else if (currentGroup == "{MERGEFIELD BeginGroup:PlansWithoutFunds}" && activeGroups.Contains("Investments}"))
                    {

                    }
                     else if (currentGroup == "{MERGEFIELD BeginGroup:AllPlans}" && activeGroups.Contains("Investments}"))
                    {

                    }
                    //PENSIONS
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Pensions}")
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:PlansWithFunds}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:CostsAndChargesSummary}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:CostsAndCharges}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithoutPortfolio}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Funds}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:LookThrough}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Assets}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithPortfolio}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Portfolios}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:AssetClasses}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Summarised}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Detailed}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Regions}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:SubPlansWithFunds}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                     else if (currentGroup == "{MERGEFIELD BeginGroup:SubPlansWithoutFunds}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                     else if (currentGroup == "{MERGEFIELD BeginGroup:PlansWithoutFunds}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:AllPlans}" && activeGroups.Contains("Pensions}"))
                    {

                    }
                    //General Insurances
                    else if (currentGroup == "{MERGEFIELD BeginGroup:GeneralInsurances}")
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Plans}" && activeGroups.Contains("GeneralInsurances}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithoutPortfolio}" && activeGroups.Contains("GeneralInsurances}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Funds}" && activeGroups.Contains("GeneralInsurances}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:LookThrough}" && activeGroups.Contains("GeneralInsurances}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Assets}" && activeGroups.Contains("GeneralInsurances}"))
                    {

                    }
                    //Mortgages
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Mortgages}")
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Plans}" && activeGroups.Contains("Mortgages}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithoutPortfolio}" && activeGroups.Contains("Mortgages}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Funds}" && activeGroups.Contains("Mortgages}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:LookThrough}" && activeGroups.Contains("Mortgages}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Assets}" && activeGroups.Contains("Mortgages}"))
                    {

                    }
                    //Protections
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Protections}")
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Plans}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithoutPortfolio}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Funds}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:LookThrough}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Assets}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:AssetClasses}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Regions}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Covers}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Summarised}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Detailed}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:CoverDetails}" && activeGroups.Contains("Protections}"))
                    {

                    }
                    //Tax Wrappers
                    else if (currentGroup == "{MERGEFIELD BeginGroup:TaxWrappers}")
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Plans}" && activeGroups.Contains("TaxWrappers}"))
                    {

                    }
                    //FundXRay
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundXRay}")
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:AssetClasses}" && activeGroups.Contains("FundXRay}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Regions}" && activeGroups.Contains("FundXRay}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Summarised}" && activeGroups.Contains("FundXRay}"))
                    {

                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Detailed}" && activeGroups.Contains("FundXRay}"))
                    {

                    }
                }
            }

            return failedMergefields_Hierarchy;
        }
    }
}
