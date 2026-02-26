using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Auchan.Controller.Filters
{
	// Token: 0x02000CA1 RID: 3233
	[Token(Token = "0x2000CA1")]
	public class AuchanAvailableFilter : IAuchanItemFilter
	{
		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06004EAC RID: 20140 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EAD RID: 20141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FEC")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6004EAC")]
			[Address(RVA = "0x9CDD", Offset = "0x9CDD", VA = "0x9CDD", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EAD")]
			[Address(RVA = "0x9CDE", Offset = "0x9CDE", VA = "0x9CDE", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0x9CDF", Offset = "0x9CDF", VA = "0x9CDF", Slot = "6")]
		public bool Filter(ArtifactData artifactData)
		{
		/* --- GHIDRA: Filter ---
		void Gameplay_Auchan_Controller_Filters_AuchanAvailableFilter__Filter(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58970 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Filters_FilterInfo_TypeInfo);
		    DAT_ram_00a58970 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Filters_FilterInfo_TypeInfo);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EAF")]
		[Address(RVA = "0x9CE0", Offset = "0x9CE0", VA = "0x9CE0")]
		public AuchanAvailableFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		uint Gameplay_Auchan_Controller_Filters_AuchanAvailableFilter__set_FilterInfo
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5896f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5896f = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) == '\0') {
		    return 1;
		  }
		  iVar1 = Core_Data_ArtifactData__get_StackLimit(param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar4 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar4 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f4fe39;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar4);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f4fe39:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar4 = Core_Data_UserData__set_LevelDic(uVar3,0);
		  return (uint)((longlong)iVar1 <= (longlong)(ulonglong)uVar4);
		}
		*/

}
