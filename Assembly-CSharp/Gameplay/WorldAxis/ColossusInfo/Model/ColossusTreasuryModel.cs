using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Core.Dict;
using Gameplay.WorldAxis.ColossusInfo.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;

namespace Gameplay.WorldAxis.ColossusInfo.Model
{
	// Token: 0x0200032B RID: 811
	[Token(Token = "0x200032B")]
	public class ColossusTreasuryModel : AbstractModel
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002E4")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x600129E")]
			[Address(RVA = "0x6498", Offset = "0x6498", VA = "0x6498")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x6499", Offset = "0x6499", VA = "0x6499")]
		public ColossusTreasuryModel(UserData user, ColossusInfoModel colossusInfoModel)
		{
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E5")]
		public IBalanceSource ClanBalance
		{
			[Token(Token = "0x60012A0")]
			[Address(RVA = "0x649A", Offset = "0x649A", VA = "0x649A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012A1")]
			[Address(RVA = "0x649B", Offset = "0x649B", VA = "0x649B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E6")]
		public TreasuryOptionListElement.TreasuryOptionListElementArgs[] Options
		{
			[Token(Token = "0x60012A2")]
			[Address(RVA = "0x649C", Offset = "0x649C", VA = "0x649C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012A3")]
			[Address(RVA = "0x649D", Offset = "0x649D", VA = "0x649D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x649E", Offset = "0x649E", VA = "0x649E")]
		public void PopulateOptions(ProtoGetTreasuryOptionsAns msg)
		{
		/* --- GHIDRA: PopulateOptions ---
		int Gameplay_WorldAxis_ColossusInfo_Model_ColossusTreasuryModel__PopulateOptions
		              (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58be2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58be2 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a58bd6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElementArgs_TreasuryOptionListElement___ctor__
		              );
		    DAT_ram_00a58bd6 = '\x01';
		  }
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1_00,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_TreasuryOptionListElement___ctor__
		            );
		  uVar1 = Core_Data_ArtifactData__IsGuideTarget
		                    (*(undefined4 *)(param2 + 0x10),*(undefined4 *)(param1 + 8),
		                     *(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),0);
		  *(undefined4 *)(param1_00 + 0x20) = uVar1;
		  *(undefined4 *)(param1_00 + 0x24) = *(undefined4 *)(param2 + 0x18);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param2 + 0x14);
		  HuaweiMobileServices_Ads_InstallReferrer_InstallReferrerStateCallbackListener_InstallReferrerStateCallbackListenerInterfaceWrapper___ctor
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0x28) = *(undefined4 *)(param1 + 0x10);
		  *(undefined4 *)(param1_00 + 0x2c) = *(undefined4 *)(param2 + 0xc);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x649F", Offset = "0x649F", VA = "0x649F")]
		private TreasuryOptionListElement.TreasuryOptionListElementArgs CreateOptionArgs(ProtoGetTreasuryOptionsAns.Types.TreasuryOption option)
		{
			return null;
		}

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0xC")]
		public readonly ColossusInfoModel ColossusInfoModel;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DictProvider ---
		void Gameplay_WorldAxis_ColossusInfo_Model_ColossusTreasuryModel__get_DictProvider
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58be0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58be0 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0xc) = param3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80f866f5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f866f5:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0x18);
		  return;
		}
		*/


		/* --- GHIDRA: set_Options ---
		void Gameplay_WorldAxis_ColossusInfo_Model_ColossusTreasuryModel__set_Options
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58be1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Model_ColossusTreasuryModel_CreateOptionArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetTreasuryOptionsAns_Types_TreasuryOption__TreasuryOptionListElement_TreasuryOptionListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_TreasuryOptionListElement_TreasuryOptionListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetTreasuryOptionsAns_Types_TreasuryOption__TreasuryOptionListElement_TreasuryOptionListElementArgs__TypeInfo
		              );
		    DAT_ram_00a58be1 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ProtoGetTreasuryOptionsAns_Types_TreasuryOption__TreasuryOptionListElement_TreasuryOptionListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Model_ColossusTreasuryModel_CreateOptionArgs__,0
		            );
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetTreasuryOptionsAns_Types_TreasuryOption__TreasuryOptionListElement_TreasuryOptionListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_TreasuryOptionListElement_TreasuryOptionListElementArgs___
		                      );
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
