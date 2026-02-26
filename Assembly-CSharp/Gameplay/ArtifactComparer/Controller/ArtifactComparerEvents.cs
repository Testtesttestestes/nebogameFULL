using System;
using Gameplay.Inventory.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ArtifactComparer.Controller
{
	// Token: 0x02000CEC RID: 3308
	[Token(Token = "0x2000CEC")]
	public class ArtifactComparerEvents : AbstractMVCEvents
	{
		// Token: 0x0600507A RID: 20602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507A")]
		[Address(RVA = "0x9E89", Offset = "0x9E89", VA = "0x9E89")]
		public ArtifactComparerEvents(InventoryBaseEvents inventoryEvents)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58a3a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_Filters_ArtifactLevelFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_Filters_ArtifactSkillFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_Filters_ArtifactTitleFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__TypeInfo
		              );
		    DAT_ram_00a58a3a = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ArtifactComparerModel__ArtifactComparerEvents__ArtifactComparerController__ArtifactComparerWindow___ctor__
		            );
		  *(undefined1 *)(param1 + 0x1c) = (undefined1)param5;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar2 = unnamed_function_1417(Gameplay_Inventory_Controller_Filters_ArtifactSkillFilter_TypeInfo);
		  func_ii_10812(uVar1,1,uVar2,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__Add__
		               );
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(Gameplay_Inventory_Controller_Filters_ArtifactLevelFilter_TypeInfo);
		  func_ii_10812(uVar2,5,uVar1,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__Add__
		               );
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(Gameplay_Inventory_Controller_Filters_ArtifactTitleFilter_TypeInfo);
		  func_ii_10812(uVar2,4,uVar1,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IArtifactFilter__Add__
		               );
		  return;
		}
		*/

		}

		// Token: 0x04002C00 RID: 11264
		[Token(Token = "0x4002C00")]
		[FieldOffset(Offset = "0x14")]
		public readonly InventoryBaseEvents InventoryEvents;

		// Token: 0x04002C01 RID: 11265
		[Token(Token = "0x4002C01")]
		[FieldOffset(Offset = "0x18")]
		public Action TargetArtifactChangedEvent;

		// Token: 0x04002C02 RID: 11266
		[Token(Token = "0x4002C02")]
		[FieldOffset(Offset = "0x1C")]
		public Action InventoryChangedEvent;

		// Token: 0x04002C03 RID: 11267
		[Token(Token = "0x4002C03")]
		[FieldOffset(Offset = "0x20")]
		public Action SelectedSkillsChangedEvent;

		// Token: 0x04002C04 RID: 11268
		[Token(Token = "0x4002C04")]
		[FieldOffset(Offset = "0x24")]
		public Action PowersChangedEvent;
	}
}
