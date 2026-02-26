using System;
using System.Runtime.CompilerServices;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Market.Controller.Filters
{
	// Token: 0x02000637 RID: 1591
	[Token(Token = "0x2000637")]
	public class MarketAvailableFilter : IMarketFilter
	{
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073D")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60026AC")]
			[Address(RVA = "0x77E1", Offset = "0x77E1", VA = "0x77E1", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026AD")]
			[Address(RVA = "0x77E2", Offset = "0x77E2", VA = "0x77E2", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x60026AE")]
		[Address(RVA = "0x77E3", Offset = "0x77E3", VA = "0x77E3", Slot = "6")]
		public bool Filter(MarketLotData marketLotData)
		{
		/* --- GHIDRA: Filter ---
		void Gameplay_Market_Controller_Filters_MarketAvailableFilter__Filter(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a03c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a03c = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x811b7ae4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811b7ae4:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar3 = Core_Data_UserData__set_LevelDic(uVar3,0);
		  *(undefined4 *)(param1 + 8) = uVar3;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x77E4", Offset = "0x77E4", VA = "0x77E4", Slot = "7")]
		public void Prepare()
		{
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x77E5", Offset = "0x77E5", VA = "0x77E5")]
		public MarketAvailableFilter()
		{
		}

		// Token: 0x0400151D RID: 5405
		[Token(Token = "0x400151D")]
		[FieldOffset(Offset = "0x8")]
		private uint _userLevel;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		uint Gameplay_Market_Controller_Filters_MarketAvailableFilter__set_FilterInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(char *)(*(int *)(param1 + 0xc) + 0x10) != '\0') {
		    iVar1 = Core_Data_ArtifactData__get_StackLimit(*(undefined4 *)(param2 + 8),0);
		    return (uint)((longlong)iVar1 <= (longlong)(ulonglong)*(uint *)(param1 + 8));
		  }
		  return 1;
		}
		*/

}
