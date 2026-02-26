using System;
using Core.Animations;
using Il2CppDummyDll;

namespace Animations
{
	// Token: 0x02001329 RID: 4905
	[Token(Token = "0x2001329")]
	public class AvatarAnimation : GameSpineAnimation
	{
		// Token: 0x0600744B RID: 29771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600744B")]
		[Address(RVA = "0xBE19", Offset = "0xBE19", VA = "0xBE19")]
		public AvatarAnimation()
		{
		/* --- GHIDRA: .ctor ---
		void Animations_AvatarAnimation___ctor(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a596a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a596a8 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x8104c23e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x8104c23e:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ArtifactDropManager__RemoveView(param1_00,param1,0);
		  return;
		}
		*/

		}
	}
}
