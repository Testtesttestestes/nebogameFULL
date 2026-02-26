using System;
using System.Collections.Generic;
using Gameplay.Inventory.View.Chest;
using Il2CppDummyDll;
using UI;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x02000320 RID: 800
	[Token(Token = "0x2000320")]
	public class ColossusTreasuryView : MonoBehaviourWithStates<ColossusTreasuryView.State>
	{
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002DA")]
		public Price TreasuryBalance
		{
			[Token(Token = "0x6001275")]
			[Address(RVA = "0x646F", Offset = "0x646F", VA = "0x646F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002DB")]
		public Button BuyButton
		{
			[Token(Token = "0x6001276")]
			[Address(RVA = "0x6470", Offset = "0x6470", VA = "0x6470")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002DC")]
		public InventoryGridView InventoryGridView
		{
			[Token(Token = "0x6001277")]
			[Address(RVA = "0x6471", Offset = "0x6471", VA = "0x6471")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002DD")]
		public Button CreateClanButton
		{
			[Token(Token = "0x6001278")]
			[Address(RVA = "0x6472", Offset = "0x6472", VA = "0x6472")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002DE")]
		public Button ToTreasuryButton
		{
			[Token(Token = "0x6001279")]
			[Address(RVA = "0x6473", Offset = "0x6473", VA = "0x6473")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127A")]
		[Address(RVA = "0x6474", Offset = "0x6474", VA = "0x6474")]
		public void Init(IList<TreasuryOptionListElement.TreasuryOptionListElementArgs> items)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_ColossusInfo_View_ColossusTreasuryView__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bd0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ColossusTreasuryView_State___ctor__);
		    DAT_ram_00a58bd0 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ColossusTreasuryView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127B")]
		[Address(RVA = "0x6475", Offset = "0x6475", VA = "0x6475")]
		public ColossusTreasuryView()
		{
		}

		// Token: 0x040009F1 RID: 2545
		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private InventoryGridView _inventoryGridView;

		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TreasuryOptionsOSAView _osaView;

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Price _treasuryBalance;

		// Token: 0x040009F4 RID: 2548
		[Token(Token = "0x40009F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _buyButton;

		// Token: 0x040009F5 RID: 2549
		[Token(Token = "0x40009F5")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _createClanButton;

		// Token: 0x040009F6 RID: 2550
		[Token(Token = "0x40009F6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _toTreasuryButton;

		// Token: 0x02000321 RID: 801
		[Token(Token = "0x2000321")]
		public enum State
		{
			// Token: 0x040009F8 RID: 2552
			[Token(Token = "0x40009F8")]
			UNKNOWN_STATE,
			// Token: 0x040009F9 RID: 2553
			[Token(Token = "0x40009F9")]
			ALL_OK,
			// Token: 0x040009FA RID: 2554
			[Token(Token = "0x40009FA")]
			NO_CLAN,
			// Token: 0x040009FB RID: 2555
			[Token(Token = "0x40009FB")]
			NO_GOLEM
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ToTreasuryButton ---
		void Gameplay_WorldAxis_ColossusInfo_View_ColossusTreasuryView__get_ToTreasuryButton
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58bcf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClansPoliciesViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_View_ColossusTreasuryView___c__DisplayClass17_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ColossusInfo_View_ColossusTreasuryView___c__DisplayClass17_0_TypeInfo
		              );
		    DAT_ram_00a58bcf = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_ColossusInfo_View_ColossusTreasuryView___c__DisplayClass17_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar2 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x20),*(undefined4 *)(iVar2 + 0x3bc));
		  piVar1 = *(int **)(param1 + 0x20);
		  if ((char)piVar1[0x14] != '\0') {
		    (**(code **)((ulonglong)
		                 *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + *piVar1 + 0x10) * 4))
		              (piVar1,*(undefined4 *)(param2_00 + 0xc),
		               *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + *piVar1 + 0x14));
		    return;
		  }
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param2_00,
		             Method_Gameplay_WorldAxis_ColossusInfo_View_ColossusTreasuryView___c__DisplayClass17_0__Init_b__0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x298) * 4))
		            (piVar1,param1_00,*(undefined4 *)(*piVar1 + 0x29c));
		  return;
		}
		*/

}
