using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Custom_Report_Debugger
{
    class HierarchyChecker
    {
        private static List<string> ConfigImport(string[] config)
        {
            var group = new List<string>();

            foreach (var field in config)
            {
                group.Add(field.Trim().Replace("\n", ""));
            }

            return group;
        }

        public static List<string> HierarchyManagement(List<string> mergefieldsToTest)
        {
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));
            var managedAssetSummary = ConfigImport(ConfigurationManager.AppSettings.Get("ManagedAssetSummary").Split(','));
            var managedAssetSummary_Plans = ConfigImport(ConfigurationManager.AppSettings.Get("ManagedAssetSummary_Plans").Split(','));
            var managedAssetSummary_AllPlans = ConfigImport(ConfigurationManager.AppSettings.Get("ManagedAssetSummary_AllPlans").Split(','));
            var managedAssetSummary_SubPlans = ConfigImport(ConfigurationManager.AppSettings.Get("ManagedAssetSummary_SubPlans").Split(','));
            var managedAssetSummary_CostsAndChargesSummary = ConfigImport(ConfigurationManager.AppSettings.Get("ManagedAssetSummary_CostsAndChargesSummary").Split(','));
            var managedAssetSummary_CostsAndCharges = ConfigImport(ConfigurationManager.AppSettings.Get("ManagedAssetSummary_CostsAndCharges").Split(','));
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));
            var report_Group = ConfigImport(ConfigurationManager.AppSettings.Get("Report").Split(','));

            //Report
            //var report_Group = new List<string>();
            //var report_Group_Array = ConfigurationManager.AppSettings.Get("Report").Split(',');
            //foreach (var field in report_Group_Array)
            //{
            //    report_Group.Add(field.Trim().Replace("\n", ""));
            //}

            //Managed Asset Summary
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

            //Protections
            var protections_Group = new List<string>();
            var protections_Group_Array = ConfigurationManager.AppSettings.Get("Protections").Split(',');
            foreach (var field in protections_Group_Array)
            {
                protections_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_Plans_Group = new List<string>();
            var protections_Plans_Group_Array = ConfigurationManager.AppSettings.Get("Protections_Plans").Split(',');
            foreach (var field in protections_Plans_Group_Array)
            {
                protections_Plans_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_FundsWithoutPortfolio_Group = new List<string>();
            var protections_FundsWithoutPortfolio_Group_Array = ConfigurationManager.AppSettings.Get("Protections_FundsWithoutPortfolio").Split(',');
            foreach (var field in protections_FundsWithoutPortfolio_Group_Array)
            {
                protections_FundsWithoutPortfolio_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_AssetClasses_Group = new List<string>();
            var protections_AssetClasses_Group_Array = ConfigurationManager.AppSettings.Get("Protections_AssetClasses").Split(',');
            foreach (var field in protections_AssetClasses_Group_Array)
            {
                protections_AssetClasses_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_Regions_Group = new List<string>();
            var protections_Regions_Group_Array = ConfigurationManager.AppSettings.Get("Protections_Regions").Split(',');
            foreach (var field in protections_Regions_Group_Array)
            {
                protections_Regions_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_Covers_Group = new List<string>();
            var protections_Covers_Group_Array = ConfigurationManager.AppSettings.Get("Protections_Covers").Split(',');
            foreach (var field in protections_Covers_Group_Array)
            {
                protections_Covers_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_Funds_Group = new List<string>();
            var protections_Funds_Group_Array = ConfigurationManager.AppSettings.Get("Protections_Funds").Split(',');
            foreach (var field in protections_Funds_Group_Array)
            {
                protections_Funds_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_Detailed_Group = new List<string>();
            var protections_Detailed_Group_Array = ConfigurationManager.AppSettings.Get("Protections_Detailed").Split(',');
            foreach (var field in protections_Detailed_Group_Array)
            {
                protections_Detailed_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_Summarised_Group = new List<string>();
            var protections_Summarised_Group_Array = ConfigurationManager.AppSettings.Get("Protections_Summarised").Split(',');
            foreach (var field in protections_Summarised_Group_Array)
            {
                protections_Summarised_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_CoverDetails_Group = new List<string>();
            var protections_CoverDetails_Group_Array = ConfigurationManager.AppSettings.Get("Protections_CoverDetails").Split(',');
            foreach (var field in protections_CoverDetails_Group_Array)
            {
                protections_CoverDetails_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_LookThrough_Group = new List<string>();
            var protections_LookThrough_Group_Array = ConfigurationManager.AppSettings.Get("Protections_LookThrough").Split(',');
            foreach (var field in protections_LookThrough_Group_Array)
            {
                protections_LookThrough_Group.Add(field.Trim().Replace("\n", ""));
            }

            var protections_Assets_Group = new List<string>();
            var protections_Assets_Group_Array = ConfigurationManager.AppSettings.Get("Protections_Assets").Split(',');
            foreach (var field in protections_Assets_Group_Array)
            {
                protections_Assets_Group.Add(field.Trim().Replace("\n", ""));
            }

            //Mortgages
            var mortgages_Group = new List<string>();
            var mortgages_Group_Array = ConfigurationManager.AppSettings.Get("Mortgages").Split(',');
            foreach (var field in mortgages_Group_Array)
            {
                mortgages_Group.Add(field.Trim().Replace("\n", ""));
            }

            var mortgages_Plans_Group = new List<string>();
            var mortgages_Plans_Group_Array = ConfigurationManager.AppSettings.Get("Mortgages_Plans").Split(',');
            foreach (var field in mortgages_Plans_Group_Array)
            {
                mortgages_Plans_Group.Add(field.Trim().Replace("\n", ""));
            }

            var mortgages_FundsWithoutPortfolio_Group = new List<string>();
            var mortgages_FundsWithoutPortfolio_Group_Array = ConfigurationManager.AppSettings.Get("Mortgages_FundsWithoutPortfolio").Split(',');
            foreach (var field in mortgages_FundsWithoutPortfolio_Group_Array)
            {
                mortgages_FundsWithoutPortfolio_Group.Add(field.Trim().Replace("\n", ""));
            }

            var mortgages_LookThrough_Group = new List<string>();
            var mortgages_LookThrough_Group_Array = ConfigurationManager.AppSettings.Get("Mortgages_LookThrough").Split(',');
            foreach (var field in mortgages_LookThrough_Group_Array)
            {
                mortgages_LookThrough_Group.Add(field.Trim().Replace("\n", ""));
            }

            var mortgages_Assets_Group = new List<string>();
            var mortgages_Assets_Group_Array = ConfigurationManager.AppSettings.Get("Mortgages_Assets").Split(',');
            foreach (var field in mortgages_Assets_Group_Array)
            {
                mortgages_Assets_Group.Add(field.Trim().Replace("\n", ""));
            }

            var mortgages_Funds_Group = new List<string>();
            var mortgages_Funds_Group_Array = ConfigurationManager.AppSettings.Get("Mortgages_Funds").Split(',');
            foreach (var field in mortgages_Funds_Group_Array)
            {
                mortgages_Funds_Group.Add(field.Trim().Replace("\n", ""));
            }

            //General Insurances
            var generalInsurances_Group = new List<string>();
            var generalInsurances_Group_Array = ConfigurationManager.AppSettings.Get("GeneralInsurances").Split(',');
            foreach (var field in generalInsurances_Group_Array)
            {
                generalInsurances_Group.Add(field.Trim().Replace("\n", ""));
            }

            var generalInsurances_Plans_Group = new List<string>();
            var generalInsurances_Plans_Group_Array = ConfigurationManager.AppSettings.Get("GeneralInsurances_Plans").Split(',');
            foreach (var field in generalInsurances_Plans_Group_Array)
            {
                generalInsurances_Plans_Group.Add(field.Trim().Replace("\n", ""));
            }

            var generalInsurances_FundsWithoutPortfolio_Group = new List<string>();
            var generalInsurances_FundsWithoutPortfolio_Group_Array = ConfigurationManager.AppSettings.Get("GeneralInsurances_FundsWithoutPortfolio").Split(',');
            foreach (var field in generalInsurances_FundsWithoutPortfolio_Group_Array)
            {
                generalInsurances_FundsWithoutPortfolio_Group.Add(field.Trim().Replace("\n", ""));
            }

            var generalInsurances_LookThrough_Group = new List<string>();
            var generalInsurances_LookThrough_Group_Array = ConfigurationManager.AppSettings.Get("GeneralInsurances_LookThrough").Split(',');
            foreach (var field in generalInsurances_LookThrough_Group_Array)
            {
                generalInsurances_LookThrough_Group.Add(field.Trim().Replace("\n", ""));
            }

            var generalInsurances_Funds_Group = new List<string>();
            var generalInsurances_Funds_Group_Array = ConfigurationManager.AppSettings.Get("GeneralInsurances_Funds").Split(',');
            foreach (var field in generalInsurances_Funds_Group_Array)
            {
                generalInsurances_Funds_Group.Add(field.Trim().Replace("\n", ""));
            }

            var generalInsurances_Assets_Group = new List<string>();
            var generalInsurances_Assets_Group_Array = ConfigurationManager.AppSettings.Get("GeneralInsurances_Assets").Split(',');
            foreach (var field in generalInsurances_Assets_Group_Array)
            {
                generalInsurances_Assets_Group.Add(field.Trim().Replace("\n", ""));
            }

            //FundXRay
            var fundXRay_Group = new List<string>();
            var fundXRay_Group_Array = ConfigurationManager.AppSettings.Get("FundXRay").Split(',');
            foreach (var field in fundXRay_Group_Array)
            {
                fundXRay_Group.Add(field.Trim().Replace("\n", ""));
            }

            var fundXRay_AssetClasses_Group = new List<string>();
            var fundXRay_AssetClasses_Group_Array = ConfigurationManager.AppSettings.Get("FundXRay_AssetClasses").Split(',');
            foreach (var field in fundXRay_AssetClasses_Group_Array)
            {
                fundXRay_AssetClasses_Group.Add(field.Trim().Replace("\n", ""));
            }

            var fundXRay_Regions_Group = new List<string>();
            var fundXRay_Regions_Group_Array = ConfigurationManager.AppSettings.Get("FundXRay_Regions").Split(',');
            foreach (var field in fundXRay_Regions_Group_Array)
            {
                fundXRay_Regions_Group.Add(field.Trim().Replace("\n", ""));
            }

            var fundXRay_Summarised_Group = new List<string>();
            var fundXRay_Summarised_Group_Array = ConfigurationManager.AppSettings.Get("FundXRay_Summarised").Split(',');
            foreach (var field in fundXRay_Summarised_Group_Array)
            {
                fundXRay_Summarised_Group.Add(field.Trim().Replace("\n", ""));
            }

            var fundXRay_Detailed_Group = new List<string>();
            var fundXRay_Detailed_Group_Array = ConfigurationManager.AppSettings.Get("FundXRay_Detailed").Split(',');
            foreach (var field in fundXRay_Detailed_Group_Array)
            {
                fundXRay_Detailed_Group.Add(field.Trim().Replace("\n", ""));
            }

            //TaxWrappers
            var taxWrappers_Group = new List<string>();
            var taxWrappers_Group_Array = ConfigurationManager.AppSettings.Get("TaxWrappers").Split(',');
            foreach (var field in taxWrappers_Group_Array)
            {
                taxWrappers_Group.Add(field.Trim().Replace("\n", ""));
            }

            var taxWrappers_Plans_Group = new List<string>();
            var taxWrappers_Plans_Group_Array = ConfigurationManager.AppSettings.Get("TaxWrappers_Plans").Split(',');
            foreach (var field in taxWrappers_Plans_Group_Array)
            {
                taxWrappers_Plans_Group.Add(field.Trim().Replace("\n", ""));
            }



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
                        if (!generalInsurances_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Plans}" && activeGroups.Contains("GeneralInsurances}"))
                    {
                        if (!generalInsurances_Plans_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithoutPortfolio}" && activeGroups.Contains("GeneralInsurances}"))
                    {
                        if (!generalInsurances_FundsWithoutPortfolio_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Funds}" && activeGroups.Contains("GeneralInsurances}"))
                    {
                        if (!generalInsurances_Funds_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:LookThrough}" && activeGroups.Contains("GeneralInsurances}"))
                    {
                        if (!generalInsurances_LookThrough_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Assets}" && activeGroups.Contains("GeneralInsurances}"))
                    {
                        if (!generalInsurances_Assets_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    //Mortgages
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Mortgages}")
                    {
                        if (!mortgages_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Plans}" && activeGroups.Contains("Mortgages}"))
                    {
                        if (!mortgages_Plans_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithoutPortfolio}" && activeGroups.Contains("Mortgages}"))
                    {
                        if (!mortgages_FundsWithoutPortfolio_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Funds}" && activeGroups.Contains("Mortgages}"))
                    {
                        if (!mortgages_Funds_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:LookThrough}" && activeGroups.Contains("Mortgages}"))
                    {
                        if (!mortgages_LookThrough_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Assets}" && activeGroups.Contains("Mortgages}"))
                    {
                        if (!mortgages_Assets_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    //Protections
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Protections}")
                    {
                        if (!protections_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Plans}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_Plans_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundsWithoutPortfolio}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_FundsWithoutPortfolio_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Funds}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_Funds_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:LookThrough}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_LookThrough_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Assets}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_Assets_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:AssetClasses}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_AssetClasses_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Regions}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_Regions_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Covers}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_Covers_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Summarised}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_Summarised_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Detailed}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_Detailed_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:CoverDetails}" && activeGroups.Contains("Protections}"))
                    {
                        if (!protections_CoverDetails_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    //Tax Wrappers
                    else if (currentGroup == "{MERGEFIELD BeginGroup:TaxWrappers}")
                    {
                        if (!taxWrappers_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Plans}" && activeGroups.Contains("TaxWrappers}"))
                    {
                        if (!taxWrappers_Plans_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    //FundXRay
                    else if (currentGroup == "{MERGEFIELD BeginGroup:FundXRay}")
                    {
                        if (!fundXRay_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:AssetClasses}" && activeGroups.Contains("FundXRay}"))
                    {
                        if (!fundXRay_AssetClasses_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Regions}" && activeGroups.Contains("FundXRay}"))
                    {
                        if (!fundXRay_Regions_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Summarised}" && activeGroups.Contains("FundXRay}"))
                    {
                        if (!fundXRay_Summarised_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                    else if (currentGroup == "{MERGEFIELD BeginGroup:Detailed}" && activeGroups.Contains("FundXRay}"))
                    {
                        if (!fundXRay_Detailed_Group.Contains(field))
                        {
                            Console.WriteLine(field + " -- Could not be found in this path");
                            failedMergefields_Hierarchy.Add(field);
                        }
                        else
                        {
                            Console.WriteLine(field);
                        }
                    }
                }
            }

            return failedMergefields_Hierarchy;
        }
    }
}
