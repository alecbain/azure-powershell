---
external help file: Az.Purview-help.xml
Module Name: Az.Purview
online version: https://learn.microsoft.com/powershell/module/Az.Purview/new-AzPurviewAzureSynapseWorkspaceMsiScanObject
schema: 2.0.0
---

# New-AzPurviewAzureSynapseWorkspaceMsiScanObject

## SYNOPSIS
Create an in-memory object for AzureSynapseWorkspaceMsiScan.

## SYNTAX

```
New-AzPurviewAzureSynapseWorkspaceMsiScanObject -Kind <ScanAuthorizationType>
 [-CollectionReferenceName <String>] [-CollectionType <String>] [-ConnectedViaReferenceName <String>]
 [-CredentialReferenceName <String>] [-CredentialType <CredentialType>]
 [-ResourceType <IExpandingResourceScanPropertiesResourceTypes>] [-ScanRulesetName <String>]
 [-ScanRulesetType <ScanRulesetType>] [-Worker <Int32>]
 [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for AzureSynapseWorkspaceMsiScan.

## EXAMPLES

### Example 1: Create Azure Synapse Workspace Msi scan object
```powershell
New-AzPurviewAzureSynapseWorkspaceMsiScanObject -Kind 'AzureSynapseWorkspaceMsi' -CollectionReferenceName 'parv-brs-2' -CollectionType 'CollectionReference' -ScanRulesetName 'AzureSynapseSQL' -ScanRulesetType 'System'
```

```output
CollectionLastModifiedAt  :
CollectionReferenceName   : parv-brs-2
CollectionType            : CollectionReference
ConnectedViaReferenceName :
CreatedAt                 :
CredentialReferenceName   :
CredentialType            :
Id                        :
Kind                      : AzureSynapseWorkspaceMsi
LastModifiedAt            :
Name                      :
ResourceType              : {
                            }
Result                    :
ScanRulesetName           : AzureSynapseSQL
ScanRulesetType           : System
Worker                    :
```

Create Azure Synapse Workspace Msi scan object

## PARAMETERS

### -CollectionReferenceName

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CollectionType

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectedViaReferenceName

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CredentialReferenceName

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CredentialType

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Kind

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanAuthorizationType
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceType
To construct, see NOTES section for RESOURCETYPE properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IExpandingResourceScanPropertiesResourceTypes
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScanRulesetName

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScanRulesetType

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Worker

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AzureSynapseWorkspaceMsiScan

## NOTES

## RELATED LINKS
