using System;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x0200097B RID: 2427
	[Token(Token = "0x200097B")]
	public class AntiqEffectCombatAnimationContentDecorator : CombatAnimationContentDecorator
	{
		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B57")]
		public ProtoAntiqEffectTriggeredEvt.Types.EffectResult Effect
		{
			[Token(Token = "0x60039CA")]
			[Address(RVA = "0x8958", Offset = "0x8958", VA = "0x8958")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x2A46", Offset = "0x2A46", VA = "0x2A46")]
		public AntiqEffectCombatAnimationContentDecorator(IGameAudio audio, CombatAnimation.IContent content, string text, CombatEventsToast toast, ProtoAntiqEffectTriggeredEvt.Types.EffectResult effect)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Animations_AntiqEffectCombatAnimationContentDecorator___ctor
		               (int param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined1 uVar9;
		  undefined8 uVar10;
		  
		  if (DAT_ram_00a5cd7a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_ICombatAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IGameAssetProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__AddResultHandler__
		              );
		    DAT_ram_00a5cd7a = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 200);
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  iVar5 = unnamed_function_1417(iVar5);
		  *(int *)(iVar5 + 0x10) = param1;
		  *(undefined4 *)(iVar5 + 0xc) = param3;
		  uVar1 = 0;
		  piVar6 = *(int **)(*(int *)(*(int *)(param1 + 8) + 0x3c) + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_IGameAssetProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81617ef0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_IGameAssetProvider_TypeInfo,0);
		code_r0x81617ef0:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))
		                    (piVar6,CONCAT44(in_register_20000014,param2),puVar2[1]);
		  piVar6 = *(int **)(param1 + 8);
		  uVar10 = *(undefined8 *)(piVar6[0xd] + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x110) * 4))
		                    (piVar6,uVar10,*(undefined4 *)(*piVar6 + 0x114));
		  uVar4 = (undefined4)((ulonglong)uVar10 >> 0x20);
		  if (iVar3 == 1) {
		    uVar9 = 1;
		  }
		  else {
		    uVar8 = Gameplay_Combat_Model_CombatModel__GetTurnState(*(undefined4 *)(param1 + 8),0);
		    uVar9 = (undefined1)uVar8;
		  }
		  *(undefined1 *)(iVar5 + 8) = uVar9;
		  uVar1 = 0;
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Animations_ICombatAnimation_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x81617fba;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Animations_ICombatAnimation_TypeInfo,2);
		code_r0x81617fba:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,CONCAT44(uVar4,uVar8),puVar2[1]);
		  uVar8 = unnamed_function_1417
		                    (
		                    System_Action_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___TypeInfo
		                    );
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0xd0),0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar4,uVar8,0,
		             Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__AddResultHandler__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Effect ---
		void Gameplay_Combat_View_Animations_AntiqEffectCombatAnimationContentDecorator__get_Effect
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57df8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57df8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatAnimation_IContent__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
