using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Placements.Base.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Model
{
	// Token: 0x0200120C RID: 4620
	[Token(Token = "0x200120C")]
	public class EnergyRegenAdPlacementModel : AbstractAdPlacementModel
	{
		// Token: 0x06006DA4 RID: 28068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DA4")]
		[Address(RVA = "0xB864", Offset = "0xB864", VA = "0xB864")]
		public EnergyRegenAdPlacementModel(UserData user, IAdPlacementData placementData)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Model_EnergyRegenAdPlacementModel___ctor
		              (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a78a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a5a78a = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x8126ab03;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8126ab03:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar4 = *(int *)(*(int *)(iVar4 + 0x14) + 0x1c);
		  if (iVar4 != 0) {
		    uVar1 = com_unity3d_mediation_LevelPlayBannerAd___ctor(iVar4,0);
		    *(double *)(iVar2 + 0x20) = (double)uVar1;
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA5")]
		[Address(RVA = "0xB865", Offset = "0xB865", VA = "0xB865")]
		public ResourceSet GetEnergyRegenTargetValue()
		{
			return null;
		}

		// Token: 0x04003968 RID: 14696
		[Token(Token = "0x4003968")]
		[FieldOffset(Offset = "0x10")]
		public readonly Resources TargetResource;
	}
}
