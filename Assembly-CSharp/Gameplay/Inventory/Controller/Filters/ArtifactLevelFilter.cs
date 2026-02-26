using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Inventory.Controller.Filters
{
	// Token: 0x020006C3 RID: 1731
	[Token(Token = "0x20006C3")]
	public class ArtifactLevelFilter : IArtifactFilter
	{
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060029E3 RID: 10723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E5")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60029E2")]
			[Address(RVA = "0x7A8B", Offset = "0x7A8B", VA = "0x7A8B", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029E3")]
			[Address(RVA = "0x7A8C", Offset = "0x7A8C", VA = "0x7A8C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x7A8D", Offset = "0x7A8D", VA = "0x7A8D", Slot = "6")]
		public bool Filter(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x7A8E", Offset = "0x7A8E", VA = "0x7A8E")]
		public ArtifactLevelFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		uint Gameplay_Inventory_Controller_Filters_ArtifactLevelFilter__set_FilterInfo
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5a18e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a18e = '\x01';
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
		        goto code_r0x811d9f53;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar4);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811d9f53:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar4 = Core_Data_UserData__set_LevelDic(uVar3,0);
		  return (uint)((longlong)iVar1 <= (longlong)(ulonglong)uVar4);
		}
		*/

}
